using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.SubArrayWithProductLessThanK
{
    /// <summary>
    /// https://leetcode.com/problems/subarray-product-less-than-k/
    /// </summary>
    public class SubArrayWithProductLessThanKV1
    {
        public int Find(int[] values, int product)
        {
            var startIndex = 0;
            var count = 0;
            var currentProduct = 1;
            for (var i = 0; i < values.Length; i++)
            {
                currentProduct = currentProduct * values[i];
                if (currentProduct >= product)
                {
                    while (startIndex < i)
                    {
                        currentProduct = currentProduct / values[startIndex];
                        startIndex += 1;
                        if (currentProduct < product)
                        {
                            break;
                        }
                    }
                }

                if (currentProduct < product)
                {
                    count = count + i - startIndex + 1;
                }
            }
            return count;
        }
    }
}
