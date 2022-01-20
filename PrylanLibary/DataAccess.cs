using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using PrylanLibary.Enums;
using PrylanLibary.Models;
using SQLite;
using SQLitePCL;

namespace PrylanLibary
{
    public class DataAccess
    {
        private SQLiteConnection db;

        public bool Open(string dbPath)
        {
            if (string.IsNullOrWhiteSpace(dbPath))
            {
                return false;
            }

            bool succesful;
            try
            {
                db = new SQLiteConnection(dbPath,  true);
                db.CreateTable<Artikel>();
                db.CreateTable<Person>();
                db.CreateTable<Handelse>();
                succesful = true;
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                succesful = false;
            }
            return succesful;
        }

        public void Close()
        {
            db.Close();
        }

        public static bool CreateFile(string dbPath)
        {
            try
            {
                SQLiteConnection createDb = new SQLiteConnection(dbPath);
                createDb.CreateTable<Artikel>();
                createDb.CreateTable<Person>();
                createDb.CreateTable<Handelse>();
            }
            catch(Exception ex)
            {
                Logger.Log(ex);
                return false;
            }
            return true;
        }

        public List<Handelse> HamtaHandelserTESTTESTTEST()
        {
            return db.Table<Handelse>().ToList();
        }

        public List<Artikel> HamtaArtiklar()
        {
            return db.Table<Artikel>()
                .OrderBy(a => a.Besk)
                .ToList();
        }
        public List<Artikel> HamtaLedigaArtiklar()
        {
            return db.Table<Artikel>()
                .Where(a => a.Status == Status.INNE)
                .OrderBy(a => a.Besk)
                .ToList();
        }
        public List<Artikel> HamtaArtiklarFranBesk(string besk)
        {
            return db.Table<Artikel>()
                .Where(a => a.Besk == besk)
                .OrderBy(a => a.Besk)
                .ToList();
        }
        public List<Artikel> HamtaRegistreradeArtiklar(Person person)
        {
            return db.Table<Artikel>()
                .Where(a => a.PersId == person.Id && a.Status == Status.UTE)
                .OrderBy(a => a.Besk)
                .ToList();
        }
        public Artikel HamtaArtikel(int id)
        {
            return db.Table<Artikel>()
                .FirstOrDefault(a => a.Id == id);
        }
        public Artikel HamtaArtikelFranSerieNr(string serieNr)
        {
            return db.Table<Artikel>()
                 .FirstOrDefault(a => a.SerieNr == serieNr);
        }
        public int InfogaArtikel(Artikel artikel)
        {
            return db.Insert(artikel);
        }
        public int UpdateraArtikel(Artikel artikel)
        {
            Artikel a = this.HamtaArtikel(artikel.Id);
            if (a is null)
                return 0;
            a.DatorNamn = artikel.DatorNamn;
            a.StoldTag = artikel.StoldTag;
            a.Os = artikel.Os;
            a.Ovrigt = artikel.Ovrigt;
            return db.Update(a);
        }
        public int RaderaArtikel(Artikel artikel)
        {
            Artikel a = this.HamtaArtikel(artikel.Id);
            return db.Delete(a);
        }
        public int RegisterArtikelToPerson(Person person, Artikel artikel)
        {
            Artikel a = this.HamtaArtikel(artikel.Id);
            Person p = this.HamtaPerson(person.Id);
            if (a is null || p is null)
                return 0;
            a.PersId = p.Id;
            a.Status = Status.UTE;
            return db.Update(a);
        }
        public int AvregistreraArtikelFromPerson(Artikel artikel)
        {
            Artikel a = this.HamtaArtikel(artikel.Id);
            if (a is null)
                return 0;
            a.Status = Status.INNE;
            a.PersId = 0;
            return db.Update(a);
        }

        public List<Person> HamtaPersoner()
        {
            return db.Table<Person>()
                .OrderBy(p => p.Fornamn)
                .ToList();
        }
        public List<Person> HamtaPersonerFranTillhorighet(string tillhorighet)
        {
            return db.Table<Person>()
                .Where(p => p.Tillhorighet == tillhorighet)
                .OrderBy(p => p.Fornamn)
                .ToList();
        }
        public Person HamtaPerson(int? id)
        {
            if (id is null)
                return null;
            return db.Table<Person>()
                .FirstOrDefault(p => p.Id == id);
        }
        public Person HamtaPersonFranPersNr(string persNr)
        {
            return db.Table<Person>()
               .FirstOrDefault(p => p.PersNr == persNr);
        }
        public int InfogaPerson(Person person)
        {
            return db.Insert(person);
        }
        public int UpdateraPerson(Person person)
        {
            Person p = this.HamtaPerson(person.Id);
            if (p is null)
                return 0;
            p.Fornamn = person.Fornamn;
            p.Efternamn = person.Efternamn;
            p.Sign = person.Sign;
            p.Telefon = person.Telefon;
            p.Epost = person.Epost;
            p.Tillhorighet = person.Tillhorighet;
            p.Ovrigt = person.Ovrigt;
            return db.Update(p);
        }
        public int RaderaPerson(Person person)
        {
            Person p = this.HamtaPerson(person.Id);
            if (p is null)
                return 0;
            List<Artikel> registreradeArtiklar = this.HamtaRegistreradeArtiklar(person);
            if (registreradeArtiklar.Any())
            {
                return 0;
            }
            return db.Delete(p);
        }

        public int InfogaHandelse(Handelse handelse)
        {
            return db.Insert(handelse);
        }
        public List<Handelse> HamtaHandelserArtikel(Artikel artikel)
        {
            return db.Table<Handelse>()
                .Where(h => h.ArtikelId == artikel.Id)
                .OrderBy(h => h.Datum)
                .ToList();
        }
        public List<Handelse> HamtaHandelserPerson(Person person)
        {
            return db.Table<Handelse>()
                 .Where(h => h.PersId == person.Id)
                 .OrderBy(h => h.Datum)
                 .ToList();
        }

        public List<string> GetUniqueBesk()
        {
            List<string> list = db.Table<Artikel>()
                              .Where(a => a.Besk != null)
                              .Select(a => a.Besk)
                              .Distinct()
                              .ToList();
            return list;
        }

        public List<string> GetUniqueOS()
        {
            List<string> list = db.Table<Artikel>()
                               .Where(a => a.Os != null)
                              .Select(a => a.Os)
                              .Distinct()
                              .ToList();
            return list;
        }

        public List<string> GetUniqueTillhorighet()
        {
            List<string> list = db.Table<Person>()
                                .Where(p => p.Tillhorighet != null)
                               .Select(p => p.Tillhorighet)
                               .Distinct()
                               .ToList();
            return list;
        }

        public List<string> GetUniqueHandelser()
        {
            List<string> list = db.Table<Handelse>()
                            .Where(h => h.FriText != null)
                            .Select(h => h.FriText)
                            .Distinct()
                            .ToList();
            return list;
        }
    }
}