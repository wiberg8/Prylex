using PrylanLibary.Enums;
using PrylanLibary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrylanLibary
{
    static class DataExtensions
    {
        public static Artikel ParseToArtikel(this DataRow r)
        {
            try
            {
                Artikel a = new Artikel(int.Parse(r[nameof(a.Id)].ToString()))
                {
                    Besk = r[nameof(a.Besk)].ToString(),
                    StoldTag = r[nameof(a.StoldTag)].ToString(),
                    DatorNamn = r[nameof(a.DatorNamn)].ToString(),
                    SerieNr = r[nameof(a.SerieNr)].ToString(),
                    Mac = r[nameof(a.Mac)].ToString(),
                    Os = r[nameof(a.Os)].ToString(),
                    Inkop = r[nameof(a.Inkop)].ToString(),
                    Ovrigt = r[nameof(a.Ovrigt)].ToString()
                };
                a.Status = (Status)int.Parse(r[nameof(a.Status)].ToString());
                if (int.TryParse(r[nameof(a.PersId)].ToString(), out int parsedPersId))
                {
                    a.PersId = parsedPersId;
                }
                return a;
            }
            catch
            {
                return null;
            }
        }

        public static Person ParseToPerson(this DataRow r)
        {
            try
            {
                Person p = new Person(int.Parse(r[nameof(p.Id)].ToString()))
                {
                    Fornamn = r[nameof(p.Fornamn)].ToString(),
                    Efternamn = r[nameof(p.Efternamn)].ToString(),
                    PersNr = r[nameof(p.PersNr)].ToString(),
                    Sign = r[nameof(p.Sign)].ToString(),
                    Tillhorighet = r[nameof(p.Tillhorighet)].ToString(),
                    Telefon = r[nameof(p.Telefon)].ToString(),
                    Ovrigt = r[nameof(p.Ovrigt)].ToString(),
                    Epost = r[nameof(p.Epost)].ToString()
                };
                return p;
            }
            catch
            {
                return null;
            }
        }

        public static Handelse ParseToHandelse(this DataRow r)
        {
             try
             {
                    Handelse h = new Handelse()
                    {
                        Id = int.Parse(r[nameof(h.Id)].ToString()),
                        ArtikelId = int.Parse(r[nameof(h.ArtikelId)].ToString()),
                        PersId = int.Parse(r[nameof(h.PersId)].ToString()),
                        Typ = (HandelseTyp)int.Parse(r[nameof(h.Typ)].ToString()),
                        FriText = r[nameof(h.FriText)].ToString(),
                        Datum = DateTime.Parse(r[nameof(h.Datum)].ToString())
                    };
                    return h;
            }
            catch
            {
                return null;
            }
        }
    }
}
