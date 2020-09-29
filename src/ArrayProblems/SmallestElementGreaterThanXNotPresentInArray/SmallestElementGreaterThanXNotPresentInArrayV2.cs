using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.SmallestElementGreaterThanXNotPresentInArray
{
    /// <summary>
    /// https://www.geeksforgeeks.org/smallest-element-greater-than-x-not-present-in-the-array/
    /// </summary>
    public class SmallestElementGreaterThanXNotPresentInArrayV2
    {
        public int FindSmallestElement(int[] values, int k)
        {
            Array.Sort(values);
            return FindSmallestElement(values, 0, values.Length - 1, k + 1);
        }

        private int FindSmallestElement(int[] values, int inclusiveStart, int inclusiveEnd, int k)
        {
            if (inclusiveStart > inclusiveEnd)
            {
                return k;
            }

            var mid = (inclusiveStart + inclusiveEnd) / 2;
            if (values[mid] == k)
            {
                return FindSmallestElement(values, mid + 1, inclusiveEnd, k + 1);
            }

            if (values[mid] > k)
            {
                return FindSmallestElement(values, inclusiveStart, mid, k);
            }

            return FindSmallestElement(values, mid, inclusiveEnd, k);
        }
    }
}
