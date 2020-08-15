using ArrayProblems.SmallestSubArrayWithAtleastOneDuplicate;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.Tests.SmallestSubArrayWithAtleastOneDuplicate
{
    [TestClass]
    public class SmallestSubArrayWithAtleastOneDuplicateV1Tests
    {
        private static IEnumerable<object[]> GetDataset()
        {
            var dataset = new List<object[]>();
            dataset.Add(new object[]
            {
                new int[] { 1, 2, 3, 1, 5, 4, 5 },
                3
            });
            dataset.Add(new object[]
            {
                new int[]{ 4, 7, 11, 3, 1, 2, 4 },
                7
            });
            return dataset;
        }

        [DataTestMethod]
        [DynamicData(nameof(GetDataset), DynamicDataSourceType.Method)]
        public void Given_ValueOfIntegers_When_Find_Then_ShouldReturnStartIndexAndEndIndexOfSubArray(int[] values, int expectedResult)
        {
            //Given
            var problem = new SmallestSubArrayWithAtleastOneDuplicateV1();

            //When
            var actualResult = problem.Find(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
