using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.Fitness_Tracker
{
    public class Workout : UserProfile, ITrackable
    {
        public Workout(string name, int age) : base(name, age){ }
        Random rand = new Random(); 

        public void CardioWorkout()
        {
            int min = rand.Next(5, 16);
            int cardioCalorie = min * 10;
            Console.WriteLine("Running workout : Duration = "+min);

            min = rand.Next(11, 20);
            cardioCalorie += min * 15;
            Console.WriteLine("Jumping Jacks : Duration = " + min);

            Console.WriteLine("Total Calories Burnt = "+cardioCalorie);
            Console.WriteLine("---------------------------------");

            base.totCalorie += cardioCalorie;
        }

        public void StrengthWorkout()
        {
            int min = rand.Next(2, 10);
            int calorie = min * 20;
            Console.WriteLine("Pushups : Duration = " + min);

            min = rand.Next(5, 10);
            calorie += min * 18;
            Console.WriteLine("Dumbbells : Duration = " + min);

            min = rand.Next(15, 30);
            calorie += min * 16;
            Console.WriteLine("Squats : Duration = " + min);

            Console.WriteLine("Total Calories Burnt = " + calorie);
            Console.WriteLine("---------------------------------");
            base.totCalorie += calorie;
        }

        public void Display()
        {
            base.Display();
            Console.WriteLine("---------------------------");
        }
    }
}
