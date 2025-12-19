using System;
class TotalPrice
{
    static void Main(string[]args)
    {
        double price= Convert.ToDouble(Console.ReadLine());
        int quantity= Convert.ToInt32(Console.ReadLine());
        double totalPrice= price*quantity;
        Console.WriteLine("The total purchase price is INR "+totalPrice+" if the quantity "+quantity+" and unit price is INR "+price);

    }
}