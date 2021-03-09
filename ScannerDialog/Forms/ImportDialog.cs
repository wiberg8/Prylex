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
using PrylanLibary;

namespace ScannerDialog.Forms
{
    public partial class ImportDialog : Form
    {
        private List<ImportPerson> importer = new List<ImportPerson>();
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

        private void cmdImportFilUtforska_Click(object sender, EventArgs e)
        {
            lbPersoner.Items.Clear();
            lbPersonerErrosSuccess.Items.Clear();
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

        private void cmdLasFranFil_Click(object sender, EventArgs e)
        {
            if (!File.Exists(SelectedImportFil))
            {
                return;
            }
            if (IO.GetEncoding(SelectedImportFil) != Encoding.UTF8)
            {
                MessageBox.Show("Filen måste ha UTF8 enkodning");
                return;
            }

            lbPersoner.Items.Clear();
            List<string> fileData = File.ReadAllLines(SelectedImportFil).ToList();
            if(fileData.Count > 0)
            {
                fileData.RemoveAt(0);
            }
            foreach (string line in fileData)
            {
                string[] lineSplit = line.Split(';');
                if (lineSplit.Length >= 2)
                {
                    Person p = new Person()
                    {
                        Fornamn = lineSplit[0],
                        Efternamn = lineSplit[1],
                        PersNr = "20"+lineSplit[2],
                        Tillhorighet = cbTillhorighet.Text
                    };

                    lbPersoner.Items.Add(p);
                }
            }
           
        }

        private void cmdVerkstallImport_Click(object sender, EventArgs e)
        {
            if(lbPersoner.Items.Count > 0)
            {
                lbPersonerErrosSuccess.Items.Clear();
                using (DataAccess dataAccess = new DataAccess())
                {
                    foreach (Person p in lbPersoner.Items)
                    {
                        ImportPerson importPerson = new ImportPerson();
                        importPerson.Person = p;
                        if (p.ValidPersNr() && p.ValidTillhorighet() && !dataAccess.ExisterarPerson(p.PersNr))
                        {
                            dataAccess.InfogaPerson(p);
                            importPerson.Exist = true;
                            importPerson.Success = true;
                            importer.Add(importPerson);
                        }
                        else
                        {
                            importPerson.Success = false;
                            importer.Add(importPerson);
                        }
                    }
                    int lyckade = importer.Where((ImportPerson p) => p.Success).Count();
                    int misslyckade = importer.Where((ImportPerson p) => !p.Success).Count();
                    if(lyckade == misslyckade)
                    {
                        rbLyckade.Checked = true;
                    }
                    else if(lyckade > misslyckade)
                    {
                        rbLyckade.Checked = true;
                    }
                    else if(lyckade < misslyckade)
                    {
                        rbMisslyckade.Checked = true;
                    }
                }
                ErrorsUpdate();
            }
        }

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

        private void ImportDialog_Load(object sender, EventArgs e)
        {
            LaddaSnabbVal();
            SelectedImportFil = @"E:\PlaceriUTF8.csv";
        }

        private void ErrorsUpdate()
        {
            lbPersonerErrosSuccess.Items.Clear();
            List<ImportPerson> imports;
            if (rbLyckade.Checked)
            {
                imports = importer.Where((ImportPerson p) => p.Success).ToList();
               
            }
            else
            {
                imports = importer.Where((ImportPerson p) => !p.Success).ToList();
            }
            foreach (ImportPerson importPerson in imports)
            {
                lbPersonerErrosSuccess.Items.Add(importPerson);
            }
        }

        private void rbLyckade_CheckedChanged(object sender, EventArgs e)
        {
            ErrorsUpdate();
        }

        private void rbMisslyckade_CheckedChanged(object sender, EventArgs e)
        {
            ErrorsUpdate();
        }

        private void rbExists_CheckedChanged(object sender, EventArgs e)
        {
            ErrorsUpdate();
        }
    }
}
