using System;
class SumNatural
{
    static int Sum(int num)//method to calculate sum
    {
        int sum = 0;
        for (int i = 1; i <= num; i++)
        {
            sum = sum + i;
        }
        return sum;
    }
    static void Main()
    {
        // Get user input
        Console.Write("Enter a number ");
        int num = Convert.ToInt32(Console.ReadLine());//input
        int result = Sum(num);
        Console.WriteLine("The sum of first " + num + " natural numbers is " + result);//printing
    }
}
