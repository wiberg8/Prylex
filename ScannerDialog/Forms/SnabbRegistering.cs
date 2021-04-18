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
    public partial class SnabbRegistering : Form
    {
        public SnabbRegistering()
        {
            InitializeComponent();
        }

        //form events
        private void HanteraPersonDialogcs_Load(object sender, EventArgs e) => FormStartup();
        //cmd events
        private void cmdSok_Click(object sender, EventArgs e) => SokPersoner();
        private void cmdRegistreraSkanna_Click_1(object sender, EventArgs e) => RegistreraSkannaEttiketPaValdPerson();
        private void cmdRegistreraArtikel_Click_1(object sender, EventArgs e) => RegistreraArtikelPaValdPerson();
        //listbox events
        private void lbPersoner_SelectedIndexChanged(object sender, EventArgs e) => NyPersonSelected();
        //combobox events
        private void cbTillhorighet_SelectedIndexChanged(object sender, EventArgs e) => NyTillhorighetSelected();

        private void FormStartup()
        {
            cbTillhorighet.Items.Add(Locales.ValjTillhorighet);
            cbTillhorighet.SelectedIndex = 0;
            AppSettings.Tillhorigheter.ForEach((string x) => cbTillhorighet.Items.Add(x));
        }
        private void NyTillhorighetSelected()
        {
            lbRegistreradeArtiklar.Items.Clear();
            if (cbTillhorighet.SelectedIndex == 0)
            {
                lbPersoner.Items.Clear();
            }
            else
            {
                List<AdvancedPerson> advancedPersoner = new List<AdvancedPerson>();
                foreach (Person p in DBAccess.HamtaPersonerFranTillhorighet(cbTillhorighet.Text))
                {
                    AdvancedPerson advancedPerson = new AdvancedPerson() { Person = p, RegistreradeArtiklar = DBAccess.HamtaRegistreradeArtiklar(p) };
                    advancedPersoner.Add(advancedPerson);
                }
                FyllPersoner(advancedPersoner);
            }
        }
        private void NyPersonSelected()
        {
            if (lbPersoner.SelectedItem is null)
            {
                lbRegistreradeArtiklar.Items.Clear();
            }
            else
            {
                AdvancedPerson p = lbPersoner.SelectedItem as AdvancedPerson;
                lbRegistreradeArtiklar.Items.Clear();
                p.RegistreradeArtiklar.ForEach((Artikel a) => lbRegistreradeArtiklar.Items.Add(a));
            }
        }
        private void RegistreraArtikelPaValdPerson()
        {
            if (lbPersoner.SelectedItem is null)
            {
                MessageBox.Show("Du måste välja en person");
            }
            else
            {
                Person selectedPerson = (lbPersoner.SelectedItem as AdvancedPerson).Person;
                List<Artikel> ledigaArtiklar;
                ledigaArtiklar = DBAccess.HamtaLedigaArtiklar();
                var dialog = new ValjArtikelDialog(ledigaArtiklar);
                dialog.ShowDialog();
                if (dialog.ValdArtikel != null)
                {
                    KnytArtikelToPerson(dialog.ValdArtikel, selectedPerson);
                }
            }
        }
        private void RegistreraSkannaEttiketPaValdPerson()
        {
            if (lbPersoner.SelectedItem is null)
            {
                MessageBox.Show("Du måste välja en person");
            }
            else
            {
                Person selectedPerson = (lbPersoner.SelectedItem as AdvancedPerson).Person;
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
                        KnytArtikelToPerson(artikel, selectedPerson);
                    }
                }
            }
        }
        private void KnytArtikelToPerson(Artikel artikel, Person person)
        {
            Artikel a;
            DBAccess.RegisterArtikelToPerson(person, artikel);
            a = DBAccess.HamtaArtikelFranId(artikel.Id);
            if (a != null && a.Status == Status.UTE)
            {
                Handelse h = new Handelse() { PersId = person.Id, ArtikelId = a.Id, Typ = HandelseTyp.REGISTRERING };
                DBAccess.InfogaHandelse(h);
            }
            List<AdvancedPerson> advancedPersoner = new List<AdvancedPerson>();
            foreach (Person p in DBAccess.HamtaPersonerFranTillhorighet(cbTillhorighet.Text))
            {
                AdvancedPerson advancedPerson = new AdvancedPerson() { Person = p, RegistreradeArtiklar = DBAccess.HamtaRegistreradeArtiklar(p) };
                advancedPersoner.Add(advancedPerson);
            }
            FyllPersoner(advancedPersoner, person);
            if (a != null && cbPrintOnScan.Checked)
            {
                Printing.PrintLabel(a, person, AppSettings.Skrivare);
            }
        }
        private void SokPersoner()
        {
            lbPersoner.Items.Clear();
            List<AdvancedPerson> advancedPersoner = new List<AdvancedPerson>();
            foreach (Person p in DBAccess.HamtaSokPersoner(txtSok.Text).Where((Person p) => p.Tillhorighet == cbTillhorighet.Text))
            {
                AdvancedPerson advancedPerson = new AdvancedPerson() { Person = p, RegistreradeArtiklar = DBAccess.HamtaRegistreradeArtiklar(p) };
                advancedPersoner.Add(advancedPerson);
            }
            FyllPersoner(advancedPersoner);
        }
        private void FyllPersoner(List<AdvancedPerson> personer)
        {
            personer.Sort();
            lbPersoner.Items.Clear();
            foreach (AdvancedPerson p in personer)
            {
                lbPersoner.Items.Add(p);
            }

        }
        private void FyllPersoner(List<AdvancedPerson> personer, Person previousPerson)
        {
            personer.Sort();
            lbPersoner.Items.Clear();
            foreach (AdvancedPerson p in personer)
            {
                lbPersoner.Items.Add(p);
                if (p.Person.Id == previousPerson.Id)
                {
                    lbPersoner.SelectedIndex = lbPersoner.Items.Count - 1;
                }
            }
        }

        private void lbPersoner_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
