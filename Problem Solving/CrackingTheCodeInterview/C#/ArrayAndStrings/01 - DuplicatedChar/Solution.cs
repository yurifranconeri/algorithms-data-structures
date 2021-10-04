using System;

namespace Solution
{
    class Solution
    {
        //Implement an algorithm to determine if a string has all unique characters. What if 
        //you can not use additional data structures?
        static void Main(string[] args)
        {
            string testCaseTrue = "abcd";
            string testCaseTrue2 = "1234567890qwertyuiopasdfghjklzxcvbnm";
            string testCaseFalse = "abcc";
            string testCaseFalse2 = "aaaa";


            bool result = IsOnlyUniqueChars(testCaseTrue);
            Console.WriteLine($"Is unique chars: True - {result}");

            result = IsOnlyUniqueChars(testCaseTrue2);
            Console.WriteLine($"Is unique chars: True - {result}");

            result = IsOnlyUniqueChars(testCaseFalse);
            Console.WriteLine($"Is unique chars: False - {result}");

            result = IsOnlyUniqueChars(testCaseFalse2);
            Console.WriteLine($"Is unique chars: False - {result}");
        }

        private static bool IsOnlyUniqueChars(string text)
        {
            //Creating a char set for ASCII
            var charSet = new bool[256];
#if DEBUG
            Console.WriteLine("INITIAL:");
            Console.WriteLine($"[{string.Join(",",charSet)}]");
            Console.WriteLine();
#endif
            //Passing for all string
            for (int i = 0; i < text.Length; i++)
            {
                // Getting the char
                char value = text[i];
#if DEBUG
                Console.WriteLine($"Checking value {value}");
                Console.WriteLine();
#endif
                // If exists on our char set return false
                if (charSet[value])
                {
                    return false;
                }
                // If not store the char set as true
                charSet[value] = true;
#if DEBUG
   `             Console.WriteLine($"RUN: {i+1}");
                Console.WriteLine($"[{string.Join(",", charSet)}]");
                Console.WriteLine();
#endif
            }
            // If loop is over and no duplicated values found return true
            return true;
        }
    }