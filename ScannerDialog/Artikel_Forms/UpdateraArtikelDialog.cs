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
    public partial class UpdateraArtikelDialog : Form
    {
        public Artikel Result { get; private set; }
        public Artikel artikelEdit;

        public UpdateraArtikelDialog(Artikel artikel)
        {
            InitializeComponent();
            this.artikelEdit = artikel;
        }

        //form events
        private void UpdateraArtikelDialog_Load(object sender, EventArgs e) => FormStartup();
        private void UpdateraArtikelDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        //cmd events
        private void cmdSpara_Click(object sender, EventArgs e) => Spara();

        private void FormStartup()
        {
            LaddaSnabbval();
            FyllFalt(this.artikelEdit);
        }
        private void Spara()
        {
            Artikel artikelFranFalt = FaltTillArtikel();
            ArtikelValidator validator = new ArtikelValidator();
            var validationResult = validator.Validate(artikelFranFalt);
            FyllErrors(validationResult);
            if (validationResult.IsValid)
            {
                this.Result = FaltTillArtikel();
                this.DialogResult = DialogResult.OK;
            }
        }
        private Artikel FaltTillArtikel()
        {
            Artikel artikel = this.artikelEdit.Copy();
            artikel.Besk = cbBeskrivningar.Text.Trim();
            artikel.StoldTag = txtStoldtag.Text.Trim();
            artikel.DatorNamn = txtDatornamn.Text.Trim();
            artikel.Os = cbOS.Text.Trim();
            artikel.Ovrigt = txtOvrigt.Text.Trim();

            return artikel;
        }
        private void LaddaSnabbval()
        {
            cbBeskrivningar.Items.AddRange(AppSettings.Beskrivningar.ToArray());
            cbOS.Items.AddRange(AppSettings.Os.ToArray());

            if (cbBeskrivningar.Items.Count > 0)
            {
                cbBeskrivningar.SelectedIndex = 0;
            }
            if (cbOS.Items.Count > 0)
            {
                cbOS.SelectedIndex = 0;
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
        private void FyllFalt(Artikel artikel)
        {
            txtDatornamn.Text = artikel.DatorNamn;
            txtStoldtag.Text = artikel.StoldTag;
            txtOvrigt.Text = artikel.Ovrigt;
            cbBeskrivningar.Text = artikel.Besk;
            cbOS.Text = artikel.Os;
        }


    }
}
