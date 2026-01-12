using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.MetalFactory
{
    public class Menu
    {
        public void Display(int rodLength)
        {
            MaxRevenue obj = new MaxRevenue();

            int[] priceA = { 1, 5, 7, 8, 9, 11, 13, 15 };
            bool choice = true;

            while (choice)
            {
                Console.WriteLine(".................Menu.................");
                Console.WriteLine("Press 1 for Optimized Revenue");
                Console.WriteLine("Press 2 to change length price and then find revenue");
                Console.WriteLine("Press 3 for Non-Optimized Revenue");
                Console.WriteLine("Press 4 to exit");
                Console.WriteLine("\nEnter Choice");
                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        {
                            
                            Console.WriteLine("Optimized Revenue = " + obj.GetMaxRevenue(priceA, rodLength));
                            break;
                        }
                    case 2:
                        {
                            int[] priceB = { 1, 5, 7, 8, 9, 11, 20, 15 };
                            Console.WriteLine("Enter length to change price");
                            int rod = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter new price");
                            int newPrice = Convert.ToInt32(Console.ReadLine());

                            priceB[rod - 1] = newPrice;

                            Console.WriteLine("Optimized Revenue with custom price = " + obj.GetMaxRevenue(priceB, rodLength));
                            break;
                        }
                    case 3:
                        { 
                            Console.WriteLine("Non Optimized Revenue = " + rodLength * priceA[0]);
                            break;
                        }
                    case 4:
                        {
                            choice = false;
                            break;
                        }
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}

