using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems
{
    /// <summary>
    /// Problem : Find sub array with maximum sum
    /// https://www.geeksforgeeks.org/largest-sum-contiguous-subarray/
    /// This uses KADANE'S algorithm
    /// </summary>
    public class SubArrayWithMaximumSumProblem
    {
        public int MaximumSum(int[] values)
        {
            var currentSum = 0;
            var maximumSum = 0;
            foreach (var value in values)
            {
                currentSum = currentSum + value;
                if (currentSum > maximumSum)
                {
                    maximumSum = currentSum;
                }

                if (currentSum < 0)
                {
                    currentSum = 0;
                }
            }
            return maximumSum;
        }
    }
}
