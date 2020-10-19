using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.SubArrayWithGivenSum
{
    /// <summary>
    /// https://www.geeksforgeeks.org/find-subarray-with-given-sum-in-array-of-integers/
    /// </summary>
    public class SubArrayWithGivenSumIncludesNegativeNumbersV1
    {
        public int FindSubArray(int[] values, int sum)
        {
            var previousSum = 0;
            var dict = new Dictionary<int, IList<int>>();
            var count = 0;
            for (var i = 0; i < values.Length; i++)
            {
                previousSum = previousSum + values[i];
                if (previousSum == sum)
                {
                    if (dict.ContainsKey(previousSum))
                    {
                        dict[previousSum].Add(i);
                    }
                    else
                    {
                        dict.Add(previousSum, new List<int> { i });
                    }
                    count++;
                    continue;
                }

                if (dict.ContainsKey(previousSum - sum))
                {
                    count += dict[previousSum - sum].Count;
                }

                if (dict.ContainsKey(previousSum))
                {
                    dict[previousSum].Add(i);
                }
                else
                {
                    dict.Add(previousSum, new List<int> { i });
                }
            }

            return count;
        }
    }
}
