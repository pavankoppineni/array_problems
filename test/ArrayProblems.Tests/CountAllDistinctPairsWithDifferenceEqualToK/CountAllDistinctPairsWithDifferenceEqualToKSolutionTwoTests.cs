﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.Tests
{
    [TestClass]
    public class CountAllDistinctPairsWithDifferenceEqualToKSolutionTwoTests
    {
        [TestMethod]
        public void ArrayOfIntegersAndK_Count_ReturnsPairsOfNumbersWithDifferenceEqualToK()
        {
            //Arrange
            var solution = new CountAllDistinctPairsWithDifferenceEqualToKSolutionTwo();
            var values = new int[] { 8, 12, 16, 4, 0, 20 };
            var k = 4;

            //Act
            var pairs = solution.Count(values, k);

            //Assert
            Assert.IsTrue(pairs.Count == 5);
        }
    }
}
