using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.CinemaTime
{
    public class Menu
    {
        IMovieManager manage = new CinemaManager();
        public void Display()
        {

            bool exit = true;

            while (exit)
            {
                Console.WriteLine("\n........XYZ Cinema.........");
                Console.WriteLine("Enter 1 to display all movie");
                Console.WriteLine("Enter 2 to add movie");
                Console.WriteLine("Enter 3 to search any movie");
                Console.WriteLine("Enter 4 to exit");
                Console.WriteLine("\nEnter Choice");

                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        manage.DisplayAllMovies();
                        break;

                    case 2:
                        Console.WriteLine("Enter movie name");
                        string movie = Console.ReadLine();
                        Console.WriteLine("Enter show time");
                        string time = Console.ReadLine();
                        manage.AddMovie(movie, time);
                        break;

                    case 3:
                        Console.WriteLine("Enter movie to search");
                        string keyword = Console.ReadLine();
                        manage.SearchMovie(keyword);
                        break;

                    case 4:
                        exit = false;
                        break;

                    default:
                        Console.WriteLine("Enter valid input");
                        break;
                }
            }
        }
    }
}
