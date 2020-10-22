using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.CountPairsWithSumLessThanK
{
    /// <summary>
    /// https://www.geeksforgeeks.org/count-pairs-array-whose-sum-less-x/
    /// </summary>
    public class CountPairsWithSumLessThanKV1
    {
        public int CountPairs(int[] values, int sum)
        {
            return CountPairs(values, sum, 0, values.Length - 1);
        }

        private int CountPairs(int[] values, int sum, int lowInclusive, int highInclusive)
        {
            var result = 0;
            if (lowInclusive > highInclusive)
            {
                return 0;
            }

            if (values[lowInclusive] + values[highInclusive] > sum)
            {
                return result + CountPairs(values, sum, lowInclusive, highInclusive - 1);
            }

            result = highInclusive - lowInclusive;
            return result + CountPairs(values, sum, lowInclusive + 1, highInclusive);
        }
    }
}
