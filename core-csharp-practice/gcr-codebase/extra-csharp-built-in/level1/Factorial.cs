using System;
class Factorial
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());
        long result = Factorial_Num(number);
        Console.WriteLine("Factorial of " + number + " is: " + result);
    }
    static long Factorial_Num(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }    
        return n * Factorial_Num(n - 1);
    }
}
