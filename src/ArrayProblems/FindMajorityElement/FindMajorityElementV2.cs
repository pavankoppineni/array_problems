using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.FindMajorityElement
{
    /// <summary>
    /// https://www.geeksforgeeks.org/majority-element/
    /// </summary>
    public class FindMajorityElementV2
    {
        public int? Find(int[] values)
        {
            var majorityElement = FindMajorityElement(values);
            if (IsMajorityElement(values, majorityElement))
            {
                return majorityElement;
            }
            else
            {
                return null;
            }
        }

        private bool IsMajorityElement(int[] values, int majorityElement)
        {
            var count = 0;
            foreach (var value in values)
            {
                if (value == majorityElement)
                {
                    count++;
                }
            }

            return count > values.Length / 2;
        }

        private int FindMajorityElement(int[] values)
        {
            var majorityIndex = 0;
            var count = 1;
            for (var i = 1; i < values.Length; i++)
            {
                if (values[majorityIndex] == values[i])
                {
                    majorityIndex = i;
                    count++;
                }
                else
                {
                    count--;
                }

                if (count == 0)
                {
                    majorityIndex = i;
                    count = 1;
                }
            }

            return values[majorityIndex];
        }
    }
}
