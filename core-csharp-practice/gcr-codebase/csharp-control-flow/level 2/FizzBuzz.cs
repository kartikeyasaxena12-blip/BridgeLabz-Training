using System;
class Prime
{
    static void  Main(string[]args)
    {
        Console.WriteLine("Enter a number");//input
        int num= Convert.ToInt32(Console.ReadLine());
        if(num<0)
        {
            Console.WriteLine("Invalid Input");
        }

        for(int i=0;i<=num;i++)
        {
            if(i%3==0 && i%5==0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if(i%5==0)
            {
                Console.WriteLine("Buzz");
            }
            else if(i%3==0)
            {
                Console.WriteLine("Fizz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}