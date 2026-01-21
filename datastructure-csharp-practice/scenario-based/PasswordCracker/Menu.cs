using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.PasswordCracker
{
    public class Menu
    {
        private Password vault;

        public Menu(Password vault)
        {
            this.vault = vault;
        }

        public void ShowMenu()
        {
            ICracker cracker = new PasswordUtility(vault.GetPassword());
            cracker.StartCracking();
        }
    }
}
