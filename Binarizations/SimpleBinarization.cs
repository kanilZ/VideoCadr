using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VideoAudio.Binarizations
{
    public class SimpleBinarization : Binarize
    {
        public override Bitmap Apply(Bitmap entered)
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
                    int binColor = SetToBinary(avgColor, 128);
                    colorBinary = Color.FromArgb(binColor, binColor, binColor);
                    exited.SetPixel(i, j, colorBinary);
                }
            }

            return exited;
        }


        
    }
}
