using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.FindFirstAndSecondSmallestElementInArray
{
    /// <summary>
    /// https://auth.geeksforgeeks.org/user/pavankumar70/todo-done/
    /// </summary>
    public class FindFirstAndSecondSmallestElementInArrayV2
    {
        public (int first, int second) Find(int[] values)
        {
            var first = values[0];
            var second = values[1];

            if (first > second)
            {
                second = values[0];
                first = values[1];
            }

            for (var i = 2; i < values.Length; i++)
            {
                if (values[i] > second)
                {
                    continue;
                }

                if (values[i] < first)
                {
                    var temp = first;
                    first = values[i];
                    second = temp;
                }

                if (values[i] > first && values[i] < second)
                {
                    second = values[i];
                }
            }

            return (first, second);
        }
    }
}
