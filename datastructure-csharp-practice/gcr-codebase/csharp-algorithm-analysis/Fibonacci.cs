using System;

class Fibonacci
{
    static void Main()
    {
        int n = 10;  

        int result1 = FibonacciRecursive(n);
        int result2 = FibonacciIterative(n);

        Console.WriteLine("Recursive Fibonacci Result: " + result1);
        Console.WriteLine("Iterative Fibonacci Result: " + result2);
    }

    // Recursive Fibonacci complexity = O(n^2)
    public static int FibonacciRecursive(int n)
    {
        if (n <= 1)
            return n;

        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    // Iterative Fibonacci complexity = O(n)
    public static int FibonacciIterative(int n)
    {
        if (n <= 1)
            return n;

        int a = 0, b = 1, sum = 0;

        for (int i = 2; i <= n; i++)
        {
            sum = a + b;
            a = b;
            b = sum;
        }
        return b;
    }
}
