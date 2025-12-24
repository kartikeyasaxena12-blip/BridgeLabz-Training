using System;
class Factors
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");//input
        int number = Convert.ToInt32(Console.ReadLine());

        int[] factors = new int[number];
        int c=0;  //counter

        for (int i=1,j=0;i<=number;i++)
        {
            if (number % i == 0)//finding fctors
            {
                factors[j] = i;
                j++;
                c++;
            }
        }

        Console.WriteLine("Factors of " + number + " are");
        for (int i = 0; i < c; i++)
        {
            Console.WriteLine(factors[i]);//printing factors
        }

    }
}