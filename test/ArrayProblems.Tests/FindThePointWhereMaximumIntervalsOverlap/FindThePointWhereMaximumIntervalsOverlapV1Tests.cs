using ArrayProblems.FindThePointWhereMaximumIntervalsOverlap;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.Tests.FindThePointWhereMaximumIntervalsOverlap
{
    [TestClass]
    public class FindThePointWhereMaximumIntervalsOverlapV1Tests
    {
        [TestMethod]
        public void Given_InTimeAndOutTimeIntervals_When_FindMaximumInterval_Then_ShouldReturnMaximumInterval()
        {
            //Given
            var intTimeIntervals = new int[] { 1, 2, 9, 5, 5 };
            var outTimeIntervals = new int[] { 4, 5, 12, 9, 12 };
            var problem = new FindThePointWhereMaximumIntervalsOverlapV1();
            var expectedResult = 3;

            //When
            var actualResult = problem.Find(intTimeIntervals, outTimeIntervals);

            //Then
            Assert.Inconclusive();
        }
    }
}
