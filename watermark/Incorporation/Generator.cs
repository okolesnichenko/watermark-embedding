using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace watermark.Incorporation
{
    class Generator
    {
        private float[] result;
        private int k, a, b;
        public Generator(int u0, int k, int a, int b, int length)
        {
            this.result = new float[length];
            result[0] = u0;
            this.k = k;
            this.a = a * 4 + 1;
            this.b = b * 2 + 1;
        }

        public float[] Generate()
        {
            for (int i = 1; i < result.Length; i++)
            {
                result[i] = (a * result[i - 1] + b) % (2 << (k - 1));
            }
            return result;
        }
    }
}
