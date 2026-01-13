using System;

class FirstNegative
{
    static void Main()
    {
        int[] numbers = { 3, 7, 0, -2, 5, -9, 8 };
        bool found = false;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < 0)
            {
                Console.WriteLine("First negative number: " + numbers[i] + " at index " + i);
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("No negative number found in the array.");
        }
    }
}
