using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.FitnessApp
{
    internal class Menu
    {
        public User[] GetData()
        {
            Console.Write("Enter number of users: ");
            int count = Convert.ToInt32(Console.ReadLine());

            User[] users = new User[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("\nEnter details for User " + (i + 1));
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Steps: ");
                int steps = Convert.ToInt32(Console.ReadLine());

                users[i] = new User(name, steps);
            }

            return users;
        }

        public void ShowMenu(User[] users, ISort sorter)
        {
            int choice;

            do
            {
                Console.WriteLine("\n--- Fitness App Menu ---");
                Console.WriteLine("1. Display Leaderboard");
                Console.WriteLine("2. Sort Leaderboard (Bubble Sort)");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Display(users);
                        break;

                    case 2:
                        sorter.Sort(users);
                        Console.WriteLine("Leaderboard sorted successfully!");
                        break;

                    case 3:
                        Console.WriteLine("Exiting application...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (choice != 3);
        }

        private void Display(User[] users)
        {
            Console.WriteLine("\n--- Leaderboard ---");
            foreach (User user in users)
            {
                Console.WriteLine(user);
            }
        }
    }
}
