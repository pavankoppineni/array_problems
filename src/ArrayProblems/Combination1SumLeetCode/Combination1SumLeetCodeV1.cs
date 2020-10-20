using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.Combination1SumLeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/combinations/
    /// </summary>
    public class Combination1SumLeetCodeV1
    {
            private int combination;
            private int[] path;
            private int max;
            private IList<IList<int>> combinations;
            public IList<IList<int>> FindCombinations(int number, int combination)
            {
                combinations = new List<IList<int>>();
                this.max = number;
                this.path = new int[combination];
                this.combination = combination;
                for (var i = 1; i <= number; i++)
                {
                    AddCombinations(i, 0);
                }
                return combinations;
            }

            private bool AddCombinations(int number, int level)
            {
                if(level == combination)
                {
                    var newCombination = new int[path.Length];
                    Array.Copy(path, newCombination, path.Length);
                    combinations.Add(newCombination);
                    return false;
                }
                path[level] = number;
                while (number <= max)
                {
                    number += 1;
                    var result = AddCombinations(number, level + 1);
                    if (!result)
                    {
                        break;
                    }
                }

                return true;
            }
    }
}
