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
        private void VisaValideringsFel()
        {
            if (txtFornamn.Text.RemoveWhiteSpaces().Length < 2)
                errorFornamn.SetError(txtFornamn, "Minst 2 tecken");
            else
                errorFornamn.Clear();
            if (txtEfternamn.Text.RemoveWhiteSpaces().Length < 2)
                errorEfternamn.SetError(txtEfternamn, "Minst 2 tecken");
            else
                errorEfternamn.Clear();
            if (cbTillhorighet.Text.RemoveWhiteSpaces().Length < 2)
                errorTillhorighet.SetError(cbTillhorighet, "Minst 2 tecken");
            else
                errorTillhorighet.Clear();

        }

        private void cmdSpara_Click(object sender, EventArgs e)
        {
            if (IsFaltGiltiga())
            {
                this.Result = this.FaltToPerson();
                this.DialogResult = DialogResult.OK;
            }
        }


        private void LaddaSnabbVal()
        {
            Installningar ins = Installningar.Hamta();
            foreach(string v in ins.Tillhorigheter)
            {
                cbTillhorighet.Items.Add(v);
            }
        }

        private void UpdateraPersonDialog_Load(object sender, EventArgs e)
        {
            LaddaSnabbVal();
            VisaValideringsFel();
            FyllFalt(this.personEdit);
        }

        private void cbTillhorighet_TextChanged(object sender, EventArgs e)
        {
            VisaValideringsFel();
        }

        private void txtEfternamn_TextChanged(object sender, EventArgs e)
        {
            VisaValideringsFel();
        }

        private void txtFornamn_TextChanged(object sender, EventArgs e)
        {
            VisaValideringsFel();
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
