using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.FindFirstMissingPositiveIntegerFromAnUnsortedArray
{
    public class FindFirstMissingPositiveIntegerFromAnUnsortedArrayV1
    {
        public int Find(int[] values)
        {
            for(var i = 0; i < values.Length; i++)
            {
                // Value is beyond boundary
                if(Math.Abs(values[i]) - 1 >= values.Length)
                {
                    continue;
                }

                // Value is with in boundary
                if (Math.Abs(values[i]) - 1 < values.Length)
                {
                    var index = Math.Abs(values[i]);
                    if (values[index - 1] < 0)  
                    {
                        continue;
                    }
                    values[index - 1] = -1 * values[index - 1];
                }
            }

            var missingNumber = -1;
            for (var i = 0; i < values.Length; i++)
            {
                if(values[i] > 0)
                {
                    missingNumber = i + 1;
                    break;
                }
            }

            return missingNumber;
        }
    }
}
