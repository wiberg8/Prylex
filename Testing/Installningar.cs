using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Testing
{
    public class Installningar
    {
        public event EventHandler Change;
        public static string FileName { get; set; }

        public string Databas { get; set; } = string.Empty;
        public string DatabasBackup { get; set; } = string.Empty;
        public string ForetagsNamn { get; set; } = string.Empty;
        public string Skrivare { get; set; } = string.Empty;
        public bool BackupOnStart { get; set; } = false;

      

        private void SetThisAsAnother(Installningar installningar)
        {
            this.Databas = installningar.Databas;
            this.DatabasBackup = installningar.DatabasBackup;
            this.ForetagsNamn = installningar.ForetagsNamn;
            this.Skrivare = installningar.Skrivare;
            this.BackupOnStart = installningar.BackupOnStart;
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
            string installningarEncoded = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(FileName, installningarEncoded);
        }
    }
}
