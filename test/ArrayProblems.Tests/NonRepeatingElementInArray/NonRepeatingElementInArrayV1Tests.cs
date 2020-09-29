using ArrayProblems.NonRepeatingElementInArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.Tests.NonRepeatingElementInArray
{
    [TestClass]
    public class NonRepeatingElementInArrayV1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_FindFirstNonRepeatingElement_Then_ShouldReturnFirstNonRepeatingElement()
        {
            //Given
            var values = new int[] { 9, 4, 9, 6, 7, 4 };
            var problem = new NonRepeatingElementInArrayV1();
            var expectedResult = 6;

            //When
            var actualResult = problem.Find(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
