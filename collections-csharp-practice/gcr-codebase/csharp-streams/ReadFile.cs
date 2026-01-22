using System;
using System.IO;

class ReadFile
{
    static void Main()
    {
        string filePath = "file.txt";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        using (FileStream fs = new FileStream(
                   filePath,
                   FileMode.Open,
                   FileAccess.Read,
                   FileShare.Read,
                   bufferSize: 8192,
                   useAsync: false))
        using (StreamReader reader = new StreamReader(fs))
        {
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                // Case-insensitive check for "error"
                if (line.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
