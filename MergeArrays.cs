using System;

namespace MergeArrays
{
    class MergeArrays
    {
        static int[] Merge(int[] v1, int[] v2)
        {
            int i = 0, j = 0, k = 0;
            int[] v3 = new int[v1.Length + v2.Length];
            while (i < v1.Length && j < v2.Length)
            {
                if (v1[i] < v2[j])
                {
                    v3[k++] = v1[i++];
                }
                else
                {
                    v3[++k] = v2[j++];
                }
            }
            while (i < v1.Length)
            {
                v3[k++] = v1[i++];
            }
            while (j < v2.Length)
            {
                v3[k++] = v2[j++];
            }

            return v3;
        }
    }
}