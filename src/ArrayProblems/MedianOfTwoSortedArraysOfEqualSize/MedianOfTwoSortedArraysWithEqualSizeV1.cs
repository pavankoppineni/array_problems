using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.MedianOfTwoSortedArraysOfEqualSize
{
    /// <summary>
    /// https://www.geeksforgeeks.org/median-of-two-sorted-arrays/
    /// </summary>
    public class MedianOfTwoSortedArraysWithEqualSizeV1
    {
        public double FindMedian(int[] arrayOne, int[] arrayTwo)
        {
            return FindMedian(arrayOne, arrayTwo, 0, arrayOne.Length - 1, 0, arrayTwo.Length - 1);
        }

        private double FindMedian(int[] a, int[] b, int startA, int endA, int startB, int endB)
        {
            if (endA - startA == 1)
            {
                return (Math.Max(a[startA], b[startB]) + Math.Min(a[endA], b[endB])) / 2;
            }

            var medianA = GetMedian(a, startA, endA);
            var medianB = GetMedian(b, startB, endB);

            if (medianA == medianB)
            {
                return medianA;
            }

            if (medianA < medianB)
            {
                return FindMedian(a, b, (startA + endA) / 2, endA, startB, (startB + endB) / 2 + 1);
            }

            return FindMedian(a, b, startA, (startA + endA) / 2 + 1, (startB + endB) / 2, endB);
        }

        private double GetMedian(int[] array, int low, int end)
        {
            if (low == end)
            {
                return array[low];
            }

            if (end - low == 1)
            {
                return (array[low] + array[end]) / 2;
            }

            var len = end - low + 1;
            if (len % 2 == 0)
            {
                return (array[low + (len / 2)] + array[low + (len / 2) - 1]) / 2;
            }

            return array[low + len / 2];
        }
    }
}
