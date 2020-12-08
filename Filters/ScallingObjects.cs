using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoAudio.Filters
{
    static class ScallingObjects
    {
        public static List<Bitmap> Objects { get; set; }
        public static List<Bitmap> Apply(List<List<Pixel>> pixels, Bitmap entryBmp)
        {
            Objects = new List<Bitmap>();
            foreach (var item in pixels)
            {
                Objects.Add( ResizeBitmap(item, entryBmp));           
            }

            return Objects;
        }

        public static void SaveObjects(List<Bitmap> bitmap)
        {
            for (int i = 0; i < bitmap.Count; i++)
            {
                string path = $@"D:\IT\repos\VideoCadr\Frames\{i}.bmp";
                if (bitmap != null)
                {
                    Bitmap varBmp = new Bitmap(bitmap[i]);
                    varBmp.Save(path, ImageFormat.Png);
                    varBmp.Dispose();
                }
            }
            
        }

        private static Bitmap ResizeBitmap(List<Pixel> obj, Bitmap bmp)
        {
            var image = MakeBitmap(obj, bmp);
            var resizeImage = new Bitmap(image, new Size(60, 40));
            return resizeImage;
        }
        private static Bitmap MakeBitmap(List<Pixel> obj, Bitmap bmp)
        {
            int width = obj[2].X - obj[0].X, height = obj[1].Y - obj[3].Y;
            int startH = obj[3].Y, startW = obj[0].X;
            Bitmap newBmp = new Bitmap(width, height);
            for (int i = startW + 1,newI = 0; newI < width - 1; i++,newI++)
            {
                for (int j = startH + 1,newJ=0; newJ < height - 1; j++, newJ++)
                {
                    newBmp.SetPixel(newI, newJ, bmp.GetPixel(i, j));
                }
            }
            return newBmp;
        }
    }
}
