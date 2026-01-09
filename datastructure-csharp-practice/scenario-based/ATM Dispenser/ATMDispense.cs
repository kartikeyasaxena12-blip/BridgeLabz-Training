using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.ATM_Dispenser
{
    public class ATMDispense
    {
        public void Dispense(int amount, int[] notes)
        {
            int originalAmount = amount;

            Console.WriteLine("\nDispensing Amount: Rs" + amount);

            foreach (int note in notes)
            {
                if (amount >= note)
                {
                    int count = amount / note;
                    amount = amount % note;

                    Console.WriteLine("Rs" + note + " x " + count);
                }
            }

            if (amount != 0)
            {
                Console.WriteLine("\nExact amount cannot be dispensed.");
                Console.WriteLine("Fallback Amount: Rs" + (originalAmount - amount));
            }
            else
            {
                Console.WriteLine("\nCash Dispensed Successfully");
            }
        }
    }
}
