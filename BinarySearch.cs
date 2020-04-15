using System;

namespace BinarySearch
{
    class BinarySearch
    {
        static bool BinarySearch(int[] v, int n)
        {
            int left = 0, right = v.Length - 1, pivot;
            while (left <= right)
            {
                pivot = (left + right) / 2;
                if (v[pivot] == n)
                {
                    return true;
                }
                else
                {
                    if (v[pivot] < n)
                    {
                        left = pivot + 1;
                    }
                    else
                    {
                        if (v[pivot] > n)
                        {
                            right = pivot - 1;
                        }
                    }
                }
            }
            return false;
        }
    }
}