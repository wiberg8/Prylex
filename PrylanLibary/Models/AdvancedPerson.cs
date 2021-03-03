using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrylanLibary.Models
{
    public class AdvancedPerson
    {
        public Person Person { get; set; }
        public List<Artikel> RegistreradeArtiklar { get; set; }

        public override string ToString()
        {
            return this.Person.ToString(); 
        }
    }
}
