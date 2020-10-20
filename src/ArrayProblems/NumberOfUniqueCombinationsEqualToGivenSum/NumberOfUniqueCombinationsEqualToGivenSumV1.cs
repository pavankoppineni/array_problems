using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.NumberOfUniqueCombinationsEqualToGivenSum
{
    /// <summary>
    /// https://leetcode.com/problems/combination-sum/
    /// </summary>
    public class NumberOfUniqueCombinationsEqualToGivenSumV1
    {
        private int[] values;
        private IList<IList<int>> numberOfPaths;
        private Stack<int> path;
        public IList<IList<int>> FindCombinations(int[] values, int target)
        {
            path = new Stack<int>();
            numberOfPaths = new List<IList<int>>();
            this.values = values;
            FindPath(0, target);
            return numberOfPaths;
        }

        private void FindPath(int index, int target)
        {
            if (target == 0)
            {
                numberOfPaths.Add(path.ToArray());
                return;
            }
            while (index < values.Length && target - values[index] >= 0)
            {
                path.Push(values[index]);
                FindPath(index, target - values[index]);
                path.Pop();
                index++;
            }
        }
    }
}
