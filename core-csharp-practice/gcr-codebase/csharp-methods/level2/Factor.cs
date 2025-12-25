using System;
class Factor
{
    public static int[] FindFactors(int number)//finding factors
    {
        int count = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
                count++;
        }
        int[] factors = new int[count];
        int index = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
                factors[index++] = i;
        }

        return factors;
    }

    public static int SumOfFactors(int[] factors)//sum of factors
    {
        int sum = 0;
        foreach (int f in factors)
            sum += f;
        return sum;
    }

    public static long ProductOfFactors(int[] factors)//product of factors
    {
        long product = 1;
        foreach (int f in factors)
            product *= f;
        return product;
    }

    public static double SumOfSquares(int[] factors)
    {
        double sum = 0;
        foreach (int f in factors)
            sum += Math.Pow(f, 2);
        return sum;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] factors = FindFactors(number);

        Console.WriteLine("Factors of " + number + ":");
        foreach (int f in factors)
            Console.Write(f + " ");

        Console.WriteLine("\nSum of factors: " + SumOfFactors(factors));
        Console.WriteLine("Product of factors: " + ProductOfFactors(factors));
        Console.WriteLine("Sum of squares of factors: " + SumOfSquares(factors));
    }
}
