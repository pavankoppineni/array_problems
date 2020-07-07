using ArrayProblems.RunningMedian;
using ArrayProblems.RunningMedian.Heaps;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayProblems.Tests.RunningMedian
{
    [TestClass]
    public class RunningMedianProblemUsingHeapsV1Tests
    {
        [TestMethod]
        public void Given_StreamOfIntegers_When_FindRunningMedian_Then_ReturnsListOfMedians()
        {
            //Given
            var stream = new int[] { 12, 4, 5, 3, 8, 7 };
            var runnindMedianProblem = new RunningMedianProblemUsingHeapsV1(stream.Length);
            var expectedResult = new Queue<decimal>();
            expectedResult.Enqueue(12.0m);
            expectedResult.Enqueue(8.0m);
            expectedResult.Enqueue(5.0m);
            expectedResult.Enqueue(4.5m);
            expectedResult.Enqueue(5.0m);
            expectedResult.Enqueue(6.0m);

            //When
            var actualResult = runnindMedianProblem.FindRunningMedian(stream);

            //Then
            Assert.AreEqual(expectedResult.Count, actualResult.Length);
            Assert.Inconclusive();
        }
    }
}
