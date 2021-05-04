using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using PrylanLibary.Enums;
using PrylanLibary.Models;

namespace PrylanLibary
{
    public class DataAccess
    {
        private readonly DBHandler dbHandler = new DBHandler();
        private string currentFile;
        public string CurrentFile { get { return currentFile; } set { dbHandler.SetConnection(value, ConnectionChanged); currentFile = value; } }
        public EventHandler ConnectionChanged { get; set; }
        public int LastInsertRowId { get { return dbHandler.GetLastInsertId(); } }

        public EventHandler ArtikelChange { get; set; }
        public EventHandler PersonChange { get; set; }

        public bool TryOpen()
        {
            return dbHandler.TryOpen();
        }

        public void Close()
        {
            dbHandler.Close();
        }

        public bool CreateFile(string fileName)
        {
            return dbHandler.CreateFile(fileName);
        }

        public List<string> GetUniqueBesk()
        {
            List<Artikel> artiklar = new List<Artikel>();
            List<string> beskrivningar = new List<string>();
            dbHandler.ExecQuery("SELECT DISTINCT Besk FROM artiklar");
            if(dbHandler.DBDT != null)
            {
                foreach (DataRow R in dbHandler.DBDT.Rows)
                {
                    if (!string.IsNullOrWhiteSpace(R["Besk"].ToString()))
                    {
                        beskrivningar.Add(R["Besk"].ToString());
                    }
                }
            }
            return beskrivningar;
        }
        public List<string> GetUniqueOS()
        {
            List<Artikel> artiklar = new List<Artikel>();
            List<string> Os = new List<string>();
            dbHandler.ExecQuery("SELECT DISTINCT Os FROM artiklar");
            if (dbHandler.DBDT != null)
            {
                foreach (DataRow R in dbHandler.DBDT.Rows)
                {
                    if (!string.IsNullOrWhiteSpace(R["Os"].ToString()))
                    {
                        Os.Add(R["Os"].ToString());
                    }
                }
            }
            return Os;
        }
        public List<string> GetUniqueTillhorighet()
        {
            List<Artikel> artiklar = new List<Artikel>();
            List<string> tillhorighet = new List<string>();
            dbHandler.ExecQuery("SELECT DISTINCT Tillhorighet FROM personer");
            if (dbHandler.DBDT != null)
            {
                foreach (DataRow R in dbHandler.DBDT.Rows)
                {
                    if (!string.IsNullOrWhiteSpace(R["Tillhorighet"].ToString()))
                    {
                        tillhorighet.Add(R["Tillhorighet"].ToString());
                    }
                }
            }
            return tillhorighet;
        }
        public List<string> GetUniqueHandelser()
        {
            List<Artikel> artiklar = new List<Artikel>();
            List<string> handelser = new List<string>();
            dbHandler.ExecQuery("SELECT DISTINCT FriText FROM handelser");
            if (dbHandler.DBDT != null)
            {
                foreach (DataRow R in dbHandler.DBDT.Rows)
                {
                    if (!string.IsNullOrWhiteSpace(R["FriText"].ToString()))
                    {
                        handelser.Add(R["FriText"].ToString());
                    }
                }
            }
            return handelser;
        }

        public IEnumerable<Artikel> HamtaArtiklar()
        {
            dbHandler.ExecQuery("SELECT * FROM artiklar ORDER BY Id");
            return ParseTableToArtiklar(dbHandler.DBDT);
        }
        public IEnumerable<Artikel> HamtaLedigaArtiklar()
        {
            dbHandler.AddParam("@Status", Status.INNE);
            dbHandler.ExecQuery("SELECT * FROM artiklar WHERE Status = @Status");
            return ParseTableToArtiklar(dbHandler.DBDT);
        }
        public IEnumerable<Artikel> HamtaSokArtiklar(string sok)
        {
            dbHandler.AddParam("@Sok", $"{sok}%");
            dbHandler.ExecQuery("SELECT * FROM artiklar WHERE Id LIKE @Sok OR Besk LIKE @Sok OR Stoldtag LIKE @Sok OR Datornamn LIKE @Sok OR SerieNr LIKE @Sok OR Mac LIKE @Sok OR Os LIKE @Sok OR Inkop LIKE @Sok OR Ovrigt LIKE @Sok ORDER BY Id");
            return ParseTableToArtiklar(dbHandler.DBDT);
        }
        public IEnumerable<Artikel> HamtaSokArtiklarLediga(string sok)
        {
            dbHandler.AddParam("@Sok", $"{sok}%");
            dbHandler.AddParam("@Status", Status.INNE);
            dbHandler.ExecQuery("SELECT * FROM artiklar WHERE (Id LIKE @Sok OR Besk LIKE @Sok OR Stoldtag LIKE @Sok OR Datornamn LIKE @Sok OR SerieNr LIKE @Sok OR Mac LIKE @Sok OR Os LIKE @Sok OR Inkop LIKE @Sok OR Ovrigt LIKE @Sok) AND Status = @Status ORDER BY Id");
            return ParseTableToArtiklar(dbHandler.DBDT);
        }
        public Artikel HamtaArtikelFranId(int Id)
        {
            dbHandler.AddParam("@Id", Id);
            dbHandler.ExecQuery("SELECT * FROM artiklar WHERE Id=@Id");
            return FirstArtikelFromTable();
        }

