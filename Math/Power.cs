using System;

namespace Power
{
    internal class Power
    {
        public static long Pow(int bas, int exp)
        {
            if (exp == 1) return bas;
            if (exp == 0) return 1;
            long result = 1;
            for (int i = 0; i < exp; i++) result *= bas;
            return result;
        }
    }
}
