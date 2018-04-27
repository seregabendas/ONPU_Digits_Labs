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
        // Обьявление глобальной переменной исходного изорбражения
        private Bitmap _pixelMatrix;
        // Обьявление глобальной переменной результирующего изображения 
        private Bitmap _pixelMatrixResult;

        public Form1()
        {
            InitializeComponent();
        }

        // Обработчик кнопки открытия файла
        private void btnOpen_Click(object sender, EventArgs e)
        {
            // Открытие диалогового окна выбора изображения
            openFileDialog1.ShowDialog();
            // Возврат из обработчика при отсутствии названия файла
            if (openFileDialog1.FileName.Equals("")) return;
            // Создание объекта класса Bitmap c использованием 
            // контструктора с параметром пути к файлу и
            // присваиваение обьекта ссылке _pixelMatrix
            _pixelMatrix = new Bitmap(openFileDialog1.FileName);
            // Отображение изображения в елементе pbSource
            pbSource.Image = _pixelMatrix;
            // Создание двумерного массива для зачений гистограмм
            // получаемых в результате выполнения функции
            // getHistogram с входным параметром объектом Bitmap
            // исходного изображения
            int[][] arrays = getHistogram(_pixelMatrix);
            // Вызов функции отображения гистограммы с передачей 
            // трех параметров данных о гистограмме каждого цвета
            showHistogram(arrays[0], arrays[1], arrays[2]);
        }


        // Функция получения двумерного массива значений
        // гистограмм каждого канала изображения
        private int[][] getHistogram(Bitmap bitmap)
        {
            // Создание массивов длинной 256 для каждого цвета,
            // для хранения повторений каждого значения цвета
            // где индекс ибозначает значение цвета 
            int[] arrayRed = new int[256];
            int[] arrayBlue = new int[256];
            int[] arrayGreen = new int[256];
            // Цикл для посещение каждого столбца изображения
            for (int i = 0; i < bitmap.Width; i++)
            {
                //Цикл для посещения кажой строки изображения
                for (int j = 0; j < bitmap.Height; j++)
                {
                    // Создание переменной цвета и присваивание
                    // ей значение пикселя координат i, j
                    Color color = bitmap.GetPixel(i, j);
                    // Определение значение цвета каждого 
                    // расчет количества повторений
                    arrayRed[color.R]++;
                    arrayBlue[color.B]++;
                    arrayGreen[color.G]++;
                }
            }
            // Возврат двумерного массива, со значениями каждого 
            // массива каждого цвета
            return new int[][] { arrayRed, arrayGreen, arrayBlue };
        }

        // Функция отображения гистограмм каждого цветового канала
        private void showHistogram(int[] arrayRed, int[] arrayGreen, int[] arrayBlue)
        {
            // Очистка текущих значений графиков
            chartRed.Series["Red"].Points.Clear();
            chartGreen.Series["Green"].Points.Clear();
            chartBlue.Series["Blue"].Points.Clear();
            // Цикл для посещения каждого елемента 
            // массивов значений цветов и добавления
            // значения оси Y по оси X графиков
            for (int i = 0; i < 256; i++)
            {
                // Определение значений массива и добавление 
                // этого значения на график
                chartRed.Series["Red"].Points.AddY(arrayRed[i]);
                chartGreen.Series["Green"].Points.AddY(arrayGreen[i]);
                chartBlue.Series["Blue"].Points.AddY(arrayBlue[i]);
            }
        }

        private void chartRed_Click(object sender, EventArgs e)
        {

        }

        // Обработчик кнопки гистограммной обработки изображений
        private void btnHist_Click(object sender, EventArgs e)
        {
            // Возврат из обработчика при отсутствии изображения
            if (_pixelMatrix == null) return;
            // Создание результирующего изображения с размерами исходного
            _pixelMatrixResult = new Bitmap(_pixelMatrix.Width, _pixelMatrix.Height);
            // Создание переменных минимальных и максимальных
            // значений каждого цветового канала с присваиванием
            // крайних значений
            int Rmin = 0;
            int Rmax = 255;
            int Gmin = 0;
            int Gmax = 255;
            int Bmin = 0;
            int Bmax = 255;
            // Присваивание переменным минмальных и максимальных значений 
            // значений из соответствующих элементов textbox преобразованныых
            // в тип int c предварительной проверкой на присутствие значений
            // в соответствующих элементах texbox
            if (!tbRmin.Text.Equals("")) Rmin = Convert.ToInt32(tbRmin.Text);
            if (!tbRmax.Text.Equals("")) Rmax = Convert.ToInt32(tbRmax.Text);
            if (!tbGmin.Text.Equals("")) Gmin = Convert.ToInt32(tbGmin.Text);
            if (!tbGmax.Text.Equals("")) Gmax = Convert.ToInt32(tbGmax.Text);
            if (!tbBmin.Text.Equals("")) Bmin = Convert.ToInt32(tbBmin.Text);
            if (!tbBmax.Text.Equals("")) Bmax = Convert.ToInt32(tbBmax.Text);
            // Цикл для посещение каждого столбца изображения
            for (int i = 0; i < _pixelMatrix.Width; i++)
            {
                //Цикл для посещения кажой строки изображения
                for (int j = 0; j < _pixelMatrix.Height; j++)
                {
                    // Создание переменной цвета и присваивание
                    // ей значение пикселя координат i, j
                    Color col = _pixelMatrix.GetPixel(i, j);
                    // Создание переменной значений каждого
                    // цветового канала
                    int oldR = col.R;
                    int oldG = col.G;
                    int oldB = col.B;
                    // Расчет новых значений каждого цветового канала
                    int newR = (int)((oldR - Rmin) * (255.0 / (Rmax - Rmin)));
                    int newG = (int)((oldG - Gmin) * (255.0 / (Gmax - Gmin)));
                    int newB = (int)((oldB - Bmin) * (255.0 / (Bmax - Bmin)));
                    // Проверка новых значений на минимальное и 
                    // максимальное значение
                    if (newR < 0) newR = 0;
                    if (newR > 255) newR = 255;
                    if (newG < 0) newG = 0;
                    if (newG > 255) newG = 255;
                    if (newB < 0) newB = 0;
                    if (newB > 255) newB = 255;
                    // Присваивание пикслелю с координатами i,j результирующего
                    // изображения нового цвета
                    _pixelMatrixResult.SetPixel(i, j, Color.FromArgb(newR, newG, newB));
                }        
            }
            // Отображение нового изображения в елементе
            // pictureBox результирующего изображения
            pbResult.Image = _pixelMatrixResult;
            // Создание двумерного массива для зачений гистограмм
            // получаемых в результате выполнения функции
            // getHistogram с входным параметром объектом Bitmap
            // результирующего изображения
            int[][] arrays = getHistogram(_pixelMatrixResult);
            // Вызов функции отображения гистограммы с передачей 
            // трех параметров данных о гистограмме каждого цвета
            showHistogram(arrays[0], arrays[1], arrays[2]);
        }
    }
}
