using AForge.Imaging;
using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoAudio.Filters
{
    class TimeRow : IFilter
    {
        string[] names;
        List<Bitmap> bitmaps;
        int count;
        public TimeRow()
        {
            bitmaps = new List<Bitmap>();
        }

        public TimeRow(string[] names)
        {
            bitmaps = new List<Bitmap>();
            this.names = names;
            foreach (var name in names)
            {
                bitmaps.Add((Bitmap)System.Drawing.Image.FromFile(name));
            }
            count = bitmaps.Count();
        }


        public Bitmap Apply(Bitmap image)
        {
            int height = image.Height, width = image.Width;
            Bitmap result = new Bitmap(width, height);
            Color c;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    int r = 0, g = 0, b = 0;
                    foreach (var bitmap in bitmaps)
                    {
                        c = bitmap.GetPixel(i, j);
                        r += c.R;
                        g += c.G;
                        b += c.B;
                    }
                    result.SetPixel(i, j, Color.FromArgb(r/ count, g/ count, b/ count));
                }
            }

            return result;
        }


        public Bitmap Apply(BitmapData imageData)
        {
            throw new NotImplementedException();
        }

        public UnmanagedImage Apply(UnmanagedImage image)
        {
            throw new NotImplementedException();
        }

        public void Apply(UnmanagedImage sourceImage, UnmanagedImage destinationImage)
        {
            throw new NotImplementedException();
        }
    }
}
