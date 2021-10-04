
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
            string result = RemoveDuplicates(testCase);
            Console.WriteLine($"Remove duplicates: {testCase} - {result}");

            testCase = "abcdd";
            result = RemoveDuplicates(testCase);
            Console.WriteLine($"Remove duplicates: {testCase} - {result}");

            testCase = "ababab";
            result = RemoveDuplicates(testCase);
            Console.WriteLine($"Remove duplicates: {testCase} - {result}");

            testCase = "aaaaaa";
            result = RemoveDuplicates(testCase);
            Console.WriteLine($"Remove duplicates: {testCase} - {result}");
        }

        private static string RemoveDuplicates(string text)
        {
            if (string.IsNullOrEmpty(text))
                return string.Empty;

            var length = text.Length;
            char[] notDuplicatesArray = new char[text.Length];
            notDuplicatesArray[0] = text[0];

            var index = 1;
            for (int i = 1; i < length; i++)
            {
                bool contains = false;
                for (int j=0; j < index; j++)
                {
                    if (text[i] == notDuplicatesArray[j])
                    {
                        contains = true;
                        break;
                    }
                }
                if (contains)
                {
                    continue;
                }
                notDuplicatesArray[index++] = text[i];
            }

            return new string(notDuplicatesArray);
        }
    }
}
