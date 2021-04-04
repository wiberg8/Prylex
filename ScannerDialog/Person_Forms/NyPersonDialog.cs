using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentValidation.Results;
using PrylanLibary;
using PrylanLibary.Models;
using PrylanLibary.Validators;
using static ScannerDialog.Program;

namespace ScannerDialog
{
    public partial class NyPersonDialog : Form
    {
        public NyPersonDialog()
        {
            InitializeComponent();
        }

        //form events
        private void NyPersonDialog_Load(object sender, EventArgs e)
        {
            FormStartup();
        }

        //cmd events
        private void cmdSpara_Click(object sender, EventArgs e)
        {
            Spara();
        }

        private void FormStartup()
        {
            LaddaSnabbVal();
        }
        private void Spara()
        {
            Person person = this.FaltToPerson();
            var validator = new PersonValidator();
            var errors = validator.Validate(person);
            FyllErrors(errors);
            if (errors.IsValid)
            {
                if (DBAccess.ExisterarPerson(person.PersNr))
                {
                    MessageBox.Show("PersNr existerar redan");
                }
                else
                {
                    DBAccess.InfogaPerson(person);
                    FaltRensa();
                }
            }
        }
        private Person FaltToPerson()
        {
            string transformedPersNr = string.Empty;
            if (txtPersNr.MaskFull)
            {
                transformedPersNr = txtPersNr.Text;
            }
            Person person = new Person()
            {
                Fornamn = txtFornamn.Text.Trim(),
                Efternamn = txtEfternamn.Text.Trim(),
                PersNr = transformedPersNr,
                Sign = txtSign.Text.Trim(),
                Epost = txtEpost.Text.Trim(),
                Telefon = txtTelefon.Text.Trim(),
                Ovrigt = txtOvrigt.Text,
                Tillhorighet = cbTillhorighet.Text
            };
            return person;
        }
        private void FaltRensa()
        {
            //Rensar alla fält förutom cbTillhorighet
            txtFornamn.Clear();
            txtEfternamn.Clear();
            txtPersNr.Clear();
            txtSign.Clear();
            txtEpost.Clear();
            txtTelefon.Clear();
            txtOvrigt.Clear();
        }
        private void LaddaSnabbVal()
        {
            cbTillhorighet.DataSource = AppSettings.Tillhorigheter;
            if (cbTillhorighet.Items.Count > 0)
                cbTillhorighet.SelectedIndex = 0;
        }
        private void FyllErrors(ValidationResult lista)
        {
            lbErrors.Items.Clear();
            foreach (var x in lista.Errors)
            {
                lbErrors.Items.Add(x);
            }
        }
    }
}
