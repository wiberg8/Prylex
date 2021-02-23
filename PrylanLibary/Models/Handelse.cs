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

        public override string ToString()
        {
            return $"{FriText} {ArtikelId} {PersId}";
        }
    }
}
