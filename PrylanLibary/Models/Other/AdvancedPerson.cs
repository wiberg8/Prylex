using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrylanLibary.Models
{
    public class AdvancedPerson : IComparable
    {
        public Person Person { get; set; }
        public List<Artikel> RegistreradeArtiklar { get; set; }

        public int CompareTo(object person)
        {
            AdvancedPerson x = person as AdvancedPerson;
            if(this.RegistreradeArtiklar.Count > x.RegistreradeArtiklar.Count)
            {
                return 1;
            }
            else if (this.RegistreradeArtiklar.Count < x.RegistreradeArtiklar.Count)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"{Person} [{RegistreradeArtiklar.Count}]"; 
        }
    }
}
