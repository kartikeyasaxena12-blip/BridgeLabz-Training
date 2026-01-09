using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.Fitness_Tracker
{
    public class UserProfile
    {
        private string userName;
        private int age;
        protected double totCalorie=0.0;

        public UserProfile(string userName, int age)
        {
            this.userName = userName;
            this.age = age;
        }

        public void Display()
        {
            Console.WriteLine("Name = " + userName);
            Console.WriteLine("Age = "+age);
            Console.WriteLine("Total Calories Burnt = " + totCalorie);
        }
    }
}
