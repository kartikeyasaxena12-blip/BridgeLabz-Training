using System;

class SearchWord
{
    static void Main()
    {
        string[] sentences = { "The sun rises in the east.","I love programming in C#." };

        string wordToFind = "sun";
        bool found = false;

        for (int i = 0; i < sentences.Length; i++)
        {
            if (sentences[i].Contains(wordToFind))
            {
                Console.WriteLine("Sentence containing '" + wordToFind + "': " + sentences[i]);
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("No sentence contains the word '" + wordToFind + "'.");
        }
    }
}
