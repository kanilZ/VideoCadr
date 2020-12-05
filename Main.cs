using AForge.Imaging.Filters;
using AForge.Video;
using AForge.Video.DirectShow;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoAudio.Filters;

namespace VideoAudio
{
    public partial class Main : Form
    {
        private VideoProcess videoProcess;
        private Bitmap video;
        private CancellationTokenSource cancelTokenSource;
        private CancellationToken token;
        private Image backImage;
        private AudioProcess audioProcess;
        private IFilter filter;
        private Form cv;
        public Main()
        {
            InitializeComponent();
            videoProcess = new VideoProcess();
            videoProcess.Devices(comboCameras);
            comboCameras.SelectedIndex = 0;

            audioProcess = new AudioProcess();
            backImage = pictureBox.Image;
        }
        private void WaveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new EventHandler<WaveInEventArgs>(WaveIn_DataAvailable), sender, e);
            }
            else
            {
                audioProcess.WriteData(e);

            }
        }

        private void WaveIn_RecordingStopped(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new EventHandler(WaveIn_RecordingStopped), sender, e);
            }
            else
            {
                audioProcess.CloseDispose();
            }
        }
        private void FinalVideo_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            video = (Bitmap)eventArgs.Frame.Clone();
            pictureBox.Image = video;
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            videoProcess.Start(FinalVideo_NewFrame, comboCameras.SelectedIndex);
        }
        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (videoProcess.IsRunning())
            {
                videoProcess.Stop();
            }
        }

        private void buttonScr_Click(object sender, EventArgs e)
        {
            videoProcess.MakeTxtFromBitmap((Bitmap)pictureBox.Image);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (videoProcess.IsRunning())
            {
                videoProcess.Stop();
                Process.GetCurrentProcess().Kill();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            videoProcess.SaveImage((Bitmap)pictureBox.Image);
        }

        private async void buttonStartInterval_Click(object sender, EventArgs e)
        {
            if (!videoProcess.IsRunning())
            {
                return;
            }
            cancelTokenSource = new CancellationTokenSource();
            token = cancelTokenSource.Token;
            int value = (int)numericUpDown.Value;
            do
            {
                await Task.Run(() =>
                {
                    videoProcess.SaveImage(video);
                    Thread.Sleep(value * 1000);

                });
                if (token.IsCancellationRequested)
                {
                    break;
                }


            } while (true);
        }

        private void loadwavToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileWavDialog.ShowDialog() == DialogResult.OK)
            {
                textWav.Text = openFileWavDialog.FileName;
                waveViewer.ForeColor = Color.GreenYellow;
                waveViewer.SamplesPerPixel = waveViewer.Height;
                waveViewer.StartPosition = 40000;
                waveViewer.WaveStream = new WaveFileReader(textWav.Text);
            }
        }

        private void buttonStopInterval_Click(object sender, EventArgs e)
        {
            if (cancelTokenSource != null)
                cancelTokenSource.Cancel();

        }

        private void uploadPhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileTxtDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = videoProcess.MakeBitmapFromTxt(openFileTxtDialog.FileName);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            pictureBox.Image = backImage;
        }

        private void buttonStartRec_Click(object sender, EventArgs e)
        {
            audioProcess.StartRecording(WaveIn_DataAvailable, WaveIn_RecordingStopped);
        }

        private void buttonStopRec_Click(object sender, EventArgs e)
        {
            audioProcess.StopRecording();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            audioProcess.Play(textWav.Text);
        }

        private void buttonResumePlay_Click(object sender, EventArgs e)
        {

            audioProcess.ResumePlay();

        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            audioProcess.Pause();
        }

        private void buttonMakeTxt_Click(object sender, EventArgs e)
        {
            audioProcess.MakeTxtFromWav(textWav.Text);
        }


        private void buttonStopPlay_Click(object sender, EventArgs e)
        {
            if (audioProcess.HasAudio())
            {
                audioProcess.Stop();
            }
        }

        private void uploadBitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UploadBitmap(pictureBox);
        }

        private void UploadBitmap(PictureBox picture)
        {
            if (openFileBitDialog.ShowDialog() == DialogResult.OK)
            {
                picture.Image = Image.FromFile(openFileBitDialog.FileName);
            }
        }
        private void buttonFiltering_Click(object sender, EventArgs e)
        {
            if (filter != null)
            {
                pictureBoxOutput.Image = filter.Apply((Bitmap)pictureBoxInput.Image);

            }
            //pictureBoxOutput.Image;        
        }

        private void uploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UploadBitmap(pictureBoxInput);
        }

        private void contrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filter = new ContrastStretch();
        }

        private void medianaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filter = new Median();
        }

        private void timeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void selectFIlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialogMoreOne.ShowDialog() == DialogResult.OK)
            {
                filter = new TimeRow(openFileDialogMoreOne.FileNames);
                pictureBoxInput.Image = Image.FromFile(openFileDialogMoreOne.FileNames[0]);
            }
        }

        private void buttonSaveFiltered_Click(object sender, EventArgs e)
        {
            videoProcess.SaveImage((Bitmap)pictureBoxOutput.Image);
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            if (pictureBoxAffineIn.Image == null)
                return;
            pictureBoxAffineOut.SizeMode = PictureBoxSizeMode.StretchImage;
            if (label2.Text == "Height")
                return;
            
            filter = new RotateBilinear(trackBarHalf.Value, true);
            pictureBoxAffineOut.Image = filter.Apply(AForge.Imaging.Image.Clone((Bitmap)pictureBoxAffineIn.Image, PixelFormat.Format24bppRgb));

        }

        private void uploadAffineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UploadBitmap(pictureBoxAffineIn);
        }

        private void buttonMirror_Click(object sender, EventArgs e)
        {

            if (pictureBoxAffineIn.Image == null)
                return;
            pictureBoxAffineOut.SizeMode = PictureBoxSizeMode.StretchImage;
            filter = new Mirror(false, true);
            pictureBoxAffineOut.Image = filter.Apply(AForge.Imaging.Image.Clone((Bitmap)pictureBoxAffineIn.Image, PixelFormat.Format24bppRgb));

        }

        private void buttonSaveAffine_Click(object sender, EventArgs e)
        {
            if (pictureBoxAffineIn.Image == null)
                return;
            videoProcess.SaveImage((Bitmap)pictureBoxAffineOut.Image);
        }

        private void buttonScale_Click(object sender, EventArgs e)
        {
            if (pictureBoxAffineIn.Image == null)
                return;
            pictureBoxAffineOut.SizeMode = PictureBoxSizeMode.CenterImage;
            filter = new ResizeBicubic(trackBarHalf.Value,trackBarWidth.Value);
            pictureBoxAffineOut.Image = filter.Apply(AForge.Imaging.Image.Clone((Bitmap)pictureBoxAffineIn.Image, PixelFormat.Format24bppRgb));       
        }

        private void rotateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Text = "Rotate";
            label3.Enabled = false;
            label2.Enabled = true;
            trackBarWidth.Enabled = false;
            trackBarHalf.Maximum = 360;
            trackBarHalf.Enabled = true;
            trackBarHalf.Minimum = 0;
        }

        private void scaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Text = "Height";
            label3.Enabled = true;
            label2.Enabled = true;
            trackBarWidth.Enabled = true;
            trackBarHalf.Maximum = 2000;
            trackBarHalf.Enabled = true;
            trackBarHalf.Minimum = 100;
        }

        private void buttonCV_Click(object sender, EventArgs e)
        {
            cv = new CV();
            cv.Show();
        }

      
    }
}


