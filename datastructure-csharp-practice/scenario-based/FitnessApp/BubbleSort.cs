using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.FitnessApp
{
    public class BubbleSort : ISort
    {
        public void Sort(User[] users)
        {
            for (int i = 0; i < users.Length; i++)
            {
                for (int j = 0; j < users.Length - i - 1; j++)
                {
                    if (users[j].GetSteps() < users[j + 1].GetSteps())
                    {
                        User temp = users[j];
                        users[j] = users[j + 1];
                        users[j + 1] = temp;

                    }
                }
            }
        }
    }
}
