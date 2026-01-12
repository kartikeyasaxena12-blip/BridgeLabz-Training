using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.LoanBuddy
{
    internal class Program
    {
        static void Main()
        {
            Applicant applicant = new Applicant(
                "Ravi",
                720,
                60000,
                500000
            );

            Applicant applicant1 = new Applicant(
                "Rohan",
                800,
                40000,
                800000
                );

            LoanApplication loan = new HomeLoan(240, applicant.LoanAmount);
            {
                if (loan.ApproveLoan(applicant))
                {
                    Console.WriteLine("Home Loan Approved ");
                    Console.WriteLine("Monthly EMI: " + loan.CalculateEMI());
                }
                else
                {
                    Console.WriteLine("Loan Rejected ");
                }
            }

            LoanApplication loan1 = new AutoLoan(84, applicant1.LoanAmount);
            {
                if (loan1.ApproveLoan(applicant))
                {
                    Console.WriteLine("\nAuto Loan Approved ");
                    Console.WriteLine("Monthly EMI: " + loan1.CalculateEMI());
                }
                else
                {
                    Console.WriteLine("Loan Rejected ");
                }
            }
        }
    }
}
