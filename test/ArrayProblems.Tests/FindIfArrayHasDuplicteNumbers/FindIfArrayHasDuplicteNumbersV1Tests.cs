using ArrayProblems.FindIfArrayHasDuplicteNumbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.Tests.FindIfArrayHasDuplicteNumbers
{
    [TestClass]
    public class FindIfArrayHasDuplicteNumbersV1Tests
    {
        private static IEnumerable<object[]> GetDataset()
        {
            var dataSet = new List<object[]>()
            {
                new object[] { new int[] { 0, 1, 2, 8, 8 }, true },
                new object[] { new int[] { 0, 1, 2, 8 }, false }
            };

            return dataSet;
        }

        [DataTestMethod]
        [DynamicData(nameof(GetDataset), DynamicDataSourceType.Method)]
        public void Given_ArrayOfDistinctNumbers_When_DoesArrayHasDuplicateNumbers_Then_ShoulReturnFalse(int[] values, bool expectedValue)
        {
            //Given
            var problem = new FindIfArrayHasDuplicateNumbersV1();

            //When
            var actualValue = problem.DoesArrayHasDuplicateNumbers(values);

            //Then
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
