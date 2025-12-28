using System;
class PrimeNumber
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int a = Convert.ToInt32(Console.ReadLine());
        PrimeNumber_Check(a);
    }
    static void PrimeNumber_Check(int a)
    {
        bool isPrime=true;
        if(a<=1)
        {
            Console.WriteLine("Not a Prime Number");
            return;
        }
        for(int i=2;i<a;i++)
        {
            if(a%i==0)
            {
                isPrime=false;
                break;
            }
        }
        if(isPrime)
        Console.WriteLine("Prime Number");
        else
        Console.WriteLine("Not a Prime Number");
    }
}