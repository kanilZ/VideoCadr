using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoAudio.Binarizations
{
    class AvarageMethod : Binarize
    {
        public override Bitmap Apply(Bitmap entered)
        {
            return BuildTable(entered);
        }

        private Bitmap BuildTable(Bitmap bitmap)
        {
            int width = bitmap.Width, height = bitmap.Height;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    
                }
            }

            return bitmap;
        }
    }
}
