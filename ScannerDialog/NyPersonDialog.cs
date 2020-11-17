using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PrylanLibary;
using PrylanLibary.Models;

namespace ScannerDialog
{
    public partial class NyPersonDialog : Form
    {
        public NyPersonDialog()
        {
            InitializeComponent();
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
            Installningar ins = Installningar.Hamta();
            cbTillhorighet.DataSource = ins.Tillhorigheter;
            if (cbTillhorighet.Items.Count > 0)
                cbTillhorighet.SelectedIndex = 0;

            VisaValideringsFel();
        }

        private void cmdSpara_Click(object sender, EventArgs e)
        {
            if (!IsFaltGiltiga())
                return;
            Person person = this.FaltToPerson();

            using (var dataAccess = new DataAccess())
            {
                if (dataAccess.ExisterarPerson(person.PersNr))
                {
                    MessageBox.Show("PersNr existerar redan");
                }
                else
                {
                    dataAccess.InfogaPerson(person);
                    FaltRensa();
                }
            }
        }

        private void txtFornamn_TextChanged(object sender, EventArgs e)
        {
            VisaValideringsFel();
        }
        private void txtEfternamn_TextChanged(object sender, EventArgs e)
        {
            VisaValideringsFel();
        }

        #region Metoder
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
        private bool IsFaltGiltiga()
        {
            //Kollar om textfäleten "Förnamn", "Efternamn" har minst 2 tecken i sig som ej är blanksteg
            if(txtFornamn.Text.RemoveWhiteSpaces().Length < 2 || txtEfternamn.Text.RemoveWhiteSpaces().Length < 2)
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
            
        }

        //private void FaltRensaValideringsFel()
        //{
        //    errorFornamn.Clear();
        //    errorEfternamn.Clear();
        //}
        #endregion
    }
}
