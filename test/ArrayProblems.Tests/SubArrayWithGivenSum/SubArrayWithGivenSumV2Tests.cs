using ArrayProblems.SubArrayWithGivenSum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.Tests.SubArrayWithGivenSum
{
    [TestClass]
    public class SubArrayWithGivenSumV2Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegersAndSum_When_Find_Then_ShouldReturnSubArrayWithGivenSum()
        {
            //Given
            var values = new int[] { 1, 4, 20, 3, 10, 5 };
            var problem = new SubArrayWithGivenSumV2();
            var expectedResult = (startIndex: 2, endIndex: 4);
            var sum = 33;

            //When
            var actualResult = problem.Find(values, sum);

            //Then
            Assert.AreEqual(expectedResult.startIndex, actualResult.startIndex);
            Assert.AreEqual(expectedResult.endIndex, actualResult.endIndex);
        }
    }
}
