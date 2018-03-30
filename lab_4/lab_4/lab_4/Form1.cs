using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_4
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

        private void btnWave_Click(object sender, EventArgs e)
        {

            if (_pixelMatrix == null)
            {
                return;
            }

            var rnd = new Random();
            _pixelMatrixResult = new Bitmap(_pixelMatrix);
      
            for (var i = 0; i < _pixelMatrix.Width; i++)
            {
                for (var j = 0; j < _pixelMatrix.Height; j++)
                {
                    var x = (int) (i + tbV1.Value * Math.Sin(2 * Math.PI * j / tbV2.Value));
                    var y = (int) (j + tbV3.Value * Math.Sin(2 * Math.PI * i / tbV4.Value));
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
