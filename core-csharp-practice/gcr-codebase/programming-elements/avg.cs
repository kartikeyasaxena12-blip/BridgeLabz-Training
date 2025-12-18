using System;
class Avg
{
    static void Main(string[]args)
    {
        double a= Convert.ToDouble(Console.ReadLine());
        double b= Convert.ToDouble(Console.ReadLine());
        double c= Convert.ToDouble(Console.ReadLine());
        double avg= (a+b+c)/3.0;
        Console.WriteLine(avg);

    }
}