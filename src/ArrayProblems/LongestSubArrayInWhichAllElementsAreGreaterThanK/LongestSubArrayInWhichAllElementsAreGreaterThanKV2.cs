using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.LongestSubArrayInWhichAllElementsAreGreaterThanK
{
    /// <summary>
    /// https://www.geeksforgeeks.org/longest-subarray-in-which-all-elements-are-greater-than-k/
    /// </summary>
    public class LongestSubArrayInWhichAllElementsAreGreaterThanKV2
    {
        public int Find(int[] values, int k)
        {
            var maxLength = 0;
            var currentLength = 0;
            for (var i = 0; i < values.Length; i++)
            {
                if (values[i] > k)
                {
                    currentLength += 1;
                }
                else
                {
                    currentLength = 0;
                }

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                }
            }

            return maxLength;
        }
    }
}
