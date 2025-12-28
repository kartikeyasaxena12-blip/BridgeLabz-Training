using System;
class Anagram
{
    static void Main()
    {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();
        char[] a1 = s1.ToLower().ToCharArray();
        char[] a2 = s2.ToLower().ToCharArray();
        Array.Sort(a1);
        Array.Sort(a2);
        if (new string(a1) == new string(a2))
            Console.WriteLine("Anagrams");
        else
            Console.WriteLine("Not Anagrams");
    }
}
