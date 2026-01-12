using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.LoanBuddy
{
    abstract class LoanApplication : IApprovable
    {
        protected string loanType;
        protected int term;             
        protected double interestRate;
        protected double principal;

        private bool approved;           

        protected LoanApplication(string loanType, int term, double interestRate, double principal)
        {
            this.loanType = loanType;
            this.term = term;
            this.interestRate = interestRate;
            this.principal = principal;
        }

        protected void SetApproval(bool status)
        {
            approved = status;
        }

        public bool IsApproved()
        {
            return approved;
        }

        public abstract bool ApproveLoan(Applicant applicant);
        public abstract double CalculateEMI();
    }
}
