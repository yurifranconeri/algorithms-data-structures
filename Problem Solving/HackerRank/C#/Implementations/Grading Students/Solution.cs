using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public static List<int> gradingStudents(List<int> grades)
    {
        var finalGrades = new List<int>();
        finalGrades.AddRange(grades.Select(x => roundGrade(x)));
        return finalGrades;
    }

    private static int roundGrade(int x)
    {
        if (x < 38)
        {
            return x;
        }

        if (x % 5 > 2)
        {
            return ((x / 5) * 5) + 5;
        }

        return x;
    }

    static void Main(string[] args)
    {
        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = gradingStudents(grades);
        Console.WriteLine(String.Join("\n", result));
    }
}
