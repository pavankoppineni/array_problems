using ArrayProblems.FindSmallestPositiveNumberMissingFromAnUnsortedArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.Tests.FindSmallestPositiveNumberMissingFromAnUnsortedArray
{
    [TestClass]
    public class FindSmallestPositiveNumberMissingFromAnUnsortedArrayV1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_Find_Then_ShouldReturnSmallestPositiveNumber()
        {
            //Given
            var values = new int[] { 2, 3, -7, 6, 8, 1, -10, 15 };
            var problem = new FindSmallestPositiveNumberMissingFromAnUnsortedArrayV1();
            var expectedResult = 4;

            //When
            var acutalResult = problem.Find(values);

            //Then
            Assert.AreEqual(expectedResult, acutalResult);
        }
    }
}
