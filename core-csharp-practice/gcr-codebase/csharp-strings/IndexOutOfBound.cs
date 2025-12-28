using System;
class IndexOutOfBound
{
    static void DemonstrateArray()
    {
        int[] numbers = { 10, 20, 30 };

        try
        {
            int value = numbers[5];
            Console.WriteLine("Value: " + value);
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("IndexOutOfRangeException caught!");
            Console.WriteLine(e.Message);
        }
    }

    static void Main(string[] args)
    {
        DemonstrateArray();
    }
}