        public Artikel HamtaArtikelFranSerieNr(string serieNr)
        {
            dbHandler.AddParam("@SerieNr", serieNr);
            dbHandler.ExecQuery("SELECT * FROM artiklar WHERE SerieNr=@SerieNr");
            if (dbHandler.DBDT is null)
                return null;
            return FirstArtikelFromTable();
        }

        public void InfogaArtikel(Artikel artikel)
        {
            dbHandler.AddParam("@Besk", artikel.Besk);
            dbHandler.AddParam("@Stoldtag", artikel.StoldTag);
            dbHandler.AddParam("@Datornamn", artikel.DatorNamn);
            dbHandler.AddParam("@SerieNr", artikel.SerieNr);
            dbHandler.AddParam("@Mac", artikel.Mac);
            dbHandler.AddParam("@Os", artikel.Os);
            dbHandler.AddParam("@Inkop", artikel.Inkop);
            dbHandler.AddParam("@Ovrigt", artikel.Ovrigt);
            dbHandler.ExecQuery("INSERT INTO artiklar (Besk,Stoldtag,Datornamn,SerieNr,Mac,Os,Inkop,Ovrigt) VALUES(@Besk,@Stoldtag,@Datornamn,@SerieNr,@Mac,@Os,@Inkop,@Ovrigt)");
            if (ArtikelChange != null)
                ArtikelChange.Invoke(artikel, new EventArgs());
        }
        public void UpdateraArtikel(Artikel artikel)
        {
            dbHandler.AddParam("@Besk", artikel.Besk);
            dbHandler.AddParam("@Stoldtag", artikel.StoldTag);
            dbHandler.AddParam("@Datornamn", artikel.DatorNamn);
            dbHandler.AddParam("@SerieNr", artikel.SerieNr);
            dbHandler.AddParam("@Mac", artikel.Mac);
            dbHandler.AddParam("@Os", artikel.Os);
            dbHandler.AddParam("@Ovrigt", artikel.Ovrigt);
            dbHandler.AddParam("@Id", artikel.Id);
            dbHandler.ExecQuery("UPDATE artiklar SET Besk=@Besk,Stoldtag=@Stoldtag,Datornamn=@Datornamn,SerieNr=@SerieNr,Mac=@Mac,Os=@Os,Ovrigt=@Ovrigt WHERE Id=@Id");
            if (ArtikelChange != null)
                ArtikelChange.Invoke(artikel, new EventArgs());
        }
        public bool ExisterarArtikel(Artikel artikel)
        {
            dbHandler.AddParam("@SerieNr", artikel.SerieNr);
            dbHandler.AddParam("@Id", artikel.Id);
            dbHandler.ExecQuery("SELECT SerieNr FROM artiklar WHERE UPPER(SerieNr)=UPPER(@SerieNr) AND SerieNr <> '' AND NOT Id=@Id");

            return dbHandler.RecordCount > 0;
        }
        public void RaderaArtikel(Artikel artikel)
        {
            dbHandler.AddParam("@Id", artikel.Id);
            dbHandler.ExecQuery("DELETE FROM artiklar WHERE Id=@Id");
        }
        public void RegisterArtikelToPerson(Person person, Artikel artikel)
        {
            dbHandler.AddParam("@pId", person.Id);
            dbHandler.AddParam("@aId", artikel.Id);
            dbHandler.AddParam("@Status", Status.UTE);
            dbHandler.ExecQuery("UPDATE artiklar SET PersId=@pId,Status=@Status WHERE Id=@aId");
        }
        public void AvregistreraArtikelFromPerson(Artikel artikel)
        {
            dbHandler.AddParam("@Id", artikel.Id);
            dbHandler.AddParam("@Status", Status.INNE);
            dbHandler.ExecQuery("UPDATE artiklar SET PersId=null,Status=@Status WHERE Id=@Id");
        }
        public IEnumerable<Artikel> HamtaRegistreradeArtiklar(Person person)
        {
            dbHandler.AddParam("@pId", person.Id);
            dbHandler.AddParam("@Status", Status.UTE);
            dbHandler.ExecQuery("SELECT * FROM artiklar WHERE PersId = @pId AND Status = @Status");
            return ParseTableToArtiklar(dbHandler.DBDT);
        }
        public IEnumerable<Artikel> HamtaSokRegistreradeArtiklar(Person person, string sok)
        {
            dbHandler.AddParam("@pId", person.Id);
            dbHandler.AddParam("@Status", Status.UTE);
            dbHandler.AddParam("@Sok", $"{sok}%");
            dbHandler.ExecQuery("SELECT * FROM artiklar WHERE (Id LIKE @Sok OR Besk LIKE @Sok OR Stoldtag LIKE @Sok OR Datornamn LIKE @Sok OR SerieNr LIKE @Sok OR Mac LIKE @Sok OR Os LIKE @Sok OR Inkop LIKE @Sok OR Ovrigt LIKE @Sok) AND PersId = @pId AND Status = @Status ORDER BY Id");
            return ParseTableToArtiklar(dbHandler.DBDT);
        }

