using PrylanLibary;
using PrylanLibary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrylanLibary.Validators;
using FluentValidation.Results;
using static ScannerDialog.Program;

namespace ScannerDialog
{
    public partial class UpdateraPersonDialog : Form
    {
        public Person Result { get; private set; }
        public Person personEdit;

        public UpdateraPersonDialog(Person person)
        {
            InitializeComponent();
            this.personEdit = person;
        }

        private Person FaltToPerson()
        {
            Person person = this.personEdit.Copy();
            person.Fornamn = txtFornamn.Text.Trim();
            person.Efternamn = txtEfternamn.Text.Trim();
            person.Sign = txtSign.Text.Trim();
            person.Epost = txtEpost.Text.Trim();
            person.Telefon = txtTelefon.Text.Trim();
            person.Ovrigt = txtOvrigt.Text;
            person.Tillhorighet = cbTillhorighet.Text;
            return person;
        }

        private void FyllFalt(Person person)
        {
            txtFornamn.Text = person.Fornamn;
            txtEfternamn.Text = person.Efternamn;
            txtSign.Text = person.Sign;
            txtEpost.Text = person.Epost;
            txtTelefon.Text = person.Telefon;
            txtOvrigt.Text = person.Ovrigt;
            cbTillhorighet.Text = person.Tillhorighet;
        }

        private bool IsFaltGiltiga()
        {
            //Kollar om textfäleten "Förnamn", "Efternamn", "Tillhörighet" har minst 2 tecken i sig som ej är blanksteg
            if (
                txtFornamn.Text.RemoveWhiteSpaces().Length < 2
                || txtEfternamn.Text.RemoveWhiteSpaces().Length < 2
                || cbTillhorighet.Text.RemoveWhiteSpaces().Length < 2
                )
                return false;
            return true;
        }

        private void cmdSpara_Click(object sender, EventArgs e)
        {
            Person p = FaltToPerson();
            PersonValidator validator = new PersonValidator();
            var validation = validator.Validate(p);
            FyllErrors(validation);
            if (validation.IsValid)
            {
                this.Result = p;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void FyllErrors(ValidationResult lista)
        {
            lbErrors.Items.Clear();
            foreach (var x in lista.Errors)
            {
                lbErrors.Items.Add(x);
            }
        }

        private void LaddaSnabbVal()
        {
            foreach(string v in AppSettings.Tillhorigheter)
            {
                cbTillhorighet.Items.Add(v);
            }
        }

        private void UpdateraPersonDialog_Load(object sender, EventArgs e)
        {
            LaddaSnabbVal();
            FyllFalt(this.personEdit);
        }

        private void cbTillhorighet_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtEfternamn_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtFornamn_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void UpdateraPersonDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
