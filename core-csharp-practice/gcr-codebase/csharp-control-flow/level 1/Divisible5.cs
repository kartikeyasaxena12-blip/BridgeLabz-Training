using System;
class Divisible5
{
    static void Main(string[]args)
    {
        int n= Convert.ToInt32(Console.ReadLine());
        if(n%5==0)
        {
            Console.WriteLine("Is the number "+n+" divisible by 5? Yes");
        }
        else
        {
            Console.WriteLine("Is the number "+n+" divisible by 5? No");
        }
    }
}