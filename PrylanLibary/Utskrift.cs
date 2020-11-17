using DYMO.Label.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrylanLibary
{
    public static class Utskrift
    {
        public static bool TrySkrivUtEtikett(string inventarieId, string datorNamn, string personNamn)
        {
            bool successPrint = true;
            try
            {
                var label = Label.Open("Etikett.label");
                label.SetObjectText("dynInvId", inventarieId);
                label.SetObjectText("dynDatornamn", datorNamn);
                label.SetObjectText("dynPersonNamn", personNamn);
                label.Print("DYMO LabelWriter 450");
            }
            catch
            {
                successPrint = false;
            }
            return successPrint;
        }

    }
}
