using System;
class Palindrome
{
    static void Main(string[]args)
    {
        Console.WriteLine("Enter number:");
        int a = Convert.ToInt32(Console.ReadLine());
        Fibonacci_Check(a);
    }
    static void Fibonacci_Check(int a)
    {
        string str = a.ToString();
        string rev="";
        for(int i=str.Length-1;i>=0;i--)
        {
            rev+=str[i];
        }
        if(str==rev)
        {
            Console.WriteLine("Palindrome");
        }
        else
        Console.WriteLine("Not a Palindrome");
    }
}