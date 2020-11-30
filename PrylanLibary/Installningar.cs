using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PrylanLibary
{
    public class Installningar
    {
        public static event EventHandler Change;
        public static string FileName { get; set; } 

        public string Databas { get; set; } = string.Empty;
        public string DatabasBackup { get; set; } = string.Empty;
        public string ForetagsNamn { get; set; } = string.Empty;

        public List<string> Beskrivningar { get; set; } = new List<string>();
        public List<string> Os { get; set; } = new List<string>();
        public List<string> Tillhorigheter { get; set; } = new List<string>();
        public List<string> Handelser { get; set; } = new List<string>();

        public string NuvarandeLicens { get; set; }
        public DateTime SenasteDatum { get; set; }

        public static void Spara(Installningar installningar)
        {
            string installningarEncoded = JsonConvert.SerializeObject(installningar, Formatting.Indented);
            File.WriteAllText(FileName, installningarEncoded);
            if(Change != null)
                Change.Invoke(installningar, new EventArgs());
        }

        public void Spara()
        {
            string installningarEncoded = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(FileName, installningarEncoded);
            if (Change != null)
                Change.Invoke(this, new EventArgs());
        }

        public static Installningar Hamta()
        {
            Installningar installningar;
            try
            {
                string lastInfo = File.ReadAllText(FileName);
                installningar = JsonConvert.DeserializeObject<Installningar>(lastInfo);
            }
            catch
            {
                installningar = new Installningar();
            }
            if(installningar is null)
            {
                return new Installningar();
            }
            return installningar;
        }
    }
}
