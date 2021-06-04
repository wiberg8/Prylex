using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PrylanLibary.Models
{
    [Table("personer")]
    public class Person
    {
        public Person()
        {

        }

        public Person(int Id)
        {
            this.Id = Id;
        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Fornamn { get; set; }
        public string Efternamn { get; set; }
        public string PersNr { get; set; }
        public string Sign { get; set; }
        public string Epost { get; set; }
        public string Telefon { get; set; }
        public string Ovrigt { get; set; }
        public string Tillhorighet { get; set; }

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

        public static Person Empty 
        { 
            get 
            {
                return new Person(){
                    Id = 0,
                    Fornamn = string.Empty,
                    Efternamn = string.Empty,
                    PersNr = string.Empty,
                    Sign = string.Empty,
                    Epost = string.Empty,
                    Telefon = string.Empty,
                    Ovrigt = string.Empty,
                    Tillhorighet = string.Empty
                };
            } 
        }

        public string FullName { get { return $"{this.Fornamn} {this.Efternamn}"; } }
        
        public override string ToString()
        {
            if (this.Id == 0)
            {
                return $"{Fornamn} {Efternamn} {PersNr}";
            }
            return $"{Id} {Fornamn} {Efternamn} {PersNr}";
        }

        public static Person GetExamplePerson()
        {
            return new Person
            {
                Fornamn = "FÖRNAMN EXEMPEL",
                Efternamn = "EFTERNAMN EXEMPEL",
                PersNr = "222222-2222",
                Sign = "EXEMPEL",
                Tillhorighet = "EXEMPEL",
                Ovrigt = "EXEMPEL"
            };
        }
    }
}
