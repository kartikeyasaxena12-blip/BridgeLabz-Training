using System;

class SelectionSort
{
    static void Main()
    {
        int[] arr = { 78, 45, 89, 62, 50 };

        Console.WriteLine("Before Sorting:");
        PrintArray(arr);

        // Selection Sort
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int minPosition = i;

            // Find minimum element in remaining array
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minPosition])
                {
                    minPosition = j;
                }
            }

            // Swap minimum with current position
            int temp = arr[i];
            arr[i] = arr[minPosition];
            arr[minPosition] = temp;
        }

        Console.WriteLine("\nAfter Sorting:");
        PrintArray(arr);
    }

    static void PrintArray(int[] scores)
    {
        foreach (int score in scores)
            Console.Write(score + " ");
        Console.WriteLine();
    }
}
