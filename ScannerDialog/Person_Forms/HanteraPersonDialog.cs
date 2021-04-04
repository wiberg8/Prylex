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
        private string noPersonBound = "Ingen artikel knyten till händelsen";

        public HanteraPersonDialog(Person personAttEditera)
        {
            InitializeComponent();
            nuvarandePerson = personAttEditera;
        }

        //form events
        private void HanteraPersonDialogcs_Load(object sender, EventArgs e)
        {
            FormStartup();
        }
        private void HanteraPersonDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        //cmd events
        private void cmdArtikelAvregistrera_Click(object sender, EventArgs e)
        {
            AvregistreraSelectedArtikel();
        }
        private void cmdArtikelSok_Click(object sender, EventArgs e)
        {
            SokRegistreradeArtiklar();
        }
        private void cmdShowAllRegistrerade_Click(object sender, EventArgs e)
        {
            VisaRegistreradeArtiklar();
        }   
        private void cmdRegistreraArtikel_Click(object sender, EventArgs e)
        {
            RegistreraArtikelViaDialog();
        }
        private void cmdRegistreraSkanna_Click(object sender, EventArgs e)
        {
            RegistreraViaSkannaEttiket();
        }
        private void cmdDelete_Click(object sender, EventArgs e)
        {
            RaderaPerson();
        }
        private void cmdSkrivUtEttiket_Click(object sender, EventArgs e)
        {
            SkrivUtEttiket();
        }
        private void cmdEdit_Click(object sender, EventArgs e)
        {
            UpdateraPerson();
        }
        private void cmdExporteraDatornamn_Click(object sender, EventArgs e)
        {
            ExporteraArtikelLista();
        }

        //listbox events
        private void lbHandelser_SelectedIndexChanged(object sender, EventArgs e)
        {
            HandelseSelected();
        }

        //combox events
        private void cbSelectHandelseTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            HandelseShowTypSelect();
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
            theLabel.ForeColor = Config.HighlightColor;
        }
        private void mouseLeave(object sender, EventArgs e)
        {
            Label theLabel = (Label)sender;
            theLabel.ForeColor = Config.StandardForeColor;
        }

        private void FormStartup()
        {
            cbSelectHandelseTyp.Items.Add("Visa alla");
            cbSelectHandelseTyp.Items.Add("Visa registreringar / avregistreringar");
            cbSelectHandelseTyp.Items.Add("Visa Fritext");
            cbSelectHandelseTyp.SelectedIndex = 0;
            FyllFalt(nuvarandePerson);
            VisaHandelser();
            VisaRegistreradeArtiklar();
        }

        private void SkrivUtEttiket()
        {
            if (lbRegistreradeArtiklar.SelectedItem is null)
            {
                MessageBox.Show("Du måste välja en registrerad artikel");
            }
            else
            {
                Artikel selectedArtikel = (Artikel)lbRegistreradeArtiklar.SelectedItem;
                Printing.PrintLabel(selectedArtikel, nuvarandePerson, AppSettings.Skrivare);
                if (!string.IsNullOrEmpty(Printing.Exception))
                {
                    MessageBox.Show(Printing.Exception);
                }
            }
        }
        private void ExporteraArtikelLista()
        {
            List<Artikel> artiklar = lbRegistreradeArtiklar.Items.Cast<Artikel>().ToList();
            if (artiklar.Count > 0)
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

        private void UpdateraPerson()
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
        private void RaderaPerson()
        {
            List<Artikel> registreradeArtiklar = DBAccess.HamtaRegistreradeArtiklar(nuvarandePerson);
            if (registreradeArtiklar.Count < 1)
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

        private void HandelseSelected()
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
        private void HandelseShowTypSelect()
        {
            switch (cbSelectHandelseTyp.SelectedIndex)
            {
                case 0: //Visa alla
                    FyllHandelser(DBAccess.HamtaHandelserPerson(nuvarandePerson));
                    break;
                case 1: //Visa registrering / avregistrering
                    FyllHandelser(DBAccess.HamtaHandelserPerson(nuvarandePerson).Where(h => h.Typ == HandelseTyp.AVREGISTRERING || h.Typ == HandelseTyp.REGISTRERING).ToList());
                    break;
                case 2:
                    FyllHandelser(DBAccess.HamtaHandelserPerson(nuvarandePerson).Where(h => h.Typ == HandelseTyp.FRITEXT).ToList());
                    break;
            }
        }

        private void RegistreraOnPerson(Artikel artikel)
        {
            Artikel artikelFranId;
            DBAccess.RegisterArtikelToPerson(nuvarandePerson, artikel);
            artikelFranId = DBAccess.HamtaArtikelFranId(artikel.Id);
            if (artikelFranId != null && artikelFranId.Status == Status.UTE)
            {
                Handelse h = new Handelse() { PersId = nuvarandePerson.Id, ArtikelId = artikelFranId.Id, Typ = HandelseTyp.REGISTRERING };
                DBAccess.InfogaHandelse(h);
            }
            VisaRegistreradeArtiklar();
            FyllHandelser(DBAccess.HamtaHandelserPerson(nuvarandePerson));
            if (artikelFranId != null && cbPrintOnScan.Checked)
            {
                Printing.PrintLabel(artikelFranId, nuvarandePerson, AppSettings.Skrivare);
            }
        }
        private void RegistreraViaSkannaEttiket()
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
                    RegistreraOnPerson(artikel);
                }
            }
        }
        private void RegistreraArtikelViaDialog()
        {
            List<Artikel> ledigaArtiklar = DBAccess.HamtaLedigaArtiklar();
            var dialog = new ValjArtikelDialog(ledigaArtiklar);
            dialog.ShowDialog();
            if (dialog.ValdArtikel != null)
            {
                RegistreraOnPerson(dialog.ValdArtikel);
            }
        }
        private void AvregistreraSelectedArtikel()
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
                    Handelse h = new Handelse() { PersId = nuvarandePerson.Id, ArtikelId = a.Id, Typ = HandelseTyp.AVREGISTRERING };
                    DBAccess.InfogaHandelse(h);
                }
                FyllHandelser(DBAccess.HamtaHandelserPerson(nuvarandePerson));
                FyllRegistreradeArtiklar(DBAccess.HamtaRegistreradeArtiklar(nuvarandePerson));
                laAntalRegArtiklar.Text = $"Antal: {lbRegistreradeArtiklar.Items.Count}";
            }
        }

        private void VisaRegistreradeArtiklar()
        {
            List<Artikel> artiklar = DBAccess.HamtaRegistreradeArtiklar(nuvarandePerson);
            FyllRegistreradeArtiklar(artiklar);
        }
        private void VisaHandelser()
        {
            List<Handelse> handelser = DBAccess.HamtaHandelserPerson(nuvarandePerson);
            FyllHandelser(handelser);
        }
        private void SokRegistreradeArtiklar()
        {
            List<Artikel> artiklar = DBAccess.HamtaSokRegistreradeArtiklar(nuvarandePerson, txtArtikelSok.Text);
            FyllRegistreradeArtiklar(artiklar);
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
        private void FyllRegistreradeArtiklar(List<Artikel> artiklar)
        {
            lbRegistreradeArtiklar.Items.Clear();
            lbRegistreradeArtiklar.Items.AddRange(artiklar.ToArray());
            laAntalRegArtiklar.Text = $"Antal: {lbRegistreradeArtiklar.Items.Count}";
        }
        private void FyllHandelser(List<Handelse> handelser)
        {
            lbHandelser.Items.Clear();
            lbHandelser.Items.AddRange(handelser.ToArray());
        }
    }
}
