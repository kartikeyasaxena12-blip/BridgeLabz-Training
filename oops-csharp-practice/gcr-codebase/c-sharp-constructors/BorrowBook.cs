using System;

class Book
{
    string title;
    string author;
    double price;
    bool available;

    // Constructor
    public Book(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
        this.available = true;
    }

    // Method to borrow a book
    public void BorrowBook()
    {
        if (available)
        {
            available = false;
            Console.WriteLine("Book borrowed successfully.");
        }
        else
        {
            Console.WriteLine("Sorry, the book is already borrowed.");
        }
    }

    // Method to display book details
    public void Display()
    {
        Console.WriteLine("Title       : " + title);
        Console.WriteLine("Author      : " + author);
        Console.WriteLine("Price       : " + price);
        Console.WriteLine("Availability: " + (available ? "Available" : "Borrowed"));
    }
}

class Program
{
    static void Main()
    {
        Book b1 = new Book("The Alchemist", "Paulo Coelho", 350);

        b1.Display();
        Console.WriteLine();

        b1.BorrowBook();   // borrow book
        Console.WriteLine();

        b1.Display();      
    }
}
