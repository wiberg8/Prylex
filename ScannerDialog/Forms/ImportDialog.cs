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

namespace ScannerDialog.Forms
{
    public partial class ImportDialog : Form
    {
        private string selectedImportFil;
        private string SelectedImportFil 
        { 
            get { return this.selectedImportFil; }
            set { this.selectedImportFil = value; txtImportFil.Text = value; }
        }
      

        public ImportDialog()
        {
            InitializeComponent();
        }

        private void ImportDialog_Load(object sender, EventArgs e)
        {
            LaddaSnabbVal();
        }

        private void cmdImportFilUtforska_Click(object sender, EventArgs e)
        {
            lbPersoner.Items.Clear();
            var fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Csv filer (*.csv)|*.csv";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (fileDialog.CheckFileExists)
                {
                    SelectedImportFil = fileDialog.FileName;
                }
                else
                {
                    MessageBox.Show("Något är fel med den utpekade filen");
                }
            }
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

            laTillhorighet.Visible = itemExists;
            cbTillhorighet.Visible = itemExists;
            cmdVerkstallImport.Visible = itemExists;
        }

        private void cmdLasFranFil_Click(object sender, EventArgs e)
        {
            if (!File.Exists(SelectedImportFil))
            {
                return;
            }
            Encoding encoding = IO.GetEncoding(SelectedImportFil);
            if(!(encoding == Encoding.UTF8 || encoding == Encoding.ASCII))
            {
                MessageBox.Show("Filen måste ha UTF8 eller ASCII enkodning");
                return;
            }
                
            ClearInlastPersoner();
            List<string> fileData = File.ReadAllLines(SelectedImportFil).ToList();
            foreach (string line in fileData)
            {
                string[] lineSplit = line.Split(';');
                if (lineSplit.Length >= 3)
                {
                    Person p = new Person()
                    {
                        Fornamn = lineSplit[0],
                        Efternamn = lineSplit[1],
                        PersNr = lineSplit[2],
                        Tillhorighet = cbTillhorighet.Text
                    };
                    AddInlastPerson(p);
                }
            }
        }

        private void cmdVerkstallImport_Click(object sender, EventArgs e)
        {
            if (lbPersoner.Items.Count > 0)
            {
                List<ImportPerson> importer = new List<ImportPerson>();
                PersonValidator validator = new PersonValidator();
                using (DataAccess dataAccess = new DataAccess())
                {
                    foreach (Person p in lbPersoner.Items)
                    {
                        ImportPerson importPerson = new ImportPerson() { Person = p};
                        importPerson.Errors = validator.Validate(p);
                        importPerson.AlreadyExist = dataAccess.ExisterarPerson(importPerson.Person.PersNr);
                        importPerson.Success = importPerson.Errors.IsValid && !importPerson.AlreadyExist;
                        if (importPerson.Success)
                        {
                            dataAccess.InfogaPerson(importPerson.Person);
                            importPerson.Person.Id = DataAccess.LastInsertRowId;
                        }
                        importer.Add(importPerson);
                    }
                }
                ClearInlastPersoner();
                ImportResultDialog resultDialog = new ImportResultDialog(importer);
                resultDialog.ShowDialog();
            }
        }
        //int lyckade = importer.Where((ImportPerson p) => p.Success).Count();
        //int misslyckade = importer.Where((ImportPerson p) => !p.Success).Count();
        //if (lyckade == misslyckade)
        //{
        //    rbLyckade.Checked = true;
        //}
        //else if (lyckade > misslyckade)
        //{
        //    rbLyckade.Checked = true;
        //}
        //else if (lyckade < misslyckade)
        //{
        //    rbMisslyckade.Checked = true;
        //}

        private void laTillhorighet_Click(object sender, EventArgs e)
        {

        }

        private void cbTillhorighet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbPersoner_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void LaddaSnabbVal()
        {
            Installningar ins = Installningar.Hamta();
            cbTillhorighet.DataSource = ins.Tillhorigheter;
            if (cbTillhorighet.Items.Count > 0)
                cbTillhorighet.SelectedIndex = 0;
        }

        private void ImportDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
