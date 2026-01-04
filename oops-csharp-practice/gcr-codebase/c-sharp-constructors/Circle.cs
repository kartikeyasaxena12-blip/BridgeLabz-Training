using System;
class Circle
{
    double radius;

    // Default constructor
    public Circle() : this(1.0) 
    {
    }

    // Parameterized constructor
    public Circle(double radius)
    {
        this.radius = radius;
    }

    public void Display()
    {
        Console.WriteLine("Radius: " + radius);
        Console.WriteLine("Area: " + Math.PI * radius * radius);
        Console.WriteLine("Circumference: " + 2 * Math.PI * radius);
    }
}

class Program
{
    static void Main()
    {
        // Using default constructor
        Circle c1 = new Circle();
        c1.Display();

        Console.WriteLine();

        Console.Write("Enter radius: ");
        double r = Convert.ToDouble(Console.ReadLine());

        // Using parameterized constructor
        Circle c2 = new Circle(r);
        c2.Display();
    }
}
