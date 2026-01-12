using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.LoanBuddy
{
    class AutoLoan : LoanApplication
    {
        public AutoLoan(int term, double principal)
    : base("Auto Loan", term, 10.5, principal)
        {
        }

        public override bool ApproveLoan(Applicant applicant)
        {
            bool eligible = applicant.GetCreditScore() >= 650;
            SetApproval(eligible);
            return eligible;
        }

        public override double CalculateEMI()
        {
            double r = interestRate / (12 * 100);
            int n = term;

            return (principal * r * Math.Pow(1 + r, n)) /
                   (Math.Pow(1 + r, n) - 1);
        }
    }
}
