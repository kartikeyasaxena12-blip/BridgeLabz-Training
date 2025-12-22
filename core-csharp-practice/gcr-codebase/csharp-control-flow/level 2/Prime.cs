using System;
class Prime
{
    static void  Main(string[]args)
    {
        Console.WriteLine("Enter a number");//input
        int num= Convert.ToInt32(Console.ReadLine());
        bool isPrime=true;

        if(num<=1)//if number is less than equal to 1
        {
            Console.WriteLine("Invalid Input");
        }

        else
        {
            for(int i=2;i<num;i++) // for loop from 2 to num
            {
                if(num%i==0)
                {
                    isPrime=false;
                    break;
                }
            }
        }
        if(isPrime)
        {
            Console.WriteLine("Prime Number");
        }
        else
        {
            Console.WriteLine("Not a Prime Number");
        }
    }
}
