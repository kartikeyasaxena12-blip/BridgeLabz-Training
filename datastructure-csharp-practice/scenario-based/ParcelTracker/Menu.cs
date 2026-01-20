using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.ParcelTracker
{
    public class Menu
    {
        private IParcel parcelOps;

        public Menu(IParcel ops)
        {
            parcelOps = ops;
        }

        public void Show()
        {
            parcelOps.AddStage("Packed");
            parcelOps.AddStage("Shipped");
            parcelOps.AddStage("In Transit");
            parcelOps.AddStage("Delivered");

            parcelOps.AddCheckpoint("Shipped", "Custom Checkpoint");

            parcelOps.TrackParcel();
        }
    }
}
