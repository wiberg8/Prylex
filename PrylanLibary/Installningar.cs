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

        public string Databas { get; set; }
        public string DatabasBackup { get; set; }
        public string ForetagsNamn { get; set; }
        public string Skrivare { get; set; }
        public bool BackupOnStart { get; set; }

        public List<string> Beskrivningar { get; set; } = new List<string>();
        public List<string> Os { get; set; } = new List<string>();
        public List<string> Tillhorigheter { get; set; } = new List<string>();
        public List<string> Handelser { get; set; } = new List<string>();

        public string NuvarandeLicens { get; set; }
        public DateTime SenasteDatum { get; set; }

        public void TriggerChangeEvent()
        {
            if (Change != null)
                Change.Invoke(this, new EventArgs());
        }

        public void Ladda()
        {
            Installningar installningar;
            try
            {
                string lastinfo = File.ReadAllText(FileName);
                installningar = JsonConvert.DeserializeObject<Installningar>(lastinfo);
            }
            catch
            {
                installningar = null;
            }
            if (installningar != null)
            {
                SetThisAsAnother(installningar);
            }
        }

        public void Spara()
        {
            try
            {
                string installningarEncoded = JsonConvert.SerializeObject(this, Formatting.Indented);
                Console.WriteLine(installningarEncoded);
                File.WriteAllText(FileName, installningarEncoded);
            }
            catch
            {

            }

        }

        private void SetThisAsAnother(Installningar another)
        {
            this.Databas = another.Databas;
            this.DatabasBackup = another.DatabasBackup;
            this.ForetagsNamn = another.ForetagsNamn;
            this.Skrivare = another.Skrivare;
            this.BackupOnStart = another.BackupOnStart;
            this.Beskrivningar = another.Beskrivningar;
            this.Os = another.Os;
            this.Tillhorigheter = another.Tillhorigheter;
            this.Handelser = another.Handelser;
        }

    }
}
