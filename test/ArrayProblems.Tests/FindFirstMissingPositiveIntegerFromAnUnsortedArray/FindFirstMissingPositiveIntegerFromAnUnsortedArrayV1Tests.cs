using ArrayProblems.FindFirstMissingPositiveIntegerFromAnUnsortedArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.Tests.FindFirstMissingPositiveIntegerFromAnUnsortedArray
{
    [TestClass]
    public class FindFirstMissingPositiveIntegerFromAnUnsortedArrayV1Tests
    {
        private static IEnumerable<object[]> GetDataset()
        {
            var dataset = new List<object[]>();

            // All elements are withon boundary
            var testCaseOne = new object[]
            {
                new int[] { 3, 4, 1, 2 },
                -1
            };

            // All elements are outside boundary
            var testCaseTwo = new object[]
            {
                new int[] { 104, 102, 55, 9},
                1
            };

            // Some elementsa are within boundary and rest are 
            // outside boundary
            var testCaseThree = new object[]
            {
                new int[] { 3, 1, 101, 99},
                2
            };

            // Repeated elements with in boundary
            var testCaseFour = new object[]
            {
                new int[] { 2, 1, 3, 1},
                4
            };

            dataset.Add(testCaseOne);
            dataset.Add(testCaseTwo);
            dataset.Add(testCaseThree);
            dataset.Add(testCaseFour);

            return dataset;
        }

        [DataTestMethod]
        [DynamicData(nameof(GetDataset), DynamicDataSourceType.Method)]
        public void Given_ArrayOfNonNegativeIntegers_When_FindFirstMissingInteger_Then_ShouldReturnFirstMissingPositiveNumber(int[] values, int expectedValue)
        {
            // Given
            var problem = new FindFirstMissingPositiveIntegerFromAnUnsortedArrayV1();

            // When
            var actualValue = problem.Find(values);

            // Then
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
