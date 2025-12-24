using System;
class FizzBuzz
{
    static void Main()
    {
        Console.Write("Enter a number: ");// Take input
        int number = Convert.ToInt32(Console.ReadLine());
        if (number <= 0)// Check for positive integer
        {
            Console.WriteLine("Invalid Input");
            return;
        }
        string[] result = new string[number + 1];//array creation
        for (int i = 1; i <= number; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)//conditions
            {
                result[i] = "FizzBuzz";
            }
            else if (i % 3 == 0)
            {
                result[i] = "Fizz";
            }
            else if (i % 5 == 0)
            {
                result[i] = "Buzz";
            }
            else
            {
                result[i] = i.ToString();
            }
        }
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine("Position " + i + " = " + result[i]);// Print results
        }
    }
}
