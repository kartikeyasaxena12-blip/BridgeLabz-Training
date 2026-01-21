using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.PasswordCracker
{
    public class PasswordUtility : ICracker
    {
        private char[] charset;
        private char[] current;
        private string target;
        private bool isCracked;

        public PasswordUtility(string password)
        {
            charset = new char[26];
            for (int i = 0; i < 26; i++)
            {
                charset[i] = (char)('a' + i);
            }

            target = password;
            current = new char[target.Length];
            isCracked = false;
        }

        public void StartCracking()
        {
            Generate(0);
        }

        private void Generate(int index)
        {
            if (isCracked)
                return;

            if (index == current.Length)
            {
                string attempt = new string(current);
                Console.WriteLine(attempt);

                if (attempt.Equals(target))
                {
                    Console.WriteLine("Password Cracked: " + attempt);
                    isCracked = true;
                }
                return;
            }

            for (int i = 0; i < charset.Length; i++)
            {
                current[index] = charset[i];
                Generate(index + 1);
            }
        }
    }
}