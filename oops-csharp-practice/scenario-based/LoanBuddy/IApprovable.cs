using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.LoanBuddy
{
    interface IApprovable
    {
        Boolean ApproveLoan(Applicant applicant);
        double CalculateEMI();
    }
}
