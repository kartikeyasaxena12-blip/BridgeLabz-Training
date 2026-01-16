using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.BrowserBuddy
{
    public class BrowserHistory : IBrowser
    {
        private Browser[] history = new Browser[20];
        private int currentIndex = -1;
        private int size = 0;


        public void Visit(string url)
        {
            size = currentIndex + 1;
            history[size] = new Browser(url);
            currentIndex = size;
            size++;

            Console.WriteLine("Visited: " + url);
        }

        public void Back()
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                Console.WriteLine("Back to: " + history[currentIndex].GetUrl());
            }
            else
            {
                Console.WriteLine("No previous page");
            }
        }

        public void Forward()
        {
            if (currentIndex < size - 1)
            {
                currentIndex++;
                Console.WriteLine("Forward to: " + history[currentIndex].GetUrl());
            }
            else
            {
                Console.WriteLine("No next page");
            }
        }

        public string GetCurrentPage()
        {
            if (currentIndex >= 0)
                return history[currentIndex].GetUrl();

            return "No page open";
        }
    }
}
