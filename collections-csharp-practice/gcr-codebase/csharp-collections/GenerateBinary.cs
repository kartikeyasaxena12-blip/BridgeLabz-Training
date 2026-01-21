using System;
using System.Collections.Generic;

class GenerateBinary
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        Queue<string> queue = new Queue<string>();
        queue.Enqueue("1");

        Console.WriteLine($"First {n} binary numbers:");

        for (int i = 0; i < n; i++)
        {
            string current = queue.Dequeue();
            Console.Write(current + " ");

            // Enqueue next binary numbers
            queue.Enqueue(current + "0");
            queue.Enqueue(current + "1");
        }
    }
}
