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

namespace VideoAudio
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

        public void MakeTxtFromBitmap(Bitmap bitmap)
        {
            Random random = new Random();
           // string test = "test";
            string path =   $@"D:\IT\repos\VideoCadr\Txt\{random.Next()}.txt"; //
            using (StreamWriter sw = new StreamWriter(path, false, Encoding.Default))
            {
                sw.WriteLine(bitmap.Width);
                sw.WriteLine(bitmap.Height);
                for (int i = 0; i < bitmap.Width; i++)
                {
                    for (int j = 0; j < bitmap.Height; j++)
                    {
                        Color c = bitmap.GetPixel(i, j);
                        sw.WriteLine(c.R);
                        sw.WriteLine(c.G);
                        sw.WriteLine(c.B);
                    }
                }
            }
        }
        
        public Bitmap MakeBitmapFromTxt(string path)
        {
            using (StreamReader sr = new StreamReader(path, Encoding.Default)) 
            {
                int width = Convert.ToInt32(sr.ReadLine()), height = Convert.ToInt32(sr.ReadLine());
                int R,G,B;
                Bitmap res = new Bitmap(width, height);
                Color c;

                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        R = Convert.ToInt32(sr.ReadLine());
                        G = Convert.ToInt32(sr.ReadLine());
                        B = Convert.ToInt32(sr.ReadLine());
                       
                        c = Color.FromArgb(R, G, B);                    
                        res.SetPixel(i, j, c);
                    }
                }
                return res;
            }

        }

        public void SaveImage(Bitmap bitmap)
        {
            Random random = new Random();
            string path = $@"D:\IT\repos\VideoCadr\Frames\{random.Next()}.bmp";

            if (bitmap != null)
            {
                Bitmap varBmp = new Bitmap(bitmap);
                varBmp.Save(path, ImageFormat.Png);
                varBmp.Dispose();
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
