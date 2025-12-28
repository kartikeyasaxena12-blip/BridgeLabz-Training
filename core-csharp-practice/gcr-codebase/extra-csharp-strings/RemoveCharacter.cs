using System;
class RemoveCharacter
{
    static void Main()
    {
        string input = Console.ReadLine();
        char remove = Convert.ToChar(Console.ReadLine());//input Character to remove
        string result = "";
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] != remove)
                result += input[i];
        }

        Console.WriteLine(result);
    }
}
