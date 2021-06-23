using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrylanLibary.Enums;
using SQLite;

namespace PrylanLibary.Models
{
    [Table("Handelser")]
    public class Handelse
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int ArtikelId { get; set; }
        public int? PersId { get; set; }
        public HandelseTyp Typ { get; set; }
        public string FriText { get; set; }
        public DateTime Datum { get; set; } = DateTime.Now;

        public override string ToString()
        {
            string x;
            switch (Typ)
            {
                case HandelseTyp.AVREGISTRERING:
                    x = $"{Locales.Avregistrering}  |  {Datum}";
                    break;
                case HandelseTyp.REGISTRERING:
                    x = $"{Locales.Registrering}  |  {Datum}";
                    break;
                default:
                    x = $"{FriText}  |  {Datum}";
                    break;   
            }
            return x;
        }
    }
}
