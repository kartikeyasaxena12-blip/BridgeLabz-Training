using System;
class KlToMl
{
    static void Main(string[]args)
    {
        double km= Convert.ToDouble(Console.ReadLine());
        double miles= 0.621371*km;
        Console.WriteLine(miles);

    }
}