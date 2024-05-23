using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("tacocat", true)] // ← you will need to put some test data and expected result here.  
        [InlineData("wow", true)]
        [InlineData("happy", false)]

        public void isAPalindromeTest(string word, bool expected)
        {
            var wordTest = new Wordsmith();

            var actual = wordTest.isAPalindrome(word);

            Assert.Equal(expected, actual);
        }
    }
}
