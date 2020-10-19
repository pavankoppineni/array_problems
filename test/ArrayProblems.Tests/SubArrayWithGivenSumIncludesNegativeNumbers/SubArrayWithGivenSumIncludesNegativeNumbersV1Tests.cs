using ArrayProblems.SubArrayWithGivenSum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.Tests.SubArrayWithGivenSumIncludesNegativeNumbers
{
    [TestClass]
    public class SubArrayWithGivenSumIncludesNegativeNumbersV1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_GivenSum_Then_ShouldReturnNumberOfSubArraysWithGivenSum()
        {
            // Given
            var values = new int[] { -10, 0, 2, -2, -20, 10 };
            var sum = -10;
            var problem = new SubArrayWithGivenSumIncludesNegativeNumbersV1();
            var expectedResult = 6;

            // When
            var actualResult = problem.FindSubArray(values, sum);

            // Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
