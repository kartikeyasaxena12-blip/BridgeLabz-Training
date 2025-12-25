using System;

class NumberCheck2
{
    public static int CountDigits(int number) => number.ToString().Length;

    public static int[] GetDigitsArray(int number)//to store digits in an array
    {
        int[] digits = new int[CountDigits(number)];
        int temp = number;
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            digits[i] = temp % 10;
            temp /= 10;
        }
        return digits;
    }
    public static int SumOfDigits(int[] digits)//find sum of digits
    {
        int sum = 0;
        foreach (int d in digits)
            sum += d;
        return sum;
    }

    public static int SumOfSquares(int[] digits)
    {
        int sum = 0;
        foreach (int d in digits)
            sum += (int)Math.Pow(d, 2);
        return sum;
    }
    public static bool IsHarshadNumber(int number, int[] digits)
    {
        int sum = SumOfDigits(digits);
        return sum != 0 && number % sum == 0;
    }

    public static int[,] DigitFrequency(int[] digits)//find frequency
    {
        int[,] freq = new int[10, 2];
        for (int i = 0; i < 10; i++)
            freq[i, 0] = i;

        foreach (int d in digits)
            freq[d, 1]++;

        return freq;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int[] digits = GetDigitsArray(number);
        Console.WriteLine("Digits: " + string.Join(", ", digits));
        Console.WriteLine("Number of digits: " + CountDigits(number));
        Console.WriteLine("Sum of digits: " + SumOfDigits(digits));
        Console.WriteLine("Sum of squares of digits: " + SumOfSquares(digits));
        Console.WriteLine("Is Harshad Number: " + IsHarshadNumber(number, digits));
        int[,] freq = DigitFrequency(digits);
        Console.WriteLine("Digit Frequencies:");
        for (int i = 0; i < 10; i++)
        {
            if (freq[i, 1] > 0)
                Console.WriteLine("Digit " + freq[i, 0] + " occurs " + freq[i, 1] + " time(s)");
        }
    }
}
