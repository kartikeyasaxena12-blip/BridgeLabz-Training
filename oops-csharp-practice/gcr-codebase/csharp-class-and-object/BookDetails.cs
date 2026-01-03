using System;

class BookDetails
{
    // Attributes
    string title;
    string author;
    double price;

    public BookDetails(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }

    // Method to display book details
    public void Display()
    {
        Console.WriteLine("   Book Details   ");
        Console.WriteLine("Title : " + title);
        Console.WriteLine("Author : " + author);
        Console.WriteLine("Price : " + price);
    }

    // Main method
    static void Main(string[] args)
    {
        BookDetails obj = new BookDetails("Rich Dad Poor Dad", "Robert Kiyosaki", 500); 

        obj.Display();
    }
}
