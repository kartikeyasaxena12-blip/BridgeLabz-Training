using System;
using System.Collections.Generic;

class Subset
{
    static void Main()
    {
        HashSet<int> set1 = new HashSet<int>() { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int>() { 1, 2, 3, 4, 5 };

        if (set1.IsSubsetOf(set2))
        {
            Console.WriteLine("Set1 is a subset of Set2.");
        }
        else
        {
            Console.WriteLine("Set1 is not a subset of Set2.");
        }
    }
}
