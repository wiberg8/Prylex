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
    public class Installningar : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public static string FileName { get; set; }

        private string _databas;
        private string _databasBackup;
        private string _foretagsNamn;
        private string _skrivare;
        private bool _backupOnStart;
        private List<string> _beskrivningar = new List<string>();
        private List<string> _os = new List<string>();
        private List<string> _tillhorigheter = new List<string>();
        private List<string> _handelser = new List<string>();

        public string Databas { get { return _databas; } set { _databas = value; NotifyPropertyChanged(); } }
        public string DatabasBackup { get { return _databasBackup; } set { _databasBackup = value; NotifyPropertyChanged(); } }
        public string ForetagsNamn { get => _foretagsNamn; set => _foretagsNamn = value; }
        public string Skrivare { get => _skrivare; set => _skrivare = value; }
        public bool BackupOnStart { get => _backupOnStart; set => _backupOnStart = value; }
        public List<string> Beskrivningar { get => _beskrivningar; set => _beskrivningar = value; }
        public List<string> Os { get => _os; set => _os = value; }
        public List<string> Tillhorigheter { get => _tillhorigheter; set { _tillhorigheter = value; NotifyPropertyChanged(); } }
        public List<string> Handelser { get => _handelser; set => _handelser = value; }

        public void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
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
