using System;
class LowerCase
{
      static void Main(string[]args)
    {
        Console.WriteLine("Enter a string");
        string s1= Console.ReadLine();
        string res=ConvertToLower(s1);
        Console.WriteLine(res);
    }
    static string ConvertToLower(string s1)
    {
        int l=s1.Length;
        string result="";
        for(int i=0;i<l;i++)
        {
            char ch= s1[i];
            if(ch>='A' && ch<='Z')
            {
                ch=(char)(ch+32);
            }
            result=result+ch;
        }
        return result;
    }
}