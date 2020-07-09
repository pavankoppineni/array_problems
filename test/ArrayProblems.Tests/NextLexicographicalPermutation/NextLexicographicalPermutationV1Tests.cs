using ArrayProblems.NextLexicographicalPermutation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.Tests.NextLexicographicalPermutation
{
    [TestClass]
    public class NextLexicographicalPermutationV1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_Generate_Then_ReturnsNextPermutationInLexicographicalOrder()
        {
            //Given
            var values = new int[] { 0, 1, 2, 5, 3, 3, 0 };
            var problem = new NextLexicographicalPermutationV1();
            var expectedValues = new int[] { 0, 1, 3, 0, 2, 3, 5 };

            //When
            var actualValues = problem.Generate(values);

            //Then
            Assert.AreEqual(true, actualValues.hasNextPermutation);
            for (var i = 0; i < values.Length; i++)
            {
                Assert.AreEqual<int>(expectedValues[i], actualValues.values[i]);
            }
        }
    }
}
