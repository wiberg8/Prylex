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
        public string ErrorMessage{ get; set; }
        public bool AlreadyExist { get; set; }
        public bool Success { get; set; }

        public override string ToString()
        {
            return Person.ToString();     
        }
    }
}
