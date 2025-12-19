using System;
class Chocolates
{
    static void Main(string[]args)
    {
        int numberOfChocolates= Convert.ToInt32(Console.ReadLine());
        int numberOfChildren= Convert.ToInt32(Console.ReadLine());
        int chocolatesGets= numberOfChocolates/numberOfChildren; // chocolates per child
        int remainingChocolates= numberOfChocolates%numberOfChildren;

        Console.WriteLine("The number of chocolates each child gets is "+chocolatesGets+" and the number of remaining chocolates is "+remainingChocolates);
    }
}