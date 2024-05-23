using System;
namespace PalindromeExercise
{
	public class Wordsmith
	{
          public bool isAPalindrome(string word)
            {
            string reverseDrow = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverseDrow += word[i];
            }

            if (word == reverseDrow )
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

