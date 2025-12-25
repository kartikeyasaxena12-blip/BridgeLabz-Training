using System;

class NumberCheck3
{
    public static int CountDigits(int number) => number.ToString().Length;
    public static int[] GetDigitsArray(int number)
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

    public static int[] ReverseDigits(int[] digits)
    {
        int[] reversed = new int[digits.Length];
        for (int i = 0; i < digits.Length; i++)
            reversed[i] = digits[digits.Length - 1 - i];
        return reversed;
    }

    public static bool AreArraysEqual(int[] arr1, int[] arr2)
    {
        if (arr1.Length != arr2.Length) return false;
        for (int i = 0; i < arr1.Length; i++)
            if (arr1[i] != arr2[i]) return false;
        return true;
    }

    public static bool IsPalindrome(int[] digits)
    {
        int[] reversed = ReverseDigits(digits);
        return AreArraysEqual(digits, reversed);
    }

    public static bool IsDuckNumber(int[] digits)
    {
        foreach (int d in digits)
            if (d != 0) return true;
        return false;
    }

    static void Main()
    {
        Console.Write("Please enter a number to analyze: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int[] digits = GetDigitsArray(number);
        int[] reversedDigits = ReverseDigits(digits);
        Console.WriteLine("\nAnalysis Report for the number " + number + ":");
        Console.WriteLine("- The number has " + CountDigits(number) + " digit(s).");
        Console.WriteLine("- The digits of the number are: " + string.Join(", ", digits) + ".");
        Console.WriteLine("- The number reversed is: " + string.Join("", reversedDigits) + ".");
        Console.WriteLine("- Is the number a palindrome? " + (IsPalindrome(digits) ? "Yes" : "No"));
        Console.WriteLine("- Is the number a duck number? " + (IsDuckNumber(digits) ? "Yes" : "No"));
    }
}
