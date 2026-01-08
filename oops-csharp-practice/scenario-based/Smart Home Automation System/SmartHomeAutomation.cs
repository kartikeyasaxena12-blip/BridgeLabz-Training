using BridgeLabTraining.Smart_Home_Automation_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.Smart_Home_Automation_System
{
    public class SmartHomeAutomation
    {
        public static void Main(string[] args)
        {
            IControllable livingRoomLight = new Light("Living Room");
            IControllable bedroomFan = new Fan("Bedroom");
            IControllable kitchenAC = new AC("Kitchen");
            SmartHomeUtility.TurnOnDevice(livingRoomLight);
            SmartHomeUtility.TurnOffDevice(bedroomFan);
            SmartHomeUtility.TurnOnDevice(kitchenAC);
            SmartHomeUtility.TurnOnDevice(livingRoomLight);
            SmartHomeUtility.TurnOffDevice(bedroomFan);
            SmartHomeUtility.TurnOnDevice(kitchenAC);
        }
    }
}