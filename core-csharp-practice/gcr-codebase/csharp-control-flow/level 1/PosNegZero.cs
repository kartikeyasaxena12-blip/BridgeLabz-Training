using System;
class PosNegZero
{
    static void Main(string[]args)
    {
        int n= Convert.ToInt32(Console.ReadLine()); //input number

        if(n>0)
        {
            Console.WriteLine("Positive");
        }
        else if(n==0)
        {
            Console.WriteLine("Zero");
        }
        else{
            Console.WriteLine("Negative");
        }
    }
}