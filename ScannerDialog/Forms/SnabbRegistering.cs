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
        private const string valjTillhorighet = "Välj tillhörighet";

        public SnabbRegistering()
        {
            InitializeComponent();
        }

        private void laTillhorighet_Click(object sender, EventArgs e)
        {

        }

        private void HanteraPersonDialogcs_Load(object sender, EventArgs e)
        {
            cbTillhorighet.Items.Add(valjTillhorighet);
            cbTillhorighet.SelectedIndex = 0;
            AppSettings.Tillhorigheter.ForEach((string x) => cbTillhorighet.Items.Add(x));
        }

        //private void UpdateRegistreradeArtiklar()
        //{
        //    List<Artikel> registreradeArtiklar;
        //    using (DataAccess dataAccess = new DataAccess())
        //    {
        //        registreradeArtiklar = dataAccess.HamtaRegistreradeArtiklar(nuvarandePerson);
        //    }
        //    lbRegistreradeArtiklar.Items.Clear();
        //    foreach (Artikel artikel in registreradeArtiklar)
        //    {
        //        lbRegistreradeArtiklar.Items.Add(artikel);
        //    }
        //}

        private void cmdPersonAndra_Click(object sender, EventArgs e)
        {

        }

        private void cmdArtikelAvregistrera_Click(object sender, EventArgs e)
        {
            
        }

        private void cmdArtikelSok_Click(object sender, EventArgs e)
        {
            //List<Artikel> artiklar;
            //using (DataAccess dataAccess = new DataAccess())
            //{
            //    artiklar = dataAccess.HamtaSokRegistreradeArtiklar(nuvarandePerson, txtArtikelSok.Text);
            //}
            //FyllRegistreradeArtiklar(artiklar);
        }

        //private void cmdShowAllRegistrerade_Click(object sender, EventArgs e)
        //{
        //    List<Artikel> artiklar;
        //    using (DataAccess dataAccess = new DataAccess())
        //    {
        //        artiklar = dataAccess.HamtaRegistreradeArtiklar(nuvarandePerson);
        //    }
        //    FyllRegistreradeArtiklar(artiklar);
        //}

        private void cmdRegistreraArtikel_Click(object sender, EventArgs e)
        {

        }

        private void cmdRegistreraSkanna_Click(object sender, EventArgs e)
        {

        }

        //private void KnytArtikel(Artikel artikel)
        //{
        //    Artikel a;
        //    using (DataAccess dataAccess = new DataAccess())
        //    {
        //        dataAccess.RegisterArtikelToPerson(nuvarandePerson, artikel);
        //        a = dataAccess.HamtaArtikelFranId(artikel.Id);
        //        if (a != null && a.Status == Status.UTE)
        //        {
        //            Handelse h = new Handelse() { PersId = nuvarandePerson.Id, ArtikelId = a.Id, Typ = HandelseTyp.REGISTRERING };
        //            dataAccess.InfogaHandelse(h);
        //        }
        //        FyllRegistreradeArtiklar(dataAccess.HamtaRegistreradeArtiklar(nuvarandePerson));
        //        FyllHandelser(dataAccess.HamtaHandelserPerson(nuvarandePerson));
        //    }
        //    if (a != null && cbPrintOnScan.Checked)
        //    {
        //        Printing.PrintLabel(a.DatorNamn, nuvarandePerson.GetNamn(), a.SerieNr, nuvarandePerson.Tillhorighet);
        //    }
        //}




        private void cmdExporteraDatornamn_Click(object sender, EventArgs e)
        {
            List<string> datorNamnLista = new List<string>();
            foreach (Artikel a in lbRegistreradeArtiklar.Items)
            {
                datorNamnLista.Add(a.DatorNamn);
            }
            if(datorNamnLista.Count > 0)
            {
                string temp = string.Empty;
                datorNamnLista.ForEach((string datorNamn) => temp += datorNamn + "\n");

                SaveFileDialog fileDialog = new SaveFileDialog();
                fileDialog.Filter = "Text file(*.txt)|*.txt";
                fileDialog.DefaultExt = "txt";
                fileDialog.AddExtension = true;
                DialogResult dialogResult = fileDialog.ShowDialog();
                if(dialogResult == DialogResult.OK && fileDialog.CheckPathExists && !fileDialog.CheckFileExists)
                {
                    File.WriteAllText(fileDialog.FileName, temp);
                }
            }
            
        }

        private void lbHandelser_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
            //Interera igenom lbPersoner och casta istället för att gå igenom listan igen
            //for (int i=0; i< personer.Count; i++)
            //{
            //    if (personer[i].Person.Id == previousPerson.Id)
            //    {
            //        lbPersoner.SelectedIndex = i;
            //    }
            //}
        }

        //private void FyllHandelser(List<Handelse> handelser)
        //{
        //    lbHandelser.Items.Clear();
        //    foreach (Handelse handelse in handelser)
        //    {
        //        lbHandelser.Items.Add(handelse);
        //    }
        //}

        private void cbTillhorighet_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbRegistreradeArtiklar.Items.Clear();
            if(cbTillhorighet.SelectedIndex == 0)
            {
                lbPersoner.Items.Clear();
            }
            else
            {
                using (DataAccess dataAccess = new DataAccess())
                {
                    List<AdvancedPerson> advancedPersoner = new List<AdvancedPerson>();
                    foreach (Person p in dataAccess.HamtaPersonerFranTillhorighet(cbTillhorighet.Text))
                    {
                        AdvancedPerson advancedPerson = new AdvancedPerson() { Person = p, RegistreradeArtiklar = dataAccess.HamtaRegistreradeArtiklar(p)};
                        advancedPersoner.Add(advancedPerson);
                    }
                    FyllPersoner(advancedPersoner);
                }
            }
        }

        private void lbPersoner_SelectedIndexChanged(object sender, EventArgs e)
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

        private void cmdRegistreraSkanna_Click_1(object sender, EventArgs e)
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
                        KnytArtikelToperson(artikel, selectedPerson);
                    }
                }
            }
        }
        private void KnytArtikelToperson(Artikel artikel, Person person)
        {
            Artikel a;
            using (DataAccess dataAccess = new DataAccess())
            {
                dataAccess.RegisterArtikelToPerson(person, artikel);
                a = dataAccess.HamtaArtikelFranId(artikel.Id);
                if (a != null && a.Status == Status.UTE)
                {
                    Handelse h = new Handelse() { PersId = person.Id, ArtikelId = a.Id, Typ = HandelseTyp.REGISTRERING };
                    dataAccess.InfogaHandelse(h);
                }
                List<AdvancedPerson> advancedPersoner = new List<AdvancedPerson>();
                foreach (Person p in dataAccess.HamtaPersonerFranTillhorighet(cbTillhorighet.Text))
                {
                    AdvancedPerson advancedPerson = new AdvancedPerson() { Person = p, RegistreradeArtiklar = dataAccess.HamtaRegistreradeArtiklar(p) };
                    advancedPersoner.Add(advancedPerson);
                }
                FyllPersoner(advancedPersoner, person);
            }
            if (a != null && cbPrintOnScan.Checked)
            {
                Printing.PrintLabel(a, person, AppSettings.Skrivare);
            }
        }

        private void cmdRegistreraArtikel_Click_1(object sender, EventArgs e)
        {
            if (lbPersoner.SelectedItem is null)
            {
                MessageBox.Show("Du måste välja en person");
            }
            else
            {
                Person selectedPerson = (lbPersoner.SelectedItem as AdvancedPerson).Person;
                List<Artikel> ledigaArtiklar;
                using (DataAccess dataAccess = new DataAccess())
                {
                    ledigaArtiklar = dataAccess.HamtaLedigaArtiklar();
                }
                var dialog = new ValjArtikelDialog(ledigaArtiklar);
                dialog.ShowDialog();
                if (dialog.ValdArtikel != null)
                {
                    KnytArtikelToperson(dialog.ValdArtikel, selectedPerson);
                }
            }
        }

        private void cmdSok_Click(object sender, EventArgs e)
        {
            lbPersoner.Items.Clear();
            using (DataAccess dataAccess = new DataAccess())
            {
                List<AdvancedPerson> advancedPersoner = new List<AdvancedPerson>();
                foreach (Person p in dataAccess.HamtaSokPersoner(txtSok.Text).Where((Person p) => p.Tillhorighet == cbTillhorighet.Text))
                {
                    AdvancedPerson advancedPerson = new AdvancedPerson() { Person = p, RegistreradeArtiklar = dataAccess.HamtaRegistreradeArtiklar(p) };
                    advancedPersoner.Add(advancedPerson);
                }
                FyllPersoner(advancedPersoner);
            }
        }
    }
}
