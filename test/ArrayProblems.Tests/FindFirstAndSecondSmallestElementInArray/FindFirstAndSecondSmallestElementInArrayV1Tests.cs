using ArrayProblems.FindFirstAndSecondSmallestElementInArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.Tests.FindFirstAndSecondSmallestElementInArray
{
    [TestClass]
    public class FindFirstAndSecondSmallestElementInArrayV1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_Find_Then_ReturnsFirstAndSecondSmallestIntegers()
        {
            //Given
            var values = new int[] { 9, 8, 1, 0, -1, 4, 5 };
            var problem = new FindFirstAndSecondSmallestElementInArrayV1();
            var expectedResult = (firstSmallest : -1, secondSmallest : 0);

            //When
            var actualResult = problem.Find(values);

            //Then
            Assert.AreEqual(expectedResult.firstSmallest, actualResult.firstSmallest);
            Assert.AreEqual(expectedResult.secondSmallest, actualResult.secondSmallest);
        }
    }
}
