
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
            string s1 = "roma";
            string s2 = "amor";
            bool result = IsAnagram(s1, s2);
            Console.WriteLine($"Anagrama: True - {result}");

            s1 = "roma";
            s2 = "amora";
            result = IsAnagram(s1, s2);
            Console.WriteLine($"Anagrama: False - {result}");
            
            s1 = "romae";
            s2 = "amora";
            result = IsAnagram(s1, s2);
            Console.WriteLine($"Anagrama: False - {result}");
        }

        private static bool IsAnagram(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }
            var uniqueCharsInS1 = 0;
            var charsCompletedInS2 = 0;
            var charSetS1 = new char[256];
            foreach (var item in s1)
            {
                if (charSetS1[item] == 0)
                {
                    uniqueCharsInS1++;
                }

                charSetS1[item]++;
            }


            for (int i = 0; i <= s2.Length; i++)
            {
                if (charSetS1[s2[i]]==0)
                {
                    return false;
                }

                --charSetS1[s2[i]];

                if (charSetS1[s2[i]] == 0)
                {
                    charsCompletedInS2++;

                    if (charsCompletedInS2 == uniqueCharsInS1)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private static bool IsAnagram2(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }

            var charSetS1 = new char[256];
            foreach (var item in s1)
            {
                charSetS1[item]++;
            }

            var charSetS2 = new char[256];
            foreach (var item in s2)
            {
                charSetS2[item]++;
            }

            for (int i = 0; i <= 256; i++)
            {
                if (charSetS2[i] != charSetS1[i])
                {
                    return false;
                }
            }

            return true;
        }
     
        private static bool IsAnagram(string s1, string s2)
        {
            var s1Array = s1.ToCharArray();
            Array.Sort(s1Array);

            var s2Array = s2.ToCharArray();
            Array.Sort(s2Array);

            return string.Equals(new string(s1Array), new string(s2Array));
        }
    }
}
