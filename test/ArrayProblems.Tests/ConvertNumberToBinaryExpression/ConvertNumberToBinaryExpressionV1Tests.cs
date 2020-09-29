using ArrayProblems.ConvertNumberToBinaryExpression;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.Tests.ConvertNumberToBinaryExpression
{
    [TestClass]
    public class ConvertNumberToBinaryExpressionV1Tests
    {
        [TestMethod]
        public void Given_Number_When_ConvertToBinaryExpression_Then_ShouldReturnBinaryExpression()
        {
            //Given
            var number = 11;
            var expectedResult = new Stack<int>();
            expectedResult.Push(1);
            expectedResult.Push(1);
            expectedResult.Push(0);
            expectedResult.Push(1);
            var problem = new ConvertNumberToBinaryExpressionV1();

            //When
            var actualResult = problem.ConvertToBinaryExpression(number);

            //Then
            Assert.AreEqual(expectedResult.Count, actualResult.Count);
        }
    }
}
