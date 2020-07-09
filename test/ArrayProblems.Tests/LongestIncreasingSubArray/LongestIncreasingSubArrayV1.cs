using ArrayProblems.LongestIncreasingSubArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.Tests.LongestIncreasingSubArray
{
    [TestClass]
    public class LongestIncreasingSubArrayV1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_Find_Then_ReturnsLongestIncreasingSubArray()
        {
            //Given
            var values = new int[] { 5, 6, 3, 5, 7, 8, 9, 1, 2 };
            var problem = new LongestIncreasingSubArrayV1();
            var expectedResult = (startIndex : 2, length : 5);

            //When
            var actualResult = problem.Find(values);

            //Then
            Assert.AreEqual(expectedResult.startIndex, actualResult.startIndex);
            Assert.AreEqual(expectedResult.length, actualResult.length);
        }
    }
}
