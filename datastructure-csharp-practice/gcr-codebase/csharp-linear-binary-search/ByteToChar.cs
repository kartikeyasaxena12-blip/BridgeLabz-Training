using System;
using System.IO;

class ByteToCharStream
{
    static void Main()
    {
        string filePath = "sample.bin"; 

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                int ch;
                
                while ((ch = reader.Read()) != -1)
                {
                    Console.Write((char)ch);
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error: " + ex.Message);
        }
    }
}
