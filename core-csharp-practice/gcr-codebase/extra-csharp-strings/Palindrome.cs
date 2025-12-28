using System;
class Palindrome
{
    static void Main(string[]args)
    {
        Console.WriteLine("Enter text");
        string str= Console.ReadLine();
        bool ispalin=true;
        for(int i=0;i<str.Length/2;i++)
        {
            if(str[i]!=str[str.Length-i-1])
            {
                ispalin=false;
                break;
            }
        }
        if(ispalin)
        {
            Console.WriteLine("Palindrome");
        }
        else
        {
            Console.WriteLine("Not Palindrome");
        }
    }
}