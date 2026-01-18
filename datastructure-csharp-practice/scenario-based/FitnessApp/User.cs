using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.FitnessApp
{
    public class User
    {
        private string name;
        private int steps;

        public User(string name, int steps)
        {
            this.name = name;
            this.steps = steps;
        }

        public string GetName()
        {
            return name;
        }

        public int GetSteps()
        {
            return steps;
        }

        public override string ToString()
        {
            return name + " - " + steps + " steps";
        }
    }
}
