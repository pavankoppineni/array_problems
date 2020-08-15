using ArrayProblems.BirthdayCakeCandlesProblem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.Tests.BirthdayCakeCandlesProblem
{
    [TestClass]
    public class BirthdayCakeCandlesProblemV1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_Find_Then_ReturnNumberOfMaximumIntegerRepeatedInArray()
        {
            //Given
            var values = new int[] { 3, 2, 1, 3 };
            var problem = new BirthdayCakeCandlesProblemV1();
            var expectedResult = 2;

            //When
            var actualResult = problem.FindNumberOfCandles(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
