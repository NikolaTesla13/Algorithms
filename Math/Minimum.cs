using System;

namespace Minimum
{
    internal class Minimum
    {
        public static int FindMinimum(int[] v)
        {
            int m = Int32.MaxValue;
            for (int i = 0; i < v.Length; i++)
                if (v[i] < m) m = v[i];
            return m;
        }
    }
}
