using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLHMenuPolicyInfo
{
    public class PolicyOutput
    {
        public string policyNumber { get; set; }
        public string PolicyHolder { get; set; }
        public string WaitingPeriodHS { get; set; }
        public string WaitingPeriodMA { get; set; }
        public string ProviderStatusCode { get; set; }
        public string ProviderStatusDescription { get; set; }
        public Message message { get; set; }
    }
    public class Message
    {
        public string code { get; set; }
        public string message { get; set; }
    }
}
