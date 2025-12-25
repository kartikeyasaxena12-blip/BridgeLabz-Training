using System;
class UnitConvertor
{
    public static double ConvertFahrenheitToCelsius(double fahrenheit)
    {
        double fahrenheit2celsius = (fahrenheit - 32) * 5 / 9;
        return fahrenheit2celsius;
    }

    public static double ConvertCelsiusToFahrenheit(double celsius)
    {
        double celsius2fahrenheit = (celsius * 9 / 5) + 32;
        return celsius2fahrenheit;
    }

    public static double ConvertPoundsToKilograms(double pounds)
    {
        double pounds2kilograms = 0.453592;
        return pounds * pounds2kilograms;
    }

    public static double ConvertKilogramsToPounds(double kilograms)
    {
        double kilograms2pounds = 2.20462;
        return kilograms * kilograms2pounds;
    }

    public static double ConvertGallonsToLiters(double gallons)
    {
        double gallons2liters = 3.78541;
        return gallons * gallons2liters;
    }

    public static double ConvertLitersToGallons(double liters)
    {
        double liters2gallons = 0.264172;
        return liters * liters2gallons;
    }

    static void Main()
    {
        Console.Write("Enter temperature in Fahrenheit: ");
        double f = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Celsius = " + ConvertFahrenheitToCelsius(f));

        Console.Write("Enter temperature in Celsius: ");
        double c = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Fahrenheit = " + ConvertCelsiusToFahrenheit(c));

        Console.Write("Enter weight in Pounds: ");
        double p = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Kilograms = " + ConvertPoundsToKilograms(p));

        Console.Write("Enter weight in Kilograms: ");
        double kg = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Pounds = " + ConvertKilogramsToPounds(kg));

        Console.Write("Enter volume in Gallons: ");
        double g = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Liters = " + ConvertGallonsToLiters(g));

        Console.Write("Enter volume in Liters: ");
        double l = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Gallons = " + ConvertLitersToGallons(l));
    }
}
