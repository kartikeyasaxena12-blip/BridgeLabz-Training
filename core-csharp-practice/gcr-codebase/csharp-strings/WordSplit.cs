using System;

class WordSplit
{
    static string[,] SplitWordsAndLengths(string text)
    {
        string[] words = text.Split(' ');

        string[,] result = new string[words.Length, 2];

        for (int i = 0; i < words.Length; i++)
        {
            result[i, 0] = words[i];
            result[i, 1] = words[i].Length.ToString();
        }

        return result;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter text:");
        string input = Console.ReadLine();

        string[,] output = SplitWordsAndLengths(input);

        for (int i = 0; i < output.GetLength(0); i++)
        {
            Console.WriteLine(output[i, 0] + "\t" + output[i, 1]);
        }
    }
}
