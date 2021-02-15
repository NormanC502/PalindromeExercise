using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Stats", true)]
        [InlineData("Mom", true)]
        [InlineData("Tenet", true)]
        [InlineData("Raccoon", false)]
        [InlineData("Showboat", false)]       
        
        public void IsAPalindrome(string str1, bool expected)
        {
            //Arrange
            WordSmith test = new WordSmith();

            //Act
            bool actual = test.IsAPalindrome(str1);

            //Assert
            Assert.Equal(expected, actual);            
        }
    }
}
