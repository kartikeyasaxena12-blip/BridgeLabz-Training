using System;
class Height
{
    static void Main(string[]args)
    {
        double centimeters= Convert.ToDouble(Console.ReadLine());
        double totalinches= centimeters/2.54;
        double feet= totalinches/12;
        double inches= totalinches%12;
        Console.WriteLine("Your Height in cm is "+centimeters+" while in feet is "+feet+" and inches is "+inches);
    }
}
