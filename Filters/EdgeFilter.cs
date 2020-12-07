using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoAudio.Filters
{
    static class EdgeFilter
    {
       
        public static Bitmap Apply(Bitmap bitmap)
        {
            int width = bitmap.Width, height = bitmap.Height;
            RowColmChecking(ref bitmap, 0, width, true);
            RowColmChecking(ref bitmap, height - 1, width, true);
            RowColmChecking(ref bitmap, height, 0, false);
            RowColmChecking(ref bitmap, height, width - 1, false);
            return bitmap;
        }

        private static void RowColmChecking(ref Bitmap bitmap, int row, int colmn, bool state)
        {
            Queue<Pixel> queueColors = new Queue<Pixel>();
            Pixel[,] pixels = BitmapOperations.MakePixelArray(bitmap);
            if (state)
            {
                for (int j = 0; j < colmn; j++) 
                {
                    if (!BitmapOperations.IsWhiteColor(pixels[j,row].Color))
                    {
                        //pixels[j, row].IsChecked = true;
                        queueColors.Enqueue(pixels[j, row]);
                        while (queueColors.Count != 0)
                        {
                            BitmapOperations.FindNeighbours(pixels, queueColors);
                            BitmapOperations.PaintCells(bitmap, queueColors.ToList(),Color.White);
                        }
                    }
                }
            }
            else
            {
                for (int j = 0; j < row; j++)
                {
                    if (!BitmapOperations.IsWhiteColor(pixels[colmn, j].Color))
                    {
                        //pixels[colmn, j].IsChecked = true;
                        queueColors.Enqueue(pixels[colmn, j]);
                        while (queueColors.Count != 0)
                        {
                            BitmapOperations.FindNeighbours(pixels, queueColors);
                            BitmapOperations.PaintCells(bitmap, queueColors.ToList(), Color.White);
                        }

                    }
                }

            }
        }

        

    }

   
}
