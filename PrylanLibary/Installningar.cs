using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PrylanLibary
{
    public class Installningar
    {
        public string Databas { get; set; }
        public string DatabasBackup { get; set; }
        public string ForetagsNamn { get; set; }
        public string Skrivare { get; set; }
        public bool BackupOnStart { get; set; }

        public void Ladda()
        {
            Installningar installningar;
            try
            {
                string fileData = File.ReadAllText(Global.INSTALLNINGAR_FILENAME);
                installningar = JsonConvert.DeserializeObject<Installningar>(fileData);
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

        public bool Spara()
        {
            try
            {
                string installningarEncoded = JsonConvert.SerializeObject(this, Formatting.Indented);
                File.WriteAllText(Global.INSTALLNINGAR_FILENAME, installningarEncoded);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void SetThisAsAnother(Installningar another)
        {
            this.Databas = another.Databas;
            this.DatabasBackup = another.DatabasBackup;
            this.ForetagsNamn = another.ForetagsNamn;
            this.Skrivare = another.Skrivare;
            this.BackupOnStart = another.BackupOnStart;
        }

    }
}
