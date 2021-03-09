using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PrylanLibary.Models
{
    public class Person
    {
        private static readonly string PERSNR_REGEX = "^[0-9]{8}[-][0-9]{4}$";
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

        public bool ValidPersNr()
        {
            return Regex.IsMatch(this.PersNr, PERSNR_REGEX);
        }

        public bool ValidTillhorighet()
        {
            if(this.Tillhorighet.RemoveWhiteSpaces().Length > 2)
            {
                return true;
            }
            return false;
        }

        public Person Copy()
        {
            Person person = new Person()
            {
                Id = this.Id,
                Fornamn = this.Fornamn,
                Efternamn = this.Efternamn,
                PersNr = this.PersNr,
                Sign = this.Sign,
                Epost = this.Epost,
                Telefon = this.Telefon,
                Ovrigt = this.Ovrigt,
                Tillhorighet = this.Tillhorighet
            };
            return person;
        }

        public string GetNamn()
        {
            return this.Fornamn + " " + this.Efternamn;
        }

        public override string ToString()
        {
            if (this.Id == 0)
            {
                return $"{Fornamn} {Efternamn} {PersNr}";
            }
            return $"{Id} {Fornamn} {Efternamn} {PersNr}";
        }
    }
}
