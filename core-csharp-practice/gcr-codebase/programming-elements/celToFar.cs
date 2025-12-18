using System;
class CelToFar
{
    static void Main(string[] args)
    {
        double cel= Convert.ToDouble(Console.ReadLine());
        double far= (cel*9/5)+32;
        Console.WriteLine(far);
    }
}