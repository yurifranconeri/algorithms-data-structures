using System;

class Solution
{
    static void Main(string[] args)
    {
        var firstNumber = int.Parse(Console.ReadLine());
        var secondNumber = int.Parse(Console.ReadLine());
        
        Prod(firstNumber, secondNumber);
    }

    private static void Prod(int firstNumber, int secondNumber)
    {
        Console.WriteLine($"PROD = {firstNumber * secondNumber}");
    }
}