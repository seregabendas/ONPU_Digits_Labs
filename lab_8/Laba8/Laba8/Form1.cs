using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba8
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
            if (openFileDialog1.FileName.Equals("")) return;
            _pixelMatrix = new Bitmap(openFileDialog1.FileName);
            pbSource.Image = _pixelMatrix;
        }

        private void btnMedianFilter_Click(object sender, EventArgs e)
        {
            if (_pixelMatrix == null) return;
            _pixelMatrixResult = new Bitmap(_pixelMatrix.Width, _pixelMatrix.Height);

            int[] arrR = new int[9];
            int[] arrG = new int[9];
            int[] arrB = new int[9];
            for (int i = 1; i < _pixelMatrix.Width - 1; i++)
            {
                for (int j = 1; j < _pixelMatrix.Height - 1; j++)
                {
                    int n = 0;
                    for (int k = -1; k <= 1; k++)
                    {
                        for (int p = -1; p <= 1; p++)
                        {
                            Color col = _pixelMatrix.GetPixel(i + k, j + p);
                            arrR[n] = col.R;
                            arrG[n] = col.G;
                            arrB[n] = col.B;
                            n++;
                        }
                    }
                    Array.Sort(arrR);
                    Array.Sort(arrG);
                    Array.Sort(arrB);
                    _pixelMatrixResult.SetPixel(i, j, Color.FromArgb(arrR[4], arrG[4], arrB[4]));
                }
            }
            pbResult.Image = _pixelMatrixResult;
            
        }
    }
}
