using System.IO;
using Newtonsoft.Json;

namespace PrylanLibary
{
    public class Installningar
    {
        private const string DefaultBusinessName = "Verksamhetsnamn";

        public string Databas { get; set; }
        public string DatabasBackup { get; set; }
        public string ForetagsNamn { get; set; }
        public string Skrivare { get; set; }
        public string BusinessName { get; set; } = DefaultBusinessName;
        public bool BackupOnStart { get; set; }

        public void Ladda()
        {
            Installningar installningar;
            try
            {
                string fileData = File.ReadAllText(Global.INSTALLNINGAR_FILENAME);
                installningar = JsonConvert.DeserializeObject<Installningar>(fileData);
                if (string.IsNullOrWhiteSpace(installningar.BusinessName))
                {
                    installningar.BusinessName = DefaultBusinessName;
                }
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
                string installningarSerialized = JsonConvert.SerializeObject(this, Formatting.Indented);
                File.WriteAllText(Global.INSTALLNINGAR_FILENAME, installningarSerialized);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void SetThisAsAnother(Installningar another)
        {
            Databas = another.Databas;
            DatabasBackup = another.DatabasBackup;
            ForetagsNamn = another.ForetagsNamn;
            BusinessName = another.BusinessName;
            Skrivare = another.Skrivare;
            BackupOnStart = another.BackupOnStart;
        }

    }
}
