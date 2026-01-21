using System;
using System.Collections.Generic;
using System.IO;

class WordCount
{
    static void Main()
    {
        string filePath = "data.txt"; // text file path

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string text = File.ReadAllText(filePath);

        // Convert to lowercase and split words
        string[] words = text.ToLower().Split(new char[] { ' ', ',', '.', '\n', '\r', '\t', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (wordCount.ContainsKey(word))
            {
                wordCount[word]++;
            }
            else
            {
                wordCount[word] = 1;
            }
        }

        Console.WriteLine("Word Frequencies:");
        foreach (var item in wordCount)
        {
            Console.WriteLine(item.Key + " : " + item.Value);
        }
    }
}
