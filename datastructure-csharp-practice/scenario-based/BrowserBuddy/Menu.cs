using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.BrowserBuddy
{
    public class Menu
    {
        private IBrowser history = new BrowserHistory();

        public void Display()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n--- BrowserBuddy Menu ---");
                Console.WriteLine("1. Open URL");
                Console.WriteLine("2. Back");
                Console.WriteLine("3. Forward");
                Console.WriteLine("4. Current Page");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter URL: ");
                        history.Visit(Console.ReadLine());
                        break;

                    case 2:
                        history.Back();
                        break;

                    case 3:
                        history.Forward();
                        break;

                    case 4:
                        Console.WriteLine("Current Page: " + history.GetCurrentPage());
                        break;

                    case 5:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
