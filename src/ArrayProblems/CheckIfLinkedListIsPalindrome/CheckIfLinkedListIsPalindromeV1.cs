using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.CheckIfLinkedListIsPalindrome
{
    public class CheckIfLinkedListIsPalindromeV1
    {
        public bool CheckForPalindrome(Node node)
        {
            var result = true;
            var currentNode = node;
            var stack = new Stack<int>();
            while (currentNode != null)
            {
                stack.Push(currentNode.Value);
                currentNode = currentNode.Next;
            }

            var halfCount = stack.Count / 2;
            var currentValue = node;
            while (halfCount > 0)
            {
                var nodeValue = stack.Pop();
                if (currentValue.Value != nodeValue)
                {
                    result = false;
                    break;
                }
                currentValue = node.Next;
                halfCount -= 1;
            }

            return result;
        }
    }
}
