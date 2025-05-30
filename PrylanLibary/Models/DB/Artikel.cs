﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PrylanLibary.Enums;
using SQLite;

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

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Besk { get; set; }
        public string StoldTag { get; set; }
        public string DatorNamn { get; set; }
        public string SerieNr { get; set; }
        public string Mac { get; set; }
        public string Os { get; set; }
        public string Inkop { get; set; }
        public string Ovrigt { get; set; }
        public Status Status { get; set; }
        public int? PersId { get; set; }

        public Artikel Copy()
        {
            Artikel artikel = new Artikel()
            {
                Id = this.Id,
                Besk = this.Besk,
                StoldTag = this.StoldTag,
                DatorNamn = this.DatorNamn,
                SerieNr = this.SerieNr,
                Mac = this.Mac,
                Os = this.Os,
                Inkop = this.Inkop,
                Ovrigt = this.Ovrigt,
                Status = this.Status,
                PersId = this.PersId
            };
            return artikel;
        }

        public override string ToString()
        {
            return $"{Id} {Besk} {DatorNamn} {StoldTag} {SerieNr}";
        }


    }
}
