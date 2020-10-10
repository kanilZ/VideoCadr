using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoCadr
{
    public partial class Form1 : Form
    {
        private VideoProcess videoProcess;
        private Bitmap video;
        public Form1()
        {
            InitializeComponent();
            videoProcess = new VideoProcess();
            videoProcess.Devices(comboCameras);
            comboCameras.SelectedIndex = 0;
        }     
        private void FinalVideo_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            video = (Bitmap)eventArgs.Frame.Clone();
            pictureBox.Image = video;
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            videoProcess.Start(FinalVideo_NewFrame,comboCameras.SelectedIndex);
        }
        private void buttonStop_Click(object sender, EventArgs e)
        {
            videoProcess.Stop();
        }

        private void buttonScr_Click(object sender, EventArgs e)
        {
               videoProcess.TakeScrTxt(video);
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
    }
}


