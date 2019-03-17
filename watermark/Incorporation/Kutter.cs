using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace watermark.Incorporation
{
    class Kutter
    {
        static public Bitmap EmbeddingKutter(Bitmap bmp, float[] pseudo, string wbyte)
        {
            int r, g, b;
            int h, w;
            double l = 0.1;
            Color color = new Color();
            for (int i = 0; i < pseudo.Length; i++)
            {
                h = (int)(pseudo[i] / bmp.Height);
                w = (int)(pseudo[i] / bmp.Width);
                r = bmp.GetPixel(h, w).R;
                g = bmp.GetPixel(h, w).G;
                b = bmp.GetPixel(h, w).B;
                double Y = Incorporation.Context.GetBrightness(h, w, bmp);
                if (wbyte[i] == '0')
                {
                    b -= (int)(l * Y);
                }
                else
                {
                    b += (int)(l * Y);
                    if (b > 255)
                        b = 255;
                }
                color = Color.FromArgb(r, g, b);
                bmp.SetPixel((int)(pseudo[i] / bmp.Height), (int)(pseudo[i] / bmp.Width), color);
            }
            return bmp;
        }
        static public string ExtractingKutter(Bitmap bmp, float[] pseudo)
        {
            string wbyte = "";
            int b = 0, bn = 0, n = 2, tmp = 0;
            for (int i = 0; i < pseudo.Length; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    tmp = j;
                    if (((int)(pseudo[i] / bmp.Width) + tmp) > bmp.Width || ((int)(pseudo[i] / bmp.Width) - tmp) < 0 ||
                        ((int)(pseudo[i] / bmp.Height) + tmp) > bmp.Height || ((int)(pseudo[i] / bmp.Height) - tmp) < 0) tmp = 0;
                    b = b + bmp.GetPixel((int)(pseudo[i] / bmp.Height), (int)(pseudo[i] / bmp.Width) + tmp).B +
                        bmp.GetPixel((int)(pseudo[i] / bmp.Height), (int)(pseudo[i] / bmp.Width) - tmp).B +
                        bmp.GetPixel((int)(pseudo[i] / bmp.Height) + tmp, (int)(pseudo[i] / bmp.Width)).B +
                        bmp.GetPixel((int)(pseudo[i] / bmp.Height) - tmp, (int)(pseudo[i] / bmp.Width)).B;

                }
                bn = b / (4 * n);
                if (bmp.GetPixel((int)(pseudo[i] / bmp.Height), (int)(pseudo[i] / bmp.Width)).B > bn)
                {
                    wbyte += '1';
                }
                else
                {
                    wbyte += '0';
                }
                b = 0;
            }
            return wbyte;
        }
    }
}
