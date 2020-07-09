using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.NextLexicographicalPermutation
{
    /// <summary>
    /// https://www.nayuki.io/page/next-lexicographical-permutation-algorithm
    /// </summary>
    public class NextLexicographicalPermutationV1
    {
        public (bool hasNextPermutation, int[] values) Generate(int[] values)
        {
            var longestDecreasingStartIndex = values.Length - 1;
            while (longestDecreasingStartIndex > 0
                && values[longestDecreasingStartIndex - 1] >= values[longestDecreasingStartIndex])
            {
                longestDecreasingStartIndex--;
            }   

            // If there is no decreasing sequence
            if (longestDecreasingStartIndex <= 0)
            {
                return (false, values);
            }

            var pivotIndex = longestDecreasingStartIndex - 1;
            // If array is long, then binary search is efficient
            for (var i = values.Length - 1; i > pivotIndex; i--)
            {
                if (values[i] > values[pivotIndex])
                {
                    var temp = values[i];
                    values[i] = values[pivotIndex];
                    values[pivotIndex] = temp;
                    break;
                }
            }

            Array.Reverse(values, longestDecreasingStartIndex, values.Length - longestDecreasingStartIndex);

            return (true, values);
        }
    }
}
