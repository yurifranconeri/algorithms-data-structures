using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static int BirthdayCakeCandles(long[] candlesHeight)
    {
        var candlesHeightList = new List<long>(candlesHeight);
        long maxCandleHeight = candlesHeightList.Max();

        return candlesHeightList.Count(IsEqualMaxHeight(maxCandleHeight));
    }

    private static Func<long, bool> IsEqualMaxHeight(long maxCandleHeight)
    {
        return x => x.CompareTo(maxCandleHeight) == 0;
    }

    static void Main(string[] args)
    {
        int arCount = Convert.ToInt32(Console.ReadLine());
        long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp));
        long result = BirthdayCakeCandles(ar);
        
        Console.WriteLine(result);
    }
}
