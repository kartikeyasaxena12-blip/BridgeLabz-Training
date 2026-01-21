using System;
using System.Collections.Generic;

class InvertDictionary
{
    static void Main()
    {
        Dictionary<string, int> original =
            new Dictionary<string, int>()
            {
                { "A", 1 },
                { "B", 2 },
                { "C", 1 }
            };

        Dictionary<int, List<string>> inverted =
            new Dictionary<int, List<string>>();

        foreach (var pair in original)
        {
            if (!inverted.ContainsKey(pair.Value))
            {
                inverted[pair.Value] = new List<string>();
            }

            inverted[pair.Value].Add(pair.Key);
        }

        Console.WriteLine("Inverted Dictionary:");
        foreach (var item in inverted)
        {
            Console.Write(item.Key + " -> ");
            Console.WriteLine(string.Join(", ", item.Value));
        }
    }
}
