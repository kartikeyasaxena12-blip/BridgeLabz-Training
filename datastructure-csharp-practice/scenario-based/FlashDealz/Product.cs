using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.FlashDealz
{
    public class Product
    {
        public int Id { get; private set; }
        public int Discount { get; private set; }

        public Product(int id, int discount)
        {
            Id = id;
            Discount = discount;
        }
    }
}
