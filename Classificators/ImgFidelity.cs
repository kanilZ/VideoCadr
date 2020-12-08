using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoAudio.Classificators
{
    static class ImgFidelity
    {
        static private List<int> Classification(List<Bitmap> objects)
        {
            List<Bitmap> ethalons = UploadEthalons();
            List<double> bufResults = new List<double>();
            List<int> results = new List<int>();
            foreach (var item in objects)
            {
                foreach (var ethalon in ethalons)
                {
                    bufResults.Add(ComputeImgFidelity(item, ethalon));
                }
                results.Add(FindOutIndex(bufResults));
                bufResults.Clear();
            }
            return results;
        }
        static private int FindOutIndex(List<double> vs)
        {
            double max = vs[0];
            int index = 0;
            for (int i = 1; i < vs.Count; i++)
            {
                if (max<vs[i])
                {
                    max = vs[i];
                    index = i;
                }
            }
            max *= 100;
            if (max > 60.0)
                return index;

            return -9999;
        }
        static private double ComputeImgFidelity(Bitmap f, Bitmap f0)
        {
            int width = f.Width, height = f.Height;
            double sqrF = 0.0;
            double sqrF0_F = 0.0;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    sqrF0_F += (f.GetPixel(i, j).R - f0.GetPixel(i, j).R) * (f.GetPixel(i, j).R - f0.GetPixel(i, j).R);
                    sqrF += f.GetPixel(i, j).R * f.GetPixel(i, j).R;
                }
            }
            double res = sqrF0_F / sqrF;
            return 1.0 - res;
        }

        static public List<int> ShowClassificatorResults(List<Bitmap> bitmaps)
        {
          return  Classification(bitmaps);
            //return null;
        }
        static private List<Bitmap> UploadEthalons()
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
