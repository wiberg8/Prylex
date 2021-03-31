using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using PrylanLibary;
using PrylanLibary.Models;
using PrylanLibary.Enums;
using static ScannerDialog.Program;

namespace ScannerDialog
{
    public partial class HanteraPersonDialog : Form
    {
        private Person nuvarandePerson;
        private Label clickedLabel;
        private string noPersonBound = "Ingen artikel knyten till händelsen";

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
            FyllHandelser(DBAccess.HamtaHandelserPerson(nuvarandePerson));
            UpdateRegistreradeArtiklar();
        }

        private void UpdateRegistreradeArtiklar()
        {
            List<Artikel> registreradeArtiklar;
            registreradeArtiklar = DBAccess.HamtaRegistreradeArtiklar(nuvarandePerson);
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
                    DBAccess.UnregisterArtikelFromPerson(selectedArtikel);
                    Artikel a = DBAccess.HamtaArtikelFranId(selectedArtikel.Id);
                    if (a.Status == Status.INNE) 
                    {
                        Handelse h = new Handelse() { PersId = nuvarandePerson.Id, ArtikelId = a.Id, Typ = HandelseTyp.AVREGISTRERING};
                        DBAccess.InfogaHandelse(h);
                    }
                    FyllHandelser(DBAccess.HamtaHandelserPerson(nuvarandePerson));
                    FyllRegistreradeArtiklar(DBAccess.HamtaRegistreradeArtiklar(nuvarandePerson));
            }
        }

        private void cmdArtikelSok_Click(object sender, EventArgs e)
        {
            List<Artikel> artiklar;
            artiklar = DBAccess.HamtaSokRegistreradeArtiklar(nuvarandePerson, txtArtikelSok.Text);
            FyllRegistreradeArtiklar(artiklar);
        }

        private void cmdShowAllRegistrerade_Click(object sender, EventArgs e)
        {
            List<Artikel> artiklar;
            artiklar = DBAccess.HamtaRegistreradeArtiklar(nuvarandePerson);
            FyllRegistreradeArtiklar(artiklar);
        }

        private void cmdRegistreraArtikel_Click(object sender, EventArgs e)
        {
            List<Artikel> ledigaArtiklar;
            ledigaArtiklar = DBAccess.HamtaLedigaArtiklar();
            var dialog = new ValjArtikelDialog(ledigaArtiklar);
            dialog.ShowDialog();
            if(dialog.ValdArtikel != null)
            {
                KnytArtikel(dialog.ValdArtikel);
            }
        }

        private void cmdRegistreraSkanna_Click(object sender, EventArgs e)
        {
            InputBox inputBox = new InputBox() { PromptText = "Skanna Ettiket (SerieNr)" };
            inputBox.ShowDialog();
            string scannedInput = inputBox.Input.ToUpper();

            if (!string.IsNullOrWhiteSpace(scannedInput))
            {
                Artikel artikel;
                artikel = DBAccess.HamtaArtikelFranSerieNr(scannedInput);
                if (artikel is null)
                {
                    MessageBox.Show("Inga träffar");
                }
                else if (artikel.Status == Status.UTE)
                {
                    MessageBox.Show("Artikeln är redan utlämnad");
                }
                else
                {
                    KnytArtikel(artikel);
                }
            }

        }

        private void KnytArtikel(Artikel artikel)
        {
            Artikel a;
            DBAccess.RegisterArtikelToPerson(nuvarandePerson, artikel);
            a = DBAccess.HamtaArtikelFranId(artikel.Id);
            if (a != null && a.Status == Status.UTE)
            {
                Handelse h = new Handelse() { PersId = nuvarandePerson.Id, ArtikelId = a.Id, Typ = HandelseTyp.REGISTRERING };
                DBAccess.InfogaHandelse(h);
            }
            FyllRegistreradeArtiklar(DBAccess.HamtaRegistreradeArtiklar(nuvarandePerson));
            FyllHandelser(DBAccess.HamtaHandelserPerson(nuvarandePerson));
            if (a != null && cbPrintOnScan.Checked)
            {
                Printing.PrintLabel(a, nuvarandePerson, AppSettings.Skrivare);
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
            if (sender is null)
                return;
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
            List<Artikel> registreradeArtiklar;

            registreradeArtiklar = DBAccess.HamtaRegistreradeArtiklar(nuvarandePerson);
            if(registreradeArtiklar.Count < 1)
            {
                if (MessageBox.Show("Är du säker?", "Prylex", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DBAccess.RaderaPerson(this.nuvarandePerson);
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show($"{nuvarandePerson.GetNamn()} har artiklar fortfarande registrerade på sig");
            }
        }

        private void cmdSkrivUtEttiket_Click(object sender, EventArgs e)
        {
            if (lbRegistreradeArtiklar.SelectedItem != null)
            {
                Artikel selectedArtikel = (Artikel)lbRegistreradeArtiklar.SelectedItem;
                Printing.PrintLabel(selectedArtikel, nuvarandePerson, AppSettings.Skrivare);
                if (!string.IsNullOrEmpty(Printing.exception))
                {
                    MessageBox.Show(Printing.exception);
                }
            }
            else
            {
                MessageBox.Show("Du måste välja en registrerad artikel");
            }
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            using (var updateraPerson = new UpdateraPersonDialog(this.nuvarandePerson))
            {
                updateraPerson.ShowDialog();
                if (updateraPerson.Result != null)
                {
                    DBAccess.UpdateraPerson(updateraPerson.Result);
                    Person personFromDB = DBAccess.HamtaPersonFranId(updateraPerson.Result.Id);
                    if (personFromDB != null)
                    {
                        this.nuvarandePerson = personFromDB;
                        FyllFalt(this.nuvarandePerson);
                    }
                }
            }
        }

       

        private void cmdExporteraDatornamn_Click(object sender, EventArgs e)
        {
            List<Artikel> artiklar = lbRegistreradeArtiklar.Items.Cast<Artikel>().ToList();
            if(artiklar.Count > 0)
            {
                SaveFileDialog fileDialog = new SaveFileDialog
                {
                    Filter = "Json file(*.json)|*.json",
                    DefaultExt = "json",
                    AddExtension = true
                };
                DialogResult dialogResult = fileDialog.ShowDialog();
                if (dialogResult == DialogResult.OK && fileDialog.CheckPathExists && !fileDialog.CheckFileExists)
                {
                    File.WriteAllText(fileDialog.FileName, artiklar.ToJson());
                }
            }
        }

        private void lbHandelser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbHandelser.SelectedItem != null)
            {
                Handelse handelse = (Handelse)lbHandelser.SelectedItem;
                Artikel artikelFromId;
                artikelFromId = DBAccess.HamtaArtikelFranId(handelse.ArtikelId);
                if (artikelFromId is null)
                {
                    txtHandelseArtikel.Text = noPersonBound;
                }
                else
                {
                    txtHandelseArtikel.Text = artikelFromId.ToString();
                }
            }
        }

        private void FyllHandelser(List<Handelse> handelser)
        {
            lbHandelser.Items.Clear();
            foreach (Handelse handelse in handelser)
            {
                lbHandelser.Items.Add(handelse);
            }
        }

        private void cbPrintOnScan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void HanteraPersonDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) 
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
