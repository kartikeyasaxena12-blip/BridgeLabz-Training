using System;
class LongestWord
{
    static void Main(string[]args)
    {
        Console.WriteLine("Enter a string ");
        string input = Console.ReadLine();
        string[] str = input.Split(' ');
        string longest="";
        for(int i=0;i<str.Length;i++)
        {
            if(str[i].Length>longest.Length)
            {
                longest=str[i];
            }
        }
        Console.WriteLine(longest);
    }
}
