using System;

namespace Maxim
{
    class Maxim
    {
        public static int FindMaxim(int[] v)
        {
            int m = 0;
            for (int i = 0; i < v.Length; i++)
                if (v[i] > m) m = v[i];
            return m;
        }
    }
}
