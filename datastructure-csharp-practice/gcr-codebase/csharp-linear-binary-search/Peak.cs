using System;

class Peak
{
    static void Main()
    {
        int[] arr = { 1, 3, 20, 4, 1, 0 };
        int n = arr.Length;

        int peakIndex = FindPeak(arr, 0, n - 1, n);

        Console.WriteLine("Peak element: " + arr[peakIndex] + " at index " + peakIndex);
    }

    static int FindPeak(int[] arr, int low, int high, int n)
    {
        int mid = low + (high - low) / 2;

        if ((mid == 0 || arr[mid] >= arr[mid - 1]) &&
            (mid == n - 1 || arr[mid] >= arr[mid + 1]))
        {
            return mid;
        }

        if (mid > 0 && arr[mid - 1] > arr[mid])
        {
            return FindPeak(arr, low, mid - 1, n);
        }

        return FindPeak(arr, mid + 1, high, n);
    }
}
