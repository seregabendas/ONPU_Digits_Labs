using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabaRGR
{
    public partial class Form1 : Form
    {
        private Bitmap _pixelMatrix;
        private Bitmap _pixelMatrixResult;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName.Equals(""))
            {
                return;
            }

            _pixelMatrix = new Bitmap(openFileDialog1.FileName);
            pbSource.Image = _pixelMatrix;
            int[][] arrays = getHistogram(_pixelMatrix);
            showHistogram(arrays[0], arrays[1], arrays[2]);
        }

        private int[][] getHistogram(Bitmap bitmap)
        {
            int[] arrayRed = new int[256];
            int[] arrayBlue = new int[256];
            int[] arrayGreen = new int[256];
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color color = bitmap.GetPixel(i, j);
                    arrayRed[color.R]++;
                    arrayBlue[color.B]++;
                    arrayGreen[color.G]++;
                }
            }
            return new int[][] { arrayRed, arrayGreen, arrayBlue };
        }

        private void showHistogram(int[] arrayRed, int[] arrayGreen, int[] arrayBlue)
        {
            chartRed.Series["Red"].Points.Clear();
            chartGreen.Series["Green"].Points.Clear();
            chartBlue.Series["Blue"].Points.Clear();

            for (int i = 0; i < 256; i++)
            {
                chartRed.Series["Red"].Points.AddY(arrayRed[i]);
                chartGreen.Series["Green"].Points.AddY(arrayGreen[i]);
                chartBlue.Series["Blue"].Points.AddY(arrayBlue[i]);
            }
        }
    }
}
