using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.FindFirstAndSecondSmallestElementInArray
{
    /// <summary>
    /// https://auth.geeksforgeeks.org/user/pavankumar70/todo-done/
    /// </summary>
    public class FindFirstAndSecondSmallestElementInArrayV1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public (int firstSmallest, int secondSmallest) Find(int[] values)
        {
            var second = values[1];
            var first = values[0];
            if (first > second)
            {
                first = values[1];
                second = values[0];
            }

            for (var i = 2; i < values.Length; i++)
            {
                if (values[i] > second)
                {
                    continue;
                }

                if (values[i] < first)
                {
                    second = first;
                    first = values[i];
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
