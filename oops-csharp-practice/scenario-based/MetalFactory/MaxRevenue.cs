using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.MetalFactory
{
    public class MaxRevenue
    {
        public int GetMaxRevenue(int[] prices, int rodLength)
        {
            int[] max = new int[rodLength + 1];
            max[0] = 0;
            for (int i = 1; i <= rodLength; i++)
            {
                int maxVal = 0;
                for (int j = 0; j < i; j++)
                {
                    maxVal = Math.Max(maxVal, prices[j] + max[i - j - 1]);
                }
                max[i] = maxVal;
            }
            return max[rodLength];
        }
    }
}