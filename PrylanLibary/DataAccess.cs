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

        public List<Artikel> HamtaArtiklar()
        {
            List<Artikel> hamtadeArtiklar = new List<Artikel>();

            dbHandler.ExecQuery("SELECT * FROM artiklar ORDER BY Id");
            FyllArtikelLista(hamtadeArtiklar, dbHandler.DBDT);
            return hamtadeArtiklar;
        }
        public List<Artikel> HamtaLedigaArtiklar()
        {
            List<Artikel> hamtadeArtiklar = new List<Artikel>();

            dbHandler.AddParam("@Status", Status.INNE);
            dbHandler.ExecQuery("SELECT * FROM artiklar WHERE Status = @Status");
            FyllArtikelLista(hamtadeArtiklar, dbHandler.DBDT);
            return hamtadeArtiklar;
        }
        public List<Artikel> HamtaSokArtiklar(string sok)
        {
            List<Artikel> hamtadeArtiklar = new List<Artikel>();

            dbHandler.AddParam("@Sok", $"{sok}%");
            dbHandler.ExecQuery("SELECT * FROM artiklar WHERE Id LIKE @Sok OR Besk LIKE @Sok OR Stoldtag LIKE @Sok OR Datornamn LIKE @Sok OR SerieNr LIKE @Sok OR Mac LIKE @Sok OR Os LIKE @Sok OR Inkop LIKE @Sok OR Ovrigt LIKE @Sok ORDER BY Id");
            FyllArtikelLista(hamtadeArtiklar, dbHandler.DBDT);
            return hamtadeArtiklar;
        }
        public List<Artikel> HamtaSokArtiklarLediga(string sok)
        {
            List<Artikel> hamtadeArtiklar = new List<Artikel>();

            dbHandler.AddParam("@Sok", $"{sok}%");
            dbHandler.AddParam("@Status", Status.INNE);
            dbHandler.ExecQuery("SELECT * FROM artiklar WHERE (Id LIKE @Sok OR Besk LIKE @Sok OR Stoldtag LIKE @Sok OR Datornamn LIKE @Sok OR SerieNr LIKE @Sok OR Mac LIKE @Sok OR Os LIKE @Sok OR Inkop LIKE @Sok OR Ovrigt LIKE @Sok) AND Status = @Status ORDER BY Id");
            FyllArtikelLista(hamtadeArtiklar, dbHandler.DBDT);
            return hamtadeArtiklar;
        }
        public Artikel HamtaArtikelFranId(int Id)
        {
            dbHandler.AddParam("@Id", Id);
            dbHandler.ExecQuery("SELECT * FROM artiklar WHERE Id=@Id");
            if (dbHandler.DBDT is null)
                return null;
            if (dbHandler.DBDT.Rows.Count > 0)
            {
                var R = dbHandler.DBDT.Rows[0];
                try
                {
                    Artikel a = new Artikel(int.Parse(R["Id"].ToString()))
                    {
                        Beskrivning = R["Besk"].ToString(),
                        StoldTag = R["Stoldtag"].ToString(),
                        DatorNamn = R["Datornamn"].ToString(),
                        SerieNr = R["SerieNr"].ToString(),
                        Mac = R["Mac"].ToString(),
                        Os = R["Os"].ToString(),
                        Inkop = R["Inkop"].ToString()
                    };
                    a.Ovrigt = R["Ovrigt"].ToString();
                    a.Status = (Status)int.Parse(R["Status"].ToString());
                    if (int.TryParse(R["PersId"].ToString(), out int parsedPersId))
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
            return null;
        }
        public Artikel HamtaArtikelFranSerieNr(string serieNr)
        {
            dbHandler.AddParam("@SerieNr", serieNr);
            dbHandler.ExecQuery("SELECT * FROM artiklar WHERE SerieNr=@SerieNr");
            if (dbHandler.DBDT is null)
                return null;
            if (dbHandler.DBDT.Rows.Count > 0)
            {
                var R = dbHandler.DBDT.Rows[0];
                try
                {
                    Artikel a = new Artikel(int.Parse(R["Id"].ToString()))
                    {
                        Beskrivning = R["Besk"].ToString(),
                        StoldTag = R["Stoldtag"].ToString(),
                        DatorNamn = R["Datornamn"].ToString(),
                        SerieNr = R["SerieNr"].ToString(),
                        Mac = R["Mac"].ToString(),
                        Os = R["Os"].ToString(),
                        Inkop = R["Inkop"].ToString()
                    };
                    a.Ovrigt = R["Ovrigt"].ToString();
                    a.Status = (Status)int.Parse(R["Status"].ToString());
                    if (int.TryParse(R["PersId"].ToString(), out int parsedPersId))
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
            return null;
        }
        public void InfogaArtikel(Artikel artikel)
        {
            dbHandler.AddParam("@Besk", artikel.Beskrivning);
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
            dbHandler.AddParam("@Besk", artikel.Beskrivning);
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
        public void UnregisterArtikelFromPerson(Artikel artikel)
        {
            dbHandler.AddParam("@Id", artikel.Id);
            dbHandler.AddParam("@Status", Status.INNE);
            dbHandler.ExecQuery("UPDATE artiklar SET PersId=null,Status=@Status WHERE Id=@Id");
        }
        public List<Artikel> HamtaRegistreradeArtiklar(Person person)
        {
            List<Artikel> personArtiklar = new List<Artikel>();
            dbHandler.AddParam("@pId", person.Id);
            dbHandler.AddParam("@Status", Status.UTE);
            dbHandler.ExecQuery("SELECT * FROM artiklar WHERE PersId = @pId AND Status = @Status");
            FyllArtikelLista(personArtiklar, dbHandler.DBDT);
            return personArtiklar;
        }
        public List<Artikel> HamtaSokRegistreradeArtiklar(Person person, string sok)
        {
            List<Artikel> personArtiklar = new List<Artikel>();
            dbHandler.AddParam("@pId", person.Id);
            dbHandler.AddParam("@Status", Status.UTE);
            dbHandler.AddParam("@Sok", $"{sok}%");
            dbHandler.ExecQuery("SELECT * FROM artiklar WHERE (Id LIKE @Sok OR Besk LIKE @Sok OR Stoldtag LIKE @Sok OR Datornamn LIKE @Sok OR SerieNr LIKE @Sok OR Mac LIKE @Sok OR Os LIKE @Sok OR Inkop LIKE @Sok OR Ovrigt LIKE @Sok) AND PersId = @pId AND Status = @Status ORDER BY Id");
            FyllArtikelLista(personArtiklar, dbHandler.DBDT);
            return personArtiklar;
        }

        public List<Person> HamtaPersoner()
        {
            var hamtadePersoner = new List<Person>();

            dbHandler.ExecQuery("SELECT * FROM personer ORDER BY Id");
            FyllPersonLista(hamtadePersoner, dbHandler.DBDT);
            return hamtadePersoner;
        }
        public List<Person> HamtaSokPersoner(string sok)
        {
            var hamtadePersoner = new List<Person>();
            dbHandler.AddParam("@Sok", $"{sok}%");
            dbHandler.ExecQuery("SELECT * FROM personer WHERE Id LIKE @Sok OR Fornamn LIKE @Sok OR Efternamn LIKE @Sok OR PersNr LIKE @Sok OR Sign LIKE @Sok OR Tillhorighet LIKE @Sok OR Telefon LIKE @Sok OR Epost LIKE @Sok OR Ovrigt LIKE @Sok ORDER BY Id");
            FyllPersonLista(hamtadePersoner, dbHandler.DBDT);
            return hamtadePersoner;
        }
        public List<Person> HamtaPersonerFranTillhorighet(string tillhorighet)
        {
            var hamtadePersoner = new List<Person>();

            dbHandler.AddParam("@Tillhorighet", tillhorighet);
            dbHandler.ExecQuery("SELECT * FROM personer WHERE Tillhorighet = @Tillhorighet ORDER BY Id");
            FyllPersonLista(hamtadePersoner, dbHandler.DBDT);
            return hamtadePersoner;
        }
        public Person HamtaPersonFranId(int Id)
        {
            dbHandler.AddParam("@Id", Id);
            dbHandler.ExecQuery("SELECT * FROM personer WHERE Id=@Id");
            if (dbHandler.DBDT is null)
                return null;

            if (dbHandler.DBDT.Rows.Count > 0)
            {
                DataRow R = dbHandler.DBDT.Rows[0];
                try
                {
                    Person p = new Person(int.Parse(R["Id"].ToString()))
                    {
                        Fornamn = R["Fornamn"].ToString(),
                        Efternamn = R["Efternamn"].ToString(),
                        PersNr = R["PersNr"].ToString(),
                        Sign = R["Sign"].ToString(),
                        Tillhorighet = R["Tillhorighet"].ToString(),
                        Telefon = R["Telefon"].ToString(),
                        Ovrigt = R["Ovrigt"].ToString(),
                        Epost = R["Epost"].ToString()
                    };
                    return p;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return null;
        }
        public Person HamtaPersonFranPersNr(string persNr)
        {
            dbHandler.AddParam("@PersNr", persNr);
            dbHandler.ExecQuery("SELECT * FROM personer WHERE PersNr=@PersNr");
            if (dbHandler.DBDT is null)
                return null;

            if (dbHandler.DBDT.Rows.Count > 0)
            {
                DataRow R = dbHandler.DBDT.Rows[0];
                try
                {
                    Person p = new Person(int.Parse(R["Id"].ToString()))
                    {
                        Fornamn = R["Fornamn"].ToString(),
                        Efternamn = R["Efternamn"].ToString(),
                        PersNr = R["PersNr"].ToString(),
                        Sign = R["Sign"].ToString(),
                        Tillhorighet = R["Tillhorighet"].ToString(),
                        Telefon = R["Telefon"].ToString(),
                        Ovrigt = R["Ovrigt"].ToString(),
                        Epost = R["Epost"].ToString()
                    };
                    return p;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return null;
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
        public List<Handelse> HamtaHandelserArtikel(Artikel artikel)
        {
            List<Handelse> hamtadeHandelser = new List<Handelse>();
            dbHandler.AddParam("@ArtikelId", artikel.Id);
            dbHandler.ExecQuery("SELECT * FROM handelser WHERE ArtikelId=@ArtikelId ORDER BY Datum DESC");
            FyllHandelseLista(hamtadeHandelser, dbHandler.DBDT);
            return hamtadeHandelser;
        }
        public List<Handelse> HamtaHandelserPerson(Person person)
        {
            List<Handelse> hamtadeHandelser = new List<Handelse>();
            dbHandler.AddParam("@PersId", person.Id);
            dbHandler.ExecQuery("SELECT * FROM handelser WHERE PersId=@PersId ORDER BY Id DESC");
            FyllHandelseLista(hamtadeHandelser, dbHandler.DBDT);
            return hamtadeHandelser;
        }

        //public Artikel ParseSingleArtikelRowInDataTable(DataTable dbdt)
        //{
        //    if (dbdt is null)
        //        return null;
        //    if (dbdt.Rows.Count > 0)
        //    {
        //        DataRow R = dbdt.Rows[0];
        //        try
        //        {

        //            Artikel a = new Artikel(int.Parse(R["Id"].ToString()))
        //            {
        //                Beskrivning = R["Besk"].ToString(),
        //                StoldTag = R["Stoldtag"].ToString(),
        //                DatorNamn = R["Datornamn"].ToString(),
        //                SerieNr = R["SerieNr"].ToString(),
        //                Mac = R["Mac"].ToString(),
        //                Os = R["Os"].ToString(),
        //                Inkop = R["Inkop"].ToString()
        //            };
        //            a.Ovrigt = R["Ovrigt"].ToString();
        //            a.Status = (Status)int.Parse(R["Status"].ToString());
        //            if (int.TryParse(R["PersId"].ToString(), out int parsedPersId))
        //            {
        //                a.PersId = parsedPersId;
        //            }
        //            return a;
        //        }
        //        catch
        //        {
        //            return null;
        //        }
        //    }

        //}

        private void FyllPersonLista(List<Person> lista, DataTable dbdt)
        {
            if (dbdt is null)
                return;
            foreach (DataRow R in dbdt.Rows)
            {
                try
                {
                    Person p = new Person(int.Parse(R["Id"].ToString()))
                    {
                        Fornamn = R["Fornamn"].ToString(),
                        Efternamn = R["Efternamn"].ToString(),
                        PersNr = R["PersNr"].ToString(),
                        Sign = R["Sign"].ToString(),
                        Tillhorighet = R["Tillhorighet"].ToString(),
                        Telefon = R["Telefon"].ToString(),
                        Ovrigt = R["Ovrigt"].ToString(),
                        Epost = R["Epost"].ToString()
                    };
                    lista.Add(p);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        private void FyllArtikelLista(List<Artikel> lista, DataTable dbdt)
        {
            if (dbdt is null)
                return;
            foreach (DataRow R in dbdt.Rows)
            {
                try
                {
                    Artikel a = new Artikel(int.Parse(R["Id"].ToString()))
                    {
                        Beskrivning = R["Besk"].ToString(),
                        StoldTag = R["Stoldtag"].ToString(),
                        DatorNamn = R["Datornamn"].ToString(),
                        SerieNr = R["SerieNr"].ToString(),
                        Mac = R["Mac"].ToString(),
                        Os = R["Os"].ToString(),
                        Inkop = R["Inkop"].ToString()
                    };
                    a.Ovrigt = R["Ovrigt"].ToString();
                    a.Status = (Status)int.Parse(R["Status"].ToString());
                    if (int.TryParse(R["PersId"].ToString(), out int parsedPersId))
                    {
                        a.PersId = parsedPersId;
                    }
                    lista.Add(a);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        private void FyllHandelseLista(List<Handelse> lista, DataTable dbdt)
        {
            if (dbdt is null)
                return;
            foreach (DataRow R in dbdt.Rows)
            {
                try
                {
                    Handelse handelse = new Handelse()
                    {
                        Id = int.Parse(R["Id"].ToString()),
                        ArtikelId = int.Parse(R["ArtikelId"].ToString()),
                        PersId = int.Parse(R["PersId"].ToString()),
                        Typ = (HandelseTyp)int.Parse(R["Typ"].ToString()),
                        FriText = R["FriText"].ToString(),
                        Datum = DateTime.Parse(R["Datum"].ToString())
                    };
                    lista.Add(handelse);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}