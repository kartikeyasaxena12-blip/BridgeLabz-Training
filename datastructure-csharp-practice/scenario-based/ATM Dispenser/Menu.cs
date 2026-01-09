using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.ATM_Dispenser
{
    public class Menu
    {
        static void Main()
        {
            ATMDispense atm = new ATMDispense();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n====== ATM MENU ======");
                Console.WriteLine("1. Scenario A (All Notes Available)");
                Console.WriteLine("2. Scenario B (Rs500 Note Removed)");
                Console.WriteLine("3. Scenario C (Fallback Case)");
                Console.WriteLine("4. Exit");

                Console.Write("Enter choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nEnter amount to withdraw");
                int money;

                switch (choice)
                {
                    case 1:
                        money = Convert.ToInt32(Console.ReadLine());
                        atm.Dispense(money, new int[] { 500, 200, 100, 50, 20, 10, 5, 2, 1 });
                        break;

                    case 2:
                        money = Convert.ToInt32(Console.ReadLine());
                        atm.Dispense(money, new int[] { 200, 100, 50, 20, 10, 5, 2, 1 });
                        break;

                    case 3:
                        money = Convert.ToInt32(Console.ReadLine());
                        atm.Dispense(money, new int[] { 500,200,100,50, 20, 10 });
                        break;

                    case 4:
                        exit = true;
                        Console.WriteLine("Thank you for using ATM.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            } 
        }
    }
}
