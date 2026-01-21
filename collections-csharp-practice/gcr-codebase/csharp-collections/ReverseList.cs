using System;
using System.Collections;

class ReverseList
{
    static void Main()
    {
        ArrayList list = new ArrayList() { 10, 20, 30, 40, 50 };

        int start = 0;
        int end = list.Count - 1;

        while (start < end)
        {
            object temp = list[start];
            list[start] = list[end];
            list[end] = temp;

            start++;
            end--;
        }

        Console.WriteLine("Reversed ArrayList:");
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
    }
}
