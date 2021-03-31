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
        public static string exception;
        private static string LabelFileName = "Prylan.label";

        public static void PrintSerieNrLabel(string serieNr, string printer)
        {
            try
            {
                var label = Label.Open("SerieNr.label");
                label.SetObjectText("dynSerieNr", serieNr);
                label.Print(printer);
            }
            catch (Exception ex)
            {
                exception = ex.Message;
            }
        }

        public static void PrintLabel(Artikel artikel, Person person, string printer)
        {
            try
            {
                var label = Label.Open(LabelFileName);
                label.SetObjectText("dynDatorNamn", artikel.DatorNamn);
                label.SetObjectText("dynSerieNr", artikel.SerieNr);
                label.SetObjectText("dynNamn", person.GetNamn());
                label.SetObjectText("dynTillhorighet", person.Tillhorighet);
                label.Print(printer);
            }
            catch (Exception ex)
            {
                exception = ex.Message;
            }
        }

        public static List<string> GetPrinters()
        {
            return System.Drawing.Printing.PrinterSettings.InstalledPrinters.Cast<string>().ToList();
        }
    }
}
