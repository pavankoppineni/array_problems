using ArrayProblems.KthSmallestElementInUnsortedArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.Tests.KthSmallestElementInUnsortedArray
{
    [TestClass]
    public class KthSmallestElementInUnsortedArrayV1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_Find_Then_ShouldReturnKthSmallestElement()
        {
            //Given
            var values = new int[] { 7, 10, 4, 3, 20, 15 };
            var k = 3;
            var problem = new KthSmallestElementInUnsortedArrayV1();
            var expectedResult = 7;

            //When
            var actualResult = problem.Find(values, k);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
