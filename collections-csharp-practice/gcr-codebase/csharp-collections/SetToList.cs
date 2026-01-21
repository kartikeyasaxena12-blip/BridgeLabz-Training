using System;
using System.Collections.Generic;

class SetToList
{
    static void Main()
    {
        HashSet<int> set = new HashSet<int>() { 5, 1, 4, 2, 3 };

        // Converted to List
        List<int> sortedList = new List<int>(set);

        sortedList.Sort();

        Console.WriteLine("Sorted List:");
        foreach (int item in sortedList)
        {
            Console.Write(item + " ");
        }
    }
}
