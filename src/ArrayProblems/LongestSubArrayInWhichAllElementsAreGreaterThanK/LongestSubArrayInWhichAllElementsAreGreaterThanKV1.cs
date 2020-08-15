using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.LongestSubArrayInWhichAllElementsAreGreaterThanK
{
    /// <summary>
    /// https://www.geeksforgeeks.org/longest-subarray-in-which-all-elements-are-greater-than-k/
    /// </summary>
    public class LongestSubArrayInWhichAllElementsAreGreaterThanKV1
    {
        public (int start, int length) Find(int[] values, int k)
        {
            var currentIndex = -1;
            var currenLength = 0;
            var maxIndex = -1;
            var maxLength = 0;

            for (var i = 0; i < values.Length; i++)
            {
                if (values[i] > k)
                {
                    currenLength++;

                    if (currentIndex < 0)
                    {
                        currentIndex = i;
                    }
                }
                else
                {
                    currentIndex = -1;
                    currenLength = 0;
                }

                if (currenLength > maxLength)
                {
                    maxLength = currenLength;
                    maxIndex = currentIndex;
                }
            }

            return (maxIndex, maxLength);
        }
    }
}
