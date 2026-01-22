using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.SmartCheckout
{
    public interface Icheckout
    {
        void AddCustomer(string name);
        void ProcessCustomer();
    }
}
