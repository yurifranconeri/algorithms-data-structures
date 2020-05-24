using System.Linq;
using System;
using System.Collections.Generic;

class Solution
{

    static List<double> PlusMinus(int[] arr)
    {
        var list = arr.ToList();
        var listCount = list.Count();

        var positiveCount = list.Where(x => x > 0).Count();
        var negativeCount = list.Where(x => x < 0).Count();
        var zeroCount = list.Where(x => x == 0).Count();

        double positiveProportion = (double)positiveCount / listCount;
        double negativeProportion = (double)negativeCount / listCount;
        double zeroProportion = (double)zeroCount / listCount;

        return new List<double>() {
            positiveProportion,
            negativeProportion,
            zeroProportion
        };
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        List<double> result = PlusMinus(arr);

        Console.WriteLine(String.Join(" ", result));
    }
}
