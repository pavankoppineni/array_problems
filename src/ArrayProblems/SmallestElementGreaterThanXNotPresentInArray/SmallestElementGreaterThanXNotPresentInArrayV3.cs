using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.SmallestElementGreaterThanXNotPresentInArray
{
    /// <summary>
    /// https://www.geeksforgeeks.org/smallest-element-greater-than-x-not-present-in-the-array/
    /// </summary>
    public class SmallestElementGreaterThanXNotPresentInArrayV3
    {
        public int Find(int[] values, int k)
        {
            Sort(values, 0, values.Length - 1);
            return -1;
        }

        private void Sort(int[] values, int start, int end)
        {
            if (start > end)
            {
                return;
            }
            var pivot = GetPivot(values, start, end);
            Sort(values, start, pivot - 1);
            Sort(values, pivot + 1, end);
        }

        private int GetPivot(int[] values, int start, int end)
        {
            var currentPosition = start;
            while (start < end)
            {
                if (values[currentPosition] > values[end])
                {
                    start += 1;
                    continue;
                }
                var temp = values[currentPosition];
                values[currentPosition] = values[start];
                values[start] = temp;
                currentPosition += 1;
                start += 1;
            }

            var tempValue = values[currentPosition];
            values[currentPosition] = values[end];
            values[end] = tempValue;

            return currentPosition;
        }
    }
}
