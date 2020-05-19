using System;

class Solution
{
    static void Main(string[] args)
    {
         var radius = double.Parse(Console.ReadLine());
        
        const double pi = 3.14159;
        var area = Math.Round(pi * Math.Pow(radius, 2), 4);
        
        Console.WriteLine($"A={area.ToString("0.0000")}");
    }
}       