using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrylanLibary.Enums;

namespace PrylanLibary.Models
{
    public class Handelse
    {
        public int Id { get; set; }
        public int ArtikelId { get; set; }
        public int PersId { get; set; }
        public HandelseTyp Typ { get; set; }
        public string FriText { get; set; }
        public DateTime Datum { get; set; } = DateTime.Now;

        public override string ToString()
        {
            string x;
            switch (Typ)
            {
                case HandelseTyp.AVREGISTRERING:
                    x = $"{"AvRegistrering"} {Datum}";
                    break;
                case HandelseTyp.REGISTRERING:
                    x = $"{"Registrering"} {Datum}";
                    break;
                default:
                    x = $"{FriText} {ArtikelId} {PersId} {Datum}";
                    break;   
            }
            return x;
        }
    }
}
