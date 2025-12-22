using System;
class Youngest
{
    static void Main()
    {

        Console.Write("Enter age: ");// input age
        int amar_Age = Convert.ToInt32(Console.ReadLine());
        int akbar_Age = Convert.ToInt32(Console.ReadLine());
        int anthony_Age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter height : ");// input height
        double amar_Height = Convert.ToDouble(Console.ReadLine());
        double akbar_Height = Convert.ToDouble(Console.ReadLine());
        double anthony_Height = Convert.ToDouble(Console.ReadLine());

        if (amar_Age <= akbar_Age && amar_Age <= anthony_Age)// conditions to find youngest 
        {
            Console.WriteLine("Amar is the youngest");
        }
        else if (akbar_Age <= amar_Age && akbar_Age <= anthony_Age)
        {
            Console.WriteLine("Akbar is the youngest");
        }
        else
        {
            Console.WriteLine("Anthony is the youngest");
        }

        if (amar_Height >= akbar_Height && amar_Height >= anthony_Height) //conditions to find tallest 
        {
            Console.WriteLine("Amar is the tallest");
        }
        else if (akbar_Height >= amar_Height && akbar_Height >= anthony_Height)
        {
            Console.WriteLine("Akbar is the tallest");
        }
        else
        {
            Console.WriteLine("Anthony is the tallest");
        }
    }
}
