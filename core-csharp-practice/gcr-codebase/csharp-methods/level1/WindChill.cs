using System;

class WindChill
{
    public static void CalculateWindChill(double temperature, double windSpeed)//method
    {
        double windChill = 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);
        Console.WriteLine("The Wind Chill Temperature is: " + windChill);//printing
    }
    static void Main()
    {
        Console.Write("Enter the temperature (in Fahrenheit): ");//input
        double temperature = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the wind speed (in mph): ");
        double windSpeed = Convert.ToDouble(Console.ReadLine());
        CalculateWindChill(temperature, windSpeed);
    }
}
