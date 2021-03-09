using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrylanLibary.Models
{
    public class ImportPerson
    {
        public Person Person { get; set; }
        public List<string> Errors { get; set; }
        public bool Exist { get; set; }
        public bool Success { get; set; }

        public override string ToString()
        {
            return Person.ToString();     
        }
    }
}
