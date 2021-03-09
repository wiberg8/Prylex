using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Results;

namespace PrylanLibary.Models
{
    public class ImportPerson
    {
        public Person Person { get; set; }
        public ValidationResult Errors { get; set; }
        public bool AlreadyExist { get; set; }
        public bool Success { get; set; }

        public override string ToString()
        {
            return Person.ToString();     
        }
    }
}
