using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrylanLibary
{
    public class USBAuthentication
    {
        private static readonly string[] allowedSerials = new string[]
        {
            "",
            "",
            ""
        };

        public (bool, string) AuthenticateUSB()
        { 
            return (true, string.Empty);
        }
        
    }
}
