using System;
class Factorial
{
    static void Main(string[]args)
    {
        Console.WriteLine("Enter a number"); 
        int num= Convert.ToInt32(Console.ReadLine()); //input number
        if(num>0)
        {
            int fact=1;
            int i=1;

            while(i<=num)
            {
                fact= fact*i;
                i++;
            }
            Console.WriteLine(fact);
        }
        else{
            Console.WriteLine("Enter a positive number");
        }
    }
}
        