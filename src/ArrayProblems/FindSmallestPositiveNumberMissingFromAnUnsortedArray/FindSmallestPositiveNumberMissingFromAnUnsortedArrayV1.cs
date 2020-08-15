using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.FindSmallestPositiveNumberMissingFromAnUnsortedArray
{
    /// <summary>
    /// https://www.geeksforgeeks.org/find-the-smallest-positive-number-missing-from-an-unsorted-array/
    /// </summary>
    public class FindSmallestPositiveNumberMissingFromAnUnsortedArrayV1
    {
        public int Find(int[] values)
        {
            values = ReArrangeArray(values);
            var positiveNumberStartIndex = 0;
            while (positiveNumberStartIndex < values.Length)
            {
                if (values[positiveNumberStartIndex] > 0)
                {
                    break;
                }
                positiveNumberStartIndex++;
            }

            var startIndex = positiveNumberStartIndex;
            while (startIndex < values.Length)
            {
                var number = Math.Abs(values[startIndex]);
                var currentIndex = number + positiveNumberStartIndex - 1;
                if (currentIndex >= values.Length)
                {
                    startIndex++;
                    continue;
                }
                values[currentIndex] = -1 * values[currentIndex];
                startIndex++;
            }

            startIndex = positiveNumberStartIndex;
            var currentNumber = 1;
            while (startIndex < values.Length)
            {
                if (values[startIndex] < 0)
                {
                    startIndex++;
                    currentNumber++;
                    continue;
                }
                else
                {
                    break;
                }
            }

            return currentNumber;
        }

        private int[] ReArrangeArray(int[] values) 
        {
            var left = 0;
            var right = values.Length - 1;
            while (left < right)
            {
                // Both are negative
                if (values[left] < 0 && values[right] < 0)
                {
                    left++;
                    continue;
                }

                // Both are positive
                if (values[left] >= 0 && values[right] >= 0)
                {
                    right--;
                    continue;
                }

                // Left is negative and right is positive
                if (values[left] < 0 && values[right] >= 0)
                {
                    left++;
                    right--;
                    continue;
                }

                // Left is positive and right is negative
                if (values[left] >= 0 && values[right] < 0)
                {
                    var temp = values[left];
                    values[left] = values[right];
                    values[right] = temp;
                    left++;
                    right--;
                    continue;
                }
            }

            return values;
        }
    }
}
