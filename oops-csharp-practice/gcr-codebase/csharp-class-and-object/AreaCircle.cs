using System;

class AreaCircle
{
    double r; //input radius

    // Constructor
    public Circle(double r)
    {
        this.r = r;
    }

    // Method to calculate area
    public void CalculateArea()
    {
        double area = 3.14 * r * r;
        Console.WriteLine("Area of Circle : " + area);
    }

    // Method to calculate circumference
    public void CalculateCircumference()
    {
        double circumference = 2 * 3.14 * r;
        Console.WriteLine("Circumference of Circle : " + circumference);
    }


    // Main method
    static void Main(string[] args)
    {
        Console.Write("Enter radius of circle: ");
        double r = Convert.ToDouble(Console.ReadLine());

        Circle obj = new Circle(r);
        obj.CalculateArea();
        obj.CalculateCircumference();
    }
}
