using System;
using System.IO;

class ReadFile
{
    static void Main()
    {
        string filePath = "p1.txt";

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
