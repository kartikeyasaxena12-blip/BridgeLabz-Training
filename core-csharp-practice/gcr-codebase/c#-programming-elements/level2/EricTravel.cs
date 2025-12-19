using System;
class EricTravel
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        string fromCity = Console.ReadLine();
        string viaCity = Console.ReadLine();
        string toCity = Console.ReadLine();
        double fromToVia = Convert.ToDouble(Console.ReadLine());
        double viaToFinalCity = Convert.ToDouble(Console.ReadLine());
        double timeTaken = Convert.ToDouble(Console.ReadLine());
        double totalDistance = fromToVia + viaToFinalCity;

        Console.WriteLine("The results of the trip are: "+name+" traveled from "+fromCity+" to " +toCity+" via "+viaCity+", Total Distance = "+totalDistance+" km and Total Time = "+timeTaken+" hours");
    }
}
