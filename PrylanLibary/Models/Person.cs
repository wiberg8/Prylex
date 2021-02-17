using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrylanLibary.Models
{
    public class Person
    {
        public Person()
        {

        }

        public Person(int Id)
        {
            this.Id = Id;
        }

        public int Id { get; set; }
        public string Fornamn { get; set; }
        public string Efternamn { get; set; }
        public string PersNr { get; set; }
        public string Sign { get; set; }
        public string Epost { get; set; }
        public string Telefon { get; set; }
        public string Ovrigt { get; set; }
        public string Tillhorighet { get; set; }

        public string GetNamn()
        {
            return this.Fornamn + " " + this.Efternamn;
        }

        public override string ToString()
        {
            return $"{Id} {Fornamn} {Efternamn} {PersNr}";
        }
    }
}
