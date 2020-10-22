using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.MaximumXOROfTwoNumbersInAnArray
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-xor-of-two-numbers-in-an-array/
    /// </summary>
    public class MaximumXOROfTwoNumbersInAnArrayV1
    {
        public int FindMaximumXOR(int[] values)
        {
            var binaryTree = BinaryTree.Create(values);
            var maximumXor = 0;
            var currentMaximumXor = 0;
            foreach(var value in values)
            {
                currentMaximumXor = binaryTree.FindMaximumXOR(value);
                if (currentMaximumXor > maximumXor)
                {
                    maximumXor = currentMaximumXor;
                }
            }
            return maximumXor;
        }
    }
}
