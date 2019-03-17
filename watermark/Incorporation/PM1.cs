using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace watermark.Incorporation
{
    class PM1
    {
        public static Bitmap EmbeddingPm1(Bitmap bmp, string message, int[] r)
        {
            int i = 0, count = 0, tmp = 0, delta = 0, j = 0, number = 0;
            int h = bmp.Height - 1;
            int w = bmp.Width - 1;
            for (i = 0; i < h; i++)
            {
                for (j = 0; j < w; j++)
                {
                    if (count < message.Length)
                    {
                        tmp = Convert.ToInt32(Context.GetBlueColorBright(j, i, bmp));
                        number = message[count] - '0';
                        if (tmp % 2 == number)
                        {
                            delta = 0;
                            // Нет изменений
                        }
                        else if ((tmp % 2 != number) && ((r[count] >= 0) && (tmp < 255) || (tmp == 0)))
                        {
                            delta = 1;
                            bmp = Context.SetBlueColorBright(j, i, bmp, delta);
                        }
                        else if ((tmp % 2 != number) && ((r[count] < 0) && (tmp > 0) || (tmp ==255)))
                        {
                            delta = -1;
                            bmp = Context.SetBlueColorBright(j, i, bmp, delta);
                        }
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return bmp;
        }

        public static string ExtractingPm1(Bitmap bmp, int lenght)
        {
            string message = "";
            int i = 0, count = 0, tmp = 0, j = 0;
            int h = bmp.Height - 1;
            int w = bmp.Width - 1;
            for (i = 0; i < h; i++)
            {
                for (j = 0; j < w; j++)
                {
                    if (count < lenght)
                    {
                        tmp = Convert.ToInt32(Context.GetBlueColorBright(j, i, bmp));
                        if(tmp % 2 == 1)
                        {
                            message += '1';
                        }
                        else
                        {
                            message += '0';
                        }
                        count++;
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
