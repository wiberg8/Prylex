using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using PrylanLibary.Models;

namespace PrylanLibary
{
    public class DataAccess :  System.IDisposable
    {
        public DataAccess()
        {
            DBHandler.TryOpen();
        }

        void IDisposable.Dispose()
        {
            DBHandler.Close();
        }

        public void Close()
        {
            DBHandler.Close();
        }

        public static EventHandler ArtikelChange { get; set; }
        public static EventHandler PersonChange { get; set; }

        public List<Artikel> HamtaArtiklar()
        {
            List<Artikel> hamtadeArtiklar = new List<Artikel>();

            DBHandler.ExecQuery("SELECT * FROM artiklar ORDER BY Id");
            FyllArtikelLista(hamtadeArtiklar, DBHandler.DBDT);
            return hamtadeArtiklar;
        }
        public List<Artikel> HamtaLedigaArtiklar()
        {
            List<Artikel> hamtadeArtiklar = new List<Artikel>();

            DBHandler.AddParam("@Status", Status.INNE);
            DBHandler.ExecQuery("SELECT * FROM artiklar WHERE Status = @Status");
            FyllArtikelLista(hamtadeArtiklar, DBHandler.DBDT);
            return hamtadeArtiklar;
        }
        public List<Artikel> HamtaSokArtiklar(string sok)
        {
            List<Artikel> hamtadeArtiklar = new List<Artikel>();

            DBHandler.AddParam("@Sok", $"{sok}%");
            DBHandler.ExecQuery("SELECT * FROM artiklar WHERE Id LIKE @Sok OR Besk LIKE @Sok OR Stoldtag LIKE @Sok OR Datornamn LIKE @Sok OR SerieNr LIKE @Sok OR Mac LIKE @Sok OR Os LIKE @Sok OR Inkop LIKE @Sok OR Ovrigt LIKE @Sok ORDER BY Id");
            FyllArtikelLista(hamtadeArtiklar, DBHandler.DBDT);
            return hamtadeArtiklar;
        }
        public List<Artikel> HamtaSokArtiklarLediga(string sok)
        {
            List<Artikel> hamtadeArtiklar = new List<Artikel>();

            DBHandler.AddParam("@Sok", $"{sok}%");
            DBHandler.AddParam("@Status", Status.INNE);
            DBHandler.ExecQuery("SELECT * FROM artiklar WHERE (Id LIKE @Sok OR Besk LIKE @Sok OR Stoldtag LIKE @Sok OR Datornamn LIKE @Sok OR SerieNr LIKE @Sok OR Mac LIKE @Sok OR Os LIKE @Sok OR Inkop LIKE @Sok OR Ovrigt LIKE @Sok) AND Status = @Status ORDER BY Id");
            FyllArtikelLista(hamtadeArtiklar, DBHandler.DBDT);
            return hamtadeArtiklar;
        }
        public Artikel HamtaArtikelFranId(int Id)
        {
            DBHandler.AddParam("@Id", Id);
            DBHandler.ExecQuery("SELECT * FROM artiklar WHERE Id=@Id");
            if (DBHandler.DBDT is null)
                return null;
            if (DBHandler.DBDT.Rows.Count > 0)
            {
                var R = DBHandler.DBDT.Rows[0];
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

        public List<Person> HamtaPersoner()
        {
            var hamtadePersoner = new List<Person>();

            DBHandler.ExecQuery("SELECT * FROM personer ORDER BY Id");
            FyllPersonLista(hamtadePersoner, DBHandler.DBDT);
            return hamtadePersoner;
        }
        public List<Person> HamtaSokPersoner(string sok)
        {
            var hamtadePersoner = new List<Person>();
            DBHandler.AddParam("@Sok", $"{sok}%");
            DBHandler.ExecQuery("SELECT * FROM personer WHERE Id LIKE @Sok OR Fornamn LIKE @Sok OR Efternamn LIKE @Sok OR PersNr LIKE @Sok OR Sign LIKE @Sok OR Tillhorighet LIKE @Sok OR Telefon LIKE @Sok OR Epost LIKE @Sok OR Ovrigt LIKE @Sok ORDER BY Id");
            FyllPersonLista(hamtadePersoner, DBHandler.DBDT);
            return hamtadePersoner;
        }
        public Person HamtaPersonFranId(int Id)
        {
            DBHandler.AddParam("@Id", Id);
            DBHandler.ExecQuery("SELECT * FROM personer WHERE Id=@Id");
            if (DBHandler.DBDT is null)
                return null;

            if (DBHandler.DBDT.Rows.Count > 0)
            {
                var R = DBHandler.DBDT.Rows[0];
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

        public void RegisterArtikelToPerson(Person person, Artikel artikel)
        {
            DBHandler.AddParam("@pId", person.Id);
            DBHandler.AddParam("@aId", artikel.Id);
            DBHandler.AddParam("@Status", Status.UTE);
            DBHandler.ExecQuery("UPDATE artiklar SET PersId=@pId,Status=@Status WHERE Id=@aId");
        }

        public void UnregisterArtikelFromPerson(Artikel artikel)
        {
            DBHandler.AddParam("@Id", artikel.Id);
            DBHandler.AddParam("@Status", Status.INNE);
            DBHandler.ExecQuery("UPDATE artiklar SET PersId=null,Status=@Status WHERE Id=@Id");
        }

        public List<Artikel> HamtaRegistreradeArtiklar(Person person)
        {
            List<Artikel> personArtiklar = new List<Artikel>();
            DBHandler.AddParam("@pId", person.Id);
            DBHandler.AddParam("@Status", Status.UTE);
            DBHandler.ExecQuery("SELECT * FROM artiklar WHERE PersId = @pId AND Status = @Status");
            FyllArtikelLista(personArtiklar, DBHandler.DBDT);
            return personArtiklar;
        }

        public List<Artikel> HamtaSokRegistreradeArtiklar(Person person, string sok)
        {
            List<Artikel> personArtiklar = new List<Artikel>();
            DBHandler.AddParam("@pId", person.Id);
            DBHandler.AddParam("@Status", Status.UTE);
            DBHandler.AddParam("@Sok", $"{sok}%");
            DBHandler.ExecQuery("SELECT * FROM artiklar WHERE (Id LIKE @Sok OR Besk LIKE @Sok OR Stoldtag LIKE @Sok OR Datornamn LIKE @Sok OR SerieNr LIKE @Sok OR Mac LIKE @Sok OR Os LIKE @Sok OR Inkop LIKE @Sok OR Ovrigt LIKE @Sok) AND PersId = @pId AND Status = @Status ORDER BY Id");
            FyllArtikelLista(personArtiklar, DBHandler.DBDT);
            return personArtiklar;
        }

        public void InfogaArtikel(Artikel artikel)
        {
            DBHandler.AddParam("@Besk",         artikel.Beskrivning);
            DBHandler.AddParam("@Stoldtag",     artikel.StoldTag);
            DBHandler.AddParam("@Datornamn",    artikel.DatorNamn);
            DBHandler.AddParam("@SerieNr",      artikel.SerieNr);
            DBHandler.AddParam("@Mac",          artikel.Mac);
            DBHandler.AddParam("@Os",           artikel.Os);
            DBHandler.AddParam("@Inkop",        artikel.Inkop);
            DBHandler.AddParam("@Ovrigt",       artikel.Ovrigt);
            DBHandler.ExecQuery("INSERT INTO artiklar (Besk,Stoldtag,Datornamn,SerieNr,Mac,Os,Inkop,Ovrigt) VALUES(@Besk,@Stoldtag,@Datornamn,@SerieNr,@Mac,@Os,@Inkop,@Ovrigt)");
            if (ArtikelChange != null)
                ArtikelChange.Invoke(artikel, new EventArgs());
        }
        public void UpdateraArtikel(Artikel artikel)
        {
            DBHandler.AddParam("@Besk", artikel.Beskrivning);
            DBHandler.AddParam("@Stoldtag", artikel.StoldTag);
            DBHandler.AddParam("@Datornamn", artikel.DatorNamn);
            DBHandler.AddParam("@SerieNr", artikel.SerieNr);
            DBHandler.AddParam("@Mac", artikel.Mac);
            DBHandler.AddParam("@Os", artikel.Os);
            DBHandler.AddParam("@Ovrigt", artikel.Ovrigt);
            DBHandler.AddParam("@Id", artikel.Id);
            DBHandler.ExecQuery("UPDATE artiklar SET Besk=@Besk,Stoldtag=@Stoldtag,Datornamn=@Datornamn,SerieNr=@SerieNr,Mac=@Mac,Os=@Os,Ovrigt=@Ovrigt WHERE Id=@Id");
            if (ArtikelChange != null)
                ArtikelChange.Invoke(artikel, new EventArgs());
        }
        public bool ExisterarArtikel(Artikel artikel)
        {
            DBHandler.AddParam("@SerieNr", artikel.SerieNr);
            DBHandler.AddParam("@Id", artikel.Id);
            DBHandler.ExecQuery("SELECT SerieNr FROM artiklar WHERE UPPER(SerieNr)=UPPER(@SerieNr) AND SerieNr <> '' AND NOT Id=@Id");

            return DBHandler.RecordCount > 0;
        }
        public void RaderaArtikel(Artikel artikel)
        {
            DBHandler.AddParam("@Id", artikel.Id);
            DBHandler.ExecQuery("DELETE FROM artiklar WHERE Id=@Id");
        }

        public void InfogaPerson(Person person)
        {
            DBHandler.AddParam("@Fornamn", person.Fornamn);
            DBHandler.AddParam("@Efternamn", person.Efternamn);
            DBHandler.AddParam("@PersNr", person.PersNr);
            DBHandler.AddParam("@Sign", person.Sign);
            DBHandler.AddParam("@Epost", person.Epost);
            DBHandler.AddParam("@Telefon", person.Telefon);
            DBHandler.AddParam("@Ovrigt", person.Ovrigt);
            DBHandler.AddParam("@Tillhorighet", person.Tillhorighet);
            DBHandler.ExecQuery("INSERT INTO personer (Fornamn,Efternamn,PersNr,Sign,Epost,Telefon,Ovrigt,Tillhorighet) VALUES (@Fornamn,@Efternamn,@PersNr,@Sign,@Epost,@Telefon,@Ovrigt,@Tillhorighet)");
            if (PersonChange != null)
                PersonChange.Invoke(person, new EventArgs());
        }
        public void UpdateraPerson(Person person)
        {
            DBHandler.AddParam("@Fornamn", person.Fornamn);
            DBHandler.AddParam("@Efternamn", person.Efternamn);
            DBHandler.AddParam("@Sign", person.Sign);
            DBHandler.AddParam("@Epost", person.Epost);
            DBHandler.AddParam("@Telefon", person.Telefon);
            DBHandler.AddParam("@Ovrigt", person.Ovrigt);
            DBHandler.AddParam("@Tillhorighet", person.Tillhorighet);
            DBHandler.AddParam("@Id", person.Id);
            DBHandler.ExecQuery("UPDATE personer SET Fornamn=@Fornamn,Efternamn=@Efternamn,Sign=@Sign,Epost=@Epost,Telefon=@Telefon,Ovrigt=@Ovrigt,Tillhorighet=@Tillhorighet WHERE Id=@Id");
            if (PersonChange != null)
                PersonChange.Invoke(person, new EventArgs());
        }
        public bool ExisterarPerson(string persNr)
        {
            DBHandler.AddParam("@PersNr", persNr);
            DBHandler.ExecQuery("SELECT PersNr FROM personer WHERE PersNr=@PersNr AND PersNr <> '' ");
            return DBHandler.RecordCount > 0;
        }
        public void RaderaPerson(Person person)
        {
            DBHandler.AddParam("@Id", person.Id);
            DBHandler.ExecQuery("DELETE FROM personer WHERE Id=@Id");
            DBHandler.AddParam("@PersId", person.Id);
            DBHandler.AddParam("@Status", Status.INNE);
            DBHandler.ExecQuery("UPDATE artiklar SET PersId=NULL,Status=@Status WHERE PersId=@PersId");
        }

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
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}