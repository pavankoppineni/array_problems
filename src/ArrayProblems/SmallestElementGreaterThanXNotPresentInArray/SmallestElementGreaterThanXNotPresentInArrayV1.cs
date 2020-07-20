using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.SmallestElementGreaterThanXNotPresentInArray
{
    /// <summary>
    /// https://www.geeksforgeeks.org/smallest-element-greater-than-x-not-present-in-the-array/
    /// </summary>
    public class SmallestElementGreaterThanXNotPresentInArrayV1
    {
        public int Find(int[] values, int k)
        {
            Array.Sort(values);
            return Find(values, 0, values.Length - 1, k + 1);
        }

        private int Find(int[] values, int low, int high, int k)
        {
            // low > high
            if (low > high)
            {
                return k;
            }

            var mid = (low + high) / 2;

            // k is equal to mid
            if (values[mid] == k)
            {
                return Find(values, mid + 1, high, k + 1);
            }

            // if mid is grater than k, then search first half
            if (values[mid] > k)
            {
                return Find(values, low, mid - 1, k);
            }

            // if mid is less than k, then search second half
            return Find(values, mid + 1, high, k);
        }
    }
}
