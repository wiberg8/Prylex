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

namespace ScannerDialog
{
    public partial class InstallningarDialog : Form
    {
        private Label clickedLabel;

        public InstallningarDialog()
        {
            InitializeComponent();
            cbForvalValj.SelectedIndex = 0;
            Installningar.Change += Installningar_Change;
        }

        private void Installningar_Change(object sender, EventArgs e)
        {
            var ins = (Installningar)sender;
            FyllDatabasVy(ins.Databas, ins.DatabasBackup);
        }

        private void FyllDatabasVy(string database, string databaseBackup)
        {
            laNuvarandeDbDisplay.Text = database;
            laNuvarandeDbBackupDisplay.Text = databaseBackup;
        }

        private void InstallningarDialog_Load(object sender, EventArgs e)
        {
            var ins = Installningar.Hamta();
            FyllDatabasVy(ins.Databas, ins.DatabasBackup);
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
            Installningar installningar = Installningar.Hamta();
            foreach (string forval in lbForval.Items)
            {
                forvalLista.Add(forval);
            }
            switch (cbForvalValj.SelectedIndex)
            {
                case 0:    //Beskrivningar
                    installningar.Beskrivningar = forvalLista;
                    break;
                case 1:    //Händelser
                    installningar.Handelser = forvalLista;
                    break;
                case 2:    //Os
                    installningar.Os = forvalLista;
                    break;
                case 3:    //Tillhörighet
                    installningar.Tillhorigheter = forvalLista;
                    break;
            }
            Installningar.Spara(installningar);
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
            var installningar = Installningar.Hamta();

            using (InputBox inputDialog = new InputBox())
            {
                inputDialog.ShowDialog();
                if (!string.IsNullOrWhiteSpace(inputDialog.Input))
                {
                    switch (cbForvalValj.SelectedIndex)
                    {
                        case 0:    //Beskrivningar
                            installningar.Beskrivningar.Add(inputDialog.Input);
                            break;
                        case 1:    //Händelser
                            installningar.Handelser.Add(inputDialog.Input);
                            break;
                        case 2:    //Os
                            installningar.Os.Add(inputDialog.Input);
                            break;
                        case 3:    //Tillhörighet
                            installningar.Tillhorigheter.Add(inputDialog.Input);
                            break;
                    }
                    Installningar.Spara(installningar);
                    LaddaForval();
                }
            }

        }

        private void cmdForvalTabort_Click(object sender, EventArgs e)
        {
            var installningar = Installningar.Hamta();

            if(lbForval.SelectedIndex != -1)
            {
                lbForval.Items.RemoveAt(lbForval.SelectedIndex);
                switch (cbForvalValj.SelectedIndex)
                {
                    case 0:    //Beskrivningar
                        installningar.Beskrivningar = lbForval.Items.Cast<String>().ToList();
                        break;
                    case 1:    //Händelser
                        installningar.Handelser = lbForval.Items.Cast<String>().ToList();
                        break;
                    case 2:    //Os
                        installningar.Os = lbForval.Items.Cast<String>().ToList();
                        break;
                    case 3:    //Tillhörighet
                        installningar.Tillhorigheter = lbForval.Items.Cast<String>().ToList();
                        break;
                }
                Installningar.Spara(installningar);
                LaddaForval();
            }
        }

        private void LaddaForval()
        {
            Installningar installnigar = Installningar.Hamta();
            lbForval.Items.Clear();
            switch (cbForvalValj.SelectedIndex)
            {
                case 0:    //Beskrivningar
                    foreach (string v in installnigar.Beskrivningar)
                    {
                        lbForval.Items.Add(v);
                    }
                    break;
                case 1:    //Händelser
                    foreach (string v in installnigar.Handelser)
                    {
                        lbForval.Items.Add(v);
                    }
                    break;
                case 2:    //Os
                    foreach (string v in installnigar.Os)
                    {
                        lbForval.Items.Add(v);
                    }
                    break;
                case 3:    //Tillhörighet
                    foreach (string v in installnigar.Tillhorigheter)
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
                    var ins = Installningar.Hamta();
                    ins.Databas = fileDialog.FileName;
                    ins.Spara();
                    DBHandler.SetConnection(ins.Databas);
                }
                else
                {
                    MessageBox.Show("Något är fel med den utpekade filen");
                }
            }
        }

        private void cmdDatabasAterstall_Click(object sender, EventArgs e)
        {
            var ins = Installningar.Hamta();
            ins.Databas = string.Empty;
            ins.Spara();
            DBHandler.SetConnection(ins.Databas);
        }

        private void cmdNuvarandeDbBackupUtforska_Click(object sender, EventArgs e)
        {
            var folderDialog = new FolderBrowserDialog();

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                if (Directory.Exists(folderDialog.SelectedPath))
                {
                    var ins = Installningar.Hamta();
                    ins.DatabasBackup = folderDialog.SelectedPath;
                    ins.Spara();
                }
                else
                {
                    MessageBox.Show("Något är fel med den utpekade mappen");
                }
            }
        }

        private void cmdNuvarandeDbBackupAterstall_Click(object sender, EventArgs e)
        {
            var ins = Installningar.Hamta();
            ins.DatabasBackup = string.Empty;
            ins.Spara();
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

        private void cmdForvalImport_Click(object sender, EventArgs e)
        {
            var installningar = Installningar.Hamta();
            using (DataAccess dataAccess = new DataAccess())
            {
                List<string> besk = dataAccess.HamtaUnikaBesk();
                foreach(string v in besk)
                {
                    installningar.Beskrivningar.Add(v);
                }
                installningar.Spara();
            }
            LaddaForval();
        }
    }
}
