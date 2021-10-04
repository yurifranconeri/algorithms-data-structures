
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
            string s1 = "apple";
            string s2 = "pleap";
            bool result = IsRotation(s1, s2);
            Console.WriteLine($"Replace spaces: True - {result}");
        }

        private static bool IsRotation(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }

            s2 += s2;
            return s2.Contains(s1);
        }
    }
}
