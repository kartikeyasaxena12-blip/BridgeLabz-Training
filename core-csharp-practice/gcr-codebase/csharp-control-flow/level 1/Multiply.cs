using System;
class Multiply
{
    static void Main(string[]args)
    {
        Console.WriteLine("Enter a number"); 
        int num= Convert.ToInt32(Console.ReadLine());
            for(int i=6;i<=9;i++)
            {
                int p= num*i;
                Console.WriteLine(num+" * "+i+" = "+p);
        }
    }
}