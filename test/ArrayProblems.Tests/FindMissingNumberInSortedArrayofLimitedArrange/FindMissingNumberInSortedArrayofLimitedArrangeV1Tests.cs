using ArrayProblems.FindMissingNumberInSortedArrayOfLimitedRange;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.Tests.FindMissingNumberInSortedArrayofLimitedArrange
{
    [TestClass]
    public class FindMissingNumberInSortedArrayofLimitedArrangeV1Tests
    {
        private static IEnumerable<object[]> GetDataset()
        {
            var dataset = new List<object[]>();
            dataset.Add(new object[]
            {
                new int[]{1, 3, 4, 5, 6},
                2
            });
            dataset.Add(new object[]
            {
                new int[]{1, 2, 3, 4, 5, 7, 8, 9, 10},
                6
            });

            return dataset;
        }

        [DynamicData(nameof(GetDataset), DynamicDataSourceType.Method)]
        [DataTestMethod]
        public void Given_ArrayOfIntegers_When_Find_Then_ShouldReturnMissingNumber(int[] values, int expectedMissingNumber)
        {
            //Given
            var problem = new FindMissingNumberInSortedArrayofLimitedArrangeV1();

            //When
            var actualMissingNumber = problem.Find(values);

            //Then
            Assert.AreEqual(expectedMissingNumber, actualMissingNumber);
        }
    }
}
