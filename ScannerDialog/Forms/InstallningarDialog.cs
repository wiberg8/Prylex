using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrylanLibary;
using static ScannerDialog.Program;

namespace ScannerDialog
{
    public partial class InstallningarDialog : Form
    {
        private Label clickedLabel;

        public InstallningarDialog()
        {
            InitializeComponent();
            cbForvalValj.SelectedIndex = 0;
            AppSettings.PropertyChanged += Installningar_Change;
        }

        private void Installningar_Change(object sender, EventArgs e)
        {
            var ins = (Installningar)sender;
            FyllDatabasVy(ins.Databas, ins.DatabasBackup, ins.BackupOnStart);
        }

        private void FyllDatabasVy(string database, string databaseBackup, bool backupOnStart)
        {
            laNuvarandeDbDisplay.Text = database;
            laNuvarandeDbBackupDisplay.Text = databaseBackup;
            cbBackupOnStart.Checked = backupOnStart;
        }

        private void InstallningarDialog_Load(object sender, EventArgs e)
        {
            FyllDatabasVy(AppSettings.Databas, AppSettings.DatabasBackup, AppSettings.BackupOnStart);
            foreach (string v in Printing.GetPrinters())
            {
                cbPrinter.Items.Add(v);
            }
            cbPrinter.Text = AppSettings.Skrivare;
        }

        private void cmdForvalUpp_Click(object sender, EventArgs e)
        {
            MoveUp(lbForval);
            SparaForval();
        }

        private void cmdForvalNer_Click(object sender, EventArgs e)
        {
            MoveDown(lbForval);
            SparaForval();
        }

        private void SparaForval()
        {
            List<string> forvalLista = new List<string>();
            foreach (string forval in lbForval.Items)
            {
                forvalLista.Add(forval);
            }
            switch (cbForvalValj.SelectedIndex)
            {
                case 0:    //Beskrivningar
                    AppSettings.Beskrivningar = forvalLista;
                    break;
                case 1:    //Händelser
                    AppSettings.Handelser = forvalLista;
                    break;
                case 2:    //Os
                    AppSettings.Os = forvalLista;
                    break;
                case 3:    //Tillhörighet
                    AppSettings.Tillhorigheter = forvalLista;
                    break;
            }
        }

        private void MoveUp(ListBox myListBox)
        {
            int selectedIndex = myListBox.SelectedIndex;
            if (selectedIndex > 0)
            {
                myListBox.Items.Insert(selectedIndex - 1, myListBox.Items[selectedIndex]);
                myListBox.Items.RemoveAt(selectedIndex + 1);
                myListBox.SelectedIndex = selectedIndex - 1;
            }
        }

        private void MoveDown(ListBox myListBox)
        {
            int selectedIndex = myListBox.SelectedIndex;
            if (selectedIndex < myListBox.Items.Count - 1 & selectedIndex != -1)
            {
                myListBox.Items.Insert(selectedIndex + 2, myListBox.Items[selectedIndex]);
                myListBox.Items.RemoveAt(selectedIndex);
                myListBox.SelectedIndex = selectedIndex + 1;
            }
        }

        private void cbForvalValj_SelectedIndexChanged(object sender, EventArgs e)
        {
            LaddaForval();

        }

        private void cmdForvalLaggTill_Click(object sender, EventArgs e)
        {
            using (InputBox inputDialog = new InputBox())
            {
                inputDialog.ShowDialog();
                if (!string.IsNullOrWhiteSpace(inputDialog.Input))
                {
                    switch (cbForvalValj.SelectedIndex)
                    {
                        case 0:    //Beskrivningar
                            AppSettings.Beskrivningar.Add(inputDialog.Input);
                            break;
                        case 1:    //Händelser
                            AppSettings.Handelser.Add(inputDialog.Input);
                            break;
                        case 2:    //Os
                            AppSettings.Os.Add(inputDialog.Input);
                            break;
                        case 3:    //Tillhörighet
                            AppSettings.Tillhorigheter.Add(inputDialog.Input);
                            break;
                    }
                    LaddaForval();
                }
            }

        }

        private void cmdForvalTabort_Click(object sender, EventArgs e)
        {
            if(lbForval.SelectedIndex != -1)
            {
                lbForval.Items.RemoveAt(lbForval.SelectedIndex);
                switch (cbForvalValj.SelectedIndex)
                {
                    case 0:    //Beskrivningar
                        AppSettings.Beskrivningar = lbForval.Items.Cast<String>().ToList();
                        break;
                    case 1:    //Händelser
                        AppSettings.Handelser = lbForval.Items.Cast<String>().ToList();
                        break;
                    case 2:    //Os
                        AppSettings.Os = lbForval.Items.Cast<String>().ToList();
                        break;
                    case 3:    //Tillhörighet
                        AppSettings.Tillhorigheter = lbForval.Items.Cast<String>().ToList();
                        break;
                }
                LaddaForval();
            }
        }

