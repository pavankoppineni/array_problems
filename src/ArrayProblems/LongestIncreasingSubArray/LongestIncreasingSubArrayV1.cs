using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.LongestIncreasingSubArray
{
    /// <summary>
    /// https://www.geeksforgeeks.org/longest-increasing-subarray/
    /// </summary>
    public class LongestIncreasingSubArrayV1
    {
        public (int startIndex, int length) Find(int[] values)
        {
            var maxLength = 1;
            var currentLength = 1;
            var currentIndex = 0;
            var startIndex = 0;
            var previousValue = values[0];

            for (var i = 1; i < values.Length; i++)
            {
                if (values[i] >= previousValue)
                {
                    currentLength++;
                }
                else
                {
                    currentIndex = i;
                    currentLength = 1;
                }

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    startIndex = currentIndex;
                }
            }

            return (startIndex, maxLength);
        }
    }
}
