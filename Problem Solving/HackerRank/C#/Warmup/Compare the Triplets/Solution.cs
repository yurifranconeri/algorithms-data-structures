using System;
using System.Collections.Generic;

class Solution
{
    static List<int> compareTriplets(int[] alicePoints, int[] bobPoints)
    {
        int aliceFinalPoints = 0;
        int bobFinalPoints = 0;

        for (int i = 0; i < 3; i++)
        {
            if (alicePoints[i] > bobPoints[i])
            {
                aliceFinalPoints++;
                continue;
            }

            if (bobPoints[i] > alicePoints[i])
            {
                bobFinalPoints++;
                continue;
            }
        }

        return new List<int>() { aliceFinalPoints, bobFinalPoints };
    }

    static void Main(string[] args)
    {
        string[] alicePoints = Console.ReadLine().TrimEnd().Split(' ');
        string[] bobPoints = Console.ReadLine().TrimEnd().Split(' ');

        List<int> result = compareTriplets(
                Array.ConvertAll(alicePoints, Convert.ToInt32),
                Array.ConvertAll(bobPoints, Convert.ToInt32)
            );

        Console.WriteLine(String.Join(" ", result));
    }
}