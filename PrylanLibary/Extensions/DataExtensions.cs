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
                Artikel a = new Artikel(int.Parse(r["Id"].ToString()))
                {
                    Beskrivning = r["Besk"].ToString(),
                    StoldTag = r["Stoldtag"].ToString(),
                    DatorNamn = r["Datornamn"].ToString(),
                    SerieNr = r["SerieNr"].ToString(),
                    Mac = r["Mac"].ToString(),
                    Os = r["Os"].ToString(),
                    Inkop = r["Inkop"].ToString()
                };
                a.Ovrigt = r["Ovrigt"].ToString();
                a.Status = (Status)int.Parse(r["Status"].ToString());
                if (int.TryParse(r["PersId"].ToString(), out int parsedPersId))
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
                Person p = new Person(int.Parse(r["Id"].ToString()))
                {
                    Fornamn = r["Fornamn"].ToString(),
                    Efternamn = r["Efternamn"].ToString(),
                    PersNr = r["PersNr"].ToString(),
                    Sign = r["Sign"].ToString(),
                    Tillhorighet = r["Tillhorighet"].ToString(),
                    Telefon = r["Telefon"].ToString(),
                    Ovrigt = r["Ovrigt"].ToString(),
                    Epost = r["Epost"].ToString()
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
                    Handelse handelse = new Handelse()
                    {
                        Id = int.Parse(r["Id"].ToString()),
                        ArtikelId = int.Parse(r["ArtikelId"].ToString()),
                        PersId = int.Parse(r["PersId"].ToString()),
                        Typ = (HandelseTyp)int.Parse(r["Typ"].ToString()),
                        FriText = r["FriText"].ToString(),
                        Datum = DateTime.Parse(r["Datum"].ToString())
                    };
                    return handelse;
            }
            catch
            {
                return null;
            }
        }
    }
}
