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
        public static bool CheckNeigbours(Pixel[,] pixels, int x, int y)
        {
            int width = pixels.GetUpperBound(0) + 1, height = pixels.Length / width;

            if (x < width && y < height && x >= 0 && y >= 0 && !IsWhiteColor(pixels[x, y].Color) && !pixels[x, y].IsChecked)
                return true;

            return false;
        }

        public static bool IsWhiteColor(Color c)
        {
            if (c.R == 255 && c.G == 255 && c.B == 255)
            {
                return true;
            }
            return false;
        }
        public static Color ChangeColor(int R, int G, int B)
        {
            return Color.FromArgb(R, G, B);
        }

        public static void FindNeighbours(Pixel[,] pixels, Queue<Pixel> queueColors)
        {
            Pixel p = queueColors.Dequeue();
            int lr = p.X;
            int ud = p.Y;
            if (CheckNeigbours(pixels, lr + 1, ud))
            {
                pixels[lr + 1, ud].IsChecked = true;
                queueColors.Enqueue(pixels[lr + 1, ud]);
            }
            if (CheckNeigbours(pixels, lr, ud + 1))
            {
                pixels[lr, ud + 1].IsChecked = true;
                queueColors.Enqueue(pixels[lr, ud + 1]);
            }
            if (CheckNeigbours(pixels, lr - 1, ud))
            {
                pixels[lr - 1, ud].IsChecked = true;
                queueColors.Enqueue(pixels[lr - 1, ud]);
            }
            if (CheckNeigbours(pixels, lr, ud - 1))
            {
                pixels[lr, ud - 1].IsChecked = true;
                queueColors.Enqueue(pixels[lr, ud - 1]);
            }
        }

        public static void SaveToBuf(Queue<Pixel> main, Queue<Pixel> buf)
        {
            foreach (var item in main)
            {
                buf.Enqueue(item);
            }
        }
        public static Pixel[,] MakePixelArray(Bitmap bitmap)
        {
            int width = bitmap.Width, height = bitmap.Height;
            Pixel[,] pixels = new Pixel[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    pixels[i, j] = new Pixel(i, j, bitmap.GetPixel(i, j), false);
                }
            }

            return pixels;
        }

        public static void PaintCells(Bitmap bitmap, List<Pixel> queueColors, Color color)
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

        public bool IsChecked { get; set; }
        public int Y { get; set; }
        public Color Color { get; set; }
        public Pixel()
        {

        }
        public Pixel(int x, int y, Color color, bool state)
        {
            X = x;
            Y = y;
            Color = color;
            IsChecked = state;
        }
    }
}
