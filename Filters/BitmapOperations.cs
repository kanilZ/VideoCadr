using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoAudio.Filters
{
    static class BitmapOperations
    {
        public static bool CheckNeigbours(Bitmap bitmap, int x, int y)
        {
            int width = bitmap.Width, height = bitmap.Height;

            if (x < width && y < height && x >= 0 && y >= 0 && CheckColor(bitmap.GetPixel(x, y)))
                return true;

            return false;
        }

        public static bool CheckColor(Color c)
        {
            if (c.R == 0 && c.G == 0 && c.B == 0)
            {
                return true;
            }
            return false;
        }

        public static Color ChangeColor(int R,int G,int B)
        {
            return Color.FromArgb(R, G, B);
        }

        public static void FindNeighbours(Bitmap bitmap, Queue<Pixel> queueColors)
        {
            Pixel p = queueColors.Dequeue();
            int lr = p.X;
            int ud = p.Y;
            if (CheckNeigbours(bitmap, lr + 1, ud))
            {
                queueColors.Enqueue(new Pixel(lr + 1, ud));
            }
            if (CheckNeigbours(bitmap, lr, ud + 1))
            {
                queueColors.Enqueue(new Pixel(lr, ud + 1));
            }
            if (CheckNeigbours(bitmap, lr - 1, ud))
            {
                queueColors.Enqueue(new Pixel(lr - 1, ud));
            }
            if (CheckNeigbours(bitmap, lr, ud - 1))
            {
                queueColors.Enqueue(new Pixel(lr, ud - 1));
            }
        }
        public static void PaintCells(Bitmap bitmap, Queue<Pixel> queueColors,Color color)
        {
            foreach (var item in queueColors)
            {
                Pixel r = item;
                bitmap.SetPixel(r.X, r.Y, color);
            }
        }
    }

    public class Pixel
    {
        public int X { get; set; }

        public int Y { get; set; }
        public Pixel()
        {

        }
        public Pixel(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
