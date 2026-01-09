using System;
using System.Collections.Generic;

class GivenSum
{
    static void Main()
    {
        int[] arr = { 8, 7, 2, 5, 3 };
        int target = 11;

        Dictionary<int, int> map = new Dictionary<int, int>();

        bool found = false;

        for (int i = 0; i < arr.Length; i++)
        {
            int required = target - arr[i];

            // Check if required number already exists
            if (map.ContainsKey(required))
            {
                Console.WriteLine("Pair found: " + required + " + " + arr[i] + " = " + target);
                found = true;
                break;
            }

            // Store current number
            if (!map.ContainsKey(arr[i]))
                map[arr[i]] = i;
        }

        if (!found)
        {
            Console.WriteLine("No pair found with given sum");
        }
    }
}
