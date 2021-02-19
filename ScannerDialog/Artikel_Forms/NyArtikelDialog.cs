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

using PrylanLibary;
using PrylanLibary.Models;

namespace ScannerDialog
{
    public partial class NyArtikelDialog : Form
    {

        public NyArtikelDialog()
        {
            InitializeComponent();
            dtpInkop.Value = DateTime.Now;
        }

        public NyArtikelDialog(Artikel artikel)
        {
            InitializeComponent();
            dtpInkop.Value = DateTime.Now;
        }

        private void cbInputChoose_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBeskrivningarFritext.Checked)
                cbBeskrivningar.DropDownStyle = ComboBoxStyle.DropDown;
            else
                cbBeskrivningar.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void gbStaticFields_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtOther_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSerial_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            Artikel artikelFranFalt = FaltTillArtikel();

            if (string.IsNullOrWhiteSpace(cbBeskrivningar.Text) || IsAllaFaltTomma(artikelFranFalt))
            {
                MessageBox.Show("Beskrivning / Alla fält är tomma");
                return;
            }

            using (var dataAccess = new DataAccess())
            {
                if (dataAccess.ExisterarArtikel(artikelFranFalt))
                {
                    MessageBox.Show("SerieNr existerar redan");
                }
                else
                {
                    dataAccess.InfogaArtikel(artikelFranFalt);
                    AterstallFalt();
                }
            }
        }
       

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyData == Keys.Return)
            //{
            //    e.SuppressKeyPress = true;
            //    this.SelectNextControl(ActiveControl, true, true, true, true);
            //}
        }

        private void checkBuyDate_CheckedChanged(object sender, EventArgs e)
        {
    
        }

        private void NyArtikelDialog_Load(object sender, EventArgs e)
        {
            LaddaSnabbval();
            //if (editerar)
            //{
            //    FyllFalt(this.artikelAttEditera);
            //}
            //else
            //{
            //    txtArtikelId.Visible = false;
            //    laArtikelId.Visible = false;
            //}
        }

        private bool IsAllaFaltTomma(Artikel artikel)
        {
            return string.IsNullOrWhiteSpace(artikel.DatorNamn) && string.IsNullOrWhiteSpace(artikel.StoldTag) && string.IsNullOrWhiteSpace(artikel.Mac) && string.IsNullOrWhiteSpace(artikel.SerieNr) && string.IsNullOrWhiteSpace(artikel.Ovrigt);
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

        //private void FyllFalt(Artikel artikel)
        //{
        //    cbBeskrivningar.Text = artikel.Beskrivning;
        //    txtStoldtag.Text = artikel.StoldTag;
        //    txtDatornamn.Text = artikel.DatorNamn;
        //    if (DateTime.TryParse(artikel.Inkop, out DateTime parsedInkop))
        //    {
        //        dtpInkop.Value = parsedInkop;
        //    }
        //    cbOS.Text = artikel.Os;
        //    txtSerieNr.Text = artikel.SerieNr;
        //    txtOvrigt.Text = artikel.Ovrigt;
        //    txtMAC.Text = artikel.Mac;
        //}

        private Artikel FaltTillArtikel()
        {
            Artikel artikel = new Artikel
            {
                Beskrivning = cbBeskrivningar.Text,
                StoldTag = txtStoldtag.Text.Trim(),
                DatorNamn = txtDatornamn.Text.Trim(),
                SerieNr = txtSerieNr.Text.Trim(),
                Mac = txtMAC.Text.Trim(),
                Inkop = dtpInkop.Value.ToShortDateString(),
                Os = cbOS.Text.Trim(),
                Ovrigt = txtOvrigt.Text.Trim()
            };

            return artikel;
        }

        //private Artikel FaltTillArtikel(int Id)
        //{
        //    Artikel artikel = new Artikel(Id)
        //    {
        //        Beskrivning = cbBeskrivningar.Text,
        //        StoldTag = txtStoldtag.Text.Trim(),
        //        DatorNamn = txtDatornamn.Text.Trim(),
        //        SerieNr = txtSerieNr.Text.Trim(),
        //        Mac = txtMAC.Text.Trim(),
        //        Os = cbOS.Text.Trim(),
        //        Inkop = dtpInkop.Value.ToShortDateString(),
        //        Ovrigt = txtOvrigt.Text.Trim()
        //    };

        //    return artikel;
        //}

        private void LaddaSnabbval()
        {
            Installningar ins = Installningar.Hamta();

            if (ins != null)
            {
                cbBeskrivningar.DataSource = ins.Beskrivningar;
                if (cbBeskrivningar.Items.Count > 0)
                    cbBeskrivningar.SelectedIndex = 0;
                cbOS.DataSource = ins.Os;
                if (cbOS.Items.Count > 0)
                    cbOS.SelectedIndex = 0;
            }
        }

        private void cmdAvbryt_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dtpInkop_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void checkOsFritext_CheckedChanged(object sender, EventArgs e)
        {
            if (checkOsFritext.Checked)
                cbOS.DropDownStyle = ComboBoxStyle.DropDown;
            else
                cbOS.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
