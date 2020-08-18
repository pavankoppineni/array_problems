using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.MaximumSumSuchThatNoTwoElementsAreAdjacent
{
    /// <summary>
    /// https://www.geeksforgeeks.org/maximum-sum-such-that-no-two-elements-are-adjacent/
    /// </summary>
    public class MaximumSumSuchThatNoTwoElementsAreAdjacentV1
    {
        public int GetMaximum(int[] values)
        {
            var inclusiveSum = values[0];
            var exclusiveSum = 0;

            for (var i = 1; i < values.Length; i++)
            {
                var currentMax = Math.Max(inclusiveSum, exclusiveSum);  

                inclusiveSum = exclusiveSum + values[i];
                exclusiveSum = currentMax;
            }

            return Math.Max(inclusiveSum, exclusiveSum);
        }
    }
}
