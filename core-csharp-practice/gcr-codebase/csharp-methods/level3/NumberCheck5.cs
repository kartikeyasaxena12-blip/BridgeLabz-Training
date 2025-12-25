using System;
class NumberCheck5
{
    public static int[] FindFactors(int number)
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

    public static int GreatestFactor(int[] factors) => factors[factors.Length - 1];

    public static int SumOfFactors(int[] factors)
    {
        int sum = 0;
        foreach (int f in factors) sum += f;
        return sum;
    }

    public static long ProductOfFactors(int[] factors)
    {
        long product = 1;
        foreach (int f in factors) product *= f;
        return product;
    }

    public static long ProductOfCubes(int[] factors)
    {
        long product = 1;
        foreach (int f in factors) product *= (long)Math.Pow(f, 3);
        return product;
    }

    public static bool IsPerfect(int number)
    {
        int sum = 0;
        for (int i = 1; i < number; i++)
            if (number % i == 0) sum += i;
        return sum == number;
    }

    public static bool IsAbundant(int number)
    {
        int sum = 0;
        for (int i = 1; i < number; i++)
            if (number % i == 0) sum += i;
        return sum > number;
    }

    public static bool IsDeficient(int number)
    {
        int sum = 0;
        for (int i = 1; i < number; i++)
            if (number % i == 0) sum += i;
        return sum < number;
    }

    public static bool IsStrong(int number)
    {
        int temp = number;
        int sum = 0;
        while (temp > 0)
        {
            int digit = temp % 10;
            sum += Factorial(digit);
            temp /= 10;
        }
        return sum == number;
    }

    private static int Factorial(int n)
    {
        int fact = 1;
        for (int i = 1; i <= n; i++) fact *= i;
        return fact;
    }

    static void Main()
    {
        Console.Write("Enter a number to analyze: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int[] factors = FindFactors(number);
        Console.WriteLine("\nAnalysis for number " + number + ":");
        Console.WriteLine("- Factors: " + string.Join(", ", factors));
        Console.WriteLine("- Greatest Factor: " + GreatestFactor(factors));
        Console.WriteLine("- Sum of Factors: " + SumOfFactors(factors));
        Console.WriteLine("- Product of Factors: " + ProductOfFactors(factors));
        Console.WriteLine("- Product of Cubes of Factors: " + ProductOfCubes(factors));
        Console.WriteLine("- Is Perfect Number: " + (IsPerfect(number) ? "Yes" : "No"));
        Console.WriteLine("- Is Abundant Number: " + (IsAbundant(number) ? "Yes" : "No"));
        Console.WriteLine("- Is Deficient Number: " + (IsDeficient(number) ? "Yes" : "No"));
        Console.WriteLine("- Is Strong Number: " + (IsStrong(number) ? "Yes" : "No"));
    }
}
