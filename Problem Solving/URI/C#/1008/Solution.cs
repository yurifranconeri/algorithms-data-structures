using System; 

class Solution {

    static void Main(string[] args)
    {
        var employeeNumber = int.Parse(Console.ReadLine());
        var monthWorkedHours = int.Parse(Console.ReadLine());
        var salaryPerHour = double.Parse(Console.ReadLine());
        
        CalculatePayment(employeeNumber, monthWorkedHours, salaryPerHour);
    }

    private static void CalculatePayment(int employeeNumber, int monthWorkedHours, double salaryPerHour)
    {
        var payment = monthWorkedHours * salaryPerHour;

        Console.WriteLine($"NUMBER = {employeeNumber}");
        Console.WriteLine($"SALARY = U$ {(payment).ToString("0.00")}");
    }
}