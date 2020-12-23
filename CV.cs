using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoAudio.Binarizations;
using VideoAudio.Classificators;
using VideoAudio.Filters;

namespace VideoAudio
{
    public partial class CV : Form
    {
        Median median;
        NeuralNetworkClassification networkClassification;
        Binarize binarize;
        public CV()
        {
            InitializeComponent();
        }

        private void uploadPhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxInput.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void buttonMedian_Click(object sender, EventArgs e)
        {
            median = new Median(3);
            pictureBoxOutput.Image = median.Apply(AForge.Imaging.Image.Clone((Bitmap)pictureBoxOutput.Image, PixelFormat.Format24bppRgb));

        }

        private void buttonBin_Click(object sender, EventArgs e)
        {
            pictureBoxOutput.Image = binarize?.Apply((Bitmap)pictureBoxInput.Image);
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            pictureBoxOutput.Image = MarkObject.Apply((Bitmap)pictureBoxOutput.Image);
            pictureBoxOutput.Image = Circumscription.Apply((Bitmap)pictureBoxOutput.Image);
            Circumscription.DrawLines(Circumscription.objectEdges, (Bitmap)pictureBoxInput.Image);
            pictureBoxInput.Refresh();
            ScallingObjects.Apply(Circumscription.objectEdges, (Bitmap)pictureBoxInput.Image);
        }

        private void buttonEdgeFilter_Click(object sender, EventArgs e)
        {
            pictureBoxOutput.Image = EdgeFilter.Apply((Bitmap)pictureBoxOutput.Image);
        }

        private void saveObjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScallingObjects.SaveObjects(ScallingObjects.Objects);
        }

        private void classificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pictureBoxInput.Image = ImgFidelity.ShowClassificatorResults(ScallingObjects.Objects);
            //pictureBoxOutput.Image = ImgFidelity.ShowClassificatorResults(ScallingObjects.Objects);

        }
        private void FormatForMessageBox(List<int> result)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] == -9999)
                    stringBuilder.Append($"\n{i + 1} об'єкт - невідоме число");

                else
                    stringBuilder.Append($"\n{i + 1} об'єкт - число {result[i]}");
            }
            MessageBox.Show(stringBuilder.ToString());
        }

        private void imgFidelityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormatForMessageBox(ImgFidelity.ShowClassificatorResults(ScallingObjects.Objects));
        }

        private void neuralNetworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            networkClassification = new NeuralNetworkClassification();
            FormatForMessageBox(networkClassification.TakeResult(ScallingObjects.Objects));
        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            binarize = new SimpleBinarization();
        }

        private void mTriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            binarize = new TriangleMethod();
        }
    }
}
