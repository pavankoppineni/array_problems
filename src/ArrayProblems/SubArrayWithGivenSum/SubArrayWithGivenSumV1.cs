using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.SubArrayWithGivenSum
{
    /// <summary>
    /// https://www.geeksforgeeks.org/find-subarray-with-given-sum/
    /// </summary>
    public class SubArrayWithGivenSumV1
    {
        public (int startIndex, int endIndex) Find(int[] values, int sum)
        {
            var i = 0;
            var currentSum = values[0];
            for (var j = 1; j < values.Length; j++)
            {
                currentSum += values[j];

                if (currentSum > sum)
                {
                    while (currentSum > sum)
                    {
                        currentSum -= values[i];
                        i++;
                    }
                }

                if (currentSum == sum)
                {
                    return (i, j);
                }
            }

            return (-1, -1);
        }
    }
}
