using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.ParcelTracker
{
    public interface IParcel
    {
        void AddStage(string stage);
        void AddCheckpoint(string afterStage, string newStage);
        void TrackParcel();
    }
}
