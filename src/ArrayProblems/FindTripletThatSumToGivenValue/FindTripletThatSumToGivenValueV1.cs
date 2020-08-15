using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.FindTripletThatSumToGivenValue
{
    /// <summary>
    /// https://www.geeksforgeeks.org/find-a-triplet-that-sum-to-a-given-value/
    /// </summary>
    public class FindTripletThatSumToGivenValueV1
    {
        public (int x, int y, int z) Find(int[] values, int sum)
        {
            for (var i = 0; i < values.Length; i++) 
            {
                var newSum = sum - values[i];
                var result = Find(values, newSum, i);
                if (result.x >= 0 && result.y >= 0)
                {
                    return (i, result.x, result.y);
                }
            }

            return (-1, -1, -1);
        }

        private (int x, int y) Find(int[] values, int sum, int index)
        {
            var dict = new Dictionary<int, int>();
            for (var i = 0; i < values.Length; i++)
            {
                if (index == i)
                {
                    continue;
                }

                var diff = sum - values[i];
                if (dict.ContainsKey(diff))
                {
                    return (dict[diff], i);
                }
                else
                {
                    dict.Add(values[i], i);
                }
            }

            return (-1, -1);
        }
    }
}
