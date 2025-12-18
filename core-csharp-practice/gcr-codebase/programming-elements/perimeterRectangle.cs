using System;
class Perimeter
{
    static void Main(string[]args)
    {
        double len = Convert.ToDouble(Console.ReadLine());
        double breadth= Convert.ToDouble(Console.ReadLine());
        double peri= 2*(len+breadth);
        Console.WriteLine(peri);
    }
}