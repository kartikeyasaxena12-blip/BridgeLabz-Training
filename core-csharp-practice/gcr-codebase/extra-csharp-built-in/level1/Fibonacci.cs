using System;
class Fibonacci
{
    static void Main(string[]args)
    {
        Console.WriteLine("Enter number of terms:");
        int n = Convert.ToInt32(Console.ReadLine());
        PrintFibonacci(n);
    }
    static void PrintFibonacci(int n)// Function to calculate and print Fibonacci sequence
    {
        int a = 0, b = 1;
        for (int i = 1; i <= n; i++)
        {
            Console.Write(a + " ");
            int next = a + b;
            a = b;
            b = next;
        }
    }
}
