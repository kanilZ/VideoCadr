using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoAudio.Filters
{
    static class MarkObject
    {
        public static Bitmap Apply(Bitmap bitmap)
        {
            return FindAndColor(bitmap);
        }
        private static Bitmap FindAndColor(Bitmap bitmap)
        {
            int height = bitmap.Height, width = bitmap.Width;
            int iterator = 0;
            List<Color> colors = new List<Color>() { Color.Red, Color.Green, Color.Blue, Color.Yellow, Color.Lime, Color.Pink, Color.Aqua };//          
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
                        if (iterator == colors.Count)
                            iterator = 0;

                        while (queueColors.Count != 0)
                        {
                            BitmapOperations.FindNeighbours(pixels, queueColors);
                            BitmapOperations.SaveToBuf(queueColors, bufColors);
                            BitmapOperations.PaintCells(bitmap, queueColors.ToList(), colors[iterator]);
                        }

                        iterator++;
                        if (!IsMoreThan20(bufColors.Count))
                            BitmapOperations.PaintCells(bitmap, bufColors.ToList(), Color.White);

                        bufColors.Clear();
                    }
                }
            }

            return bitmap;
        }

       
        private static bool IsMoreThan20(int checkSum)
        {
            return checkSum >= 20 ? true : false;
        }


    }
}
