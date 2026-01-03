using System;

class Product
{
    public static double Discount = 10.0;

    // readonly variable
    public readonly int ProductID;

    public string ProductName;
    public double Price;
    public int Quantity;

    // Constructor
    public Product(int ProductID, string ProductName, double Price, int Quantity)
    {
        this.ProductID = ProductID;
        this.ProductName = ProductName;
        this.Price = Price;
        this.Quantity = Quantity;
    }

    // static method to update discount
    public static void UpdateDiscount(double newDiscount)
    {
        Discount = newDiscount;
        Console.WriteLine("Discount Updated to: " + Discount + "%");
    }

    // method to display product details
    public void DisplayDetails(object obj)
    {
        if (obj is Product)
        {
            double total = Price * Quantity;
            double finalPrice = total - (total * Discount / 100);

            Console.WriteLine("Product ID: " + ProductID);
            Console.WriteLine("Product Name: " + ProductName);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Quantity: " + Quantity);
            Console.WriteLine("Final Price after Discount: " + finalPrice);
        }
        else
        {
            Console.WriteLine("Invalid Product Object");
        }
    }

    // Main method
    static void Main()
    {
        Product p1 = new Product(101, "Mobile", 15000, 1);
        Product p2 = new Product(102, "Earbuds", 3000, 2);

        Product.UpdateDiscount(20);
        Console.WriteLine();

        p1.DisplayDetails(p1);
        Console.WriteLine();

        p2.DisplayDetails(p2);

        Console.ReadLine();
    }
}
