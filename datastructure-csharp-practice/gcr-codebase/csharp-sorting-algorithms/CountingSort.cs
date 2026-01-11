using System;

class CountingSort
{
    static void Main()
    {
        int[] studentAges = { 12, 15, 10, 14, 13, 12, 18, 16, 11 };

        Console.WriteLine("Before Sorting:");
        PrintArray(studentAges);

        Countingsort(studentAges);

        Console.WriteLine("\nAfter Sorting:");
        PrintArray(studentAges);
    }

    static void Countingsort(int[] studentAges)
    {
        int minAge = 10;
        int maxAge = 18;

        int range = maxAge - minAge + 1;
        int[] countArray = new int[range];
        int[] sortedAges = new int[studentAges.Length];

        //Count frequency of each age
        for (int i = 0; i < studentAges.Length; i++)
        {
            countArray[studentAges[i] - minAge]++;
        }

        //Cumulative count
        for (int i = 1; i < countArray.Length; i++)
        {
            countArray[i] += countArray[i - 1];
        }

        //Place elements in correct position
        for (int i = studentAges.Length - 1; i >= 0; i--)
        {
            int currentAge = studentAges[i];
            int position = countArray[currentAge - minAge] - 1;

            sortedAges[position] = currentAge;
            countArray[currentAge - minAge]--;
        }

        // Copy sorted result back to original array
        for (int i = 0; i < studentAges.Length; i++)
        {
            studentAges[i] = sortedAges[i];
        }
    }

    static void PrintArray(int[] ages)
    {
        foreach (int age in ages)
            Console.Write(age + " ");
        Console.WriteLine();
    }
}
