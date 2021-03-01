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
            using (DataAccess dataAccess = new DataAccess())
            {
                FyllHandelser(dataAccess.HamtaHandelserPerson(nuvarandePerson));
            }
            
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
                        Artikel a = dataAccess.HamtaArtikelFranId(selectedArtikel.Id);
                        if (a.Status == Status.INNE) 
                        {
                            Handelse h = new Handelse() { PersId = nuvarandePerson.Id, ArtikelId = a.Id, Typ = HandelseTyp.AVREGISTRERING};
                            dataAccess.InfogaHandelse(h);
                        }
                        FyllHandelser(dataAccess.HamtaHandelserPerson(nuvarandePerson));
                        FyllRegistreradeArtiklar(dataAccess.HamtaRegistreradeArtiklar(nuvarandePerson));
                    }
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
                Artikel a;
                using (DataAccess dataAccess = new DataAccess())
                {
                    dataAccess.RegisterArtikelToPerson(nuvarandePerson, dialog.ValdArtikel);
                    a = dataAccess.HamtaArtikelFranId(dialog.ValdArtikel.Id);
                    if(a.Status == Status.UTE)
                    {
                        Handelse h = new Handelse() { PersId = nuvarandePerson.Id, ArtikelId = a.Id, Typ = HandelseTyp.REGISTRERING};
                        dataAccess.InfogaHandelse(h);
                    }
                    FyllRegistreradeArtiklar(dataAccess.HamtaRegistreradeArtiklar(nuvarandePerson));
                    FyllHandelser(dataAccess.HamtaHandelserPerson(nuvarandePerson));
                }
                if (a != null && cbPrintOnScan.Checked)
                {
                    Printing.PrintLabel(a.DatorNamn, nuvarandePerson.GetNamn(), a.SerieNr, nuvarandePerson.Tillhorighet);
                }
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
                using (DataAccess dataAccess = new DataAccess())
                {
                    artikel = dataAccess.HamtaArtikelFranSerieNr(scannedInput);
                }
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
                    //Skapa en funktion för själva knytningen
                    Artikel a;
                    using (DataAccess dataAccess = new DataAccess())
                    {
                        dataAccess.RegisterArtikelToPerson(nuvarandePerson, artikel);
                        a = dataAccess.HamtaArtikelFranId(artikel.Id);
                        if (a != null && a.Status == Status.UTE)
                        {
                            Handelse h = new Handelse() { PersId = nuvarandePerson.Id, ArtikelId = a.Id, Typ = HandelseTyp.REGISTRERING };
                            dataAccess.InfogaHandelse(h);
                        }
                        FyllRegistreradeArtiklar(dataAccess.HamtaRegistreradeArtiklar(nuvarandePerson));
                        FyllHandelser(dataAccess.HamtaHandelserPerson(nuvarandePerson));
                    }
                    if (a != null && cbPrintOnScan.Checked)
                    {
                        Printing.PrintLabel(a.DatorNamn,nuvarandePerson.GetNamn(), a.SerieNr, nuvarandePerson.Tillhorighet);
                    }
                }
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
                if (!string.IsNullOrEmpty(Printing.exception))
                {
                    MessageBox.Show(Printing.exception);
                }
            }
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            using (var updateraPerson = new UpdateraPersonDialog(this.nuvarandePerson))
            {
                updateraPerson.ShowDialog();
                if (updateraPerson.Result != null)
                {
                    using (DataAccess dataAccess = new DataAccess())
                    {
                        dataAccess.UpdateraPerson(updateraPerson.Result);
                        Person personFromDB = dataAccess.HamtaPersonFranId(updateraPerson.Result.Id);
                        if (personFromDB != null)
                        {
                            this.nuvarandePerson = personFromDB;
                            FyllFalt(this.nuvarandePerson);
                        }
                    }
                }
            }
        }

       

        private void cmdExporteraDatornamn_Click(object sender, EventArgs e)
        {
            var x = new List<string>();
            foreach (Artikel a in lbRegistreradeArtiklar.Items)
            {
                x.Add(a.DatorNamn);
            }
            if(x.Count > 0)
            {
                string t = string.Empty;
                foreach (string g in x)
                {
                    t += g + "\n";
                }
                SaveFileDialog fileDialog = new SaveFileDialog();
                fileDialog.Filter = "Text file(*.txt)|*.txt";
                fileDialog.DefaultExt = "txt";
                fileDialog.AddExtension = true;
                DialogResult dialogResult = fileDialog.ShowDialog();
                if(dialogResult == DialogResult.OK && fileDialog.CheckPathExists && !fileDialog.CheckFileExists)
                {
                    File.WriteAllText(fileDialog.FileName, t);
                }
            }
            
        }

        private void lbHandelser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbHandelser.SelectedItem != null)
            {
                Handelse handelse = (Handelse)lbHandelser.SelectedItem;
                Artikel artikelFromId;
                using (DataAccess dataAccess = new DataAccess())
                {
                    artikelFromId = dataAccess.HamtaArtikelFranId(handelse.ArtikelId);
                }
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
    }
}
