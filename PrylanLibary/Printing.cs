using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DYMO.Label.Framework;
using PrylanLibary.Models;

namespace PrylanLibary
{
    public static class Printing
    {
        public static string Exception { get; set; }
        private const string labelKombo = "Prylan.label";
        private const string labelSerieNr = "SerieNr.label";

        public static bool PrintSerieNrLabel(string serieNr, string printer)
        {
            try
            {
                ILabel label = Label.Open(labelSerieNr);
                label.SetObjectText("dynSerieNr", serieNr);
                label.Print(printer);
            }
            catch (Exception ex)
            {
                Exception = ex.Message;
                return false;
            }
            return true;
        }

        public static bool PrintLabel(Artikel artikel, Person person, string printer)
        {
            try
            {
                ILabel label = Label.Open(labelKombo);
                label.SetObjectText("dynDatorNamn", artikel.DatorNamn);
                label.SetObjectText("dynSerieNr", artikel.SerieNr);
                label.SetObjectText("dynNamn", person.FullName);
                label.SetObjectText("dynTillhorighet", person.Tillhorighet);
                label.Print(printer);
            }
            catch (Exception ex)
            {
                Exception = ex.Message;
                return false;
            }
            return true;
        }

        public static IEnumerable<string> GetPrinters()
        {
            return System.Drawing.Printing.PrinterSettings.InstalledPrinters.Cast<string>();
        }
    }
}
