using System;
using System.Collections.Generic;

class SlidingWindow
{
    static void Main()
    {
        int[] arr = { 1, 3, -1, -3, 5, 3, 6, 7 };
        int k = 3;
        int n = arr.Length;

        LinkedList<int> deque = new LinkedList<int>(); // stores indices

        Console.WriteLine("Sliding Window Maximums:");

        for (int i = 0; i < n; i++)
        {
            // Remove indices out of current window
            if (deque.Count > 0 && deque.First.Value <= i - k)
            {
                deque.RemoveFirst();
            }

            // Remove smaller elements from the back
            while (deque.Count > 0 && arr[deque.Last.Value] <= arr[i])
            {
                deque.RemoveLast();
            }

            // Add current index
            deque.AddLast(i);

            if (i >= k - 1)
            {
                Console.Write(arr[deque.First.Value] + " ");
            }
        }
    }
}
