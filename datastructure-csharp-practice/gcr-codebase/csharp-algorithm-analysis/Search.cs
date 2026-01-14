using System;

class Search
{
    static void Main()
    {
        int[] arr = { 3, 7, 12, 18, 25, 31, 42, 56, 63, 78 };
        int target = 42;   

        // Linear Search
        int linearResult = LinearSearch(arr, target);
        Console.WriteLine("Linear Search Result: Index " + linearResult);

        // Binary Search
        int binaryResult = BinarySearch(arr, target);
        Console.WriteLine("Binary Search Result: Index " + binaryResult);
    }

    static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
                return i;
        }
        return -1;
    }

    static int BinarySearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (arr[mid] == target)
                return mid;
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1;
    }
}
