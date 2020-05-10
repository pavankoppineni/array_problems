using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems
{
    /// <summary>
    /// https://www.geeksforgeeks.org/count-pairs-difference-equal-k/
    /// </summary>
    public class CountAllDistinctPairsWithDifferenceEqualToKSolutionOne
    {

        public IList<(int item1, int item2)> Count(int[] values, int k)
        {
            var pairs = new List<(int item1, int item2)>();
            var lookUp = new Dictionary<int, int>();
            foreach (var value in values)
            {
                var difference_one = value - k;
                var difference_two = value + k;
                if (lookUp.ContainsKey(difference_one))
                {
                    var pair = (difference_one, value);
                    pairs.Add(pair);
                }
                if (lookUp.ContainsKey(difference_two))
                {
                    var pair = (difference_two, value);
                    pairs.Add(pair);
                }
                lookUp.Add(value, 1);
            }
            return pairs;
        }
    }
}
