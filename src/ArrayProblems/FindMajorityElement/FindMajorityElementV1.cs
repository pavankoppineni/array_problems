using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ArrayProblems.FindMajorityElement
{
    /// <summary>
    /// https://www.geeksforgeeks.org/majority-element/
    /// </summary>
    public class FindMajorityElementV1
    {
        public int? Find(int[] values)
        {
            var halfLength = values.Length / 2;
            var dict = new Dictionary<int, int>();
            foreach (var value in values)
            {
                if (dict.ContainsKey(value))
                {
                    dict[value] += 1;
                }
                else
                {
                    dict.Add(value, 1);
                }
            }

            var majorityElement = dict.SingleOrDefault(i => i.Value > halfLength);
            if (ValueTuple.Equals(majorityElement, null))
            {
                return null;
            }

            return majorityElement.Key;
        }
    }
}
