using BridgeLabTraining.Smart_Home_Automation_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BridgeLabTraining.Smart_Home_Automation_System
{
    public class AC : Appliance, IControllable
    {
        public AC(string name) : base(name) { }
        public void TurnOn()
        {
            Console.WriteLine($"{name} AC is cooling the room to 22°C.");
        }
        public void TurnOff()
        {
            Console.WriteLine($"{name} AC is turned OFF.");
        }

    }
}