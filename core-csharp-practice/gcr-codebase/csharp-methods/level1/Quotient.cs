using System;
class Quotient
{
    public static void Find(int number, int divisor)
    {
        int quotient = number / divisor;
        int remainder = number % divisor;
        Console.WriteLine("Quotient: " + quotient);
        Console.WriteLine("Remainder: " + remainder);
    }

    static void Main()
    {
        Console.Write("Enter the number: ");
        int number = Convert.ToInt32(Console.ReadLine());//input
        Console.Write("Enter the divisor: ");
        int divisor = Convert.ToInt32(Console.ReadLine());
        Find(number, divisor);//method
    }
}
