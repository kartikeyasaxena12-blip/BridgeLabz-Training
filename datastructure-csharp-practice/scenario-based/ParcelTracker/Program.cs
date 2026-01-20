using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.ParcelTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            IParcel parcel = new ParcelUtility();
            Menu menu = new Menu(parcel);
            menu.Show();

            Console.ReadLine();
        }
    }
}
