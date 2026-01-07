using System;

// Interface
interface ITaxable
{
    double CalculateTax();
    string GetTaxDetails();
}

// Abstract Product class
abstract class Product
{
    protected int productId;
    protected string name;
    protected double price;

    public void SetProductId(int id)
    {
        productId = id;
    }

    public void SetName(string productName)
    {
        name = productName;
    }

    public void SetPrice(double productPrice)
    {
        price = productPrice;
    }

    // ✅ Getter method (FIX)
    public double GetPrice()
    {
        return price;
    }

    public abstract double CalculateDiscount();

    public void DisplayProduct()
    {
        Console.WriteLine("Product ID : " + productId);
        Console.WriteLine("Name       : " + name);
        Console.WriteLine("Price      : " + price);
    }
}

// Electronics
class Electronics : Product, ITaxable
{
    public override double CalculateDiscount()
    {
        return price * 0.10;
    }

    public double CalculateTax()
    {
        return price * 0.18;
    }

    public string GetTaxDetails()
    {
        return "Electronics Tax: 18%";
    }
}

// Clothing
class Clothing : Product, ITaxable
{
    public override double CalculateDiscount()
    {
        return price * 0.20;
    }

    public double CalculateTax()
    {
        return price * 0.12;
    }

    public string GetTaxDetails()
    {
        return "Clothing Tax: 12%";
    }
}

// Groceries
class Groceries : Product
{
    public override double CalculateDiscount()
    {
        return price * 0.05;
    }
}

// Main Program
class Program
{
    static void PrintFinalPrice(Product product)
    {
        double tax = 0;

        if (product is ITaxable)
        {
            tax = ((ITaxable)product).CalculateTax();
        }

        double discount = product.CalculateDiscount();
        double finalPrice = product.GetPrice() + tax - discount;

        product.DisplayProduct();
        Console.WriteLine("Discount   : " + discount);
        Console.WriteLine("Tax        : " + tax);
        Console.WriteLine("Final Price: " + finalPrice);
        Console.WriteLine("-----------------------------");
    }

    static void Main()
    {
        Product p1 = new Electronics();
        p1.SetProductId(101);
        p1.SetName("Laptop");
        p1.SetPrice(60000);

        Product p2 = new Clothing();
        p2.SetProductId(102);
        p2.SetName("Jacket");
        p2.SetPrice(4000);

        Product p3 = new Groceries();
        p3.SetProductId(103);
        p3.SetName("Rice Bag");
        p3.SetPrice(1200);

        Product[] products = { p1, p2, p3 };

        foreach (Product p in products)
        {
            PrintFinalPrice(p); // polymorphism
        }
    }
}
