using System;

namespace QuickSort
{
    class QuickSort
    {
        static int partition(int[] v, int left, int right)
        {
            int pivot = v[right];
            int i = (left - 1);
            for (int j = left; j < right; j++)
            {
                if (v[j] < pivot)
                {
                    i++;

                    int temp = v[i];
                    v[i] = v[j];
                    v[j] = temp;
                }
            }
            int temp1 = v[i + 1];
            v[i + 1] = v[right];
            v[right] = temp1;

            return i + 1;
        }
        static void QuickSort(int[] v, int left, int right)
        {
            int temp;
            if (left < right)
            {
                int pivot = partition(v, left, right);

                QuickSort(v, left, pivot - 1);
                QuickSort(v, pivot + 1, right);
            }
        }
    }
}