using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrylanLibary
{
    public class USBAuthentication
    {
        private static readonly ReadOnlyCollection<string> allowedSerials = new ReadOnlyCollection<string>(
            new string[] { "German", "Spanish", "Corrects", "Wrongs" }
        );

        public (bool, string) AuthenticateUSB()
        {
            return (true, string.Empty);
        }
        
    }
}
