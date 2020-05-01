using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArrayProblems.Tests
{
    [TestClass]
    public class SubArrayWithMaximumSumProblemTests
    {
        [DataTestMethod]
        [DataRow(new int[] { -1, 1, -3, 4, 2 }, 6)]
        [DataRow(new int[] { -1, 1, -3, 4, 2, 8 }, 14)]
        [DataRow(new int[] { -1, 1, 3, 4, 2 }, 10)]
        public void GivenArray_MaximumSum_ReturnsMaximumSumAmongSubArrays(int[] values, int expectedSum)
        {
            //Arrange
            var subArrayWithMaximumSubProblem = new SubArrayWithMaximumSumProblem();

            //Act
            var sum = subArrayWithMaximumSubProblem.MaximumSum(values);

            //Assert
            Assert.AreEqual(expectedSum, sum);
        }
    }
}
