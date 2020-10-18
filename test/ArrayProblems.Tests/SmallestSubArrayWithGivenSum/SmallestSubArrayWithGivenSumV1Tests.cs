using ArrayProblems.SmallestSubArrayWithGivenSum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.Tests.SmallestSubArrayWithGivenSum
{
    [TestClass]
    public class SmallestSubArrayWithGivenSumV1Tests
    {
        [TestMethod]
        public void Given_ArrayOfPositiveIntegers_When_FindSmallestSubArray_Then_ShouldReturnLengthOfSmallestSubArrayWithGivenSum()
        {
            // Given
            var values = new int[] { 2, 3, 1, 2, 4, 3 };
            var sum = 7;
            var problem = new SmallestSubArrayWithGivenSumV1();
            var expectedResult = 3;

            // When
            var actualResult = problem.Find(values, sum);

            // Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
