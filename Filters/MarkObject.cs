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

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (BitmapOperations.CheckColor(bitmap.GetPixel(i, j)))
                    {
                        queueColors.Enqueue(new Pixel(i, j));
                        bufColors.Enqueue(new Pixel(i, j));
                        if (iterator == colors.Count)
                            iterator = 0;

                        while (queueColors.Count != 0)
                        {
                            BitmapOperations.FindNeighbours(bitmap, queueColors);
                            SaveToBuf(queueColors, bufColors);
                            BitmapOperations.PaintCells(bitmap, queueColors, colors[iterator]);
                        }

                        iterator++;
                        if (IsMoreThan20(bufColors.Count))
                            BitmapOperations.PaintCells(bitmap, bufColors, Color.White);

                        bufColors.Clear();
                    }
                }
            }

            return bitmap;
        }

        private static void SaveToBuf(Queue<Pixel> main, Queue<Pixel> buf)
        {
            foreach (var item in main)
            {
                buf.Enqueue(item);
            }
        }
        private static bool IsMoreThan20(int checkSum)
        {
            return checkSum >= 20 ? false : true;
        }


    }
}
