using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.BrowserBuddy
{
    public interface IBrowser
    {
        void Visit(string url);
        void Back();
        void Forward();
        string GetCurrentPage();
    }
}