        public IEnumerable<Person> HamtaPersoner()
        {
            dbHandler.ExecQuery("SELECT * FROM personer ORDER BY Id");
            return ParseTableToPersoner(dbHandler.DBDT);
        }
        public IEnumerable<Person> HamtaSokPersoner(string sok)
        {
            dbHandler.AddParam("@Sok", $"{sok}%");
            dbHandler.ExecQuery("SELECT * FROM personer WHERE Id LIKE @Sok OR Fornamn LIKE @Sok OR Efternamn LIKE @Sok OR PersNr LIKE @Sok OR Sign LIKE @Sok OR Tillhorighet LIKE @Sok OR Telefon LIKE @Sok OR Epost LIKE @Sok OR Ovrigt LIKE @Sok ORDER BY Id");
            return ParseTableToPersoner(dbHandler.DBDT);
        }
        public IEnumerable<Person> HamtaPersonerFranTillhorighet(string tillhorighet)
        {
            dbHandler.AddParam("@Tillhorighet", tillhorighet);
            dbHandler.ExecQuery("SELECT * FROM personer WHERE Tillhorighet = @Tillhorighet ORDER BY Id");
            return ParseTableToPersoner(dbHandler.DBDT);
        }
        public Person HamtaPersonFranId(int Id)
        {
            dbHandler.AddParam("@Id", Id);
            dbHandler.ExecQuery("SELECT * FROM personer WHERE Id=@Id");
            if (dbHandler.DBDT is null)
                return null;
            return FirstPersonFromTable();
        }

        public Person HamtaPersonFranPersNr(string persNr)
        {
            dbHandler.AddParam("@PersNr", persNr);
            dbHandler.ExecQuery("SELECT * FROM personer WHERE PersNr=@PersNr");
            if (dbHandler.DBDT is null)
                return null;

            return FirstPersonFromTable();
        }

