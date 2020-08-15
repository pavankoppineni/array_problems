using ArrayProblems.ProductOfAllSubArrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.Tests.ProductOfAllSubArrays
{
    [TestClass]
    public class ProductOfAllSubArraysV1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_GetProduct_Then_ShouldReturnProductOfAllSubArrays()
        {
            //Given
            var values = new int[] { 10, 3, 7 };
            var problem = new ProductOfAllSubArraysV1();
            double expectedResult = 27783000;

            //When
            var actualResult = problem.GetProduct(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
