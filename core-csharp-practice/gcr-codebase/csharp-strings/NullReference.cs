using System;
class NullReference
{
    static void DemonstrateNull()
    {
        string message = null;

        try
        {
            int length = message.Length;
            Console.WriteLine("Length: " + length);
        }
        catch (NullReferenceException e)
        {
            Console.WriteLine("NullReferenceException caught!");
            Console.WriteLine(e.Message);
        }
    }

    static void Main(string[] args)
    {
        DemonstrateNull();
    }
}
