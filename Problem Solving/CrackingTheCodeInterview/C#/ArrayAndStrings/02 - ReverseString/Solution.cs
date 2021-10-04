
using System;
using System.Collections;
using System.Text;

namespace Solution
{
    class Solution
    {
        //Implement an algorithm to determine if a string has all unique characters. What if 
        //you can not use additional data structures?
        static void Main(string[] args)
        {
            string testCase = "abcd";

            string result = Reverse(testCase);
            Console.WriteLine($"Reverse: {testCase} - {result}");
        }

        private static string Reverse(string text)
        {
            char[] textInArray = text.ToCharArray();
            Array.Reverse(textInArray);
            return new string(textInArray);
        }

        private static string ReverseXor(string text)
        {
            var begning = -1;
            var end = text.Length;
            var reversedString = text.ToCharArray();
            while (++begning < --end)
            {
                reversedString[begning] ^= reversedString[end];
                reversedString[end] ^= reversedString[begning];
                reversedString[begning] ^= reversedString[end];
            }

            return new string(reversedString);
        }

        private static string ReverseNotInPlace(string text)
        {
            var reversedString = new char[text.Length];
            var reversedIndex = 0;
            for (var i = text.Length - 1; i >= 0; i--)
            {
                reversedString[reversedIndex++] = text[i];
            }
            return new string(reversedString);
        }

        private static string ReverseNotInPlaceStack(string text)
        {
            var stack = new Stack();
            foreach (var charValue in text)
            {
                stack.Push(charValue);
            }
            var sb = new StringBuilder();
            foreach (var item in stack)
            {
                sb = sb.Append(item);
            }
            return sb.ToString();
        }
    }
}
