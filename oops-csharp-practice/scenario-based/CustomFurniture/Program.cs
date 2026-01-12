using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BridgeLabTraining.csharp_codes.CustomFurniture.FurnitureUtility;

namespace BridgeLabTraining.csharp_codes.CustomFurniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WoodRod rod = new WoodRod(12);

            int[] prices = {2, 6, 7, 10, 13, 17, 17, 20, 24, 30, 32, 34};

            PriceChart chart = new PriceChart(prices);
            FurnitureCutting cut = new FurnitureCutting();

            int maxRevenue = cut.CalculateMaxRevenue(rod, chart);

            Console.WriteLine("Maximum Revenue: Rs" + maxRevenue);
        }
    }
}
