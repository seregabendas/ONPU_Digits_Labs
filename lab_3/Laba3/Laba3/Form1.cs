using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba3
{
    public partial class Form1 : Form
    {
        private Bitmap _pixelMatrix;

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
        }

        private void btnGlass_Click(object sender, EventArgs e)
        {
            if (_pixelMatrix == null)
            {
                return;
            }

            var rnd = new Random();

            var pixelMatrixResult = new Bitmap(_pixelMatrix);
            for (var i = 0; i < _pixelMatrix.Width; i++)
            {
                for (var j = 0; j < _pixelMatrix.Height; j++)
                {
                    var x = (int) (i + (rnd.NextDouble() - 0.5) * tbGlass.Value);
                    var y = (int) (j + (rnd.NextDouble() - 0.5) * tbGlass.Value);
                    if (x >= 0 && x < _pixelMatrix.Width && y >= 0 && y < _pixelMatrix.Height)
                    {
                        var col = _pixelMatrix.GetPixel(x, y);
                        pixelMatrixResult.SetPixel(i, j, col);
                    }
                }
            }

            pbResult.Image = pixelMatrixResult;
        }
    }
}