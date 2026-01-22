using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.SmartCheckout
{
    public class Store
    {
        protected Dictionary<string, int> priceMap = new Dictionary<string, int>();
        protected Dictionary<string, int> stockMap = new Dictionary<string, int>();

        // Initialize items
        public Store()
        {
            priceMap["Milk"] = 50;
            priceMap["Bread"] = 30;
            priceMap["Rice"] = 60;

            stockMap["Milk"] = 20;
            stockMap["Bread"] = 15;
            stockMap["Rice"] = 25;
        }

        // Display available items
        public void DisplayItems()
        {
            Console.WriteLine("\nItem\tPrice\tStock");
            foreach (var item in priceMap)
            {
                Console.WriteLine(item.Key + "\t" + item.Value + "\t" + stockMap[item.Key]);
            }
        }
    }
}
