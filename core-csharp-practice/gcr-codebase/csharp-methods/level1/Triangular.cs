using System;

class TriangularParkRun
{
    static double CalculateRounds(double side1, double side2, double side3)
    {
        double perimeter = side1 + side2 + side3;
        double distance = 5000; // 5 km in meters
        return distance / perimeter;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter side 1 of the triangular park (in meters): ");//taking input
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 2 of the triangular park (in meters): ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 3 of the triangular park (in meters): ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        double rounds = CalculateRounds(side1, side2, side3);//method to calculate no of rounds

        Console.WriteLine("The athlete must complete " + rounds + " rounds to finish a 5 km run.");//printing
    }
}
