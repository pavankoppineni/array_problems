using ArrayProblems.FindDuplicateNumbersInArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.Tests.FindDuplicateNumbersInArray
{
    [TestClass]
    public class FindDuplicateNumbersInArrayV1Tests
    {
        private static IEnumerable<object[]> GetDataset()
        {
            var dataset = new List<object[]>
            {
                new object[] { new int[] { 1, 2, 1, 2 }, new HashSet<int>{1, 2 } },
                new object[] { new int[] { 0, 1, 2, 3 }, new HashSet<int> {  } }
            };

            return dataset;
        }


        [DataTestMethod]
        [DynamicData(nameof(GetDataset), DynamicDataSourceType.Method)]
        public void Given_ArrayOfNumbers_When_FindDuplicateNumbers_Then_ReturnsListContainingDuplicateNumbers(int[] numbers, HashSet<int> expectedDuplicates)
        {
            //Given
            var problem = new FindDuplicateNumbersInArrayV1();

            //When
            var actualDuplicates = problem.FindDuplicateNumbers(numbers);

            //Then
            Assert.AreEqual(expectedDuplicates.Count, actualDuplicates.Count);
            foreach (var actualDuplicateItem in actualDuplicates)
            {
                Assert.AreEqual(true, expectedDuplicates.Contains(actualDuplicateItem));
            }
        }
    }
}
