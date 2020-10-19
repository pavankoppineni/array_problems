using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.FindSubArrayWithGivenSumInMultiplesOfK
{
    /// <summary>
    /// https://leetcode.com/problems/continuous-subarray-sum/
    /// </summary>
    public class FindSubArrayWithGivenSumInMultiplesOfKV1
    {
        public bool Find(int[] values, int sum)
        {
            var result = false;
            if (values.Length == 1)
            {
                return false;
            }

            if (sum == 0)
            {
                return FindSubArrayForZeroSum(values);
            }

            var previousSum = 0;
            var reminderArray = new int[sum];
            for (var i = 0; i < values.Length; i++)
            {
                previousSum += values[i];
                var reminderIndex = previousSum % sum;
                if(reminderArray[reminderIndex] > 0)
                {
                    result = true;
                    break;
                }
                reminderArray[previousSum % sum] += 1;
            }

            return result;
        }

        private bool FindSubArrayForZeroSum(int[] values)
        {
            var zeroValueIndex = -1;
            for (var i = 0; i < values.Length; i++)
            {
                // Case 1 : Current value is zero
                if (values[i] == 0)
                {
                    if (zeroValueIndex == -1)
                    {
                        zeroValueIndex = i;
                        continue;
                    }
                    if (zeroValueIndex == i - 1)
                    {
                        return true;
                    }
                }
                // Case 2 : Current value is not zero
                else
                {
                    zeroValueIndex = -1;
                }
            }

            return false;
        }
    }
}
