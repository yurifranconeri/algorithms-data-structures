using System;

class Solution {

    static void PrintStairCase(int n) {
        string print=""; 

        for(int index = 0; index < n; index++) {
            print +="#";

            Console.WriteLine(String.Format("{0,"+ n +"}",print));
        }
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        PrintStairCase(n);
    }
}
