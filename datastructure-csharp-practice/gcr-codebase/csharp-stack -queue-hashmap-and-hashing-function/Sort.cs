using System;
using System.Collections.Generic;

class SortStackRecursion
{
    Stack<int> stack = new Stack<int>();

    // Method to sort
    void SortStack()
    {
        if (stack.Count <= 1)
            return;

        // Remove top element
        int top = stack.Pop();

        // Sort remaining stack
        SortStack();

        // Insert the element back in sorted order
        InsertSorted(top);
    }

    // method to insert element in sorted position
    void InsertSorted(int value)
    {
        if (stack.Count == 0 || stack.Peek() <= value)
        {
            stack.Push(value);
            return;
        }

        // Remove top element
        int temp = stack.Pop();

        InsertSorted(value);

        // Put back the removed element
        stack.Push(temp);
    }

    static void Main()
    {
        SortStackRecursion obj = new SortStackRecursion();

        obj.stack.Push(30);
        obj.stack.Push(10);
        obj.stack.Push(40);
        obj.stack.Push(20);

        Console.WriteLine("Original Stack:");
        foreach (int i in obj.stack)
            Console.WriteLine(i);

        obj.SortStack();

        Console.WriteLine("\nSorted Stack (Ascending):");
        foreach (int i in obj.stack)
            Console.WriteLine(i);
    }
}
