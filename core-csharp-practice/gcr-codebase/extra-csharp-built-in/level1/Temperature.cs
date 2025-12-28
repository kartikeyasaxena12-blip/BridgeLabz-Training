using System;
class Temperature
{
    static void Main()
    {
        Console.WriteLine("Enter temperature :");
        double temp = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Choose conversion:");
        Console.WriteLine("1. Fahrenheit to Celsius");
        Console.WriteLine("2. Celsius to Fahrenheit");
        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 1)
        {
            double celsius = FahrenheitToCelsius(temp);
            Console.WriteLine("Temperature in Celsius: " + celsius);
        }
        else if (choice == 2)
        {
            double fahrenheit = CelsiusToFahrenheit(temp);
            Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
        }
        else
        {
            Console.WriteLine("Invalid choice");
        }
    }

    static double FahrenheitToCelsius(double f)// Fahrenheit to Celsius
    {
        return (f - 32) * 5 / 9;
    }

    static double CelsiusToFahrenheit(double c)// Celsius to Fahrenheit
    {
        return (c * 9 / 5) + 32;
    }
}
