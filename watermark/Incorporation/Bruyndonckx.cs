using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace watermark.Incorporation
{
    class Bruyndonckx
    {
        static public Bitmap BruyndonckxEmbedding(Bitmap bmp, string wbyte)
        {
            double[] alpha = new double[64];
            int height = bmp.Height;
            int width = bmp.Width;
            int count = 0;
            for(int i = 0; i < 1; i+=8)
            {
                for(int j = 0; j < 1; j+=8)
                {
                    for(int y = 0; y < 8; y++)
                    {
                        for(int x = 0; x < 8; x++)
                        {
                            alpha[count] = Incorporation.Context.Brightness(i + x, j + y, bmp);
                            count++;
                        }
                    }
                }
            }
            return null;
        }
    }
}
