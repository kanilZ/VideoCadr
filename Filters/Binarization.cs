using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoAudio.Filters
{
    static class Binarization
    {

        public static Bitmap Apply(Bitmap entered)
        {
            int height = entered.Height, width = entered.Width;
            Bitmap exited = new Bitmap(width, height);
            Color colorRGB, colorBinary;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    colorRGB = entered.GetPixel(i, j);
                    int r = colorRGB.R, g = colorRGB.G, b = colorRGB.B;
                    int avgColor = AvgRGB(r, g, b);
                    int binColor = SetToBinary(avgColor);
                    colorBinary = Color.FromArgb(binColor, binColor, binColor);
                    exited.SetPixel(i, j, colorBinary);
                }
            }

            return exited;
        }

        private static int AvgRGB(int r, int g, int b)
        {
            return (r + g + b) / 3;
        }
        private static int SetToBinary(int value)
        {
            return value <= 128 ? 0 : 255;
        }

    }
}
