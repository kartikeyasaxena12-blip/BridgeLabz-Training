using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.CinemaTime
{
    public class Movie
    {
        private string title;
        private string time;

        public Movie(string title, string time)
        {
            this.title = title;
            this.time = time;
        }

        public string GetTitle()
        {
            return title;
        }

        public string GetTime()
        {
            return time;
        }
    }
}
