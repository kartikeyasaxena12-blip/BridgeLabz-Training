using System;

class LibraryManagement
{
    // static variable
    public static string LibraryName = "Central City Library";

    // readonly variable
    public readonly string ISBN;

    public string Title;
    public string Author;

    // Constructor
    public LibraryManagement(string Title, string Author, string ISBN)
    {
        
        this.Title = Title;
        this.Author = Author;
        this.ISBN = ISBN;
    }

    // static method
    public static void DisplayLibraryName()
    {
        Console.WriteLine("Library Name: " + LibraryName);
    }

    // method to display details
    public void DisplayDetails(object obj)
    {
        if (obj is LibraryManagement)
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("ISBN: " + ISBN);
        }
        else
        {
            Console.WriteLine("Object is not a Book");
        }
    }
}

class Program
{
    static void Main()
    {
        LibraryManagement b1 = new LibraryManagement("The Alchemist", "Paulo Coelho", "ISBN001");
        LibraryManagement b2 = new LibraryManagement("Clean Code", "Robert C. Martin", "ISBN002");

        LibraryManagement.DisplayLibraryName();
        Console.WriteLine();

        b1.DisplayDetails(b1);
        Console.WriteLine();

        b2.DisplayDetails(b2);

        Console.ReadLine();
    }
}
