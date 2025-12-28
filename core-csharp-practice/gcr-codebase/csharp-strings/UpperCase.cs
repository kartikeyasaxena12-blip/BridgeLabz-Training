using System;
class UpperCase
{
      static void Main(string[]args)
    {
        Console.WriteLine("Enter a string");
        string s1= Console.ReadLine();
        string res=ConvertToUpper(s1);
        Console.WriteLine(res);
    }
    static string ConvertToUpper(string s1)
    {
        int l=s1.Length;
        string result="";
        for(int i=0;i<l;i++)
        {
            char ch= s1[i];
            if(ch>='a' && ch<='z')
            {
                ch=(char)(ch-32);
            }
            result=result+ch;
        }
        return result;
    }
}