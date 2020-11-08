using ArrayProblems.FindNumberOfPairsWithDifferenceLessThanOrEqualToK;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.Tests.FindNumberOfPairsWithDifferenceLessThanOrEqualToK
{
    [TestClass]
    public class FindNumberOfPairsWithDifferenceLessThanOrEqualToKV2Tests
    {
        [TestMethod]
        public void Given_ArrayOfPositiveIntegersAndDifferene_When_FindNumberOfPairsWithDifference_Then_ShoulReturnCountOfPairsWithDifferenceLessThanGiveDifference()
        {
            //Given
            var difference = 5;
            var values = new int[] { 1, 2, 3, 4, 5, 6 };
            var problem = new FindNumberOfPairsWithDifferenceLessThanOrEqualToKV2();
            var expectedCount = 14;

            //When
            var actualCount = problem.CountAllPairs(values, difference);

            //Then
            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}
