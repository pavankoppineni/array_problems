using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.SmallestSubArrayWithGivenSum
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-size-subarray-sum/
    /// </summary>
    public class SmallestSubArrayWithGivenSumV1
    {
        public int Find(int[] values, int sum)
        {
            var start = -1;
            var currentSum = 0;
            var length = 0;
            var currentLength = 0;

            for (var i = 0; i < values.Length; i++)
            {
                // Case 1 : If current value is greater than or equal to sum
                if (values[i] >= sum)
                {
                    length = 1;
                    break;
                }

                currentSum += values[i];
                currentLength += 1;
                if (start == -1)
                {
                    start = 0;
                    currentLength = 1;
                }
                else
                {
                    if (currentSum >= sum)
                    {
                        while (start < i)
                        {
                            if ((currentSum - values[start]) >= sum)
                            {
                                currentSum -= values[start];
                                start++;
                                currentLength--;
                            }
                            else
                            {
                                break;
                            }
                        }
                        if (length == 0)
                        {
                            length = currentLength;
                        }
                        else if (currentLength < length)
                        {
                            length = currentLength;
                        }
                    }
                }
            }

            return length;
        }
    }
}
