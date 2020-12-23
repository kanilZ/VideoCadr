using NeuralNetworks;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoAudio.Classificators
{
    public class NeuralNetworkClassification
    {
        static NeuralNetwork neuralNetwork = null;
        static Topology topology = null;
        List<Bitmap> ethalons;
        public NeuralNetworkClassification()
        {
            ethalons = Ethalon.UploadEthalons();
            if (topology == null)
            {
                topology = new Topology(60 * 40, ethalons.Count, 0.1, 60);
                neuralNetwork = new NeuralNetwork(topology);
                Learn();
            }
        }

        public List<int> TakeResult(List<Bitmap> objects)
        {
            var listRes = new List<int>();          
            foreach (var obj in objects)
            {
                var predict = neuralNetwork.Predict(ConvertBitmap(obj)).OrderByDescending(n => n.Output).First();
                if (predict.Output < 0.40)
                {
                    listRes.Add(-9999);
                }
                else
                {
                    listRes.Add(predict.Number);
                }

            }
            return listRes;
        }

        private void Learn()
        {
            for (int i = 1; i <= 10; i++)
            {
                neuralNetwork.Learn(new double[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, ConvertBitmap(ethalons[0]), 2);
                neuralNetwork.Learn(new double[] { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 }, ConvertBitmap(ethalons[1]), 2);
                neuralNetwork.Learn(new double[] { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 }, ConvertBitmap(ethalons[2]), 2);
                neuralNetwork.Learn(new double[] { 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 }, ConvertBitmap(ethalons[3]), 2);
                neuralNetwork.Learn(new double[] { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 }, ConvertBitmap(ethalons[4]), 2);
                neuralNetwork.Learn(new double[] { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 }, ConvertBitmap(ethalons[5]), 2);
                neuralNetwork.Learn(new double[] { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 }, ConvertBitmap(ethalons[6]), 2);
                neuralNetwork.Learn(new double[] { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 }, ConvertBitmap(ethalons[7]), 2);
                neuralNetwork.Learn(new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 }, ConvertBitmap(ethalons[8]), 2);
                neuralNetwork.Learn(new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 }, ConvertBitmap(ethalons[9]), 2);
            }
        }
        private static double[] ConvertBitmap(Bitmap input)
        {
            var res = new List<double>();
            int width = input.Width, height = input.Height;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    res.Add(ColorToDouble(input.GetPixel(i, j)));
                }
            }

            return res.ToArray();
        }

        private static double[,] GetData(List<Bitmap> ethalons)
        {
            var result = new double[ethalons.Count, 60 * 40];
            for (int i = 0; i < ethalons.Count; i++)
            {
                var eth = ConvertBitmap(ethalons[i]);
                for (int j = 0; j < eth.Length; j++)
                {
                    result[i, j] = eth[j];
                }
            }


            return result;
        }
        private static double ColorToDouble(Color color)
        {
            return color.R < 128 ? 0 : 1;
        }
    }
}
