using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace watermark.Incorporation
{
    class LSB
    {
        public static Bitmap EmbeddingLSB(Bitmap bmp, string message)
        {
            char[] charPixel = new char[7];
            int i = 0, j = 0, count=0, tmp = 0, delta = 0;
            int h = bmp.Height - 1;
            int w = bmp.Width - 1;
            for (i = 0; i < h; i++)
            {
                for (j = 0; j < w; j++)
                { 
                    if (count < message.Length)
                    {
                        tmp = Convert.ToInt32(Context.GetBlueColorBright(j, i, bmp));
                        charPixel = Convert.ToString(tmp, 2).PadLeft(8, '0').ToCharArray();
                        charPixel[7] = message[count++];
                        delta = tmp - Convert.ToInt32(new string(charPixel),2);
                        bmp = Context.SetBlueColorBright(j, i, bmp, delta);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return bmp;
        }
        public static string ExtractLSB(Bitmap bmp, int lenght)
        {
            string message = "";
            char[] charPixel = new char[7];
            int i = 0, j = 0, count = 0, tmp = 0;
            int h = bmp.Height - 1;
            int w = bmp.Width - 1;
            for (i = 0; i < h; i++)
            {
                for (j = 0; j < w; j++)
                {
                    if (count < lenght)
                    {
                        tmp = Convert.ToInt32(Context.GetBlueColorBright(j, i, bmp));
                        charPixel = Convert.ToString(tmp, 2).PadLeft(8, '0').ToCharArray();
                        message += charPixel[7];
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return message;
        }

    }
}
