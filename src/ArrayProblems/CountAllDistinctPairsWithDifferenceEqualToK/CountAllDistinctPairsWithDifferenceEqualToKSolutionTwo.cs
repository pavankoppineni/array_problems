using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems
{
    /// <summary>
    /// https://www.geeksforgeeks.org/count-pairs-difference-equal-k/
    /// </summary>
    public class CountAllDistinctPairsWithDifferenceEqualToKSolutionTwo
    {
        public IList<(int item1, int item2)> Count(int[] values, int k)
        {
            var pairs = new List<(int item1, int item2)>();
            Array.Sort(values);
            var low = 0;
            var high = 0;
            while (high < values.Length)
            {
                if (values[high] - values[low] == k)
                {
                    var pair = (values[low], values[high]);
                    pairs.Add(pair);
                    low++;
                    high++;
                }
                else if (values[high] - values[low] > k)
                {
                    low++;
                }
                else
                {
                    high++;
                }
            }
            return pairs;
        }
    }
}
