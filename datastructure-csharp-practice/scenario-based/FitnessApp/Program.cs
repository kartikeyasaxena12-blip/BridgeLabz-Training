using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.FitnessApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            ISort bubbleSort = new BubbleSort();

            User[] users = menu.GetData();
            menu.ShowMenu(users, bubbleSort);
        }
    }
}
