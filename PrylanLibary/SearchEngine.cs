using PrylanLibary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PrylanLibary
{
    public static class SearchEngine
    {
        private static string currentSearchQuery;
        public static IEnumerable<Artikel> Search(List<Artikel> artiklar, string searchQuery)
        {
            currentSearchQuery = searchQuery.ToLower();
            foreach (Artikel artikel in artiklar)
            {
                bool search = Search(artikel.Id.ToString())
                    || Search(artikel.Besk)
                    || Search(artikel.SerieNr)
                    || Search(artikel.StoldTag)
                    || Search(artikel.Os)
                    || Search(artikel.Mac)
                    || Search(artikel.DatorNamn);
                if (search)
                {
                    yield return artikel;
                }
            }
        }

        public static IEnumerable<Person> Search(List<Person> personer, string searchQuery)
        {
            currentSearchQuery = searchQuery.ToLower();
            foreach (Person person in personer)
            {
                bool search = Search(person.Id.ToString())
                      || Search(person.Fornamn)
                      || Search(person.Efternamn)
                      || Search(person.PersNr)
                      || Search(person.Sign)
                      || Search(person.Tillhorighet)
                      || Search(person.Telefon);
                if (search)
                {
                    yield return person;
                }
            }
        }
         
        private static bool Search(string x)
        {
            if (currentSearchQuery == string.Empty && x is null)
            {
                return true;
            }
            if (x is null)
            {
                return false;
            }
            string lowered = x.ToLower().RemoveWhiteSpaces();
            return x == currentSearchQuery 
                || lowered.StartsWith(currentSearchQuery) 
                || lowered.Contains(currentSearchQuery) 
                || lowered.EndsWith(currentSearchQuery);
        }
    }
}
