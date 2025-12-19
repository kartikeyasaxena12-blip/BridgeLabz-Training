using System;
class Volume{
    static void Main(string[] args)
    {
        double radius= 6378;
        double pi=3.14;
        double volume= (4.0/3.0) * pi * Math.Pow(radius,3);

        double radiusMile= radius * 0.621371;
        double volumeMile= (4.0/3.0) * pi * Math.Pow(radiusMile,3);
        Console.WriteLine("The volume of earth in cubic kilometers is "+volume+" and cubic miles is "+volumeMile);

    }
}