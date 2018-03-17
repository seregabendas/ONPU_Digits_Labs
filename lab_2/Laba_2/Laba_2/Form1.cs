using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_2
{
    public partial class Form1 : Form
    {
        private Bitmap _pixelMatrix;

        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName.Equals("openFileDialog1"))
            {
                return;
            }
            _pixelMatrix = new Bitmap(openFileDialog1.FileName);
            pbSource.Image = _pixelMatrix;
        }

        private void btnGrey_Click(object sender, EventArgs e)
        {
            if (_pixelMatrix == null)
            {
                return;
            }

            var pixelMatrixResult = new Bitmap(_pixelMatrix.Width, _pixelMatrix.Height);
            for (var i = 0; i < _pixelMatrix.Width; i++)
            {
                for (var j = 0; j < _pixelMatrix.Height; j++)
                {
                    var color = _pixelMatrix.GetPixel(i, j);
                    var red = color.R;
                    var blue = color.B;
                    var green = color.G;
                    var grey = (77 * red + 150 * green + 29 * blue) / 256;

                    var newColor = Color.FromArgb(grey, grey, grey);
                    pixelMatrixResult.SetPixel(i, j, newColor);
                }
            }

            pbResult.Image = pixelMatrixResult;
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            if (_pixelMatrix == null)
            {
                return;
            }

            var pixelMatrixResult = new Bitmap(_pixelMatrix.Width, _pixelMatrix.Height);
            for (var i = 0; i < _pixelMatrix.Width; i++)
            {
                for (var j = 0; j < _pixelMatrix.Height; j++)
                {
                    var color = _pixelMatrix.GetPixel(i, j);
                    var newRed = 255 - color.R;
                    var newBlue = 255 -color.B;
                    var newGreen = 255 - color.G;

                    var newColor = Color.FromArgb(newRed, newGreen, newBlue);
                    pixelMatrixResult.SetPixel(i, j, newColor);
                }
            }

            pbResult.Image = pixelMatrixResult;
        }
    }
}
