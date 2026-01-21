using System;
using System.Collections.Generic;

class CheckEqual
{
    static void Main()
    {
        HashSet<int> set1 = new HashSet<int>() { 1, 2, 3, 4 };
        HashSet<int> set2 = new HashSet<int>() { 4, 3, 2, 1 };

        if (set1.SetEquals(set2))
        {
            Console.WriteLine("The sets are equal.");
        }
        else
        {
            Console.WriteLine("The sets are not equal.");
        }
    }
}
