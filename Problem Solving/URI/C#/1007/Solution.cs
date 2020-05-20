using System; 

class Solution {

    static void Main(string[] args)
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());
        var c = int.Parse(Console.ReadLine());
        var d = int.Parse(Console.ReadLine());

        CalculateDifference(a, b, c, d);
    }

    private static void CalculateDifference(int a, int b, int c, int d)
    {
        Console.WriteLine($"DIFERENCA = {(a * b) - (c * d)}");
    }
}