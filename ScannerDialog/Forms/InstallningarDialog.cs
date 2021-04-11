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
        public InstallningarDialog()
        {
            InitializeComponent();
            cbForvalValj.SelectedIndex = 0;
            AppSettings.PropertyChanged += Installningar_Change;
        }

        //form events
        private void InstallningarDialog_Load(object sender, EventArgs e)
        {
            FormStartup();
        }
        private void InstallningarDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        //cmd events
        private void cmdForvalUpp_Click(object sender, EventArgs e)
        {
            MoveSelectedUp(lbForval);
            ForvalSpara();
        }
        private void cmdForvalNer_Click(object sender, EventArgs e)
        {
            MoveSelectedDown(lbForval);
            ForvalSpara();
        }
        private void cmdForvalLaggTill_Click(object sender, EventArgs e) => ForvalLaggTill();
        private void cmdForvalTabort_Click(object sender, EventArgs e) => ForvalTaBort();
        private void cmdNuvarandeDbUtforska_Click(object sender, EventArgs e) => ChangeDatabas();
        private void cmdDatabasAterstall_Click(object sender, EventArgs e)
        {
            AppSettings.Databas = string.Empty;
            DBAccess.Close();
            DBAccess.CurrentFile = AppSettings.Databas;
        }
        private void cmdNuvarandeDbBackupUtforska_Click(object sender, EventArgs e) => ChangeDatabasBackup();
        private void cmdNuvarandeDbBackupAterstall_Click(object sender, EventArgs e) => AppSettings.DatabasBackup = string.Empty;
        private void cmdExporteraPersoner_Click(object sender, EventArgs e) => ExporteraPersoner();
        private void cmdExporteraArtiklar_Click(object sender, EventArgs e) => ExporteraArtiklar();
        private void cmdImportForval_Click(object sender, EventArgs e) => ForvalImportera();

        //combobox events
        private void cbForvalValj_SelectedIndexChanged(object sender, EventArgs e) => ForvalRefresh();
        private void cbPrinter_SelectedIndexChanged(object sender, EventArgs e) => AppSettings.Skrivare = cbPrinter.Text;
        //checkbox events
        private void cbBackupOnStart_CheckedChanged(object sender, EventArgs e) => AppSettings.BackupOnStart = cbBackupOnStart.Checked;

        //shared events
        private void laNuvarandeDbDisplay_DoubleClick(object sender, EventArgs e) => Clipboard.SetText(laNuvarandeDbDisplay.Text);
        private void mouseEnter(object sender, EventArgs e)
        {
            Label theLabel = (Label)sender;
            theLabel.ForeColor = Config.HIGHLIGHT_COLOR;
        }
        private void mouseLeave(object sender, EventArgs e)
        {
            Label theLabel = (Label)sender;
            theLabel.ForeColor = Config.STANDARD_FORE_COLOR;
        }

        //events
        private void Installningar_Change(object sender, EventArgs e)
        {
            var ins = (Installningar)sender;
            FyllDatabasVy(ins.Databas, ins.DatabasBackup, ins.BackupOnStart);
        }

        private void FormStartup()
        {
            FyllDatabasVy(AppSettings.Databas, AppSettings.DatabasBackup, AppSettings.BackupOnStart);
            foreach (string v in Printing.GetPrinters())
            {
                cbPrinter.Items.Add(v);
            }
            cbPrinter.Text = AppSettings.Skrivare;
        }
        private void ForvalTaBort()
        {
            if (lbForval.SelectedIndex != -1)
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
                ForvalRefresh();
            }
        }
        private void ForvalRefresh()
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
        private void ForvalSpara()
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
        private void ForvalLaggTill()
        {
            using (InputBox inputDialog = new InputBox())
            {
                inputDialog.ShowDialog();
                if (!string.IsNullOrWhiteSpace(inputDialog.Input))
                {
                    switch (cbForvalValj.SelectedIndex)
                    {
                        case 0:    //Beskrivningar
                            AppSettings.AddBeskrivning(inputDialog.Input);
                            break;
                        case 1:    //Händelser
                            AppSettings.AddHandelse(inputDialog.Input);
                            break;
                        case 2:    //Os
                            AppSettings.AddOs(inputDialog.Input);
                            break;
                        case 3:    //Tillhörighet
                            AppSettings.AddTillhorighet(inputDialog.Input);
                            break;
                    }
                    ForvalRefresh();
                }
            }
        }
        private void ForvalImportera()
        {
            foreach (string v in DBAccess.GetUniqueBesk())
            {
                if (!AppSettings.Beskrivningar.Contains(v))
                {
                    AppSettings.Beskrivningar.Add(v);
                }
            }
            foreach (string v in DBAccess.GetUniqueOS())
            {
                if (!AppSettings.Os.Contains(v))
                {
                    AppSettings.Os.Add(v);
                }
            }
            foreach (string v in DBAccess.GetUniqueTillhorighet())
            {
                if (!AppSettings.Tillhorigheter.Contains(v))
                {
                    AppSettings.Tillhorigheter.Add(v);
                }
            }
            foreach (string v in DBAccess.GetUniqueHandelser())
            {
                if (!AppSettings.Handelser.Contains(v))
                {
                    AppSettings.Handelser.Add(v);
                }
            }
            ForvalRefresh();
        }
        private void MoveSelectedUp(ListBox myListBox)
        {
            int selectedIndex = myListBox.SelectedIndex;
            if (selectedIndex > 0)
            {
                myListBox.Items.Insert(selectedIndex - 1, myListBox.Items[selectedIndex]);
                myListBox.Items.RemoveAt(selectedIndex + 1);
                myListBox.SelectedIndex = selectedIndex - 1;
            }
        }
        private void MoveSelectedDown(ListBox myListBox)
        {
            int selectedIndex = myListBox.SelectedIndex;
            if (selectedIndex < myListBox.Items.Count - 1 & selectedIndex != -1)
            {
                myListBox.Items.Insert(selectedIndex + 2, myListBox.Items[selectedIndex]);
                myListBox.Items.RemoveAt(selectedIndex);
                myListBox.SelectedIndex = selectedIndex + 1;
            }
        }
        private void ExporteraPersoner()
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Json file(*.json)|*.json";
            fileDialog.DefaultExt = "json";
            fileDialog.AddExtension = true;
            DialogResult dialogResult = fileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK && !fileDialog.CheckFileExists && fileDialog.CheckPathExists)
            {
                File.WriteAllText(fileDialog.FileName, DBAccess.HamtaPersoner().ToJson());
            }
        }
        private void ExporteraArtiklar()
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Json file(*.json)|*.json";
            fileDialog.DefaultExt = "json";
            fileDialog.AddExtension = true;
            DialogResult dialogResult = fileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK && !fileDialog.CheckFileExists && fileDialog.CheckPathExists)
            {
                File.WriteAllText(fileDialog.FileName, DBAccess.HamtaArtiklar().ToJson());
            }
        }
        private void ChangeDatabasBackup()
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
        private void ChangeDatabas()
        {
            var fileDialog = new OpenFileDialog
            {
                Filter = "db files (*.db)|*.db"
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (fileDialog.CheckFileExists)
                {
                    AppSettings.Databas = fileDialog.FileName;
                    DBAccess.Close();
                    DBAccess.CurrentFile = AppSettings.Databas;
                    if (!DBAccess.TryOpen())
                    {
                        MessageBox.Show("Något är fel med den utpekade filen");
                    }
                }
                else
                {
                    MessageBox.Show("Något är fel med den utpekade filen");
                }
            }
        }
        private void FyllDatabasVy(string database, string databaseBackup, bool backupOnStart)
        {
            laNuvarandeDbDisplay.Text = database;
            laNuvarandeDbBackupDisplay.Text = databaseBackup;
            cbBackupOnStart.Checked = backupOnStart;
        }

 
    }
}
