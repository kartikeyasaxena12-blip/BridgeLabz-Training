using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.AeroVigil
{
    public class InvalidFlightException : Exception
    {
        public InvalidFlightException(string message) : base(message)
        {
        }
    }
}