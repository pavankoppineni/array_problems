using ArrayProblems.SubArrayWithGivenSum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.Tests.SubArrayWithGivenSum
{
    [TestClass]
    public class SubArrayWithGivenSumV1Tests
    {
        private static IEnumerable<object[]> GetDataset()
        {
            var dataset = new List<object[]>();
            dataset.Add(new object[]
            {
                new int[] { 1, 4, 0, 0, 3, 10, 5 },
                7,
                (1, 4)
            });
            dataset.Add(new object[]
            {
                new int[] { 1, 4, 20, 3, 10, 5 },
                33,
                (2, 4)
            });
            return dataset;
        }

        [DataTestMethod]
        [DynamicData(nameof(GetDataset), DynamicDataSourceType.Method)]
        public void Given_ArrayOfPositiveIntegers_When_FindSubArrayWithGivenSum_Then_ShoulReturnSubArrayStartIndexAndLength(int[] values, int sum, (int startIndex, int endIndex) expectedResult)
        {
            //Given
            var problem = new SubArrayWithGivenSumV1();

            //When
            var actualValue = problem.Find(values, sum);

            //Then
            Assert.AreEqual(expectedResult.startIndex, actualValue.startIndex);
            Assert.AreEqual(expectedResult.endIndex, actualValue.endIndex);
        }
    }
}
