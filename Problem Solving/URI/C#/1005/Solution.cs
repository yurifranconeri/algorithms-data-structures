using System;

class Program
{
    private const double FIRST_GRADE_WEIGHT = 3.5;
    private const double SECOND_GRADE_WEIGHT = 7.5;
    private const double TOTAL_GRADE_WEIGHT = FIRST_GRADE_WEIGHT + SECOND_GRADE_WEIGHT;

    static void Main(string[] args)
    {
        var firstGrade = double.Parse(Console.ReadLine());
        var secondGrade = double.Parse(Console.ReadLine());
        
        CalculateFinalGrade(firstGrade, secondGrade);
    }

    private static void CalculateFinalGrade(double firstGrade, double secondGrade)
    {
        double firstGradeWeighted = firstGrade * FIRST_GRADE_WEIGHT;
        double secondGradeWeighted = secondGrade * SECOND_GRADE_WEIGHT;
        double finalGrade = ((firstGradeWeighted + secondGradeWeighted) / TOTAL_GRADE_WEIGHT);

        Console.WriteLine($"MEDIA = {finalGrade.ToString("0.00000")}");
    }
}