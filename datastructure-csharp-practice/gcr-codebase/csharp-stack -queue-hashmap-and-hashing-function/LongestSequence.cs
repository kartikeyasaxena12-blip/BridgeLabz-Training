using System;
using System.Collections.Generic;

class LongestSequence
{
    static void Main()
    {
        int[] arr = { 100, 4, 200, 1, 3, 2 };
        
        HashSet<int> set = new HashSet<int>();

        // Add all elements
        foreach (int num in arr)
        {
            set.Add(num);
        }

        int longest = 0;

        foreach (int num in arr)
        {
            // Check if this is the start of a sequence
            if (!set.Contains(num - 1))
            {
                int currentNum = num;
                int currentStreak = 1;

                // Count consecutive numbers
                while (set.Contains(currentNum + 1))
                {
                    currentNum++;
                    currentStreak++;
                }

                // Update longest sequence
                longest = Math.Max(longest, currentStreak);
            }
        }

        Console.WriteLine("Length of Longest Consecutive Sequence: " + longest);
    }
}
