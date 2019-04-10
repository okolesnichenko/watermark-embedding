using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace watermark.Interference
{
    class Inter
    {
        public static Bitmap GenerateVoid(Bitmap bmp)
        {
            int void_h = 20;
            int length = 20, h, w, r, g, b;
            Incorporation.Generator generator = new Incorporation.Generator(90, 16, 45, 6, length);
            float[] gen = generator.Generate();

            for (int i = 0; i < length; i++)
            {
                for(int j = 0; j < length; j++)
                {
                    h = GetLength(gen[i], bmp.Height);
                    w = GetLength(gen[j], bmp.Width);

                    
                    r = bmp.GetPixel(h, w).R + void_h;
                    g = bmp.GetPixel(h, w).G - void_h;
                    b = bmp.GetPixel(h, w).B + void_h;
                    if (r < 0) r = 0;
                    else if (r > 255) r = 255;
                    if (g < 0) g = 0;
                    else if (g > 255) g = 255;
                    if (b < 0) b = 0;
                    else if (b > 255) b = 255;

                    Color color = Color.FromArgb(r, g, b);
                    bmp.SetPixel(h, w, color);
                }
            }
            return bmp;
         
        }

        public static int GetLength(float tmp, int width)
        {
            if (tmp < width)
            {
                return (int)tmp;
            }
            else
            {
                while (tmp > width)
                {
                    tmp = tmp / 2;
                }
                return (int)tmp;
            }
        }
    }
}
