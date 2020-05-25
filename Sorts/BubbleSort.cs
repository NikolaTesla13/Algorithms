using System;

namespace BubbleSort
{
    class BubbleSort
    {
        static int[] BubbleSort(int[] v, int n)
        {
            bool ok = false;
            while (!ok)
            {
                ok = true;
                for (int i = 0; i < n - 1; i++)
                {
                    if (v[i] > v[i + 1])
                    {
                        int temp = v[i];
                        v[i] = v[i + 1];
                        v[i + 1] = temp;
                        ok = false;
                    }
                }
            }
            return v;
        }
    }
}
