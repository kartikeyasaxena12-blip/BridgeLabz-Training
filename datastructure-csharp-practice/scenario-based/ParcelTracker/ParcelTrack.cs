using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.ParcelTracker
{
    public class ParcelTrack
    {
        public string StageName { get; private set; }
        public ParcelTrack Next { get; set; }

        public ParcelTrack(string stageName)
        {
            StageName = stageName;
            Next = null;
        }

        }
}
