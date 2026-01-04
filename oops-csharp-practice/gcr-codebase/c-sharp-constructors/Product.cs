using System;

class Product
{
    // Instance variables
    string productName;
    double price;

    static int totalProducts = 0;

    // Constructor
    public Product(string productName, double price)
    {
        this.productName = productName;
        this.price = price;
        totalProducts++;   
    }

    public void DisplayProductDetails()
    {
        Console.WriteLine("Product Name : " + productName);
        Console.WriteLine("Price        : " + price);
    }

    public static void DisplayTotalProducts()
    {
        Console.WriteLine("Total Products Created: " + totalProducts);
    }
}

class Program
{
    static void Main()
    {
        Product p1 = new Product("Laptop", 55000);
        Product p2 = new Product("Mobile", 25000);

        p1.DisplayProductDetails();
        Console.WriteLine();

        p2.DisplayProductDetails();
        Console.WriteLine();

        Product.DisplayTotalProducts();
    }
}
