using System;
using System.Collections.Generic;

class Difference
{
    static void Main()
    {
        HashSet<int> set1 = new HashSet<int>() { 1, 2, 3, 4 };
        HashSet<int> set2 = new HashSet<int>() { 3, 4, 5, 6 };

        HashSet<int> symDiff = new HashSet<int>(set1); 
        symDiff.SymmetricExceptWith(set2); // remove common elements

        Console.WriteLine("Symmetric Difference of sets:");
        foreach (var item in symDiff)
        {
            Console.Write(item + " ");
        }
    }
}
