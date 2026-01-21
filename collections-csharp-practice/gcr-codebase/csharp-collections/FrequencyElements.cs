using System;
using System.Collections.Generic;

class FrequencyElements
{
    static void Main()
    {
        List<string> words = new List<string>()
        {
            "apple", "banana", "apple", "orange", "banana", "apple"
        };

        Dictionary<string, int> frequency = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (frequency.ContainsKey(word))
            {
                frequency[word]++;
            }
            else
            {
                frequency[word] = 1;
            }
        }

        foreach (var item in frequency)
        {
            Console.Write(item.Key + " : " + item.Value + " | ");
        }
    }
}
