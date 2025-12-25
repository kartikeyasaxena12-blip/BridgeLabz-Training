using System;
class Geometry
{
    public static void EuclideanDistance(double x1, double y1, double x2, double y2)
    {
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        Console.WriteLine("Euclidean Distance between points (" + x1 + "," + y1 + ") and (" + x2 + "," + y2 + ") is: " + distance);
    }

    public static void LineEquation(double x1, double y1, double x2, double y2)
    {
        double m = (y2 - y1) / (x2 - x1); // slope
        double b = y1 - m * x1;           // y-intercept
        Console.WriteLine("Equation of the line passing through (" + x1 + "," + y1 + ") and (" + x2 + "," + y2 + ") is: y = " + m + "x + " + b);
    }

    static void Main()
    {
        Console.Write("Enter x1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter y1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter x2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter y2: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        EuclideanDistance(x1, y1, x2, y2);
        LineEquation(x1, y1, x2, y2);
    }
}
