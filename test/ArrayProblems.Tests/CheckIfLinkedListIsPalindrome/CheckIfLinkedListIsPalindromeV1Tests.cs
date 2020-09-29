using ArrayProblems.CheckIfLinkedListIsPalindrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems.Tests.CheckIfLinkedListIsPalindrome
{
    [TestClass]
    public class CheckIfLinkedListIsPalindromeV1Tests
    {
        [TestMethod]
        public void Given_LinkedList_When_CheckForPalindrome_Then_ShouldReturnIfLinkedListIsPalindrome()
        {
            //Given
            var problem = new CheckIfLinkedListIsPalindromeV1();
            var expectedResult = true;
            var node1 = new Node { Value = 1 };
            var node2 = new Node { Value = 3 };
            var node3 = new Node { Value = 3 };
            var node4 = new Node { Value = 3 };
            var node5 = new Node { Value = 1 };

            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node5;

            //When
            var actualResult = problem.CheckForPalindrome(node1);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
