using System;
class Frequency
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());//input a number
        int[] freq = new int[10];// to store frequency
        while (num > 0)
        {
            int digit = num % 10;
            freq[digit]++;
            num /= 10;
        }
        Console.WriteLine("Digit Frequency:");
        for (int i = 0; i < 10; i++)
        {
            if (freq[i] > 0)
                Console.WriteLine(i + " -> " + freq[i]);
        }
    }
}
