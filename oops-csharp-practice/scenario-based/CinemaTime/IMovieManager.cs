using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.CinemaTime
{
    interface IMovieManager
    {
        void AddMovie(String title, String time);
        void SearchMovie(String keyword);
        void DisplayAllMovies();
    }
}
