using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.FindNumberOfPairsWithDifferenceLessThanOrEqualToK
{
    /// <summary>
    /// https://www.geeksforgeeks.org/pairs-difference-less-k/
    /// </summary>
    public class FindNumberOfPairsWithDifferenceLessThanOrEqualToKV1
    {
        public int FindNumberOfPairs(int[] values, int difference)
        {
            Array.Sort(values);
            var result = 0;
            var low = 0;
            var high = 1;
            while (low < values.Length && high < values.Length)
            {
                if (low == high)
                {
                    high += 1;
                    continue;
                }

                // Case 1 : When difference between low and high is less than difference
                // Action : Increate high
                if (Math.Abs(values[low] - values[high]) <= difference)
                {
                    high += 1;
                }
                else
                // Case 2 : When difference between low and high is greater than difference
                // Action : 
                {
                    result += high - low - 1;
                    low += 1;
                }
            }

            return result;
        }
    }
}
