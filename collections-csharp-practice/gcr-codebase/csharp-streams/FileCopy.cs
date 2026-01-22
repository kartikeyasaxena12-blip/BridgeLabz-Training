using System;
using System.IO;

class FileCopy
{
    static void Main()
    {
        string sourceFile = "source.txt";
        string destinationFile = "destination.txt";

        if (File.Exists(sourceFile))
        {
            string content = File.ReadAllText(sourceFile);

            // Write content to destination file
            File.WriteAllText(destinationFile, content);

            Console.WriteLine("File copied successfully!");
        }
        else
        {
            Console.WriteLine("Source file does not exist.");
        }
    }
}
