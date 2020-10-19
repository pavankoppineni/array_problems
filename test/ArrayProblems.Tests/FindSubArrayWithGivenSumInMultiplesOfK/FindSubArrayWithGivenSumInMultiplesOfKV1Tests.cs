using ArrayProblems.FindSubArrayWithGivenSumInMultiplesOfK;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.Tests.FindSubArrayWithGivenSumInMultiplesOfK
{
    [TestClass]
    public class FindSubArrayWithGivenSumInMultiplesOfKV1Tests
    {
        [TestMethod]
        public void Given_ArrayOfPositiveIntegers_When_FindSuArray_Then_ShoulReturnTrueIfThereIsSubArrayWithMultiplesOfK()
        {
            // Given
            var values = new int[] { 1, 0 };
            var sum = 2;
            var expectedResult = true;
            var problem = new FindSubArrayWithGivenSumInMultiplesOfKV1();

            // When
            var actualResult = problem.Find(values, sum);

            // Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
