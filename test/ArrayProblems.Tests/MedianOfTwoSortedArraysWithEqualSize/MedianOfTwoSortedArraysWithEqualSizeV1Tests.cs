using ArrayProblems.MedianOfTwoSortedArraysOfEqualSize;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.Tests.MedianOfTwoSortedArraysWithEqualSize
{
    [TestClass]
    public class MedianOfTwoSortedArraysWithEqualSizeV1Tests
    {
        [TestMethod]
        public void Given_TwoArrays_When_FindMedian_Then_ShouldReturnMedianOfTwoSortedArrays()
        {
            //Given
            var arrayOne = new int[] { 1, 2, 3, 6 };
            var arrayTwo = new int[] { 4, 6, 8, 10 };
            var problem = new MedianOfTwoSortedArraysWithEqualSizeV1();
            var expectedResult = 5;

            //When
            var actualResult = problem.FindMedian(arrayOne, arrayTwo);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
