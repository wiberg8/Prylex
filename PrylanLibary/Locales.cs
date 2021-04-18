using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrylanLibary
{
    public static class Locales
    {
        private const string alreadyRunning = "Applikationen kör redan";
        private const string avregistrering = "Avregistrering";
        private const string registrering = "Registrering";
        private const string areYouSureYouWantToAvregistrera = "Är du säker på att avregistrera artikeln från personen?";
        private const string noPersonBound = "Ingen person knyten till händelsen";
        private const string noArtikelBound = "Ingen artikel knyten till händelsen";
        private const string ingenTraff = "Ingen träff";
        private const string skannaSerieNr = "Skanna - SerieNr";
        private const string couldNotCreateDatabaseFile = "Lyckades ej skapa databasen filen";
        private const string artikelRedanUtlamnad = "Artikeln är redan utlämnad";
        private const string antal = "Antal";
        private const string valjTillhorighet = "Välj tillhörighet";
        private const string valjBeskrivning = "Välj beskrivning";
        private const string visaAlla = "Visa alla";
        private const string kopieraDubbelKlick = "Kopiera (Dubbelklicka)";

        public static string AlreadyRunning => alreadyRunning;
        public static string Avregistrering => avregistrering;
        public static string Registrering => registrering;
        public static string NoPersonBound => noPersonBound;
        public static string NoArtikelBound => noArtikelBound;
        public static string SkannaSerieNr => skannaSerieNr;
        public static string IngenTraff => ingenTraff;
        public static string CouldNotCreateDatabaseFile => couldNotCreateDatabaseFile;
        public static string ArtikelRedanUtlamnad => artikelRedanUtlamnad;
        public static string AreYouSureYouWantToAvregistrera => areYouSureYouWantToAvregistrera;
        public static string Antal => antal;
        public static string ValjTillhorighet => valjTillhorighet;
        public static string ValjBeskrivning => valjBeskrivning;
        public static string VisaAlla => visaAlla;
        public static string KopieraDubbelKlick => kopieraDubbelKlick;
    }
}
