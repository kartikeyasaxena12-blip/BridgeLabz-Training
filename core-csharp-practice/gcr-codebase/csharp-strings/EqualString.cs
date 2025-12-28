using System;
class EqualString
{
    static void compareusingcharAt(string s1, string s2)
    {
        if(s1.Length!=s2.Length)
        {
            Console.WriteLine("Not Equal");
            return;
        }

        for(int i=0;i<s1.Length;i++)
        {
            if(s1[i]!=s2[i])
            {
                Console.WriteLine("Not Equal");
                return;
            }
        }
        Console.WriteLine("Equal");
    }
    static void Main(string[]args)
    {
        Console.WriteLine("Enter two strings");
        string s1= Console.ReadLine();
        string s2= Console.ReadLine();
        compareusingcharAt(s1,s2);
    }
}