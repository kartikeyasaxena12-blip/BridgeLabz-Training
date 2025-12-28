using System;
class DateArithmetic
{
    static void Main(string[]args)
    {
        Console.WriteLine("Enter a date ");
        DateTime inputDate = Convert.ToDateTime(Console.ReadLine());

        DateTime result = inputDate.AddDays(7);// Add 7 days

        result = result.AddMonths(1);// Add 1 month

        result = result.AddYears(2);// Add 2 years

        result = result.AddDays(-21);// Subtract 3 weeks (3*7 = 21 days)

        Console.WriteLine("Resulting date: " + result.ToString("yyyy-MM-dd"));
    }
}
