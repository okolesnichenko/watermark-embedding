using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace watermark.Incorporation
{
    class MyPixel
    {
        public int x;
        public int y;
        public double bright;
        public bool Lmark;    // True = Big, False = Less
        public bool mask;      // True = A, Fasle = Small
        /* Схема 1
        A A A A B B B B
        A A A A B B B B
        A A A A B B B B
        A A A A B B B B
        B B B B A A A A
        B B B B A A A A
        B B B B A A A A
        B B B B A A A A
        */
        public MyPixel(int x, int y, double bright, bool Lmark, bool mask)
        {
            this.x = x;
            this.y = y;
            this.bright = bright;
            this.Lmark = Lmark;
            this.mask = mask;
        }
    }

    class Bruyndonckx
    {
        static public Bitmap BruyndonckxEmbedding(Bitmap bmp, string wbyte)
        {
            List<List<MyPixel>> listOfPixels = new List<List<MyPixel>>();
            List<MyPixel> pixels;
            double mean1A, mean2A, mean1B, mean2B, mean1, mean2,
                _mean1A = 0, _mean2A = 0, _mean1B = 0, _mean2B = 0, delta = 0;
            int count1A, count2A, count1B, count2B, i = 0, j = 0,
                height = bmp.Height, width = bmp.Width, level = 4;
            // Цикл для каждого символа цвз
            // Пикселей должно быть много для большого цвз
            for (int k = 0; k < wbyte.Length - 1; k++)
            {
                i += 8;
                if (i > bmp.Height)
                {
                    j += 8;
                    if (j < bmp.Width)
                    {    
                        i = 0;
                    }
                    else
                    {
                        break;
                    }
                }
                pixels = GetPixels(bmp, i, j);
                count1A = Context.CountFor12AB(pixels, false, true);
                count2A = Context.CountFor12AB(pixels, true, true);
                count1B = Context.CountFor12AB(pixels, false, false);
                count2B = Context.CountFor12AB(pixels, true, false);
                mean1A = Context.MeanFor12AB(pixels, false, true);
                mean2A = Context.MeanFor12AB(pixels, true, true);
                mean1B = Context.MeanFor12AB(pixels, false, false);
                mean2B = Context.MeanFor12AB(pixels, true, false);
                mean1 = Context.MeanFor12(pixels, false);
                mean2 = Context.MeanFor12(pixels, true);
                // Расчет средних для каждой из 4 категорий символов
                if (wbyte[k] == '0')
                {
                    _mean1A = mean1 - (level * count1B) / (count1A + count1B);
                    _mean1B = _mean1A + level;
                    _mean2A = mean2 - (level * count2B) / (count2A + count2B);
                    _mean2B = _mean2A + level;
                }
                else
                {
                    _mean1A = mean1 + (level * count1B) / (count1A + count1B);
                    _mean1B = _mean1A - level;
                    _mean2A = mean2 + (level * count2B) / (count2A + count2B);
                    _mean2B = _mean2A - level;
                }
                // Изменение яркости в соответсвии с типом пикселей
                foreach(MyPixel pixel in pixels)
                {
                    if ((!pixel.Lmark)&&(pixel.mask))
                    {
                        delta = _mean1A - mean1A;
                    }
                    else if((pixel.Lmark) && (pixel.mask))
                    {
                        delta = _mean2A - mean2A;
                    }
                    else if((!pixel.Lmark) && (!pixel.mask))
                    {
                        delta = _mean2A - mean2A;
                    }
                    else
                    {
                        delta = _mean2B - mean2B;
                    }
                    bmp = Context.SetBrightness(pixel.x, pixel.y, bmp, delta);
                }
                listOfPixels.Add(pixels);
            }
            return bmp;
        }

        static public string BruyndonckxExtracting(Bitmap bmp, int length)
        {
            List<MyPixel> pixels;
            double mean1A, mean2A, mean1B, mean2B;
            int i = 0, j = 0, k, height = bmp.Height, width = bmp.Width;
            string wbyte = "";
            for(k = 0; k<length; k++)
            {
                i += 8;
                if (k > bmp.Height)
                {
                    j += 8;
                    if (j < bmp.Width)
                    {
                        k = 0;
                    }
                    else
                    {
                        break;
                    }
                }
                pixels = GetPixels(bmp, i, j);
                mean1A = Context.MeanFor12AB(pixels, false, true);
                mean2A = Context.MeanFor12AB(pixels, true, true);
                mean1B = Context.MeanFor12AB(pixels, false, false);
                mean2B = Context.MeanFor12AB(pixels, true, false);
                if(((mean1A - mean1B)<0)&&((mean2A - mean2B)<0))
                {
                    wbyte += "0";
                }
                else if(((mean1A - mean1B) > 0) && ((mean2A - mean2B) > 0))
                {
                    wbyte += "1";
                }
                else
                {
                    wbyte += "e";
                }
            }
            return wbyte;
        }

        static public List<MyPixel> GetPixels(Bitmap bmp, int i, int j)
        {
            List<MyPixel> pixels = new List<MyPixel>();
            double[] bright = new double[64];
            int height = bmp.Height;
            int width = bmp.Width;
            // Полная картнка

            // Блок пикселей 8 на 8
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    // Проходим по всем пикселям и считаем яркость
                    // Маркируем их по схеме 1
                    bright[y * 8 + x] = Context.GetBrightness(i + x, j + y, bmp);
                    if (((y < 4) && (x < 4)) || ((x >= 4) && (y >= 4)))
                    {
                        pixels.Add(new MyPixel(i + x, j + y, bright[y * 8 + x], false, true));
                    }
                    else
                    {
                        pixels.Add(new MyPixel(i + x, j + y, bright[y * 8 + x], false, false));
                    }
                }
            }
            Array.Sort(bright);
            int X = DiffAndMax(bright);
            pixels = MarkPixels(pixels, bright[X]);

            return pixels;
        }

        static public int DiffAndMax(double[] Y)
        {
            // Длина переданного массива пикселей (известно 64)
            // Решено взять расмотрение среднего участка яркостей
            // 25% - 50% - 25%
            // Поэтому нижнюю границу поиска производной
            // мы берем 64*0.25 = 16, верхнюю 64*0.75 = 48 
            int lengmin = 15;
            int lenmax = 47;
            // Параметр для примерного расчета производной
            int h = 1;
            double max = -Int32.MaxValue;
            // Индекс максимального перепада
            int maxIndex = -1;
            double tmp;
            for (; lengmin < lenmax; lengmin++)
            {
                // Значение производной
                tmp = (Y[lengmin + h] - Y[lengmin - h]) / (2 * h);
                if (tmp > max)
                {
                    max = tmp;
                    maxIndex = lengmin;
                }
            }
            return maxIndex;
        }

        static public List<MyPixel> MarkPixels(List<MyPixel> pixels, double limit)
        {
            foreach (MyPixel pixel in pixels)
            {
                if (pixel.bright > limit)
                {
                    pixel.Lmark = true;
                }
                else
                {
                    pixel.Lmark = false;
                }
            }
            return pixels;
        }

        static public double Func(double[] Y, double x)
        {
            int[] X = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            double res = 0;
            double tmp = 1;
            for (int i = 0; i < X.Length; i++)
            {
                for (int j = 0; j < X.Length; j++)
                {
                    if (i != j)
                    {
                        tmp *= ((x - X[j]) / (X[i] - X[j]));
                    }
                }
                if (i != 0)
                {
                    res += Y[i * 8 - 1] * tmp;
                }
                else
                {
                    res += Y[0] * tmp;
                }

            }
            return res;
        }

        static public int DiffAndMaxWithInterpolation(double[] Y)
        {
            int[] X = { 1, 2, 3, 4, 5, 6, 7 };
            double h = 0.5;
            double max = -Int32.MaxValue;
            int x_max = -1;
            double tmp;
            for (int i = 0; i < X.Length; i++)
            {
                tmp = (Func(Y, X[i] + h) - Func(Y, X[i] - h)) / 2 * h;
                //tmp = (Y[X[i] + h] - Y[X[i] - h]) / (2 * h);
                if (tmp > max)
                {
                    max = tmp;
                    x_max = X[i];
                    //x_max = X[i];
                }
            }
            return x_max;
        }
    }
}

