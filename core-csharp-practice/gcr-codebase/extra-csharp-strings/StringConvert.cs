using System;
class StringConvert
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        string res= "";
        for (int i = 0; i < str.Length; i++)
        {
            char ch=str[i];
            if(char.IsUpper(ch))
            {
                res+=char.ToLower(ch);
            }
            else if(char.IsLower(ch))
            {
                res+=char.ToUpper(ch);
            }
            else
            {
                res+=ch;
            }
        }
        Console.WriteLine(res);
    }
}