using System;
using System.Collections.Generic;

class StockSpan
{
    static void Main()
    {
        int[] prices = { 100, 80, 60, 70, 60, 75, 85 };
        int n = prices.Length;
        int[] span = new int[n];

        Stack<int> st = new Stack<int>(); // stores indices

        for (int i = 0; i < n; i++)
        {
            while (st.Count > 0 && prices[st.Peek()] <= prices[i])
            {
                st.Pop();
            }

            // If stack empty → span = i + 1
            span[i] = (st.Count == 0) ? (i + 1) : (i - st.Peek());

            // Push current index
            st.Push(i);
        }

        Console.WriteLine("Stock Prices:");
        foreach (int p in prices)
            Console.Write(p + " ");

        Console.WriteLine("\n\nStock Span:");
        foreach (int s in span)
            Console.Write(s + " ");
    }
}
