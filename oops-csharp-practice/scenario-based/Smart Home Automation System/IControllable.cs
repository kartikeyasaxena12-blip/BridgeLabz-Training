using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.Smart_Home_Automation_System
{
    public interface IControllable
    {
        void TurnOn();
        void TurnOff();
    }
}