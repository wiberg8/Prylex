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
    public partial class NyPersonSimpelDialog : Form
    {
        public Person Person { get; set; }
        public NyPersonSimpelDialog(string persNr)
        {
            InitializeComponent();
            txtPersNr.Text = persNr;
        }

        //form events
        private void NyPersonDialog_Load(object sender, EventArgs e) => LaddaSnabbVal();
        //cmd events
        private void cmdSpara_Click(object sender, EventArgs e) => Spara();

        private void Spara()
        {
            Person person = this.FaltToPerson();
            var validator = new PersonValidator();
            var errors = validator.Validate(person);
            FyllErrors(errors);
            if (errors.IsValid)
            {
                this.Person = person;
                this.DialogResult = DialogResult.OK;
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
                Tillhorighet = cbTillhorighet.Text
            };
            return person;
        }
        private void LaddaSnabbVal()
        {
            cbTillhorighet.DataSource = DBAccess.GetUniqueTillhorighet();
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
