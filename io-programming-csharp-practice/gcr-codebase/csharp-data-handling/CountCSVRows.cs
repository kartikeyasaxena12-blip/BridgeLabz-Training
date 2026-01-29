using System;
using System.IO;

class CountCSVRows
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("SampleData.csv");

        int count = lines.Length - 1; 
        Console.WriteLine("Total records: " + count);
    }
}
