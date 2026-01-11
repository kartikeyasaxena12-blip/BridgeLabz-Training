using System;

class InsertionSort
{
    static void Main(string[] args)
    {
        int[] arr = { 105, 101, 109, 103, 102, 90 }; //employee ids

        Console.WriteLine("Before Sorting:");
        PrintArray(arr);

        // Insertion Sort logic
        for (int i = 1; i < arr.Length; i++)
        {
            int temp = arr[i];

            for (int j = i - 1; j >= 0; j--)
            {
                if (arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    arr[j] = temp;
                }
                else
                {
                    break;
                }
            }
        }

        Console.WriteLine("\nAfter Sorting :");
        PrintArray(arr);
    }

    static void PrintArray(int[] arr)
    {
        foreach (int id in arr)
        {
            Console.Write(id + " ");
        }
        Console.WriteLine();
    }
}
