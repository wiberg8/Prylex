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
using ScannerDialog.Forms;
using static ScannerDialog.Program;

namespace ScannerDialog
{
    public partial class InstallningarDialog : Form
    {
        public bool SelectAnotherDatabase { get; set; }
        public InstallningarDialog()
        {
            InitializeComponent();
            SharedEvents.AttachToAllLabelsInForm(this, this.components.Components);
            //AppSettings.PropertyChanged += Installningar_Change;
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

        private void cbPrinter_SelectedIndexChanged(object sender, EventArgs e) => AppSettings.Skrivare = cbPrinter.Text;
        //checkbox events
        private void cbBackupOnStart_CheckedChanged(object sender, EventArgs e) => AppSettings.BackupOnStart = cbBackupOnStart.Checked;

        //events
        private void Installningar_Change(object sender, EventArgs e)
        {
            var ins = (Installningar)sender;
            //FyllDatabasVy(ins.Databas, ins.DatabasBackup, ins.BackupOnStart);
        }

        private void FormStartup()
        {
            laNuvarandeDbBackupDisplay.Text = AppSettings.DatabasBackup;
            foreach (string v in Printing.GetPrinters())
            {
                cbPrinter.Items.Add(v);
            }
            cbPrinter.Text = AppSettings.Skrivare;
        }

        
        private void ExporteraPersoner()
        {
            SaveFileDialog fileDialog = new SaveFileDialog
            {
                Filter = "Json file(*.json)|*.json",
                DefaultExt = "json",
                AddExtension = true
            };
            DialogResult dialogResult = fileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK && !fileDialog.CheckFileExists && fileDialog.CheckPathExists)
            {
                File.WriteAllText(fileDialog.FileName, DBAccess.HamtaPersoner().ToJson());
            }
        }
        private void ExporteraArtiklar()
        {
            SaveFileDialog fileDialog = new SaveFileDialog
            {
                Filter = "Json file(*.json)|*.json",
                DefaultExt = "json",
                AddExtension = true
            };
            DialogResult dialogResult = fileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK && !fileDialog.CheckFileExists && fileDialog.CheckPathExists)
            {
                File.WriteAllText(fileDialog.FileName, DBAccess.HamtaArtiklar().ToJson());
            }
        }
        private void ChangeDatabasBackup()
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

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

        private void cmdSelectDb_Click(object sender, EventArgs e)
        {
            AppSettings.Databas = string.Empty;
            this.Close();
        }
    }
}
