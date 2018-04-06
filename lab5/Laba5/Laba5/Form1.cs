using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba5
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
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            if (_pixelMatrix == null)
            {
                return;
            }

            _pixelMatrixResult = new Bitmap(_pixelMatrix.Width, _pixelMatrix.Height);
            var grad = tbRotate.Value;
            var rad = grad * Math.PI / 180;
            var xc = _pixelMatrix.Width / 2;
            var yc = _pixelMatrix.Height / 2;
            var radCos = Math.Cos(rad);
            var radSin = Math.Sin(rad);
            for (var i = 0; i < _pixelMatrix.Width; i++)
            {
                for (var j = 0; j < _pixelMatrix.Height; j++)
                {
                    var ix = i - xc;
                    var jy = j - yc;
                    var x = (int) (ix * radCos - jy * radSin + xc);
                    var y = (int) (ix * radSin + jy * radCos + yc);
                    if (x >= 0 && x < _pixelMatrix.Width && y >= 0 && y < _pixelMatrix.Height)
                    {
                        var col = _pixelMatrix.GetPixel(x, y);
                        _pixelMatrixResult.SetPixel(i, j, col);
                    }
                }
            }

            pbResult.Image = _pixelMatrixResult;
        }
    }
}
