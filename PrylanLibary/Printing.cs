using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DYMO.Label.Framework;

namespace PrylanLibary
{
    public static class Printing
    {
        public static string exception;
        public static void PrintLabel(string datorNamn, string namn, string serieNr, string tillhorighet)
        {
            try
            {
                var label = Label.Open("Prylan.label");
                label.SetObjectText("dynDatorNamn", datorNamn);
                label.SetObjectText("dynNamn", namn);
                label.SetObjectText("dynSerieNr", serieNr);
                label.SetObjectText("dynTillhorighet", tillhorighet);
                label.Print("DYMO LabelWriter 450");
            }
            catch(Exception ex)
            {
                exception = ex.Message;
            }
        }
    }
}
