using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.CinemaTime
{
    class CinemaManager : IMovieManager
    {
        private Movie[] movies = new Movie[10];
        int count = 0;

        public CinemaManager()
        {
            AddMovie("Avengers", "10:00 am");
            AddMovie("Iron Man", "12:00 pm");
            AddMovie("Inception", "1:40 pm");
            AddMovie("Avatar", "6:00 pm");
            AddMovie("Conjuring", "11:00 pm");
        }

        public void AddMovie(String title, String time)
        {
            if (count >= movies.Length)
            {
                Console.WriteLine("Sorry, All timeslots are full");
                return;
            }
            movies[count] = new Movie(title, time);
            count++;
        }

        public void SearchMovie(string keyword)
        {
            int found = 0;
            for (int i = 0; i < count; i++)
            {
                if (movies[i].GetTitle().Contains(keyword, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Movie = " + movies[i].GetTitle() + "       || Show Time = " + movies[i].GetTime());
                    found++;
                }
            }
            if (found == 0)
            {
                Console.WriteLine("No Movie Found");
            }
        }

        public void DisplayAllMovies()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Movie = " + movies[i].GetTitle() + "       || Show Time = " + movies[i].GetTime());
            }
        }
    }
}


