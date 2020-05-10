using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.Tests
{
    [TestClass]
    public class SubArrayWithGivenSumProblemTests
    {
        [TestMethod]
        public void GivenArrayAndSum_Find_ReturnSubArrayWithGivenSum()
        {
            //Arrange
            var values = new int[] { 6, 4, 4 };
            var sum = 8;
            var subArrayWithGivenSumProblem = new SubArrayWithGivenSumProblem();

            //Act
            var result = subArrayWithGivenSumProblem.Find(values, sum);
            //Assert
        }
    }
}
