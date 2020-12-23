using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoAudio.Binarizations
{
    public abstract class Binarize
    {
        public abstract Bitmap Apply(Bitmap entered);
        protected static int AvgRGB(int r, int g, int b)
        {
            return (r + g + b) / 3;
        }
        protected static int SetToBinary(int avg, int threshold)
        {
            return avg < threshold ? 0 : 255;
        }
    }
}
