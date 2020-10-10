using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoCadr
{
    public class VideoProcess
    {
        private FilterInfoCollection VideoCaptureDevices;
        private VideoCaptureDevice FinalVideo;

        public VideoProcess()
        {
            VideoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

        }

        public void Devices(ComboBox comboBox)
        {
            foreach (FilterInfo device in VideoCaptureDevices)
            {
                comboBox.Items.Add(device.Name);
            }
        }
        public void Start(NewFrameEventHandler FinalVideo_NewFrame, int comboBoxIndx)
        {
            FinalVideo = new VideoCaptureDevice(VideoCaptureDevices[comboBoxIndx].MonikerString);
            FinalVideo.NewFrame += new NewFrameEventHandler(FinalVideo_NewFrame);
            FinalVideo.Start();
        }

        public void TakeScrTxt(Bitmap bitmap)
        {
            //Random random = new Random();
            //string writePath = $@"D:\IT\repos\VideoCadr\Frames\{random.Next()}.txt";
            //using (FileStream sw = File.Create(writePath))
            //{
            //    for (int x = 0; x < bitmap.Width; x++)
            //    {
            //        for (int y = 0; y < bitmap.Height; y++)
            //        {
            //            Color pixelColor = bitmap.GetPixel(x, y);

            //            // Color newColor = Color.FromArgb(pixelColor.R, 0, 0);
            //            // image1.SetPixel(x, y, newColor);

            //        }
            //    }
            //}
            string path = @"D:\IT\repos\VideoCadr\Frames\sep.txt";
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                for (int i = 0; i < bitmap.Width; i++)
                {
                    for (int j = 0; j < bitmap.Height; j++)
                    {
                        Color c = bitmap.GetPixel(i, j);
                        sw.WriteLine("R|"+Convert.ToString(c.R,2));
                        sw.WriteLine("G|"+Convert.ToString(c.G,2));
                        sw.WriteLine("B|"+Convert.ToString(c.B,2));

                    }
                }
            }
        }
        public void SaveImage(Bitmap bitmap)
        {
            string path = @"D:\IT\repos\VideoCadr\Frames\image.bmp";

            if (bitmap!=null)
            {
                Bitmap varBmp = new Bitmap(bitmap);
                varBmp.Save(path, ImageFormat.Png);

                varBmp.Dispose();
                varBmp = null;
            }
            else
            {
                MessageBox.Show("Null bitmap");
            }
        }
        public bool IsRunning()
        {
            if (FinalVideo == null)
            {
                return false;
            }
            return FinalVideo.IsRunning;
        }
        public void Stop()
        {
            FinalVideo.Stop();
        }
    }
}
