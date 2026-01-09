using System;
using System.Collections.Generic;

class TwoSum
{
    static void Main()
    {
        int[] nums = { 2, 7, 11, 15, 18 };
        int target = 9;

        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int required = target - nums[i];

            // Check if required number already exists
            if (map.ContainsKey(required))
            {
                Console.WriteLine("Indices: " + map[required] + " and " + i);
                Console.WriteLine("Values: " + required + " + " + nums[i] + " = " + target);
                return;
            }
            // Store current number with its index
            if (!map.ContainsKey(nums[i]))
                map[nums[i]] = i;
        }
        Console.WriteLine("No solution found");
    }
}
