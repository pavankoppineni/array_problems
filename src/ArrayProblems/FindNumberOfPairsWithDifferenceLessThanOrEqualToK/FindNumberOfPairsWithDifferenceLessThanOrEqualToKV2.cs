using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.FindNumberOfPairsWithDifferenceLessThanOrEqualToK
{

    /// <summary>
    /// https://www.geeksforgeeks.org/pairs-difference-less-k/
    /// </summary>
    public class FindNumberOfPairsWithDifferenceLessThanOrEqualToKV2
    {
        private int[] values;
        private int difference;

        public int CountAllPairs(int[] values, int difference)
        {
            this.values = values;
            this.difference = difference;
            var endIndex = values.Length - 1;
            var count = 0;
            var startIndex = 0;
            for (var i = 0; i < values.Length; i++)
            {
                if (i > startIndex)
                {
                    startIndex = i;
                }
                var currentHighIndex = FindHigIndex(i, startIndex, endIndex, -1);
                count += currentHighIndex - i;
                startIndex = currentHighIndex;
            }
            return count;
        }

        private int FindHigIndex(int currentIndex, int start, int end, int highIndex)
        {
            if(start > end)
            {
                return highIndex;
            }

            var mid = (start + end) >> 1;
            var currentDifference = Math.Abs(values[currentIndex] - values[mid]);

            //Case 1 : Current difference is less than difference
            //Action : Search right half of an array
            if(currentDifference < difference)
            {
                highIndex = mid;
                return FindHigIndex(currentIndex, mid + 1, end, highIndex);
            }

            //Case 2 : Current difference is equal or greater than difference
            //Action : Search left half of an array
            else
            {
                return FindHigIndex(currentIndex, start, mid - 1, highIndex);
            }
        }
    }
}
