using System;
using System.Collections.Generic;

class ZeroSum
{
    static void Main()
    {
        int[] arr = { 3, 4, -7, 3, 1, 3, 1, -4, -2, -2 };
        int n = arr.Length;

        // Dictionary to store cumulative sum and its indices
        Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();

        int sum = 0;

        // To handle subarrays starting from index 0
        map[0] = new List<int> { -1 };

        Console.WriteLine("Zero Sum Subarrays:");

        for (int i = 0; i < n; i++)
        {
            sum += arr[i];

            if (map.ContainsKey(sum))
            {
                // If sum already exists, zero-sum subarray found
                foreach (int startIndex in map[sum])
                {
                    Console.WriteLine("Subarray from index " + (startIndex + 1) + " to " + i);
                }
            }

            // Add current index to map
            if (!map.ContainsKey(sum))
                map[sum] = new List<int>();

            map[sum].Add(i);
        }
    }
}
