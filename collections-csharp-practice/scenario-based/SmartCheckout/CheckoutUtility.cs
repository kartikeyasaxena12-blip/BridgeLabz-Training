using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.SmartCheckout
{
    public class CheckoutUtility : Store, Icheckout 
    {
        Queue<string> customerQueue = new Queue<string>();

        // Add customer to queue
        public void AddCustomer(string name)
        {
            customerQueue.Enqueue(name);
            Console.WriteLine(name + " added to checkout queue.");
        }

        // Process customer billing
        public void ProcessCustomer()
        {
            if (customerQueue.Count == 0)
            {
                Console.WriteLine("No customers in queue.");
                return;
            }

            string customer = customerQueue.Dequeue();
            Console.WriteLine("\nProcessing customer: " + customer);

            int totalBill = 0;
            string itemName;
            int quantity;

            DisplayItems();

            while (true)
            {
                Console.Write("\nEnter item name (or 'done'): ");
                itemName = Console.ReadLine();

                if (itemName.ToLower() == "done")
                    break;

                if (!priceMap.ContainsKey(itemName))
                {
                    Console.WriteLine("Item not found!");
                    continue;
                }

                Console.Write("Enter quantity: ");
                quantity = int.Parse(Console.ReadLine());

                if (stockMap[itemName] < quantity)
                {
                    Console.WriteLine("Insufficient stock!");
                    continue;
                }

                // Calculate bill and update stock
                totalBill += priceMap[itemName] * quantity;
                stockMap[itemName] -= quantity;
            }

            Console.WriteLine("Total Bill for " + customer + " = " + totalBill);
        }
    }
}
