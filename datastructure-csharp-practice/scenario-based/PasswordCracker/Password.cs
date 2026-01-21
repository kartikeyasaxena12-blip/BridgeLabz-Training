using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.PasswordCracker
{
    public class Password
    {
        private string password;

        public Password(string password)
        {
            this.password = password;
        }

        public string GetPassword()
        {
            return password;
        }
    }
}
