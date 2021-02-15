using System;
using System.Linq;




namespace PalindromeExercise
{
    public class WordSmith
    {

        public bool IsAPalindrome(string str1)
        {
            var palindrome = "";            // stores value of iteration 
            for (int i = str1.Length - 1; i >= 0; i--)   // loops in reverse words(str1) in a decrement 
            {
                palindrome += str1[i];       // each letter index[i] counted through str1 and stored in palindrome
            }
            if (palindrome.ToLower() == str1.ToLower())         // comparison of words forward and revers and converts to lowercase
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
