using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.NonRepeatingElementInArray
{
    /// <summary>
    /// https://www.geeksforgeeks.org/non-repeating-element/
    /// </summary>
    public class NonRepeatingElementInArrayV1
    {
        public int Find(int[] values)
        {
            var result = -1;
            var hash = new Dictionary<int, int>();
            foreach (var value in values)
            {
                if (hash.ContainsKey(value))
                {
                    hash[value] += 1;
                }
                else
                {
                    hash.Add(value, 1);
                }
            }

            foreach (var item in hash)
            {
                if (item.Value == 1)
                {
                    result = item.Key;
                    break;
                }
            }

            return result;
        }
    }
}
