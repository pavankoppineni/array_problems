﻿using ArrayProblems.LongestSubArrayInWhichAllElementsAreGreaterThanK;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.Tests.LongestSubArrayInWhichAllElementsAreGreaterThanK
{
    [TestClass]
    public class LongestSubArrayInWhichAllElementsAreGreaterThanKV2Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_Find_Then_ShouldReturnLengthOfLongestSubarray()
        {
            //Given
            var values = new int[] { 3, 4, 5, 6, 7, 2, 10, 11 };
            var k = 5;
            var problem = new LongestSubArrayInWhichAllElementsAreGreaterThanKV2();
            var expectedResult = 2;

            //When
            var actualResult = problem.Find(values, k);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
