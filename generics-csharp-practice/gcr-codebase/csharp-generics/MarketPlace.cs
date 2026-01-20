using System;

//Interface
interface IProductOperations
{
    void ShowProduct();
}

//Encapsulated Generic Class
class Product<T> : IProductOperations where T : class
{
    private string name;
    private double price;
    private T category;

    public string Name
    {
        get { return name; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    public T Category
    {
        get { return category; }
    }

    public Product(string name, double price, T category)
    {
        this.name = name;
        this.price = price;
        this.category = category;
    }

    public void ShowProduct()
    {
        Console.WriteLine("Product: " + name +", Price: " + price +", Category: " + category);
    }
}

//Methods
class MarketplaceMethods
{
    public void ApplyDiscount<T>(Product<T> product, double percentage)
        where T : class
    {
        product.Price -= product.Price * (percentage / 100);
    }
}

//Menu Class
class Menu
{
    public void Show()
    {
        Product<string> book =
            new Product<string>("C# Book", 500, "BookCategory");

        Product<string> clothing =
            new Product<string>("T-Shirt", 1000, "ClothingCategory");

        MarketplaceMethods methods = new MarketplaceMethods();

        // Apply discounts
        methods.ApplyDiscount(book, 10);
        methods.ApplyDiscount(clothing, 20);

        Console.WriteLine("Product Catalog:");
        book.ShowProduct();
        clothing.ShowProduct();
    }
}

//Main Class
class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu.Show();

        Console.ReadLine();
    }
}
