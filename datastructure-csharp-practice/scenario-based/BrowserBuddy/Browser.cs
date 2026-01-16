using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.BrowserBuddy
{
    public class Browser
    {
        private string url;

        public Browser(string url)
        {
            this.url = url;
        }

        public string GetUrl()
        {
            return url;
        }
    }
}