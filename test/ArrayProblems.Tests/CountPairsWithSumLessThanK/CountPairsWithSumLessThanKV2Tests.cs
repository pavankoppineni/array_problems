using ArrayProblems.CountPairsWithSumLessThanK;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.Tests.CountPairsWithSumLessThanK
{
    [TestClass]
    public class CountPairsWithSumLessThanKV2Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegersAndK_When_CountPairs_Then_ShouldReturnNumberOfPairsWithSumLessThanK()
        {
            // Given
            var values = new int[] { 1, 7, 9, 12, 15, 24, 28, 90 };
            var expectedResult = 12;
            var problem = new CountPairsWithSumLessThanKV2();
            var sum = 30;

            // When
            var actualResult = problem.CountPairs(values, sum);

            // Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
