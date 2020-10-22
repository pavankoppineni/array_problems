using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.CountPairsWithSumLessThanK
{
    /// <summary>
    /// https://www.geeksforgeeks.org/count-pairs-array-whose-sum-less-x/
    /// </summary>
    public class CountPairsWithSumLessThanKV2
    {
        public int CountPairs(int[] values, int sum)
        {
            var low = 0;
            var high = values.Length - 1;
            var result = 0;
            while(low < high)
            {
                if(values[low] + values[high] > sum)
                {
                    high = high - 1;
                }
                else
                {
                    result += high - low;
                    low += 1;
                }
            }

            return result;
        }
    }
}
