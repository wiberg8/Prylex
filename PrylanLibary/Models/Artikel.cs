using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrylanLibary.Models
{
    public class Artikel
    {
        public Artikel()
        {

        }

        public Artikel(int Id)
        {
            this.Id = Id;
        }

        public int Id { get; private set; }
        public string Beskrivning { get; set; }
        public string StoldTag { get; set; }
        public string DatorNamn { get; set; }
        public string SerieNr { get; set; }
        public string Mac { get; set; }
        public string Os { get; set; }
        public string Inkop { get; set; }
        public string Ovrigt { get; set; }
        public Status Status { get; set; }
        public int PersId { get; set; }

        public override string ToString()
        {
            return $"{Id} {Beskrivning} {DatorNamn} {StoldTag} {SerieNr}";
        }
    }
}
