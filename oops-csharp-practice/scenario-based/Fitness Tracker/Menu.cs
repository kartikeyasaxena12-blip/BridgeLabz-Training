using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.Fitness_Tracker
{
    internal class Menu
    {
        public static void Main(string[] args)
        {
            string name;
            int age;

            Console.WriteLine("......Welcome To XYZ Fitness Center.......");
            Console.Write("Enter Name = ");
            name = Console.ReadLine();

            Console.Write("\nEnter Age = ");
            age = Convert.ToInt32(Console.ReadLine());

            Workout work = new Workout(name, age);
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Press 1 for Cardio Workout");
                Console.WriteLine("Press 2 for Strength Workout");
                Console.WriteLine("Press 3 to get details");
                Console.WriteLine("Press 4 to get Exit");

                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        {
                            work.CardioWorkout();
                            break;
                        }
                    case 2:
                        {
                            work.StrengthWorkout();
                            break;
                        }
                    case 3:
                        {
                            work.Display();
                            break;
                        }
                    case 4:
                        {
                            exit = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please enter valid choice");
                            break;
                        }

                }
            }
        }
    }
}
