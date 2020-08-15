using ArrayProblems.LongestSubArrayInWhichAllElementsAreGreaterThanK;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.Tests.LongestSubArrayInWhichAllElementsAreGreaterThanK
{
    [TestClass]
    public class LongestSubArrayInWhichAllElementsAreGreaterThanKV1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_Find_Then_ShouldReturnLongestSubArray()
        {
            //Given
            var values = new int[] { 3, 4, 5, 6, 7, 2, 10, 11 };
            var problem = new LongestSubArrayInWhichAllElementsAreGreaterThanKV1();
            var expectedResult = (startIndex: 3, length: 2);
            var k = 5;

            //When
            var actualResult = problem.Find(values, k);

            //Then
            Assert.AreEqual(expectedResult.startIndex, actualResult.start);
            Assert.AreEqual(expectedResult.length, actualResult.length);
        }
    }
}
