using System;
using System.Collections.Generic;

class FindElement
{
    static void Main()
    {
        LinkedList<int> list = new LinkedList<int>();
        list.AddLast(10);
        list.AddLast(20);
        list.AddLast(30);
        list.AddLast(40);
        list.AddLast(50);

        Console.Write("Enter N (Nth element from end): ");
        int n = int.Parse(Console.ReadLine());

        LinkedListNode<int> first = list.First;
        LinkedListNode<int> second = list.First;

        for (int i = 0; i < n; i++)
        {
            if (first == null)
            {
                Console.WriteLine("N is larger than the list size.");
                return;
            }
            first = first.Next;
        }

        while (first != null)
        {
            first = first.Next;
            second = second.Next;
        }

        Console.WriteLine($"The {n}th element from the end is: {second.Value}");
    }
}
