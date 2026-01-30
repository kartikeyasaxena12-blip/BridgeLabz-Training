using System;
using System.Text;
using System.Collections.Generic;

class LexicalTwist
{
    static void Main()
    {
        Console.Write("Enter first word: ");
        string word1 = Console.ReadLine();

        Console.Write("Enter second word: ");
        string word2 = Console.ReadLine();

        // Reverse first word
        char[] arr = word1.ToCharArray();
        Array.Reverse(arr);
        string reversedWord = new string(arr);

        if (reversedWord.Equals(word2, StringComparison.OrdinalIgnoreCase))
        {
            string result = reversedWord.ToLower();

            StringBuilder sb = new StringBuilder();
            foreach (char ch in result)
            {
                if ("aeiou".Contains(ch))
                    sb.Append('@');
                else
                    sb.Append(ch);
            }

            Console.WriteLine("Output: " + sb.ToString());
        }
        else
        {
            string combined = (word1 + word2).ToUpper();

            int vowelCount = 0, consonantCount = 0;
            List<char> vowels = new List<char>();
            List<char> consonants = new List<char>();

            foreach (char ch in combined)
            {
                if (char.IsLetter(ch))
                {
                    if ("AEIOU".Contains(ch))
                    {
                        vowelCount++;
                        if (!vowels.Contains(ch))
                            vowels.Add(ch);
                    }
                    else
                    {
                        consonantCount++;
                        if (!consonants.Contains(ch))
                            consonants.Add(ch);
                    }
                }
            }

            if (vowelCount > consonantCount)
            {
                Console.Write("Output: ");
                for (int i = 0; i < Math.Min(2, vowels.Count); i++)
                    Console.Write(vowels[i]);
            }
            else if (consonantCount > vowelCount)
            {
                Console.Write("Output: ");
                for (int i = 0; i < Math.Min(2, consonants.Count); i++)
                    Console.Write(consonants[i]);
            }
            else
            {
                Console.WriteLine("Output: Vowels and consonants are equal");
            }
        }
    }
}
