using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.ProductOfAllSubArrays
{
    /// <summary>
    /// https://www.geeksforgeeks.org/product-of-all-subarrays-of-an-array/
    /// </summary>
    public class ProductOfAllSubArraysV1
    {
        public double GetProduct(int[] values)
        {
            double result = 1;
            var count = values.Length;
            for (var i = 0; i < values.Length; i++)
            {
                var pow = count * (i + 1);
                result = result * Math.Pow(values[i], pow);
                count--;
            }
            return result;
        }
    }
}
