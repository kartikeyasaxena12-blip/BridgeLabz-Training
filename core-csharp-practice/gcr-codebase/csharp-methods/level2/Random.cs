using System;

class RandomNumber
{
    static int[] GenerateRandom(int size)//generate random
    {
        int[] numbers = new int[size];
        System.Random random = new System.Random(); 

        for (int i = 0; i < size; i++)
        {
            numbers[i] = random.Next(1000, 10000);
        }

        return numbers;
    }

    // Method to find average, min and max
    static double[] FindAverageMinMax(int[] numbers)
    {
        int sum = 0;
        int min = numbers[0];
        int max = numbers[0];

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
            min = Math.Min(min, numbers[i]);
            max = Math.Max(max, numbers[i]);
        }

        double average = (double)sum / numbers.Length;
        return new double[] { average, min, max };
    }

    static void Main()
    {
        int[] randomNumbers = GenerateRandom(5);

        Console.WriteLine("Generated numbers:");
        for (int i = 0; i < randomNumbers.Length; i++)
        {
            Console.WriteLine(randomNumbers[i]);
        }

        double[] result = FindAverageMinMax(randomNumbers);

        Console.WriteLine("Average = " + result[0]);
        Console.WriteLine("Minimum = " + result[1]);
        Console.WriteLine("Maximum = " + result[2]);
    }
}
