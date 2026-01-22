using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.SmartCheckout
{
    public class Program
    {
        static void Main()
        {
            CheckoutUtility checkout = new CheckoutUtility();
            int choice;

            do
            {
                Console.WriteLine("\n===== SmartCheckout – Supermarket Billing =====");
                Console.WriteLine("1. Add Customer to Queue");
                Console.WriteLine("2. Process Customer Billing");
                Console.WriteLine("3. View Items & Stock");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter customer name: ");
                        checkout.AddCustomer(Console.ReadLine());
                        break;

                    case 2:
                        checkout.ProcessCustomer();
                        break;

                    case 3:
                        checkout.DisplayItems();
                        break;

                    case 4:
                        Console.WriteLine("System Closed.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (choice != 4);
        }
    }
}
