using ArrayProblems.SubArrayWithSumZero;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.Tests.SubArrayWithSumZero
{
    [TestClass]
    public class SubArrayWithSumZeroV1Tests
    {
        private static IEnumerable<object[]> GetDataSet()
        {
            var dataSet = new List<object[]>();
            dataSet.Add(new object[]
            {
                new int[]{4, 2, -3, 1, 6},
                1,
                3
            });

            dataSet.Add(new object[]
            {
                new int[]{4, 2, 0, 1, 6},
                2,
                1
            });

            return dataSet;
        }

        [DataTestMethod]
        [DynamicData(nameof(GetDataSet), DynamicDataSourceType.Method)]
        public void Given_ArrayOfIntegers_When_FindSubArrayWithZeroSum_Then_ShoulReturnStartIndexAndLengthOfSubArray(int[] values, int startIndex, int length)
        {
            //Given
            var problem = new SubArrayWithSumZeroV1();

            //When
            var actualResult = problem.Find(values);

            //Then
            Assert.AreEqual(startIndex, actualResult.startIndex);
            Assert.AreEqual(length, actualResult.length);
        }
    }
}
