using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes
{
    public class SortAadhaar
    {
        static void RadixSort(long[] arr)
        {
            long max = arr[0];

            // Find maximum number
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }

            // Sort digit by digit
            for (long exp = 1; max / exp > 0; exp *= 10)
            {
                CountingSort(arr, exp);
            }
        }

        // Counting Sort for a specific digit
        static void CountingSort(long[] arr, long exp)
        {
            int n = arr.Length;
            long[] output = new long[n];
            int[] count = new int[10];

            // Count digit occurrences
            for (int i = 0; i < n; i++)
            {
                int digit = (int)((arr[i] / exp) % 10);
                count[digit]++;
            }

            // Cumulative count
            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            // Build output array
            for (int i = n - 1; i >= 0; i--)
            {
                int digit = (int)((arr[i] / exp) % 10);
                output[count[digit] - 1] = arr[i];
                count[digit]--;
            }

            for (int i = 0; i < n; i++)
            {
                arr[i] = output[i];
            }
        }

        // Binary Search method
        static int BinarySearch(long[] arr, long target)
        {
            int left = 0, right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (arr[mid] == target)
                    return mid;

                if (arr[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1;
        }

        static void Main()
        {
            long[] aadharNumbers =
            {
            987654321012,
            123456789012,
            555544443333,
            111122223333,
            999988887777
        };

            RadixSort(aadharNumbers);

            Console.WriteLine("Sorted Aadhar Numbers:");
            for (int i = 0; i < aadharNumbers.Length; i++)
            {
                Console.WriteLine(aadharNumbers[i]);
            }

            long searchNumber = 555544443333;
            int index = BinarySearch(aadharNumbers, searchNumber);

            if (index != -1)
                Console.WriteLine("Aadhar found at index: " + index);
            else
                Console.WriteLine("Aadhar not found");

            Console.ReadLine();
        }
    }
}
