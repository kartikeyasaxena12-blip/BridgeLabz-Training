using System;
class Cafeteria
{
    static void Main(string[]args)
    {
        //creating object
        Cafeteria obj = new Cafeteria();

        // items in cafeteria
        string[] items = new string[10]
        {
            "Tea" ,
            "Coffee",
            "Sandwich",
            "Burger",
            "Pizza",
            "Pasta",
            "Noodles",
            "Samosa",
            "Juice",
            "Ice Cream"
        };

        // price of the item
        string[] price = new string[10]
        {
            "10 INR" ,
            "25 INR",
            "50 INR",
            "80 INR",
            "100 INR",
            "200 INR",
            "150 INR",
            "20 INR",
            "120 INR",
            "100 INR"
        };

        // to display items with price
        obj.Display(items, price);

        // to order items
        obj.OrderItem(items);
        
    }

    // to display items
    void Display(string[] items, string[] price)
    {
        Console.WriteLine("Cafeteria Menu:");
        Console.WriteLine();

        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine((i + 1) + ". " + items[i] + " -> "+ price[i]);// to display list of items with price
        }
    }

    // method to order item
    void OrderItem(string[] items)
    {
        Console.WriteLine("  ");
        Console.WriteLine("Enter item you want to order");
        // input item to order
        int index = Convert.ToInt32(Console.ReadLine());

        // if entered correct item
        if(index <= items.Length)
        {
            Console.WriteLine("You ordered "+items[index-1]);
        }
        // if entered invalid input
        else
        {
            Console.WriteLine("Enter valid input");
        }
    }
}