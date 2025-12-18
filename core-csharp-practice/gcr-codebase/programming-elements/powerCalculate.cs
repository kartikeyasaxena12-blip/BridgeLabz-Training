using System;
class Power
{
    static void Main(string[]args)
    {
        double bas= Convert.ToDouble(Console.ReadLine());
        double expo= Convert.ToDouble(Console.ReadLine());
        double pow= Math.Pow(bas, expo);
        Console.WriteLine(pow);
    }
}