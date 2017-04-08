using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging;
using AForge.Imaging.Filters;

namespace Krishna
{
    public partial class Form1 : Form
    {
        Bitmap orImg, grayImage;
        public Form1()
        {
            InitializeComponent();
        }


        private void GrayscaleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // create grayscale filter (BT709)
            Grayscale filter = new Grayscale(0.2125, 0.7154, 0.0721);
            // apply the filter
            grayImage = filter.Apply(orImg);
            pictureBox2.Image = grayImage;

        }

        private void CannyEdgeDetectionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CannyEdgeDetector ed = new CannyEdgeDetector();
            Bitmap s1 = ed.Apply(grayImage);
            pictureBox3.Image = s1;
        }

        private void SephiaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Sepia re = new Sepia();
            Bitmap s2 = re.Apply(orImg);
            pictureBox4.Image = s2;
        }

        private void PixellateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pixellate rs = new Pixellate();
            Bitmap s3 = rs.Apply(orImg);
            pictureBox5.Image = s3;
        }

        private void SobelEdgeDetectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SobelEdgeDetector ro = new SobelEdgeDetector();
            Bitmap s4 = ro.Apply(grayImage);
            pictureBox6.Image = s4;
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog o1 = new OpenFileDialog();
            var returnValue = o1.ShowDialog();
            if (returnValue == DialogResult.OK)
            {
                orImg = new Bitmap(o1.FileName);
                pictureBox1.Image = orImg;
            }
        }
    }
}
