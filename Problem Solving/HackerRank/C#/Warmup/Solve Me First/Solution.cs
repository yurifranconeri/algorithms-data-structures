using System;

class Solution
{
    static int solveMeFirst(int a, int b)
    {
        return a + b;
    }

    static void Main(String[] args)
    {
        var val1 = Convert.ToInt32(Console.ReadLine());
        var val2 = Convert.ToInt32(Console.ReadLine());

        int sum = solveMeFirst(val1, val2);

        Console.WriteLine(sum);
    }
}