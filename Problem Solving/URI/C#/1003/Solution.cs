using System;

class Solution
{
    static void Main(string[] args)
    {
        var firstNumber = int.Parse(Console.ReadLine());
        var secondNumber = int.Parse(Console.ReadLine());

        Sum(firstNumber, secondNumber);
    }

    private static void Sum(int firstNumber, int secondNumber)
    {
        Console.WriteLine($"SOMA = {firstNumber + secondNumber}");
    }
}