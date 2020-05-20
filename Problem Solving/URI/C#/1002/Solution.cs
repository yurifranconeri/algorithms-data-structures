using System;

class Solution
{
    private const double PI_SHORT = 3.14159;

    static void Main(string[] args)
    {
        var radius = double.Parse(Console.ReadLine());

        Area(radius);
    }

    private static void Area(double radius)
    {
        //π*R²
        var area = Math.Round(PI_SHORT * Math.Pow(radius, 2), 4);

        Console.WriteLine($"A={area.ToString("0.0000")}");
    }
}       