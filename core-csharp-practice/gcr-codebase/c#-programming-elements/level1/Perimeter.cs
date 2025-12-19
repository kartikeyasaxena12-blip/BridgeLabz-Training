using System;
class Perimeter
{
    static void Main(string[]args)
    {
        double side= Convert.ToDouble(Console.ReadLine());
        double perimeter= 4*side;
        Console.WriteLine("The length of the side is "+side+" whose perimeter is "+perimeter);
    }
}