using ArrayProblems.FindMajorityElement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.Tests.FindMajorityElement
{
    [TestClass]
    public class FindMajorityElementV2Tests
    {
        private static IEnumerable<object[]> GetDataset()
        {
            var dataSet = new List<object[]>()
            {
                new object[]
                {
                    new int[]{ 2, 4, 4, 4 },
                    4
                },
                new object[]
                {
                    new int[]{2, 3, 4, 4, 4},
                    4
                },
                new object[]
                {
                    new int[]{ 2, 3, 5, 4, 4},
                    null
                },
                new object[]
                {
                    new int[]{2, 3, 3},
                    3
                },
                new object[]
                {
                    new int[]{3, 3, 3, 3, 2},
                    3
                }
            };

            return dataSet;
        }

        [DataTestMethod]
        [DynamicData(nameof(GetDataset), DynamicDataSourceType.Method)]
        public void Given_ArrayOfIntegers_When_Find_Then_ShouldReturnMajorityElement(int[] values, int? expectedResult)
        {
            //Given
            var problem = new FindMajorityElementV2();

            //When
            var actualResult = problem.Find(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
