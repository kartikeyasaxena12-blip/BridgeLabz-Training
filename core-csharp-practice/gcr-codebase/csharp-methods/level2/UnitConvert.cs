using System;

class UnitConvert
{
    public static double KmToMiles(double km)
    {
        double kmToMiles = 0.621371;
        return km * kmToMiles;
    }

    public static double KmToMeters(double km)
    {
        return km * 1000;
    }

    public static double KmToFeet(double km)
    {
        double kmToFeet = 3280.84;
        return km * kmToFeet;
    }

    static void Main()
    {
        Console.Write("Enter distance in kilometers: ");
        double km = Convert.ToDouble(Console.ReadLine());

        double miles = KmToMiles(km);
        double meters = KmToMeters(km);
        double feet = KmToFeet(km);

        Console.WriteLine("Distance in Kilometers: " + km);
        Console.WriteLine("Miles: " + miles);
        Console.WriteLine("Meters: " + meters);
        Console.WriteLine("Feet: " + feet);
    }
}
