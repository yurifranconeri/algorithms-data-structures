using System; 

class Solution {
    static void Main(string[] args)
    {
        var firstNumber = int.Parse(Console.ReadLine());
        var secondNumber = int.Parse(Console.ReadLine());

        Sum(firstNumber, secondNumber);
    }

    private static void Sum(int firstNumber, int secondNumber)
    {
        var sum = firstNumber + secondNumber;

        Console.WriteLine($"X = {sum}");
    }
}