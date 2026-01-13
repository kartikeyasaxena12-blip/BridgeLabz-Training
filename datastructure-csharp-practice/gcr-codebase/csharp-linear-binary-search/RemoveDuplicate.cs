using System;
using System.Text;

class RemoveDuplicate
{
    static void Main()
    {
        string input = "programming";

        StringBuilder result = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            if (!result.ToString().Contains(input[i]))
            {
                result.Append(input[i]);
            }
        }

        Console.WriteLine(result);
    }
}
