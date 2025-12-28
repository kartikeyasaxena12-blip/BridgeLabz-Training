using System;
class DateFormat
{
    static void Main(string[]args)
    {
        DateTime currentDate = DateTime.Now;

        string format1 = currentDate.ToString("dd/MM/yyyy");
        string format2 = currentDate.ToString("yyyy-MM-dd");
        string format3 = currentDate.ToString("ddd, MMM dd, yyyy");

        Console.WriteLine("Format 1: " + format1);
        Console.WriteLine("Format 2: " + format2);
        Console.WriteLine("Format 3: " + format3);
    }
}
