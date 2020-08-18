using ArrayProblems.MaximumSumSuchThatNoTwoElementsAreAdjacent;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.Tests.MaximumSumSuchThatNoTwoElementsAreAdjacent
{
    [TestClass]
    public class MaximumSumSuchThatNoTwoElementsAreAdjacentV1Tests
    {
        private static IEnumerable<object[]> GetDataset()
        {
            var dataset = new List<object[]>();
            dataset.Add(new object[]
            {
                new int[] { 3, 1, 2, 100 },
                103
            });
            dataset.Add(new object[]
            {
                new int[] { 5, 5, 10, 100, 10, 5 },
                110
            });
            dataset.Add(new object[]
            {
                new int[] { 5, 5, 10, 40, 50, 35 },
                80
            });
            return dataset;
        }

        [DataTestMethod]
        [DynamicData(nameof(GetDataset), DynamicDataSourceType.Method)]
        public void Given_ArrayOfIntegers_When_FindSum_Then_ShouldReturnMaximumSum(int[] values, int expectedResult)
        {
            //Given
            var problem = new MaximumSumSuchThatNoTwoElementsAreAdjacentV1();

            //When
            var actualResult = problem.GetMaximum(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
