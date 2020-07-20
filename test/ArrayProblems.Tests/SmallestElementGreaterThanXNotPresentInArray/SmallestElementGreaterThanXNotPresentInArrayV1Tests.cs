using ArrayProblems.SmallestElementGreaterThanXNotPresentInArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.Tests.SmallestElementGreaterThanXNotPresentInArray
{
    [TestClass]
    public class SmallestElementGreaterThanXNotPresentInArrayV1Tests
    {
        private static IEnumerable<object[]> GetDataset()
        {
            var dataset = new List<object[]>
            {
                new object[]
                {
                    new int[]{ 1, 5, 10, 6, 11 },
                    10,
                    12
                },
                new object[]
                {
                    new int[]{ 1, 5, 10, 4, 7 },
                    4,
                    6
                }
            };

            return dataset;
        }

        [DataTestMethod]
        [DynamicData(nameof(GetDataset), DynamicDataSourceType.Method)]
        public void Given_ArrayOfIntegers_When_Find_Then_ReturnsNextElementGreaterThanXNotPresentInArray(int[] values, int k, int expectedValue)
        {
            //Given
            var problem = new SmallestElementGreaterThanXNotPresentInArrayV1();

            //When
            var actualValue = problem.Find(values, k);

            //Then
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
