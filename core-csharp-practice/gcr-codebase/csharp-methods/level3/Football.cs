using System;
class Football
{
    public static int[] GenerateRandomHeights(int size)
    {
        int[] heights = new int[size];
        Random rand = new Random();
        for (int i = 0; i < size; i++)
        {
            heights[i] = rand.Next(150, 251); //height between 150 and 250
        }
        return heights;
    }
    public static int CalculateSum(int[] arr)//calculate sum
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }
    public static double CalculateMean(int[] arr)//mean height
    {
        int sum = CalculateSum(arr);
        return (double)sum / arr.Length;
    }
    public static int FindShortest(int[] arr)
    {
        int shortest = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < shortest)
                shortest = arr[i];
        }
        return shortest;
    }
    public static int FindTallest(int[] arr)
    {
        int tallest = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > tallest)
                tallest = arr[i];
        }
        return tallest;
    }

    static void Main()
    {
        int[] heights = GenerateRandomHeights(11);

        Console.WriteLine("Heights of players in cm:");
        foreach (int height in heights)
        {
            Console.Write(height + " ");
        }
        Console.WriteLine();

        int shortest = FindShortest(heights);
        int tallest = FindTallest(heights);
        double mean = CalculateMean(heights);

        Console.WriteLine("Shortest height: " + shortest + " cm");
        Console.WriteLine("Tallest height: " + tallest + " cm");
        Console.WriteLine("Mean height: " + mean.ToString("F2") + " cm");
    }
}
