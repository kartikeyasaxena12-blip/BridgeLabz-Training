using System;
class Reverse
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number=Convert.ToInt32(Console.ReadLine());

        int temp=number;
        int count=0;//counter
        while (temp > 0)
        {
            count++;// to count no of digits
            temp /= 10;
        }

        int[] revDigits = new int[count];
        temp = number;

        for (int i = 0; i < count; i++) // Store digits in array
        {
            revDigits[i] = temp % 10;
            temp /= 10;
        }

        Console.WriteLine("Reversed number:");//printing reversed numbers
        for (int i = 0; i < count; i++)
        {
            Console.Write(revDigits[i]);
        }
    }
}
