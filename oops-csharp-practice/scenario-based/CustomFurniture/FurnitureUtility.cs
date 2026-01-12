using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.CustomFurniture
{
    public class FurnitureUtility
    {
        public class WoodRod
        {
            public int Length;

            public WoodRod(int length)
            {
                Length = length;
            }
        }

     
        public class PriceChart
        {
            private int[] prices;

            public PriceChart(int[] prices)
            {
                this.prices = prices;
            }

            public int GetPrice(int length)
            {
                return prices[length - 1];
            }
        }


        public class CutResult
        {
            public int Revenue;
            public int Waste;

            public CutResult(int revenue, int waste)
            {
                Revenue = revenue;
                Waste = waste;
            }
        }
    }
}
