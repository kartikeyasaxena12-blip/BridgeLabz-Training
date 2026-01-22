using System;
using System.IO;

class UserInfo
{
    static void Main()
    {
        // Take user input
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        string age = Console.ReadLine();

        Console.Write("Enter your favorite programming language: ");
        string language = Console.ReadLine();

        string filePath = "UserInfo.txt";

        // Save data to file
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Name: " + name);
            writer.WriteLine("Age: " + age);
            writer.WriteLine("Favorite Language: " + language);
        }

        Console.WriteLine("\nUser information saved successfully!");
    }
}
