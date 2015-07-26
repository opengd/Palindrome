using System;

namespace Palindrome
{
    class Program
    {

        //
        // The palindrome code works for singel word and sentences
        //
        public static bool IsPalindrome(string str)
        {
            // Get the word lenght
            int index = str.Length;

            // If the the word is length is zero (0) or one (1) return true
            if (index < 2) return true;
            else if (index < 9)
            {
                // If the word length is under 9 then make the chars lower as the check against each other
                for (int i = 0; i < index; ++i)
                {
                    char a = str[i];
                    if (char.IsLetterOrDigit(a))
                    {
                        while (!char.IsLetterOrDigit(str[--index])) ;

                        //Lower the chars, if the current letter a do not match with the one found from backwards then return false
                        if (char.ToLower(a) != char.ToLower(str[index])) return false;
                    }
                }

                // The word is a palindrome, return true
                return true;
            }
            else
            {
                // Else if the word length is above 9, lower the word before starting to check
                str = str.ToLower();
                for (int i = 0; i < index; ++i)
                {
                    // Get the char on the current position i in the word 
                    char a = str[i];

                    // Is the char a letter or digit
                    if (char.IsLetterOrDigit(a))
                    {
                        // Loop backwards to find a letter or digit to check against
                        while (!char.IsLetterOrDigit(str[--index])) ;
                        // If the current letter a do not match with the one found from backwards the return false
                        if (a != str[index]) return false;
                    }
                }
                // The word is a palindrome, return true
                return true;
            }
        }

        static void Main(string[] args)
        {
            foreach(var s in args)
                Console.WriteLine("Is string palindrome : " + s + " : " + IsPalindrome(s));
        }
    }
}
