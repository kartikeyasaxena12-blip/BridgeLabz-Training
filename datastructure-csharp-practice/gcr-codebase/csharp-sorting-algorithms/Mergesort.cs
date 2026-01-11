using System;

class Mergesort
{
    static void Main()
    {
        int[] prices = { 450, 299, 799, 199, 599 };

        Console.WriteLine("Book prices before sorting:");
        PrintArray(prices);

        MergeSort(prices, 0, prices.Length - 1);

        Console.WriteLine("\nBook prices after sorting (Ascending Order):");
        PrintArray(prices);
    }

    // Merge Sort logic
    static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;

            MergeSort(arr, left, mid);       // sort left half
            MergeSort(arr, mid + 1, right);  // sort right half

            Merge(arr, left, mid, right);    // merge both halves
        }
    }

    // Merge function
    static void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] L = new int[n1];
        int[] R = new int[n2];

        for (int i = 0; i < n1; i++)
            L[i] = arr[left + i];

        for (int j = 0; j < n2; j++)
            R[j] = arr[mid + 1 + j];

        int iIndex = 0, jIndex = 0, k = left;

        while (iIndex < n1 && jIndex < n2)
        {
            if (L[iIndex] <= R[jIndex])
            {
                arr[k] = L[iIndex];
                iIndex++;
            }
            else
            {
                arr[k] = R[jIndex];
                jIndex++;
            }
            k++;
        }

        while (iIndex < n1)
        {
            arr[k] = L[iIndex];
            iIndex++;
            k++;
        }

        while (jIndex < n2)
        {
            arr[k] = R[jIndex];
            jIndex++;
            k++;
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int price in arr)
            Console.Write(price + " ");
        Console.WriteLine();
    }
}
