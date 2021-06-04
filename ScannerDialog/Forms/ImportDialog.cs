using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PrylanLibary.Models;
using PrylanLibary.Validators;
using PrylanLibary;
using static ScannerDialog.Program;

namespace ScannerDialog.Forms
{
    public partial class ImportDialog : Form
    {
        private string SelectedImportFil { get { return txtImportFil.Text; } set { txtImportFil.Text = value; }}
      
        public ImportDialog()
        {
            InitializeComponent();
        }

        //form events
        private void ImportDialog_Load(object sender, EventArgs e) => FormStartup();
        private void ImportDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
        //cmd event
        private void cmdImportFilUtforska_Click(object sender, EventArgs e) => SelectImportFil();
        private async void cmdLasFranFil_Click(object sender, EventArgs e) => await ReadPersonerFromSelectedFile();
        private async void cmdVerkstallImport_Click(object sender, EventArgs e) => await VerkstallImport();

        private void FormStartup()
        {
            LaddaSnabbVal();
            cmdLasFranFil.Visible = false;
        }     
        private async Task ReadPersonerFromSelectedFile()
        {
            if (!File.Exists(SelectedImportFil))
            {
                return;
            }
            Encoding encoding = IO.GetEncoding(SelectedImportFil);
            if (!(encoding == Encoding.UTF8 || encoding == Encoding.ASCII))
            {
                MessageBox.Show("Filen måste ha UTF8 eller ASCII enkodning");
                return;
            }

            this.Enabled = false;
            ClearInlastPersoner();
            int counter = 0;
            string line;
            StreamReader file = new StreamReader(SelectedImportFil);
            while ((line = await file.ReadLineAsync()) != null)
            {
                string[] lineSplit = line.Split(';');
                if (lineSplit.Length >= 3)
                {
                    Person p = new Person()
                    {
                        PersNr = lineSplit[0],
                        Efternamn = lineSplit[1],
                        Fornamn = lineSplit[2],
                        Tillhorighet = cbTillhorighet.Text
                    };
                    AddInlastPerson(p);
                }
                counter++;
            }
            this.Enabled = true;
        }
        private async Task VerkstallImport()
        {
            if (lbPersoner.Items.Count > 0)
            {
                ImportSetup();
                List<ImportPerson> importer = new List<ImportPerson>();
                PersonValidator validator = new PersonValidator();
                int importedCount = 0;
                foreach (Person p in lbPersoner.Items)
                {
                    laCurrentImportPerson.Text = p.ToString();
                    ImportPerson importPerson = new ImportPerson() { Person = p };
                    importPerson.Validation = validator.Validate(p);
                    importPerson.AlreadyExist = DBAccess.HamtaPersonFranPersNr(importPerson.Person.PersNr) != null;
                    importPerson.Success = importPerson.Validation.IsValid && !importPerson.AlreadyExist;
                    if (importPerson.Success)
                    {
                        int insertCount = await Task.Run(() => DBAccess.InfogaPerson(importPerson.Person));
                        importPerson.Success = insertCount == 1;
                    }
                    progressBar.Increment(1);
                    importedCount += 1;
                    importer.Add(importPerson);
                }
                ImportFinished();
                ImportResultDialog resultDialog = new ImportResultDialog(importer);
                resultDialog.ShowDialog();
            }
        }

        private void ImportFinished()
        {
            progressBar.Value = 0;
            progressBar.Visible = false;
            laCurrentImportPerson.Visible = false;
            this.Enabled = true;
            ClearInlastPersoner();
        }
        private void ImportSetup()
        {
            this.Enabled = false;
            progressBar.Visible = true;
            laCurrentImportPerson.Visible = true;
            progressBar.Value = 0;
            progressBar.Maximum = lbPersoner.Items.Count;
        }
        private void ClearInlastPersoner()
        {
            lbPersoner.Items.Clear();
            laTillhorighet.Visible = false;
            cbTillhorighet.Visible = false;
            cmdVerkstallImport.Visible = false;
        }
        private void AddInlastPerson(object itm)
        {
            lbPersoner.Items.Add(itm);
            bool itemExists = lbPersoner.Items.Count > 0;

            lbPersoner.SelectedIndex = lbPersoner.Items.Count - 1;
            laTillhorighet.Visible = itemExists;
            cbTillhorighet.Visible = itemExists;
            cmdVerkstallImport.Visible = itemExists;
        }
        private void SelectImportFil()
        {
            lbPersoner.Items.Clear();
            var fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Csv filer (*.csv)|*.csv";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                cmdLasFranFil.Visible = fileDialog.CheckFileExists;
                if (cmdLasFranFil.Visible)
                {
                    SelectedImportFil = fileDialog.FileName;
                }
                else
                {
                    MessageBox.Show("Något är fel med den utpekade filen");
                }
            }
        }
        private void LaddaSnabbVal()
        {
            cbTillhorighet.DataSource = Program.AppSettings.Tillhorigheter;
            if (cbTillhorighet.Items.Count > 0)
                cbTillhorighet.SelectedIndex = 0;
        }
    }
}
