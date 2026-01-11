using System;

class QuickSort
{
    static void Main(string[] args)
    {
        int[] arr = { 1200, 450, 999, 300, 750 };

        Console.WriteLine("Before Sorting:");
        PrintArray(arr);

        Quicksort(arr, 0, arr.Length - 1);

        Console.WriteLine("\nAfter Sorting:");
        PrintArray(arr);
    }

    // Quick Sort method
    static void Quicksort(int[] arr, int startIndex, int endIndex)
    {
        if (startIndex < endIndex)
        {
            int pivotPosition = Partition(arr, startIndex, endIndex);

            Quicksort(arr, startIndex, pivotPosition - 1); // left side
            Quicksort(arr, pivotPosition + 1, endIndex);   // right side
        }
    }

    // Partition method
    static int Partition(int[] arr, int startIndex, int endIndex)
    {
        int pivotValue = arr[endIndex]; // last element as pivot
        int smallerIndex = startIndex - 1;

        for (int currentIndex = startIndex; currentIndex < endIndex; currentIndex++)
        {
            if (arr[currentIndex] < pivotValue)
            {
                smallerIndex++;

                int temp = arr[smallerIndex];
                arr[smallerIndex] = arr[currentIndex];
                arr[currentIndex] = temp;
            }
        }

        int swapTemp = arr[smallerIndex + 1];
        arr[smallerIndex + 1] = arr[endIndex];
        arr[endIndex] = swapTemp;

        return smallerIndex + 1;
    }

    static void PrintArray(int[] prices)
    {
        foreach (int price in prices)
            Console.Write(price + " ");
        Console.WriteLine();
    }
}
