using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ArrayProblems.KthSmallestElementInUnsortedArray
{
    /// <summary>
    /// https://www.geeksforgeeks.org/kth-smallestlargest-element-unsorted-array/
    /// </summary>
    public class KthSmallestElementInUnsortedArrayV1
    {
        public int Find(int[] values, int k)
        {
            Array.Sort(values);
            return values[k - 1];
        }
    }
}
