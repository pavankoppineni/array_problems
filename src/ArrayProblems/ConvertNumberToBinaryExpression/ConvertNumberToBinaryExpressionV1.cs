using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.ConvertNumberToBinaryExpression
{
    /// <summary>
    /// https://www.geeksforgeeks.org/binary-representation-of-a-given-number/
    /// </summary>
    public class ConvertNumberToBinaryExpressionV1
    {
        public Stack<int> ConvertToBinaryExpression(int number)
        {
            var binaryExpression = new Stack<int>();
            ConvertToBiaryExpression(number, 0, binaryExpression);
            return binaryExpression;
        }

        private Stack<int> ConvertToBiaryExpression(int number, int position, Stack<int> binaryExpression)
        {
            var nextNumber = 1 << position;
            if (nextNumber > number)
            {
                return binaryExpression;
            }
            var expression = ConvertToBiaryExpression(number, position + 1, binaryExpression);
            if (nextNumber > 0)
            {
                binaryExpression.Push(1);
            }
            else
            {
                binaryExpression.Push(0);
            }
            return expression;
        }
    }
}
