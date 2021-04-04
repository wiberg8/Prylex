using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
    public partial class NyArtikelDialog : Form
    {
        public NyArtikelDialog()
        {
            InitializeComponent();
            dtpInkop.Value = DateTime.Now;
        }

        //form events
        private void NyArtikelDialog_Load(object sender, EventArgs e)
        {
            LaddaSnabbval();
        }
        //cmd events
        private void cmdSave_Click(object sender, EventArgs e)
        {
            Spara();
        }
        //checkbox events
        private void cbInputChoose_CheckedChanged(object sender, EventArgs e)
        {
            cbBeskrivningar.DropDownStyle = checkBeskrivningarFritext.Checked ? ComboBoxStyle.DropDown : ComboBoxStyle.DropDownList;
        }
        private void checkOsFritext_CheckedChanged(object sender, EventArgs e)
        {
            cbOS.DropDownStyle = checkOsFritext.Checked ? ComboBoxStyle.DropDown : ComboBoxStyle.DropDownList;
        }

        private void Spara()
        {
            Artikel artikelFranFalt = FaltTillArtikel();

            ArtikelValidator validator = new ArtikelValidator();
            var validationResult = validator.Validate(artikelFranFalt);
            FyllErrors(validationResult);
            //if (string.IsNullOrWhiteSpace(cbBeskrivningar.Text) || IsAllaFaltTomma(artikelFranFalt))
            //{
            //    MessageBox.Show("Beskrivning / Alla fält är tomma");
            //    return;
            //}
            if (validationResult.IsValid)
            {
                if (DBAccess.ExisterarArtikel(artikelFranFalt))
                {
                    MessageBox.Show("SerieNr existerar redan");
                }
                else
                {
                    if (cbPrintEttiket.Checked)
                    {
                        Printing.PrintSerieNrLabel(artikelFranFalt.SerieNr, AppSettings.Skrivare);
                    }
                    DBAccess.InfogaArtikel(artikelFranFalt);
                    AterstallFalt();
                }
            }
        }
        private void AterstallFalt()
        {
            foreach (Control crl in gbFalt.Controls)
            {
                if (crl.GetType() == typeof(TextBox))
                    ((TextBox)crl).Clear();
            }
            txtSerieNr.Focus();
        }
        private Artikel FaltTillArtikel()
        {
            Artikel artikel = new Artikel
            {
                Beskrivning = cbBeskrivningar.Text,
                StoldTag = txtStoldtag.Text.Trim(),
                DatorNamn = txtDatornamn.Text.Trim(),
                SerieNr = txtSerieNr.Text.Trim().ToUpper(),
                Mac = txtMAC.Text.Trim(),
                Inkop = dtpInkop.Value.ToShortDateString(),
                Os = cbOS.Text.Trim(),
                Ovrigt = txtOvrigt.Text.Trim()
            };

            return artikel;
        }
        private void FyllErrors(ValidationResult lista)
        {
            lbErrors.Items.Clear();
            lbErrors.Items.AddRange(lista.Errors.ToArray());
        }
        private void LaddaSnabbval()
        {
            cbBeskrivningar.DataSource = AppSettings.Beskrivningar;
            if (cbBeskrivningar.Items.Count > 0)
                cbBeskrivningar.SelectedIndex = 0;
            cbOS.DataSource = AppSettings.Os;
            if (cbOS.Items.Count > 0)
                cbOS.SelectedIndex = 0;
        }


    
       
    }
}
