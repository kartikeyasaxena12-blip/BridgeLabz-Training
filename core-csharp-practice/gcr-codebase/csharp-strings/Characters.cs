using System;
class Characters
{
      static void Main(string[]args)
    {
        Console.WriteLine("Enter a string");
        string s1= Console.ReadLine();
        int l=s1.Length;
        return_Characters(s1,l);
    }
    static void return_Characters(string s1, int l)
    {
        for(int i=0;i<l;i++)
        {
            Console.Write(s1[i]+" ");
        }
        return;
    }
}
        