using System;

class NumberAnalysis
{
    static bool IsPositive(int number)
    {
        return number >= 0;
    }

    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    static int Compare(int number1, int number2)
    {
        if (number1 > number2)
            return 1;
        else if (number1 == number2)
            return 0;
        else
            return -1;
    }

    static void Main()
    {
        int[] numbers = new int[5];

        // Taking user input
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter number ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine();

        for (int i = 0; i < numbers.Length; i++)
        {
            if (IsPositive(numbers[i]))
            {
                Console.Write("Number " + numbers[i] + " is Positive and ");

                if (IsEven(numbers[i]))
                    Console.WriteLine("Even");
                else
                    Console.WriteLine("Odd");
            }
            else
            {
                Console.WriteLine("Number " + numbers[i] + " is Negative");
            }
        }

        Console.WriteLine();

        int result = Compare(numbers[0], numbers[numbers.Length - 1]);

        if (result == 1)
            Console.WriteLine("First element is greater than last element");
        else if (result == 0)
            Console.WriteLine("First element is equal to last element");
        else
            Console.WriteLine("First element is less than last element");
    }
}
