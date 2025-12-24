using System;
class OddEven
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());//input number

        if (num <= 0)
        {
            Console.WriteLine("Invalid Number");
        }

        int size = num / 2 + 1;
        int[] odd = new int[size];//arrays create
        int[] even = new int[size];
        int oddIndex = 0;
        int evenIndex = 0;
        for (int i = 1; i <= num; i++)//loop to find even and odd numbers
        {
            if (i % 2 == 0)
            {
                even[evenIndex] = i;
                evenIndex++;
            }
            else
            {
                odd[oddIndex] = i;
                oddIndex++;
            }
        }
        // Print odd numbers
        Console.WriteLine("Odd numbers:");
        for (int i = 0; i < oddIndex; i++)
        {
            Console.Write(odd[i] + " ");
        }
        Console.WriteLine();
        // Print even numbers
        Console.WriteLine("Even numbers:");
        for (int i = 0; i < evenIndex; i++)
        {
            Console.Write(even[i] + " ");
        }
    }
}

