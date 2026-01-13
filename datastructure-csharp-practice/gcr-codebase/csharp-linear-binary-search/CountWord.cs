using System;
using System.IO;

class CountWordOccurrence
{
    static void Main()
    {
        string filePath = "p1.txt";
        string wordToFind = "hello";
        int count = 0;

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                string[] words = line.Split(
                    new char[] { ' ', '.', ',', '!', '?', ';', ':' },
                    StringSplitOptions.RemoveEmptyEntries
                );

                foreach (string word in words)
                {
                    if (word.Equals(wordToFind, StringComparison.OrdinalIgnoreCase))
                    {
                        count++;
                    }
                }
            }
        }

        Console.WriteLine("The word '" + wordToFind + "' appears " + count + " times.");    
        }
}
