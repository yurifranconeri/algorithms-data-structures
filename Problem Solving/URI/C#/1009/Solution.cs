using System; 

class Solution {
    private const double BONUS_RATIO_PERCENT = 0.15;

    static void Main(string[] args)
    {
        var name = Console.ReadLine();
        var salary = double.Parse(Console.ReadLine());
        var totalMoneySoldOnMonth = double.Parse(Console.ReadLine());
        
        CalculatePayment(salary, totalMoneySoldOnMonth);
    }

    private static void CalculatePayment(double salary, double totalMoneySoldOnMonth)
    {
        double payment = Math.Round(salary + (totalMoneySoldOnMonth * BONUS_RATIO_PERCENT), 2);

        Console.WriteLine($"TOTAL = R$ {payment.ToString("0.00")}");
    }
}