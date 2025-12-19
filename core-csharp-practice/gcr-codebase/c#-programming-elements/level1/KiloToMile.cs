using System;
class KiloToMile
{
    static void Main(string[]args)
    {
        double kilometers= Convert.ToDouble(Console.ReadLine());
        double miles= kilometers/1.6;
        Console.WriteLine("The total miles is "+miles+ " mile for the given "+kilometers+" km");
    }
}