        private void LaddaForval()
        {
            lbForval.Items.Clear();
            switch (cbForvalValj.SelectedIndex)
            {
                case 0:    //Beskrivningar
                    foreach (string v in AppSettings.Beskrivningar)
                    {
                        lbForval.Items.Add(v);
                    }
                    break;
                case 1:    //Händelser
                    foreach (string v in AppSettings.Handelser)
                    {
                        lbForval.Items.Add(v);
                    }
                    break;
                case 2:    //Os
                    foreach (string v in AppSettings.Os)
                    {
                        lbForval.Items.Add(v);
                    }
                    break;
                case 3:    //Tillhörighet
                    foreach (string v in AppSettings.Tillhorigheter)
                    {
                        lbForval.Items.Add(v);
                    }
                    break;
            }
        }

        private void cmdNuvarandeDbUtforska_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog();
            fileDialog.Filter = "db files (*.db)|*.db";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (fileDialog.CheckFileExists)
                {
                    AppSettings.Databas = fileDialog.FileName;
                    DataAccess.CurrentFile = AppSettings.Databas;
                }
                else
                {
                    MessageBox.Show("Något är fel med den utpekade filen");
                }
            }
        }

        private void cmdDatabasAterstall_Click(object sender, EventArgs e)
        {
            AppSettings.Databas = string.Empty;
            DataAccess.CurrentFile = AppSettings.Databas;
        }

        private void cmdNuvarandeDbBackupUtforska_Click(object sender, EventArgs e)
        {
            var folderDialog = new FolderBrowserDialog();

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                if (Directory.Exists(folderDialog.SelectedPath))
                {
                    AppSettings.DatabasBackup = folderDialog.SelectedPath;
                }
                else
                {
                    MessageBox.Show("Något är fel med den utpekade mappen");
                }
            }
        }

        private void cmdNuvarandeDbBackupAterstall_Click(object sender, EventArgs e)
        {
            AppSettings.DatabasBackup = string.Empty;
        }

        private void laNuvarandeDbDisplay_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(laNuvarandeDbDisplay.Text);
        }
       
        private void mouseEnter(object sender, EventArgs e)
        {
            Label theLabel = (Label)sender;
            if (theLabel != clickedLabel)
                theLabel.ForeColor = Config.highlightColor;
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            Label theLabel = (Label)sender;
            if (theLabel != clickedLabel)
                theLabel.ForeColor = Config.standardForeColor;
        }

        private void cmdImportForval_Click(object sender, EventArgs e)
        {
            using (DataAccess dataAccess = new DataAccess())
            {
                foreach (string v in dataAccess.GetUniqueBesk())
                {
                    if (!AppSettings.Beskrivningar.Contains(v))
                    {
                        AppSettings.Beskrivningar.Add(v);
                    }
                }
                foreach (string v in dataAccess.GetUniqueOS())
                {
                    if (!AppSettings.Os.Contains(v))
                    {
                        AppSettings.Os.Add(v);
                    }
                }
                foreach (string v in dataAccess.GetUniqueTillhorighet())
                {
                    if (!AppSettings.Tillhorigheter.Contains(v))
                    {
                        AppSettings.Tillhorigheter.Add(v);
                    }
                }
                foreach (string v in dataAccess.GetUniqueHandelser())
                {
                    if (!AppSettings.Handelser.Contains(v))
                    {
                        AppSettings.Handelser.Add(v);
                    }
                }
            }
            LaddaForval();
        }

        private void cbBackupOnStart_CheckedChanged(object sender, EventArgs e)
        {
            AppSettings.BackupOnStart = cbBackupOnStart.Checked;
        }

        private void cbPrinter_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppSettings.Skrivare = cbPrinter.Text;
        }

        private void lbForval_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void InstallningarDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void cmdExporteraPersoner_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Json file(*.json)|*.json";
            fileDialog.DefaultExt = "json";
            fileDialog.AddExtension = true;
            DialogResult dialogResult = fileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK && !fileDialog.CheckFileExists && fileDialog.CheckPathExists)
            {
                using (DataAccess dataAccess = new DataAccess())
                {
                    File.WriteAllText(fileDialog.FileName, dataAccess.HamtaPersoner().ToJson());
                }
            }
        }

        private void cmdExporteraArtiklar_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Json file(*.json)|*.json";
            fileDialog.DefaultExt = "json";
            fileDialog.AddExtension = true;
            DialogResult dialogResult = fileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK && !fileDialog.CheckFileExists && fileDialog.CheckPathExists)
            {
                using (DataAccess dataAccess = new DataAccess())
                {
                    File.WriteAllText(fileDialog.FileName, dataAccess.HamtaArtiklar().ToJson());
                }
            }
        }
    }
}
