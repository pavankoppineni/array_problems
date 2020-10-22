using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.MaximumXOROfTwoNumbersInAnArray
{
    public class BinaryTree
    {
        private const int MAX = 31;

        public Node Root { get; set; }

        private void AddValue(int index, int value, Node currentNode)
        {
            if (index < 0)
            {
                return;
            }
            var rightShiftValue = value >> index;
            if ((rightShiftValue & 1) == 1)
            {
                if (currentNode.Right == null)
                {
                    currentNode.Right = new Node();
                }
                AddValue(index - 1, value, currentNode.Right);
            }
            else
            {
                if (currentNode.Left == null)
                {
                    currentNode.Left = new Node();
                }
                AddValue(index - 1, value, currentNode.Left);
            }
        }

        public int FindMaximumXOR(int value)
        {
            return FindMaximumXOR(MAX, value, Root, 0);
        }

        private int FindMaximumXOR(int index, int value, Node curretNode, int xor)
        {
            if(curretNode == null)
            {
                return xor;
            }

            if (index < 0)
            {
                return xor;
            }

            var rightShiftValue = value >> index;
            if ((rightShiftValue & 1) == 1)
            {
                if (curretNode.Left != null)
                {
                    xor += (int)Math.Pow(2, index);
                    return FindMaximumXOR(index - 1, value, curretNode.Left, xor);
                }
                else
                {
                    return FindMaximumXOR(index - 1, value, curretNode.Right, xor);
                }
            }
            else
            {
                if (curretNode.Right != null)
                {
                    xor += (int)Math.Pow(2, index);
                    return FindMaximumXOR(index - 1, value, curretNode.Right, xor);
                }
                else
                {
                    return FindMaximumXOR(index - 1, value, curretNode.Left, xor);
                }
            }
        }

        public static BinaryTree Create(int[] values)
        {
            var binaryTree = new BinaryTree();
            var root = new Node();
            binaryTree.Root = root;
            foreach (var value in values)
            {
                binaryTree.AddValue(MAX, value, root);
            }
            return binaryTree;
        }
    }

    public class Node
    {
        public Node Left { get; set; }
        public Node Right { get; set; }
    }
}
