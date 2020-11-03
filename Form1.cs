using AForge.Video;
using AForge.Video.DirectShow;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoAudio
{
    public partial class Form1 : Form
    {
        private VideoProcess videoProcess;
        private Bitmap video;
        private CancellationTokenSource cancelTokenSource;
        private CancellationToken token;
        private Image backImage;
        private AudioProcess audioProcess;
        public Form1()
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
            if (video!=null)
            {
                videoProcess.MakeTxtFromBitmap(video);
            }
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
            videoProcess.SaveImage(video);
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
            }
        }

        private void buttonStopInterval_Click(object sender, EventArgs e)
        {
            if (cancelTokenSource != null)
                cancelTokenSource.Cancel();

        }

        private void uploadPhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileTxtDialog.ShowDialog()==DialogResult.OK)
            {
                pictureBox.Image = videoProcess.MakeBitmapFromTxt(openFileTxtDialog.FileName,pictureBox.Height, pictureBox.Width);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            pictureBox.Image = backImage;
        }

        private void buttonStartRec_Click(object sender, EventArgs e)
        {
            audioProcess.StartRecording(WaveIn_DataAvailable,WaveIn_RecordingStopped);
        }

        private void buttonStopRec_Click(object sender, EventArgs e)
        {
            audioProcess.StopRecording();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            audioProcess.Play();
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
    }
}


