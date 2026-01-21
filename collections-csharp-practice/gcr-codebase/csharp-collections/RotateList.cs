using System;
using System.Collections.Generic;

class RotateList
{
    static void Main()
    {
        List<int> list = new List<int>() { 10, 20, 30, 40, 50 };

        Console.Write("Enter number of positions to rotate: ");
        int k = int.Parse(Console.ReadLine());

        int n = list.Count;

        List<int> rotatedList = new List<int>();

        for (int i = k; i < n; i++)
        {
            rotatedList.Add(list[i]);
        }

        for (int i = 0; i < k; i++)
        {
            rotatedList.Add(list[i]);
        }

        Console.WriteLine("Rotated List:");
        foreach (int item in rotatedList)
        {
            Console.Write(item + " ");
        }
    }
}
