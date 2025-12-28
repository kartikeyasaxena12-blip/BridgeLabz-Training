using System;
class ReplaceWord
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a sentence:");
        string str = Console.ReadLine();
        Console.WriteLine("Enter the word to replace:");
        string old = Console.ReadLine();
        Console.WriteLine("Enter the new word:");
        string new_word = Console.ReadLine();

        string modifiedSentence = str.Replace(old,new_word);

        Console.WriteLine("Modified Sentence: " + modifiedSentence);
    }
}
