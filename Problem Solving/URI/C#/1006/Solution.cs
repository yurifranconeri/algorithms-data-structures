
using System; 

class Solution {
    private const double FIRST_GRADE_WEIGHT = 0.2;
    private const double SECOND_GRADE_WEIGHT = 0.3;
    private const double THIRD_GRADE_WEIGHT = 0.5;

    static void Main(string[] args)
    {
        var firstGrade = double.Parse(Console.ReadLine());
        var secondGrade = double.Parse(Console.ReadLine());
        var thirdGrade = double.Parse(Console.ReadLine());

        CalculateFinalGrade(firstGrade, secondGrade, thirdGrade);
    }

    private static void CalculateFinalGrade(double firstGrade, double secondGrade, double thirdGrade)
    {
        double firstGradeWeighted = firstGrade * FIRST_GRADE_WEIGHT;
        double secondGradeWeighted = secondGrade * SECOND_GRADE_WEIGHT;
        double thirdGradeWeighted = thirdGrade * THIRD_GRADE_WEIGHT;

        var finalGrade = firstGradeWeighted + secondGradeWeighted + thirdGradeWeighted;

        Console.WriteLine($"MEDIA = {finalGrade.ToString("0.0")}");
    }
}