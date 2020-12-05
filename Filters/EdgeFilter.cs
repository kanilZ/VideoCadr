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
            if (state)
            {
                for (int j = 0; j < colmn; j++)
                {
                    if (BitmapOperations.CheckColor(bitmap.GetPixel(j, row)))
                    {
                        queueColors.Enqueue(new Pixel(j, row));
                        while (queueColors.Count != 0)
                        {
                            BitmapOperations.FindNeighbours(bitmap, queueColors);
                            BitmapOperations.PaintCells(bitmap, queueColors,Color.White);
                        }
                    }
                }
            }
            else
            {
                for (int j = 0; j < row; j++)
                {
                    if (BitmapOperations.CheckColor(bitmap.GetPixel(colmn, j)))
                    {
                        queueColors.Enqueue(new Pixel(colmn, j));
                        while (queueColors.Count != 0)
                        {
                            BitmapOperations.FindNeighbours(bitmap, queueColors);
                            BitmapOperations.PaintCells(bitmap, queueColors, Color.White);
                        }

                    }
                }

            }
        }

        

    }

   
}
