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
    public partial class HanteraPersonDialog : Form
    {
        private Person nuvarandePerson;
        private Label clickedLabel;

        public HanteraPersonDialog(Person personAttEditera)
        {
            InitializeComponent();
            nuvarandePerson = personAttEditera;
        }

        private void laTillhorighet_Click(object sender, EventArgs e)
        {

        }

        private void FyllFalt(Person person)
        {
            laPersonIdDisplay.Text = person.Id.ToString();
            laFornamnDisplay.Text = person.Fornamn;
            laEfternamnDisplay.Text = person.Efternamn;
            laPersNrDisplay.Text = person.PersNr;
            laSignDisplay.Text = person.Sign;
            laEpostDisplay.Text = person.Epost;
            laTelefonDisplay.Text = person.Telefon;
            laOvrigtDisplay.Text = person.Ovrigt;
            laTillhorighetDisplay.Text = person.Tillhorighet;
        }

        private void HanteraPersonDialogcs_Load(object sender, EventArgs e)
        {
            FyllFalt(nuvarandePerson);
            UpdateRegistreradeArtiklar();
        }

        private void UpdateRegistreradeArtiklar()
        {
            List<Artikel> registreradeArtiklar;
            using (DataAccess dataAccess = new DataAccess())
            {
                registreradeArtiklar = dataAccess.HamtaRegistreradeArtiklar(nuvarandePerson);
            }
            lbRegistreradeArtiklar.Items.Clear();
            foreach (Artikel artikel in registreradeArtiklar)
            {
                lbRegistreradeArtiklar.Items.Add(artikel);
            }
        }

        private void cmdPersonAndra_Click(object sender, EventArgs e)
        {

        }

        private void cmdArtikelAvregistrera_Click(object sender, EventArgs e)
        {
            if (lbRegistreradeArtiklar.SelectedItem is null)
                return;
            if (MessageBox.Show("Är du säker på att avregistrera artikeln från personen?", "Prylex", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                    Artikel selectedArtikel = (Artikel)lbRegistreradeArtiklar.SelectedItem;
                    using (DataAccess dataAccess = new DataAccess())
                    {
                        dataAccess.UnregisterArtikelFromPerson(selectedArtikel);
                    }
                    UpdateRegistreradeArtiklar();
            }
        }

        private void cmdArtikelSok_Click(object sender, EventArgs e)
        {
            List<Artikel> artiklar;
            using (DataAccess dataAccess = new DataAccess())
            {
                artiklar = dataAccess.HamtaSokRegistreradeArtiklar(nuvarandePerson, txtArtikelSok.Text);
            }
            FyllRegistreradeArtiklar(artiklar);
        }

        private void cmdShowAllRegistrerade_Click(object sender, EventArgs e)
        {
            List<Artikel> artiklar;
            using (DataAccess dataAccess = new DataAccess())
            {
                artiklar = dataAccess.HamtaRegistreradeArtiklar(nuvarandePerson);
            }
            FyllRegistreradeArtiklar(artiklar);
        }

        private void cmdRegistreraArtikel_Click(object sender, EventArgs e)
        {
            List<Artikel> ledigaArtiklar;
            using (DataAccess dataAccess = new DataAccess())
            {
                ledigaArtiklar = dataAccess.HamtaLedigaArtiklar();
            }
            var dialog = new ValjArtikelDialog(ledigaArtiklar, true);
            dialog.ShowDialog();
            if(dialog.ValdArtikel != null)
            {
                List<Artikel> updateradeArtiklar;
                using (DataAccess dataAccess = new DataAccess())
                {
                    dataAccess.RegisterArtikelToPerson(nuvarandePerson, dialog.ValdArtikel);
                    updateradeArtiklar = dataAccess.HamtaRegistreradeArtiklar(nuvarandePerson);
                }
                FyllRegistreradeArtiklar(updateradeArtiklar);
            }
        }

        private void FyllRegistreradeArtiklar(List<Artikel> artiklar)
        {
            lbRegistreradeArtiklar.Items.Clear();
            foreach (Artikel artikel in artiklar)
            {
                lbRegistreradeArtiklar.Items.Add(artikel);
            }
        }

        private void laDisplay_DoubleClick(object sender, MouseEventArgs e)
        {
            Clipboard.SetText(((Label)sender).Text);
        }

        private void mouseEnter(object sender, EventArgs e)
        {
            Label theLabel = (Label)sender;
            if (theLabel != clickedLabel)
                theLabel.ForeColor = Config.highlightColor;
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            Label theLabel = (Label)sender;
            if (theLabel != clickedLabel)
                theLabel.ForeColor = Config.standardForeColor;
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Är du säker?", "Prylex", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (DataAccess dataAccess = new DataAccess())
                {
                    dataAccess.RaderaPerson(this.nuvarandePerson);
                }
                this.DialogResult = DialogResult.OK;
            }
        }

        private void cmdSkrivUtEttiket_Click(object sender, EventArgs e)
        {
            if (lbRegistreradeArtiklar.SelectedItem != null)
            {
                Artikel selectedArtikel = (Artikel)lbRegistreradeArtiklar.SelectedItem;
                Printing.PrintLabel(selectedArtikel.DatorNamn, nuvarandePerson.GetNamn(), selectedArtikel.SerieNr, nuvarandePerson.Tillhorighet);
            }
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
