using System;

class Book
{
    string title;
    string author;
    double price;

    // Default constructor
    public Book()
    {
        title = " ";
        author = " ";
        price = 0.0;
    }

    // Parameterized constructor
    public Book(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }

    // Method to display book details
    public void Display()
    {
        Console.WriteLine("Title  : " + title);
        Console.WriteLine("Author : " + author);
        Console.WriteLine("Price  : " + price);
    }
}

class Program
{
    static void Main()
    {
        // Using default constructor
        Book b1 = new Book();
        b1.Display();

        Console.WriteLine();

        // Using parameterized constructor
        Book b2 = new Book("Clean Code", "Robert C. Martin", 499);
        b2.Display();
    }
}
