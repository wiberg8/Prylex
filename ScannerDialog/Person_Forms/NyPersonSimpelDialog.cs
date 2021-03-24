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

        private void TextBox_Leave(object sender, EventArgs e)
        {
          
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
          
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            
        }

        private void laPhone_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void NyPersonDialog_Load(object sender, EventArgs e)
        {
            LaddaSnabbVal();
        }

        private void cmdSpara_Click(object sender, EventArgs e)
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

        private void FyllErrors(ValidationResult lista)
        {
            lbErrors.Items.Clear();
            foreach (var x in lista.Errors)
            {
                lbErrors.Items.Add(x);
            }
        }

        private void txtFornamn_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void txtEfternamn_TextChanged(object sender, EventArgs e)
        {
            
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
        private void FaltRensa()
        {
            //Rensar alla fält förutom cbTillhorighet
            txtFornamn.Clear();
            txtEfternamn.Clear();
            txtPersNr.Clear();
            txtSign.Clear();
        }
        private bool IsFaltGiltiga()
        {
            //Kollar om textfäleten "Förnamn", "Efternamn", "Tillhörighet" har minst 2 tecken i sig som ej är blanksteg
            if(
                txtFornamn.Text.RemoveWhiteSpaces().Length < 2 
                || txtEfternamn.Text.RemoveWhiteSpaces().Length < 2
                || cbTillhorighet.Text.RemoveWhiteSpaces().Length < 2
                )
                return false;
            return true;
        }
       

        private void LaddaSnabbVal()
        {
            cbTillhorighet.DataSource = AppSettings.Tillhorigheter;
            if (cbTillhorighet.Items.Count > 0)
                cbTillhorighet.SelectedIndex = 0;
        }

        //private void FaltRensaValideringsFel()
        //{
        //    errorFornamn.Clear();
        //    errorEfternamn.Clear();
        //}

        private void gbFalt_Enter(object sender, EventArgs e)
        {

        }
    }
}
