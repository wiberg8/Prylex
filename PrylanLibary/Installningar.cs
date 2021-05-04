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
        private string _succesfulKundNamn { get; set; }
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
        public string SuccesfulKundNamn { get => _succesfulKundNamn; set => _succesfulKundNamn = value; }
        public List<string> Beskrivningar { get => _beskrivningar; set { _beskrivningar = value; NotifyPropertyChanged(nameof(this.Beskrivningar)); } }
        public List<string> Os { get => _os; set { _os = value; NotifyPropertyChanged(nameof(this.Os)); } }
        public List<string> Tillhorigheter { get => _tillhorigheter; set { _tillhorigheter = value; NotifyPropertyChanged(nameof(this.Tillhorigheter)); } }
        public List<string> Handelser { get => _handelser; set { _handelser = value; NotifyPropertyChanged(nameof(this.Handelser)); } }

        public void AddTillhorighet(string x)
        {
            this.Tillhorigheter.Add(x);
            NotifyPropertyChanged(nameof(this.Tillhorigheter));
        }

        public void AddOs(string x)
        {
            this.Os.Add(x);
            NotifyPropertyChanged(nameof(this.Os));
        }

        public void AddBeskrivning(string x)
        {
            this.Beskrivningar.Add(x);
            NotifyPropertyChanged(nameof(this.Beskrivningar));
        }

        public void AddHandelse(string x)
        {
            this.Handelser.Add(x);
            NotifyPropertyChanged(nameof(this.Handelser));
        }


        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Ladda()
        {
            Installningar installningar;
            try
            {
                string fileData = File.ReadAllText(FileName);
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
                File.WriteAllText(FileName, installningarEncoded);
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
            this.SuccesfulKundNamn = another.SuccesfulKundNamn;
            this.BackupOnStart = another.BackupOnStart;
            this.Beskrivningar = another.Beskrivningar;
            this.Os = another.Os;
            this.Tillhorigheter = another.Tillhorigheter;
            this.Handelser = another.Handelser;
        }

    }
}
