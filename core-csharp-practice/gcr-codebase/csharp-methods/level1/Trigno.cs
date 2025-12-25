using System;
class Trigno
{
    public static void CalculateTrigno(double angle)//to print 
    {
        double radians = angle * (Math.PI / 180);
        double sine = Math.Sin(radians);
        double cosine = Math.Cos(radians);
        double tangent = Math.Tan(radians);

        Console.WriteLine("For angle " + angle + " degrees:");
        Console.WriteLine("Sine: " + sine);
        Console.WriteLine("Cosine: " + cosine);
        Console.WriteLine("Tangent: " + tangent);
    }

    static void Main()
    {
        Console.Write("Enter the angle in degrees: ");
        double angle = Convert.ToDouble(Console.ReadLine());//input
        CalculateTrigno(angle);//calling methods
    }
}
