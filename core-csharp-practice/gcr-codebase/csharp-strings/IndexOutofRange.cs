using System;
class IndexOutofRange
{
    static void GenerateException()
    {
        string str = "Hello";

        char ch = str[5];
        Console.WriteLine(ch);
    }

    static void HandleException()//handling exception
    {
        string str = "Hello";

        try
        {
            char ch = str[5];
            Console.WriteLine(ch);
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("IndexOutOfRangeException caught!");
            Console.WriteLine(e.Message);
        }
    }

    static void Main(string[] args)
    {
        //if we call GenerateException our program will crash 
        HandleException();
    }
}
