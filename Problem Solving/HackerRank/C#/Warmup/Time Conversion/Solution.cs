using System;
using System.Globalization;
class Program
{
    static string TimeConversion(string time)
    {
        DateTime dateTime = DateTime.ParseExact(
            time, "h:mm:sstt",
            CultureInfo.InvariantCulture
        );

        return dateTime.ToString("HH:mm:ss", CultureInfo.CurrentCulture);
    }

    static void Main(string[] args)
    {
        Console.WriteLine(TimeConversion(Console.ReadLine()));
    }
}

