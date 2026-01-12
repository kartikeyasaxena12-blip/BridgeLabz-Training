using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BridgeLabTraining.csharp_codes.CustomFurniture.FurnitureUtility;

namespace BridgeLabTraining.csharp_codes.CustomFurniture
{
    public class FurnitureCutting
    {
        public int CalculateMaxRevenue(WoodRod rod, PriceChart chart)
        {
            int n = rod.Length;
            int[] maxRev = new int[n + 1];
            maxRev[0] = 0;

            for (int i = 1; i <= n; i++)
            {
                int max = int.MinValue;

                for (int j = 1; j <= i; j++)
                {
                    int value = chart.GetPrice(j) + maxRev[i - j];
                    max = Math.Max(max, value);
                }
                maxRev[i] = max;
            }

            return maxRev[n];
        }
    }
}
