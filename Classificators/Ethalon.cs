using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoAudio.Classificators
{
    static class Ethalon
    {
        static public List<Bitmap> UploadEthalons()
        {
            List<Bitmap> bitmaps = new List<Bitmap>();
            for (int i = 0; i < 10; i++)
            {
                string path = $@"D:\IT\repos\VideoCadr\Classficator Objects\{i}.bmp";
                bitmaps.Add((Bitmap)System.Drawing.Image.FromFile(path));
            }
            return bitmaps;
        }
    }
}
