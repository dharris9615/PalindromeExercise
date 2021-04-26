using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("rotator", true)]
        [InlineData("David", false)]
        public void Test1(string word, bool expected)
        {
            //arrange
            var pal = new WordSmith();

            //act
            bool actual = pal.IsPalindrome(word);

            //assert
            Assert.Equal(expected, actual);
        }

        

    }
}
