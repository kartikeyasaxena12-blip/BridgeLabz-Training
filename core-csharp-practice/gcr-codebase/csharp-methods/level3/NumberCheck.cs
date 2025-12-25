using System;
class NumberCheck
{
    public static int CountDigits(int number) => number.ToString().Length;

    public static int[] GetDigitsArray(int number)
    {
        int[] digits = new int[CountDigits(number)];
        int temp = number;
        for (int i = digits.Length - 1; i >= 0; i--) { digits[i] = temp % 10; temp /= 10; }
        return digits;
    }

    public static bool IsDuckNumber(int[] digits)
    {
        foreach (int d in digits)
            if (d != 0) return true;
        return false;
    }

    public static bool IsArmstrong(int[] digits)
    {
        int sum = 0, num = 0;
        foreach (int d in digits) { sum += (int)Math.Pow(d, digits.Length); num = num * 10 + d; }
        return sum == num;
    }

    public static int[] FindLargestAndSecondLargest(int[] digits)
    {
        int largest = int.MinValue, second = int.MinValue;
        foreach (int d in digits)
        {
            if (d > largest) { second = largest; largest = d; }
            else if (d > second && d != largest) second = d;
        }
        return new int[] { largest, second };
    }

    public static int[] FindSmallestAndSecondSmallest(int[] digits)
    {
        int smallest = int.MaxValue, second = int.MaxValue;
        foreach (int d in digits)
        {
            if (d < smallest) { second = smallest; smallest = d; }
            else if (d < second && d != smallest) second = d;
        }
        return new int[] { smallest, second };
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] digits = GetDigitsArray(number);

        Console.WriteLine("Digits: " + string.Join(", ", digits));
        Console.WriteLine("Number of digits: " + CountDigits(number));
        Console.WriteLine("Duck Number: " + IsDuckNumber(digits));
        Console.WriteLine("Armstrong Number: " + IsArmstrong(digits));

        int[] largest = FindLargestAndSecondLargest(digits);
        Console.WriteLine("Largest: " + largest[0] + ", Second Largest: " + largest[1]);

        int[] smallest = FindSmallestAndSecondSmallest(digits);
        Console.WriteLine("Smallest: " + smallest[0] + ", Second Smallest: " + smallest[1]);
    }
}
