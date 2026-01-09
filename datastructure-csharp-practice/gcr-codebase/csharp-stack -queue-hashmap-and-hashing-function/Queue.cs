using System;
using System.Collections.Generic;

class QueueUsingStacks
{
    Stack<int> stack1 = new Stack<int>(); // for enqueue
    Stack<int> stack2 = new Stack<int>(); // for dequeue

    // Enqueue 
    public void Enqueue(int value)
    {
        stack1.Push(value);
        Console.WriteLine(value + " enqueued");
    }

    // Dequeue 
    public void Dequeue()
    {
        if (stack2.Count == 0)
        {
            if (stack1.Count == 0)
            {
                Console.WriteLine("Queue is empty");
                return;
            }

            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
        }

        Console.WriteLine(stack2.Pop() + " dequeued");
    }

    static void Main()
    {
        QueueUsingStacks queue = new QueueUsingStacks();

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        queue.Dequeue();
        queue.Dequeue();

        queue.Enqueue(40);

        queue.Dequeue();
        queue.Dequeue();
    }
}
