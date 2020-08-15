using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.SmallestSubArrayWithAtleastOneDuplicate
{
    /// <summary>
    /// https://www.geeksforgeeks.org/find-the-smallest-subarray-having-atleast-one-duplicate/
    /// </summary>
    public class SmallestSubArrayWithAtleastOneDuplicateV1
    {
        public int Find(int[] values)
        {
            var currentStartIndex = -1;
            var currentEndIndex = -1;
            var dict = new Dictionary<int, int>();
            for (var i = 0; i < values.Length; i++)
            {
                if (dict.ContainsKey(values[i]))
                {
                    var startIndex = dict[values[i]];
                    var endIndex = i;
                    if (currentStartIndex < 0)
                    {
                        currentStartIndex = startIndex;
                        currentEndIndex = endIndex;
                    }
                    else
                    {
                        var subArrayLength = currentEndIndex - currentStartIndex;
                        var currentLength = endIndex - startIndex;
                        if (currentLength < subArrayLength)
                        {
                            currentStartIndex = startIndex;
                            currentEndIndex = endIndex;
                        }
                    }
                }
                else
                {
                    dict.Add(values[i], i);
                }
            }

            if (currentStartIndex < 0)
            {
                return 0;
            }
            else
            {
                return currentEndIndex - currentStartIndex + 1;
            }
        }
    }
}
