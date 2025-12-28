using System;
class CountVowels
{
    static void Main(string[]args)
    {
        Console.WriteLine("Enter text");
        string str= Console.ReadLine();
        int vowel_count=0;
        int conso_count=0;
        string str1=str.ToLower();
        for(int i=0;i<str1.Length;i++)
        {
            if(str1[i]=='a'||str1[i]=='e'||str1[i]=='i'||str1[i]=='o'||str1[i]=='u')
            {
                vowel_count++;
            }
            else
            {
                conso_count++;
            }
        }
        Console.WriteLine("Vowels = "+vowel_count);
        Console.WriteLine("Consonants = "+conso_count);
    }
}