using ArrayProblems.GeneratePowerSet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.Tests.GeneratePowerSet
{
    [TestClass]
    public class GeneratePowerSetV1Tests
    {
        [TestMethod]
        public void Given_ArrayOfCharacters_When_GeneratePowerSet_Then_ShouldGetPowerSet()
        {
            //Given
            var str = "abc";
            var problem = new GeneratePowerSetV1();
            var expectedResult = new List<string>
            {
                string.Empty,
                "a",
                "b",
                "c",
                "ab",
                "ac",
                "bc",
                "abc"
            };

            //When
            var powerSet = problem.GenerateSet(str);

            //Then
            expectedResult.Sort();
            powerSet.Sort();
            for(var i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], powerSet[i]);
            }
        }
    }
}
