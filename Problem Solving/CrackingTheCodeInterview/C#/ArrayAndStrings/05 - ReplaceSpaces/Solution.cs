
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Solution
{
    class Solution
    {
        private const char SPACE = ' ';

        static void Main(string[] args)
        {
            string s1 = "Ola tudo bem com voce";
            string result = ReplaceSpaces(s1);
            Console.WriteLine($"Replace spaces: {s1} - {result}");
        }

        private static string ReplaceSpaces(string s1)
        {
            int spaceCounter = 0;
            foreach (var item in s1)
            {
                if (item == SPACE)
                {
                    spaceCounter++;
                }

            }

            var newLength = s1.Length + spaceCounter * 2;
            var s1AsChar = new char[newLength];
            
            for (int i = s1.Length - 1; i >= 0; i--)
            {
                if (s1[i] == SPACE)
                {
                    s1AsChar[newLength - 3] = '%';
                    s1AsChar[newLength - 2] = '2';
                    s1AsChar[newLength - 1] = '0';
                    newLength -= 3;
                } 
                else {
                    s1AsChar[newLength - 1] = s1[i];
                    newLength--;
                }

            }
            return new string(s1AsChar);
        }

        private static string ReplaceSpaces2(string s1)
        {
            return s1.Replace(" ", "%20");
        }
    }
}
