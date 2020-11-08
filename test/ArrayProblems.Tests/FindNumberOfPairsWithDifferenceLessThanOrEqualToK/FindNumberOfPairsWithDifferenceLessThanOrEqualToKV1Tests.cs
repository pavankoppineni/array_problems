using ArrayProblems.FindNumberOfPairsWithDifferenceLessThanOrEqualToK;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.Tests.FindNumberOfPairsWithDifferenceLessThanOrEqualToK
{
    [TestClass]
    public class FindNumberOfPairsWithDifferenceLessThanOrEqualToKV1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegersAndDifferenceK_When_CountPairs_Then_ShouldReturnNumberOfPairsLessThanOrEqualToDifferenceK()
        {
            //Given
            var values = new int[] { 1, 10, 4, 2 };
            var difference = 3;
            var problem = new FindNumberOfPairsWithDifferenceLessThanOrEqualToKV1();
            var expectedResult = -1;

            //When
            var actualResult = problem.FindNumberOfPairs(values, difference);

            //Then
            Assert.Inconclusive();
        }
    }
}
