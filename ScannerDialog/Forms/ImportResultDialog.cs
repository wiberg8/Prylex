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
    public partial class ImportResultDialog : Form
    {
        private List<ImportPerson> importer = new List<ImportPerson>();

        public ImportResultDialog(List<ImportPerson> importer)
        {
            InitializeComponent();
            this.importer = importer;
        }

        private void ErrorsUpdate()
        {
            lbPersonErrors.Items.Clear();
            lbPersonerErrosSuccess.Items.Clear();
            List<ImportPerson> tImporter;
            if (rbLyckade.Checked)
            {
                tImporter = importer.Where((ImportPerson p) => p.Success).ToList();
               
            }
            else if(rbMisslyckade.Checked)
            {
                tImporter = importer.Where((ImportPerson p) => !p.Success && !p.AlreadyExist).ToList();
            }
            else
            {
                tImporter = importer.Where((ImportPerson p) => p.AlreadyExist).ToList();
            }
            foreach (ImportPerson importPerson in tImporter)
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

        private void rbExists_CheckedChanged_1(object sender, EventArgs e)
        {
            ErrorsUpdate();
        }

        private void ImportResultDialog_Load(object sender, EventArgs e)
        {
            ErrorsUpdate();
        }

        private void lbPersonerErrosSuccess_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbPersonerErrosSuccess.SelectedItem != null)
            {
                ImportPerson importPerson = lbPersonerErrosSuccess.SelectedItem as ImportPerson;
                lbPersonErrors.Items.Clear();
                lbPersonErrors.Items.AddRange(importPerson.Validation.Errors.ToArray());
            }
        }
    }
}
