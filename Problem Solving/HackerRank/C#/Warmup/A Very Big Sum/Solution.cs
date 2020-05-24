using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static long VeryBigSum(long[] ar)
    {
        var valuesToSum = new List<long>(ar);
        return ar.Sum();
    }

    static void Main(string[] args)
    {
        int arCount = Convert.ToInt32(Console.ReadLine());
        long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp));

        long result = VeryBigSum(ar);

        Console.WriteLine(result);
    }
}