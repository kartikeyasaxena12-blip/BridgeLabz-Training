using System;
class SubString
{
      static void Main(string[]args)
    {
        Console.WriteLine("Enter a string");
        string s1= Console.ReadLine();
        Console.WriteLine("Enter start index");
        int start= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter end index");
        int end= Convert.ToInt32(Console.ReadLine());
        string result=CreateSubString(s1,start,end);
        Console.WriteLine(result);
    }
    static string CreateSubString(string s1,int start,int end)
    {
      string res="";//to store substring
      for(int i=start;i<end;i++)
      {
            res=res+s1[i];
      }
      return res;
    }
}