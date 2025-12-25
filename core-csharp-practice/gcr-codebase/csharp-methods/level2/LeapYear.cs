using System;
class LeapYear
{
    public static bool IsLeapYear(int year)//check leap year
    {
        if (year < 1582)
            return false;

        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            return true;
        return false;
    }
    static void Main()
    {
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (IsLeapYear(year))
            Console.WriteLine("The year " + year + " is a Leap Year.");
        else
            Console.WriteLine("The year " + year + " is not a Leap Year.");
    }
}
