using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Laba_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bitmap bitmapBefore = new Bitmap(@"C:\Users\sereg\Desktop\ONPU_Digits\img\ris.bmp");
            Bitmap bitmapResult = new Bitmap(bitmapBefore.Width, bitmapBefore.Height);

            for (int i = 0; i < bitmapBefore.Width; i++)
            {
                for (int j = 0; j < bitmapBefore.Height; j++)
                {
                    Color colorBefore = bitmapBefore.GetPixel(i, j);
                    byte redColor = colorBefore.R;
                    Color colorResult = Color.FromArgb(redColor, 0, 0);
                    bitmapResult.SetPixel(i, j, colorResult);
                }
            }

            bitmapResult.Save(@"C:\Users\sereg\Desktop\ONPU_Digits\img\ris2.bmp");

            


        }
    }
}
