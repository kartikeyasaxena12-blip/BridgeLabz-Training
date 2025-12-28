using System;
class Calculator
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers:");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Choose operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            Console.WriteLine("Result: " + (a + b));
        }
        else if (choice == 2)
        {
            Console.WriteLine("Result: " + (a - b));
        }
        else if (choice == 3)
        {
            Console.WriteLine("Result: " + (a * b));
        }
        else if (choice == 4)
        {
            if (b != 0)
                Console.WriteLine("Result: " + (a / b));
            else
                Console.WriteLine("Cannot divide by zero");
        }
        else
        {
            Console.WriteLine("Invalid choice");
        }
    }
}
