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
using VideoAudio.Filters;

namespace VideoAudio
{
    public partial class CV : Form
    {
        Median median; 
        public CV()
        {
            InitializeComponent();
        }

        private void uploadPhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog()==DialogResult.OK)
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
            pictureBoxOutput.Image = Binarization.Apply((Bitmap)pictureBoxInput.Image);
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            pictureBoxOutput.Image = MarkObject.Apply((Bitmap)pictureBoxOutput.Image);
            pictureBoxOutput.Image = 
        }

        private void buttonEdgeFilter_Click(object sender, EventArgs e)
        {
            pictureBoxOutput.Image = EdgeFilter.Apply((Bitmap)pictureBoxOutput.Image);
        }
    }
}
