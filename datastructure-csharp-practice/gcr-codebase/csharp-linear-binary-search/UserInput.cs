using System;
using System.IO;

class UserInput
{
    static void Main()
    {
        string filePath = "p1.txt";
        Console.WriteLine("Enter text to write to file:");

        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                string input;
                while (true)
                {
                    input = Console.ReadLine();
                    if (input.ToLower() == "exit")
                        break;
                    writer.WriteLine(input); 
                }
            }
            Console.WriteLine("Input successfully written to " + filePath);
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error: " + ex.Message);
        }
    }
}
