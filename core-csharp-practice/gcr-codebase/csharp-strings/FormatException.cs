using System;
class FormatException
{
    static void DemonstrateFormat()
    {
        try
        {
            string input = "abc";
            int number = int.Parse(input);

            Console.WriteLine("Number: " + number);
        }
        catch (FormatException e)
        {
            Console.WriteLine("FormatException caught!");
            Console.WriteLine(e.Message);
        }
    }
    static void Main(string[] args)
    {
        DemonstrateFormat();
    }
}
