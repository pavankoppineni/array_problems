using ArrayProblems.SortArrayBasedOnAbsoluteValues;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.Tests.SortArrayBasedOnAbsoluteValues
{
    [TestClass]
    public class SortArrayBasedOnAbsoluteValuesV1Tests
    {
        [TestMethod]
        public void Given_SortedArray_When_Sort_Then_ShouldReturnArraySortedBasedOnAbsoluteValues()
        {
            // Given
            var values = new int[] { -8, -5, -3, -1, 3, 6, 9 };
            var expectedResult = new int[] { -1, -3, 3, -5, 6, -8, 9 };
            var problem = new SortArrayBasedOnAbsoluteValuesV1();

            // When
            var actualResult = problem.Sort(values);

            // Then
            for(var i = 0; i < values.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }
    }
}
