using System;
class DateCompare
{
    static void Main(string[]args)
    {
        Console.WriteLine("Enter first date:");
        DateTime date1 = Convert.ToDateTime(Console.ReadLine());
        Console.WriteLine("Enter second date:");
        DateTime date2 = Convert.ToDateTime(Console.ReadLine());

        int result = date1.CompareTo(date2);

        if (result < 0)
            Console.WriteLine("First date is before the second date");
        else if (result > 0)
            Console.WriteLine("First date is after the second date");
        else
            Console.WriteLine("Both dates are the same");
    }
}
