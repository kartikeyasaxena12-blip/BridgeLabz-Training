using System;
class BubbleSort
{
    static void Main(string[] args)
    {
        int[] marks = { 78, 45, 89, 62, 50, 90 };

        Console.WriteLine("Marks before sorting:");
        PrintArray(marks);

        // Bubble Sort
        for (int i = 0; i < marks.Length - 1; i++)
        {
            for (int j = 0; j < marks.Length - 1 - i; j++)
            {
                if (marks[j] > marks[j + 1])
                {
                    // swapping
                    int temp = marks[j];
                    marks[j] = marks[j + 1];
                    marks[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("\nMarks after sorting :");
        PrintArray(marks);
    }

    static void PrintArray(int[] arr)
    {
        foreach (int value in arr)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
    }
}
