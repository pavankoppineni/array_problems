using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.GeneratePowerSet
{
    /// <summary>
    /// https://www.geeksforgeeks.org/power-set/
    /// </summary>
    public class GeneratePowerSetV1
    {
        public List<string> GenerateSet(string str)
        {
            var numberOfSets = Math.Pow(2, str.Length);
            var set = new List<string>();
            for (var i = 0; i < numberOfSets; i++)
            {
                var currentSetItem = new List<char>();
                for (var j = 0; j < str.Length; j++)
                {
                    var shift = 1 << j;
                    var result = i & shift;
                    if (result > 0)
                    {
                        currentSetItem.Add(str[j]);
                    }
                }
                set.Add(new string(currentSetItem.ToArray()));
            }

            return set; 
        }
    }
}
