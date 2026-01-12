using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.LoanBuddy
{
    public class Applicant
    {
        private int creditScore;   

        public string Name { get; }
        public double Income { get; }
        public double LoanAmount { get; }

        public Applicant(string name, int creditScore, double income, double loanAmount)
        {
            Name = name;
            this.creditScore = creditScore;
            Income = income;
            LoanAmount = loanAmount;
        }

        public int GetCreditScore()
        {
            return creditScore;
        }
    }
}

