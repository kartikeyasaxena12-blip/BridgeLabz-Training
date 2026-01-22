using System;
using System.IO;

class UpperToLower
{
    static void Main()
    {
        string sourceFile = "input.txt";
        string destinationFile = "output.txt";

        if (!File.Exists(sourceFile))
        {
            Console.WriteLine("Source file does not exist.");
            return;
        }

        using (StreamReader reader = new StreamReader(sourceFile))
        using (StreamWriter writer = new StreamWriter(destinationFile))
        {
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                //convert uppercase to lowercase
                writer.WriteLine(line.ToLower());
            }
        }

        Console.WriteLine("File copied with uppercase converted to lowercase.");
    }
}
