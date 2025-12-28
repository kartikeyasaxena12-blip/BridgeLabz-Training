using System;
class ArgumentOutOfRange
{
    static void DemonstrateException()
    {
        string text = "Programming";
        try
        {
            // start index is greater than allowed range
            // Substring(startIndex, length)
            string result = text.Substring(8, 10);

            Console.WriteLine(result);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine("ArgumentOutOfRangeException caught!");
            Console.WriteLine(e.Message);
        }
    }
    static void Main(string[] args)
    {
        DemonstrateException();
    }
}
