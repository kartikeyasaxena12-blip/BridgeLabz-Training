using System;
class DistanceInYards
{
    static void Main(string[]args)
    {
        double distance= Convert.ToDouble(Console.ReadLine());//in feet
        double distance_Yards= distance/3;
        double distance_Miles= distance_Yards/1760;
        Console.WriteLine("The distance in yards is "+distance_Yards+" and in miles is "+distance_Miles);
    }
}
