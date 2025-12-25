using System;
class NumberCheck4
{
    public static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
    public static bool IsNeon(int number)
    {
        int square = number * number;
        int sum = 0;
        while (square > 0)
        {
            sum += square % 10;
            square /= 10;
        }
        return sum == number;
    }
    public static bool IsSpy(int number)
    {
        int sum = 0, product = 1;
        int temp = number;
        while (temp > 0)
        {
            int digit = temp % 10;
            sum += digit;
            product *= digit;
            temp /= 10;
        }
        return sum == product;
    }

    // Check if automorphic number
    public static bool IsAutomorphic(int number)
    {
        int square = number * number;
        string numStr = number.ToString();
        string squareStr = square.ToString();
        return squareStr.EndsWith(numStr);
    }

    // Check if buzz number
    public static bool IsBuzz(int number)
    {
        return number % 7 == 0 || number % 10 == 7;
    }

    static void Main()
    {
        Console.Write("Enter a number to check: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nNumber Analysis for " + number + ":");

        Console.WriteLine("- Prime Number: " + (IsPrime(number) ? "Yes, it is a prime number." : "No, it is not a prime number."));
        Console.WriteLine("- Neon Number: " + (IsNeon(number) ? "Yes, it is a neon number." : "No, it is not a neon number."));
        Console.WriteLine("- Spy Number: " + (IsSpy(number) ? "Yes, it is a spy number." : "No, it is not a spy number."));
        Console.WriteLine("- Automorphic Number: " + (IsAutomorphic(number) ? "Yes, it is an automorphic number." : "No, it is not an automorphic number."));
        Console.WriteLine("- Buzz Number: " + (IsBuzz(number) ? "Yes, it is a buzz number." : "No, it is not a buzz number."));
    }
}
