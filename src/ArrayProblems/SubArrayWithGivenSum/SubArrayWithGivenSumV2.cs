using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.SubArrayWithGivenSum
{
    /// <summary>
    /// https://www.geeksforgeeks.org/find-subarray-with-given-sum/
    /// </summary>
    public class SubArrayWithGivenSumV2
    {
        public (int startIndex, int endIndex) Find(int[] values, int sum)
        {
            var startIndex = -1;
            var endIndex = -1;
            var dict = new Dictionary<int, int>();
            var currentSum = 0;
            for (var i = 0; i < values.Length; i++)
            {
                currentSum += values[i];
                if (currentSum - sum == 0)
                {
                    startIndex = 0;
                    endIndex = i;
                    break;
                }

                if (dict.ContainsKey(currentSum - sum))
                {
                    startIndex = dict[currentSum - sum] + 1;
                    endIndex = i;
                    break;
                }
                else
                {
                    dict.Add(currentSum, i);
                }
            }

            return (startIndex, endIndex);
        }
    }
}
