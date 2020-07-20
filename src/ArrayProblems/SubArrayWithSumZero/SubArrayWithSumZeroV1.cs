using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.SubArrayWithSumZero
{
    /// <summary>
    /// https://www.geeksforgeeks.org/find-if-there-is-a-subarray-with-0-sum/
    /// </summary>
    public class SubArrayWithSumZeroV1
    {
        public (int startIndex, int length) Find(int[] values)
        {
            var sumDict = new Dictionary<int, int>();
            var sum = 0;
            for (var i = 0; i < values.Length; i++)
            {
                sum += values[i];
                if (sumDict.ContainsKey(sum))
                {
                    var index = sumDict[sum];
                    var nextIndex = index + 1;
                    var length = i - nextIndex + 1;
                    return (nextIndex, length);
                }
                else
                {
                    sumDict.Add(sum, i);
                }
            }

            return (-1, 0);
        }
    }
}
