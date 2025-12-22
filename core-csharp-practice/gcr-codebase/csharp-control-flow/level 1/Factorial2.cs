using System;
class Factorial2
{
    static void Main(string[]args)
    {
        Console.WriteLine("Enter a number"); 
        int num= Convert.ToInt32(Console.ReadLine()); //input number
        if(num>0)
        {
            int fact=1;
            for(int i=1;i<=num;i++)
            {
                fact=fact*i;
            }
            Console.WriteLine(fact);
        }
        else{
            Console.WriteLine("Enter a natural number");
        }
    }
}
       