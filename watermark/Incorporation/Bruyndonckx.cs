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
            List<MyPixel> pixels = GetPixels(bmp);

            return null;
        }

        static public List<MyPixel> GetPixels(Bitmap bmp)
        {
            List<MyPixel> pixels = new List<MyPixel>();
            double[] bright = new double[64];
            int height = bmp.Height;
            int width = bmp.Width;
            //int count = 0;
            for (int i = 0; i < 1; i += 8)
            {
                for (int j = 0; j < 1; j += 8)
                {
                    for (int y = 0; y < 8; y++)
                    {
                        for (int x = 0; x < 8; x++)
                        {
                            bright[y * 8 + x] = Incorporation.Context.Brightness(i + x, j + y, bmp);
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

        static public int DiffAndMax(double[] Y)
        {
            int[] X = new int[63];
            for (int i = 0; i < X.Length - 1; i++) X[i] = i + 1;
            int h = 1;
            double max = -Int32.MaxValue;
            int x_max = -1;
            double tmp;
            for (int i = 0; i < X.Length - 1; i++)
            {
                tmp = (Y[X[i] + h] - Y[X[i] - h]) / (2 * h);
                if (tmp > max)
                {
                    max = tmp;
                    x_max = X[i];
                }
            }
            return x_max;
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
            return null;
        }

    }
}

