using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems
{
    /// <summary>
    /// Find subarray with given sum (Nonnegative Numbers)
    /// https://www.geeksforgeeks.org/find-subarray-with-given-sum/
    /// </summary>
    public class SubArrayWithGivenSumProblem
    {
        public (int startIndex, int length) Find(int[] values, int sum)
        {
            var startIndex = 0;
            var length = 0;
            var currentSum = 0;
            for (var i = 0; i < values.Length; i++)
            {
                currentSum += values[i];
                if (currentSum == sum)
                {
                    length++;
                    break;
                }
                if (currentSum < sum)
                {
                    length++;
                }
                else
                {
                    var tempSum = currentSum - values[startIndex];
                    do
                    {
                        currentSum = tempSum;
                        length--;
                        startIndex++;
                    } while (tempSum > sum);
                }
            }

            return (startIndex, length);
        }
    }
}
