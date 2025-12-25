using System;
class Collinear
{
    static bool AreCollinearBySlope(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        double dx1 = x2 - x1, dy1 = y2 - y1;
        double dx2 = x3 - x2, dy2 = y3 - y2;
        double tolerance = 1e-9; 
        return Math.Abs(dy1 * dx2 - dy2 * dx1) < tolerance;
    }

    static bool AreCollinearByArea(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
        double tolerance = 1e-9;
        return Math.Abs(area) < tolerance;
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
        Console.Write("Enter x3: ");
        double x3 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter y3: ");
        double y3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Slope method: " +
            (AreCollinearBySlope(x1, y1, x2, y2, x3, y3) ? "Collinear" : "Not collinear"));
        Console.WriteLine("Area method: " +
            (AreCollinearByArea(x1, y1, x2, y2, x3, y3) ? "Collinear" : "Not collinear"));
    }
}
