using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.BirthdayCakeCandlesProblem
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/birthday-cake-candles/problem
    /// </summary>
    public class BirthdayCakeCandlesProblemV1
    {
        public int FindNumberOfCandles(int[] values)
        {
            var max = values[0];
            var maxCount = 1;
            var currentMaxCount = 1;
            var currentMax = values[0];

            for (var i = 1; i < values.Length; i++)
            {
                if (currentMax == values[i])
                {
                    currentMaxCount++;
                }

                if (values[i] > currentMax)
                {
                    currentMax = values[i];
                    currentMaxCount = 1;
                }

                if (currentMax == max)
                {
                    if (currentMaxCount > maxCount)
                    {
                        maxCount = currentMaxCount;
                    }
                }
            }

            return maxCount;
        }
    }
}