        public void InfogaPerson(Person person)
        {
            dbHandler.AddParam("@Fornamn", person.Fornamn);
            dbHandler.AddParam("@Efternamn", person.Efternamn);
            dbHandler.AddParam("@PersNr", person.PersNr);
            dbHandler.AddParam("@Sign", person.Sign);
            dbHandler.AddParam("@Epost", person.Epost);
            dbHandler.AddParam("@Telefon", person.Telefon);
            dbHandler.AddParam("@Ovrigt", person.Ovrigt);
            dbHandler.AddParam("@Tillhorighet", person.Tillhorighet);
            dbHandler.ExecQuery("INSERT INTO personer (Fornamn,Efternamn,PersNr,Sign,Epost,Telefon,Ovrigt,Tillhorighet) VALUES (@Fornamn,@Efternamn,@PersNr,@Sign,@Epost,@Telefon,@Ovrigt,@Tillhorighet)");
            if (PersonChange != null) 
                PersonChange.Invoke(person, new EventArgs());
        }
        public void UpdateraPerson(Person person)
        {
            dbHandler.AddParam("@Fornamn", person.Fornamn);
            dbHandler.AddParam("@Efternamn", person.Efternamn);
            dbHandler.AddParam("@Sign", person.Sign);
            dbHandler.AddParam("@Epost", person.Epost);
            dbHandler.AddParam("@Telefon", person.Telefon);
            dbHandler.AddParam("@Ovrigt", person.Ovrigt);
            dbHandler.AddParam("@Tillhorighet", person.Tillhorighet);
            dbHandler.AddParam("@Id", person.Id);
            dbHandler.ExecQuery("UPDATE personer SET Fornamn=@Fornamn,Efternamn=@Efternamn,Sign=@Sign,Epost=@Epost,Telefon=@Telefon,Ovrigt=@Ovrigt,Tillhorighet=@Tillhorighet WHERE Id=@Id");
            if (PersonChange != null)
                PersonChange.Invoke(person, new EventArgs());
        }
        public bool ExisterarPerson(string persNr)
        {
            dbHandler.AddParam("@PersNr", persNr);
            dbHandler.ExecQuery("SELECT PersNr FROM personer WHERE PersNr=@PersNr AND PersNr <> '' ");
            return dbHandler.RecordCount > 0;
        }
        public void RaderaPerson(Person person)
        {
            dbHandler.AddParam("@Id", person.Id);
            dbHandler.ExecQuery("DELETE FROM personer WHERE Id=@Id");
            dbHandler.AddParam("@PersId", person.Id);
            dbHandler.AddParam("@Status", Status.INNE);
            dbHandler.ExecQuery("UPDATE artiklar SET PersId=NULL,Status=@Status WHERE PersId=@PersId");
        }

        public void InfogaHandelse(Handelse handelse)
        {
            dbHandler.AddParam("@ArtikelId", handelse.ArtikelId);
            dbHandler.AddParam("@PersId", handelse.PersId);
            dbHandler.AddParam("@Typ", handelse.Typ);
            dbHandler.AddParam("@FriText", handelse.FriText);
            dbHandler.AddParam("@Datum", handelse.Datum);
            dbHandler.ExecQuery("INSERT INTO handelser (ArtikelId,PersId,Typ,FriText,Datum) VALUES (@ArtikelId,@PersId,@Typ,@FriText,@Datum)");
        }
        public IEnumerable<Handelse> HamtaHandelserArtikel(Artikel artikel)
        {
            dbHandler.AddParam("@ArtikelId", artikel.Id);
            dbHandler.ExecQuery("SELECT * FROM handelser WHERE ArtikelId=@ArtikelId ORDER BY Datum DESC");
            return ParseTableToHandelser(dbHandler.DBDT);
        }
        public IEnumerable<Handelse> HamtaHandelserPerson(Person person)
        {
            dbHandler.AddParam("@PersId", person.Id);
            dbHandler.ExecQuery("SELECT * FROM handelser WHERE PersId=@PersId ORDER BY Id DESC");
            return ParseTableToHandelser(dbHandler.DBDT);
        }

        public List<string> GetAllTables()
        {
            return dbHandler.GetAllTables();
        }

        public List<string> GetColumnsByTableName(string tableName)
        {
            return dbHandler.GetColumnsByTableName(tableName);
        }

        private Artikel FirstArtikelFromTable()
        {
            if (dbHandler.DBDT is null)
                return null;
            if (dbHandler.DBDT.Rows.Count > 0)
            {
                return dbHandler.DBDT.Rows[0].ParseToArtikel();
            }
            return null;
        }
        private Person FirstPersonFromTable()
        {
            if (dbHandler.DBDT is null)
                return null;
            if (dbHandler.DBDT.Rows.Count > 0)
            {
                return dbHandler.DBDT.Rows[0].ParseToPerson();
            }
            return null;
        }

        private IEnumerable<Artikel> ParseTableToArtiklar(DataTable table)
        {
            if (table is null)
                yield break;
            foreach (DataRow r in table.Rows)
            {
                Artikel artikel = r.ParseToArtikel();
                if (artikel != null)
                {
                    yield return artikel;
                }
            }
        }

        private IEnumerable<Handelse> ParseTableToHandelser(DataTable table)
        {
            if (table is null)
                yield break;
            foreach (DataRow r in table.Rows)
            {
                Handelse handelse = r.ParseToHandelse();
                if (handelse != null)
                {
                    yield return handelse;
                }
            }
        }

        private IEnumerable<Person> ParseTableToPersoner(DataTable table)
        {
            if (table is null)
                yield break;
            foreach (DataRow r in table.Rows)
            {
                Person person = r.ParseToPerson();
                if (person != null)
                {
                    yield return person;
                }
            }
        }
    }
}