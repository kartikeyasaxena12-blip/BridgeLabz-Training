using System;
using System.Collections.Generic;

class RemoveDuplicate
{
    static void Main()
    {
        List<int> list = new List<int>() { 3, 1, 2, 2, 3, 4, 5 };

        HashSet<int> seen = new HashSet<int>();
        List<int> result = new List<int>();

        foreach (int item in list)
        {
            if (!seen.Contains(item))
            {
                seen.Add(item);
                result.Add(item);
            }
        }

        Console.WriteLine("List after removing duplicates:");
        foreach (int item in result)
        {
            Console.Write(item + " ");
        }
    }
}
