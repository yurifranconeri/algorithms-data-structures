using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Program
{
    static List<long> MinAndMaxSum(long[] arr)
    {
        var arrayList = new List<long>(arr);

        return new List<long>(){
            GetMinSum(arrayList),
            GetMaxSum(arrayList)
        };
    }

    private static long GetMaxSum(List<long> arrayList)
    {
        List<long> arrayListTemp = GetNewListWithoutItem(arrayList, arrayList.Min());
        return arrayListTemp.Sum();
    }

    private static long GetMinSum(List<long> arrayList)
    {
        var arrayListTemp = GetNewListWithoutItem(arrayList, arrayList.Max());
        return arrayListTemp.Sum();
    }

    private static List<long> GetNewListWithoutItem(List<long> arrayList, long arrayItem)
    {
        var arrayListTemp = new List<long>(arrayList);
        arrayListTemp.Remove(arrayItem);
        return arrayListTemp;
    }

    static void Main(string[] args)
    {
        long[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt64(arrTemp));
        List<long> result = MinAndMaxSum(arr);

        Console.WriteLine(String.Join(" ", result));
    }
}
