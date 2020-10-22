using ArrayProblems.MaximumXOROfTwoNumbersInAnArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.Tests.MaximumXOROfTwoNumbersInAnArray
{
    [TestClass]
    public class MaximumXOROfTwoNumbersInAnArrayV1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_FindMaximumXORPair_Then_ShouldReturnMaximumPairXORFromArray()
        {
            // Given
            var values = new int[] { 3, 10, 5, 25, 2, 8 };
            var expectedValue = -1;
            var problem = new MaximumXOROfTwoNumbersInAnArrayV1();

            // When
            var actualResult = problem.FindMaximumXOR(values);

            // Then
            Assert.Inconclusive();
        }
    }
}
