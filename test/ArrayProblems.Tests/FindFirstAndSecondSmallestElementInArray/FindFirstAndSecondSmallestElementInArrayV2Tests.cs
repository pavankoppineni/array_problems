using ArrayProblems.FindFirstAndSecondSmallestElementInArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.Tests.FindFirstAndSecondSmallestElementInArray
{
    [TestClass]
    public class FindFirstAndSecondSmallestElementInArrayV2Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_Find_Then_ShouldReturnFirstAndSecondSmallestValue()
        {
            //Given
            var values = new int[] { 8, 7, 6, 5, 4, 3, 2, 1 };
            var problem = new FindFirstAndSecondSmallestElementInArrayV2();
            var expectedResult = (first: 1, second: 2);

            //When
            var actualResult = problem.Find(values);

            //Then
            Assert.AreEqual(expectedResult.first, actualResult.first);
            Assert.AreEqual(expectedResult.second, actualResult.second);
        }
    }
}
