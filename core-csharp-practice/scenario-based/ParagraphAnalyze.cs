using System;
class ParagraphAnalyze
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Sentence");
        string str=Console.ReadLine();//input sentence
        
        if(string.IsNullOrWhiteSpace(str))//to check for empty string or paragraph with only spaces
        {
            Console.WriteLine("Invalid Sentence");
        }
        else
        Display(str);

    }

    static int CountWords(string str)//to count length of words
    {
        string[] count= str.Split(' ');
        return count.Length;
    }

    static string DisplayWord(string str)//to display longest word
    {
        string[] arr= str.Split(' ');
        string longest=" ";
        for(int i=0;i<arr.Length;i++)
        {
            if(longest.Length<arr[i].Length)
            {
                longest=arr[i];
            }
        }
        return longest;
    }

    static string ReplaceWord(string old,string word,string str)//to replace old word with new word
    {
        string[] arr= str.Split(' ');
        for(int i=0;i<arr.Length;i++)
        {
            if(arr[i]==old)
            {
                arr[i]=word;
            }
        }
        return string.Join(" ",arr);

    }

    static void Display(string str)//method to input choice and display
    {
        int s1=CountWords(str);
        Console.WriteLine("Number of words = "+s1);
        string s2=DisplayWord(str);
        Console.WriteLine("Longest Word = "+s2);
        Console.WriteLine("Enter word to replace ");
        string old= Console.ReadLine();//input word to get replaced
        Console.WriteLine("Enter new word ");
        string word= Console.ReadLine();//input new word 
        string s3=ReplaceWord(old,word,str);
        Console.WriteLine("New Sentence = "+s3);
    }
}