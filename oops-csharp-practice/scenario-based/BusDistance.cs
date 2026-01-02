using System;
class BusDistance
{
    // main function
    static void Main(string[] args)
    {
        // name of cities
        string[] city = { "Delhi", "Mathura", "Agra", "Kanpur", "Lucknow" };
        // distance between cities
        int[] distance = { 100, 150, 75, 250, 90 }; 

        // creating object
        BusDistance obj = new BusDistance();
        obj.DistanceCalculate(city, distance);
    }


    // method to calculate total distance 
    void DistanceCalculate(string[] city, int[] distance)
    {
        string ch= "no";

        int totalDistance= 0;// to store total distance
        int i=0;
        // to store price
        double price=1;

        while(i< city.Length && ch!="yes")
        {
            Console.WriteLine(" ");
            // to display name to city bus reached
            Console.WriteLine("Bus has reached "+city[i]);
            totalDistance+= distance[i];// calculating distance travelled
            Console.WriteLine(" ");
            // asking if person wants to getoff
            Console.WriteLine("Do you want to get off at "+city[i]+"? (yes/no)");
            ch = Console.ReadLine().ToLower();
            i++;
        }
        Console.WriteLine("Thanks for travelling with us");
        // displaying total distance travelled
        Console.WriteLine("Total Distance Travelled = "+totalDistance+" Km ");

        price = totalDistance * 5;
        // displaying total amount
        Console.WriteLine("Total Payable Amount = Rs"+price);
    }
}