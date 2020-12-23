using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoAudio.Binarizations
{
    class TriangleMethod : Binarize
    {
        public override Bitmap Apply(Bitmap bitmap)
        {
            int width = bitmap.Width, height = bitmap.Height;
            Bitmap result = new Bitmap(width, height);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    int central = 12;
                    var color = bitmap.GetPixel(i, j);
                    var listColors = BuildTable(1, i, j, bitmap);
                    var sortedBrightnessList = BuildBrightneesList(listColors);
                    int avgColor = AvgRGB(color.R, color.G, color.B);

                    if (sortedBrightnessList.Count < 24)
                        central = (sortedBrightnessList.Count / 2) % 2;
                    //int max = sortedBrightnessList.Select(n => n).Max();
                    //int min = sortedBrightnessList.Select(n => n).Min();
                    //int binColor = SetToBinary((max + min) / 2, 70);
                    int binColor = SetToBinary(avgColor, sortedBrightnessList[central]);
                    result.SetPixel(i, j, Color.FromArgb(binColor, binColor, binColor));
                }
            }
            return result;
        }

        private List<Color> BuildTable(int radius, int centerX, int centerY, Bitmap bitmap)
        {
            var listRes = new List<Color>();
            int fromX = CheckEdge(centerX - radius, 0, bitmap.Width - 1), toX = CheckEdge(centerX + radius, 0, bitmap.Width - 1),
                fromY = CheckEdge(centerY - radius, 0, bitmap.Height - 1), toY = CheckEdge(centerY + radius, 0, bitmap.Height - 1);

            for (int i = fromX; i <= toX; i++)
            {
                for (int j = fromY; j <= toY; j++)
                {
                    listRes.Add(bitmap.GetPixel(i, j));
                }
            }

            return listRes;
        }

        private List<int> BuildBrightneesList(List<Color> colors)
        {
            var brightList = new List<int>();
            foreach (var color in colors)
            {
                brightList.Add(AvgRGB(color.R, color.G, color.B));
            }

            return brightList.OrderByDescending(n => n).ToList();
        }
        private int CheckEdge(int coord, int edge1, int edge2)
        {
            if (coord < edge1)
                return edge1;

            if (coord > edge2)
                return edge2;


            return coord;
        }
    }
}
