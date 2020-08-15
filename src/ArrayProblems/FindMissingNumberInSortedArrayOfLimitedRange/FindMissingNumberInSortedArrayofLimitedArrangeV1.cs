using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.FindMissingNumberInSortedArrayOfLimitedRange
{
    /// <summary>
    /// https://www.geeksforgeeks.org/find-missing-number-sorted-array-limited-range/
    /// </summary>
    public class FindMissingNumberInSortedArrayofLimitedArrangeV1
    {
        public int Find(int[] values)
        {
            return Find(values, 0, values.Length - 1);
        }

        private int Find(int[] values, int start, int end)
        {
            if (start == end)
            {
                return start + 1;
            }

            var mid = (start + end) / 2;

            var value = values[mid];

            // Value is equal to mid element
            if (value == mid + 1)
            {
                return Find(values, mid + 1, end);
            }

            // Value is greater than element
            if (value > mid + 1)
            {
                return Find(values, start, mid);
            }

            return Find(values, mid, end);
        }
    }
}
