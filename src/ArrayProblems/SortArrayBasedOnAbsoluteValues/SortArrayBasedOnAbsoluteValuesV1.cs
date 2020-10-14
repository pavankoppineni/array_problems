using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.SortArrayBasedOnAbsoluteValues
{
    public class SortArrayBasedOnAbsoluteValuesV1
    {
        public int[] Sort(int[] values)
        {
            var newValues = new int[values.Length];
            var newIndex = values.Length - 1;
            var left = 0;
            var right = values.Length - 1;
            while (left <= right)
            {
                var leftAbs = Math.Abs(values[left]);
                var rightAbs = Math.Abs(values[right]);

                // Case 1 : Left and right are equal
                if (leftAbs == rightAbs)
                {
                    newValues[newIndex] = values[right];
                    right -= 1;
                }

                // Case 2 : Left is less than right
                else if (leftAbs < rightAbs)
                {
                    newValues[newIndex] = values[right];
                    right -= 1;
                }

                // Case 3 : Left is greater than right
                else
                {
                    newValues[newIndex] = values[left];
                    left += 1;
                }

                newIndex -= 1;
            }

            return newValues;
        }
    }
}
