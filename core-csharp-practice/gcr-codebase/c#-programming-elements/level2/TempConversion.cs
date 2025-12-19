using System;
class TemperatureConversion{
    static void Main(string[]args)
    {
        double celsius= Convert.ToDouble(Console.ReadLine());
        double fahrenheit= (celsius*9/5)+32;
        Console.WriteLine("The "+celsius+" Celsius is "+fahrenheit+" Fahrenheit");
    }
}