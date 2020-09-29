using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.MaximumDistanceBetweenTwoOccurancesOfSameElement
{
    /// <summary>
    /// https://www.geeksforgeeks.org/maximum-distance-two-occurrences-element-array/
    /// </summary>
    public class MaximumDistanceBetweenTwoOccurancesOfSameElementV1
    {
        public class Node
        {
            public Node()
            {
                Start = -1;
                End = -1;
            }

            public int Start { get; set; }
            public int End { get; set; }
        }

        public int Find(int[] values)
        {
            var dict = new Dictionary<int, Node>();
            for(var i = 0; i < values.Length; i++)
            {
                if(dict.ContainsKey(values[i]))
                {
                    dict[values[i]].End = i;
                }
                else
                {
                    dict.Add(values[i], new Node { Start = i });
                }
            }

            var maxDistance = -1;
            foreach (var item in dict)
            {
                var value = item.Key;
                var node = item.Value;
                if (node.End == -1)
                {
                    continue;
                }
                var currentMaxDistance = node.End - node.Start;
                if(currentMaxDistance > maxDistance)
                {
                    maxDistance = currentMaxDistance;
                }
            }
            return maxDistance;
        }
    }
}
