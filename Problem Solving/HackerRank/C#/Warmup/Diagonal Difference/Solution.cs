using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public static int DiagonalDifference(List<List<int>> arr)
    {
        var firstDiagonalIndex = 0;
        var secondDiagonalIndex = arr.IndexOf(arr.Last());

        var firstDiagonalList = new List<int>();
        var secondDiagonalList = new List<int>();

        foreach (var line in arr)
        {
            firstDiagonalList.Add(line.ElementAt(firstDiagonalIndex++));
            secondDiagonalList.Add(line.ElementAt(secondDiagonalIndex--));
        }

        return Math.Abs(firstDiagonalList.Sum() - secondDiagonalList.Sum());
    }


    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        var arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = DiagonalDifference(arr);

        Console.WriteLine(result);
    }
}