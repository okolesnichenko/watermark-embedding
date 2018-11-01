using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace watermark.Incorporation
{
    class Context
    {
        public static double Accuracy(string a, string b)
        {
            int count = 0;
            if((a != null)&&(b != null))
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if(a[i] != b[i])
                        count ++;
                }
            }
            return 1 - (double)count / a.Length;
        }

        public static double Brightness(int x, int y, Bitmap bmp)
        {
            int r, g, b;
            r = bmp.GetPixel(x, y).R;
            g = bmp.GetPixel(x, y).G;
            b = bmp.GetPixel(x, y).B;
            return 0.3 * r + 0.59 * g + 0.11 * b;
        }
    }
}
