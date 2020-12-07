using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoAudio.Filters
{
    static class Circumscription
    {
       public static List<List<Pixel>> objectEdges { get; set; }
        public static Bitmap Apply(Bitmap bitmap)
        {
            objectEdges = new List<List<Pixel>>();
            return BuildLines(bitmap);
        }

        private static Bitmap BuildLines(Bitmap bitmap)
        {
            int width = bitmap.Width, height = bitmap.Height;
            Queue<Pixel> queueColors = new Queue<Pixel>();
            Queue<Pixel> bufColors = new Queue<Pixel>();
            Pixel[,] pixels = BitmapOperations.MakePixelArray(bitmap);

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (!BitmapOperations.IsWhiteColor(pixels[i, j].Color) && !pixels[i, j].IsChecked)
                    {
                        queueColors.Enqueue(pixels[i, j]);
                        bufColors.Enqueue(pixels[i, j]);
                        while (queueColors.Count != 0)
                        {
                            BitmapOperations.FindNeighbours(pixels, queueColors);
                            BitmapOperations.SaveToBuf(queueColors, bufColors);
                        }

                        List<Pixel> edges = EdgeCoords(bufColors);
                        objectEdges.Add(edges);
                        //BitmapOperations.PaintCells(bitmap, edges, Color.Black);
                        bufColors.Clear();
                    }
                }
            }
            DrawLines(objectEdges, bitmap);

            return bitmap;
        }

        public static void DrawLines(List<List<Pixel>> pixels, Bitmap bitmap)
        {
            foreach (var objectP in pixels)
            {
                DrawLine(objectP[3].Y, objectP[0].X, objectP[2].X, bitmap, false);
                DrawLine(objectP[2].X, objectP[3].Y, objectP[1].Y, bitmap, true);
                DrawLine(objectP[1].Y, objectP[0].X, objectP[2].X, bitmap, false);
                DrawLine(objectP[0].X, objectP[3].Y, objectP[1].Y, bitmap, true);
            }

        }

        private static void DrawLine(int where, int from, int to, Bitmap bitmap, bool IsVertical)
        {
            for (int i = from; i < to; i++)
            {
                if (!IsVertical)
                    bitmap.SetPixel(i, where, Color.Purple);
                else
                    bitmap.SetPixel(where, i, Color.Purple);
            }
        }

        private static List<Pixel> EdgeCoords(Queue<Pixel> pixels)
        {
            List<Pixel> res;
            Pixel buf = pixels.Dequeue();
            res = new List<Pixel>() { new Pixel(buf.X, buf.Y, buf.Color, buf.IsChecked), new Pixel(buf.X, buf.Y, buf.Color, buf.IsChecked), new Pixel(buf.X, buf.Y, buf.Color, buf.IsChecked), new Pixel(buf.X, buf.Y, buf.Color, buf.IsChecked) };
            foreach (var item in pixels)
            {
                if (item.X < res[0].X)
                {
                    res[0].X = item.X;
                    res[0].Y = item.Y;
                }
                if (item.Y > res[1].Y)
                {
                    res[1].Y = item.Y;
                    res[1].X = item.X;
                }
                if (item.X > res[2].X)
                {
                    res[2].X = item.X;
                    res[2].Y = item.Y;
                }
                if (item.Y < res[3].Y)
                {
                    res[3].Y = item.Y;
                    res[3].X = item.X;
                }
            }
            res[0].X--;
            res[1].Y++;
            res[2].X++;
            res[3].Y--;
            return res;
        }
    }
}
