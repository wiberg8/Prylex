using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using PrylanLibary;
using PrylanLibary.Enums;
using PrylanLibary.Models;
using PrylanLibary.Validators;
using static ScannerDialog.Program;

namespace ScannerDialog
{
    public partial class HanteraArtikelDialog : Form
    {
        private Artikel nuvarandeArtikel;
        private Person registreradPerson;

        public HanteraArtikelDialog(Artikel _artikelAttEditera)
        {
            InitializeComponent();
            nuvarandeArtikel = _artikelAttEditera;
            FyllFalt(nuvarandeArtikel);
        }

        private void HanteraArtikelDialog_Load(object sender, EventArgs e)
        {
            FormStart();
        }
        private void HanteraArtikelDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        //cmd events
        private void cmdAvbryt_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void cmdRegisterPerson_Click(object sender, EventArgs e)
        {
            RegistreraPersonDialog();
        }
        private void cmdUnregisterPerson_Click(object sender, EventArgs e)
        {
            AvregistreraPerson();
        }
        private void cmdEdit_Click(object sender, EventArgs e)
        {
            EditeraArtikel();
        }
        private void cmdDelete_Click(object sender, EventArgs e)
        {
            RaderaArtikel();
        }
        private void cmdRegistreraScanna_Click(object sender, EventArgs e)
        {
            RegistreraPersonSkanna();
        }
        private void cmdSkrivUtEttiket_Click(object sender, EventArgs e)
        {
            SkrivUtEttiket();
        }
        private void cmdNyHandelse_Click_1(object sender, EventArgs e)
        {
            VisaNyHandelseDialog();
        }
        private void cmdEttiketSerieNr_Click(object sender, EventArgs e)
        {
            Printing.PrintSerieNrLabel(nuvarandeArtikel.SerieNr, AppSettings.Skrivare);
        }

        //label events
        private void laDisplay_DoubleClick(object sender, MouseEventArgs e)
        {
            if (sender is null)
                return;
            Clipboard.SetText(((Label)sender).Text);
        }

        //listbox events
        private void lbHandelser_SelectedIndexChanged(object sender, EventArgs e)
        {
            HandelseSelected();
        }

        //combobox events
        private void cbSelectHandelseTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            HandelseShowTypSelect();
        }

        //shared events
        private void mouseEnter(object sender, EventArgs e)
        {
            Label theLabel = (Label)sender;
            theLabel.ForeColor = Config.HIGHLIGHT_COLOR;
        }
        private void mouseLeave(object sender, EventArgs e)
        {
            Label theLabel = (Label)sender;
            theLabel.ForeColor = Config.STANDARD_FORE_COLOR;
        }

        private void FormStart()
        {
            cbSelectHandelseTyp.Items.Add("Visa alla");
            cbSelectHandelseTyp.Items.Add("Visa registreringar / avregistreringar");
            cbSelectHandelseTyp.Items.Add("Visa Fritext");
            cbSelectHandelseTyp.SelectedIndex = 0;
            txtHandelsePerson.Text = Locales.NoPersonBound;
            registreradPerson = DBAccess.HamtaPersonFranId(nuvarandeArtikel.PersId);
            if (registreradPerson != null)
            {
                txtRegistredPerson.Text = registreradPerson.ToString();
            }
            HandelseShowTypSelect();
            cmdRegisterPerson.Visible = nuvarandeArtikel.Status == Status.INNE;
            cmdRegistreraScanna.Visible = nuvarandeArtikel.Status == Status.INNE;
            cmdUnregisterPerson.Visible = nuvarandeArtikel.Status == Status.UTE;
            cmdSkrivUtEttiket.Visible = nuvarandeArtikel.Status == Status.UTE;
        }
        private void AvregistreraPerson()
        {
            if (MessageBox.Show("Är du säker på att avregistrera artikeln från personen?", "Prylex", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int unregisterPersId = nuvarandeArtikel.PersId;
                DBAccess.AvregistreraArtikelFromPerson(nuvarandeArtikel);
                nuvarandeArtikel = DBAccess.HamtaArtikelFranId(nuvarandeArtikel.Id);
                if (nuvarandeArtikel != null && nuvarandeArtikel.Status == Status.INNE)
                {
                    Handelse handelse = new Handelse() { ArtikelId = nuvarandeArtikel.Id, PersId = unregisterPersId, Typ = HandelseTyp.AVREGISTRERING };
                    DBAccess.InfogaHandelse(handelse);
                    HandelseShowTypSelect();
                }
                FyllFalt(nuvarandeArtikel);
                RefreshArtikelStatus();
            }
        }
        private void RegistreraPerson(Person person)
        {
            txtRegistredPerson.Text = person.ToString();
            DBAccess.RegisterArtikelToPerson(person, nuvarandeArtikel);
            nuvarandeArtikel = DBAccess.HamtaArtikelFranId(nuvarandeArtikel.Id);
            if (nuvarandeArtikel != null)
            {
                if (nuvarandeArtikel.PersId == person.Id)
                {
                    registreradPerson = person;
                }
                Handelse handelse = new Handelse() { ArtikelId = nuvarandeArtikel.Id, PersId = nuvarandeArtikel.PersId, Typ = HandelseTyp.REGISTRERING };
                DBAccess.InfogaHandelse(handelse);
                HandelseShowTypSelect();
            }
            RefreshArtikelStatus();
        }
        private void RegistreraPersonDialog()
        {
            ValjPersonDialog dialog = new ValjPersonDialog(DBAccess.HamtaPersoner());
            dialog.ShowDialog();
            if (dialog.ValdPerson != null)
            {
                txtRegistredPerson.Text = dialog.ValdPerson.ToString();

                DBAccess.RegisterArtikelToPerson(dialog.ValdPerson, nuvarandeArtikel);
                nuvarandeArtikel = DBAccess.HamtaArtikelFranId(nuvarandeArtikel.Id);
                if (nuvarandeArtikel != null)
                {
                    if (nuvarandeArtikel.PersId == dialog.ValdPerson.Id)
                    {
                        registreradPerson = dialog.ValdPerson;
                    }
                    Handelse handelse = new Handelse() { ArtikelId = nuvarandeArtikel.Id, PersId = nuvarandeArtikel.PersId, Typ = HandelseTyp.REGISTRERING };
                    DBAccess.InfogaHandelse(handelse);
                    HandelseShowTypSelect();
                }
                RefreshArtikelStatus();
            }
        }
        private void RegistreraPersonSkanna()
        {
            InputBox inputBox = new InputBox() { PromptText = "Skanna (PersNr)" };
            inputBox.ShowDialog();
            string scannedPersNr = inputBox.Input;
            if (inputBox.DialogResult != DialogResult.OK)
                return;

            if (!PersonValidator.IsPersNrValid(scannedPersNr))
            {
                if (scannedPersNr.Length == 12 || Regex.IsMatch(scannedPersNr, "^[0-9]{8}[-][0-9]{4}$"))
                {
                    scannedPersNr = scannedPersNr.Remove(0, 2);
                }
                if (scannedPersNr.Length == 10)
                {
                    scannedPersNr = scannedPersNr.Insert(6, "-");
                }
                if (!PersonValidator.IsPersNrValid(scannedPersNr))
                {
                    MessageBox.Show("Persnr har felaktig format");
                    return;
                }
            }
            Person personFromInput;
            personFromInput = DBAccess.HamtaPersonFranPersNr(scannedPersNr);
            if (personFromInput is null)
            {
                var result = MessageBox.Show("Ingen träff, Vill du skapa en person med detta pers nr?", string.Empty, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var dialog = new NyPersonSimpelDialog(scannedPersNr);
                    dialog.ShowDialog();
                    if (dialog.Person != null)
                    {
                        bool existerarPerson;
                        existerarPerson = DBAccess.ExisterarPerson(dialog.Person.PersNr);
                        if (existerarPerson)
                        {
                            MessageBox.Show("PersNr existerar redan");
                        }
                        else
                        {
                            Person personFromPersNr;
                            DBAccess.InfogaPerson(dialog.Person);
                            personFromPersNr = DBAccess.HamtaPersonFranPersNr(dialog.Person.PersNr);
                            if (personFromPersNr != null)
                            {
                                RegistreraPerson(personFromPersNr);
                            }
                        }
                    }
                }
            }
            else
            {
                RegistreraPerson(personFromInput);
            }
        }
        private void SkrivUtEttiket()
        {
            if (nuvarandeArtikel is null || registreradPerson is null)
                return;
            if (nuvarandeArtikel.Status == Status.UTE)
            {
                Printing.PrintLabel(nuvarandeArtikel, registreradPerson, AppSettings.Skrivare);
                if (!string.IsNullOrWhiteSpace(Printing.Exception))
                {
                    MessageBox.Show(Printing.Exception);
                }
            }
        }
        private void EditeraArtikel()
        {
            var updateraArtikelDialog = new UpdateraArtikelDialog(this.nuvarandeArtikel);
            updateraArtikelDialog.ShowDialog();
            if (updateraArtikelDialog.Result != null)
            {
                DBAccess.UpdateraArtikel(updateraArtikelDialog.Result);
                Artikel artikelFromDb = DBAccess.HamtaArtikelFranId(updateraArtikelDialog.Result.Id);
                if (artikelFromDb != null)
                {
                    this.nuvarandeArtikel = artikelFromDb;
                    FyllFalt(this.nuvarandeArtikel);
                }
            }
        }
        private void RaderaArtikel()
        {
            if (nuvarandeArtikel.Status == Status.UTE)
            {
                MessageBox.Show("Du måste avregistrera artikeln från personen");
                return;
            }
            if (MessageBox.Show("Är du säker?", "Prylex", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DBAccess.RaderaArtikel(this.nuvarandeArtikel);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void VisaNyHandelseDialog()
        {
            var x = new InputBoxHandelse();
            if (x.ShowDialog() == DialogResult.OK)
            {
                Handelse handelse = new Handelse() { ArtikelId = nuvarandeArtikel.Id, FriText = x.Input, Typ = HandelseTyp.FRITEXT };
                if (nuvarandeArtikel.Status == Status.UTE)
                {
                    handelse.PersId = nuvarandeArtikel.PersId;
                }

                DBAccess.InfogaHandelse(handelse);
                HandelseShowTypSelect();
            }
        }
        private void HandelseSelected()
        {
            if (lbHandelser.SelectedItem is null)
                return;
            Handelse handelse = (Handelse)lbHandelser.SelectedItem;
            Person personFromId;

            personFromId = DBAccess.HamtaPersonFranId(handelse.PersId);
            if (personFromId is null)
            {
                txtHandelsePerson.Text = Locales.NoPersonBound;
            }
            else
            {
                txtHandelsePerson.Text = personFromId.ToString();
            }
        }
        private void HandelseShowTypSelect()
        {
            switch (cbSelectHandelseTyp.SelectedIndex)
            {
                case 0: //Visa alla
                    FyllHandelser(DBAccess.HamtaHandelserArtikel(nuvarandeArtikel));
                    break;
                case 1: //Visa registrering / avregistrering
                    FyllHandelser(DBAccess.HamtaHandelserArtikel(nuvarandeArtikel).Where(h => h.Typ == HandelseTyp.AVREGISTRERING || h.Typ == HandelseTyp.REGISTRERING).ToList());
                    break;
                case 2:
                    FyllHandelser(DBAccess.HamtaHandelserArtikel(nuvarandeArtikel).Where(h => h.Typ == HandelseTyp.FRITEXT).ToList());
                    break;
            }
        }
        private void RefreshArtikelStatus()
        {
            if (nuvarandeArtikel.Status == Status.INNE)
            {
                txtRegistredPerson.Text = string.Empty;
                registreradPerson = null;
                cmdUnregisterPerson.Visible = false;
                cmdRegisterPerson.Visible = true;
                cmdRegistreraScanna.Visible = true;
                cmdSkrivUtEttiket.Visible = false;
            }
            else
            {
                cmdUnregisterPerson.Visible = true;
                cmdRegisterPerson.Visible = false;
                cmdRegistreraScanna.Visible = false;
                cmdSkrivUtEttiket.Visible = true;
            }
        }

        private void FyllHandelser(List<Handelse> handelser)
        {
            lbHandelser.Items.Clear();
            lbHandelser.Items.AddRange(handelser.ToArray());
        }
        private void FyllFalt(Artikel artikel)
        {
            laArtikelDisplay.Text = artikel.Id.ToString();
            laBeskrivningDisplay.Text = artikel.Beskrivning;
            laStoldtagDisplay.Text = artikel.StoldTag;
            laDatornamnDisplay.Text = artikel.DatorNamn;
            laMACDisplay.Text = artikel.Mac;
            laInkopDisplay.Text = artikel.Inkop;
            laOSDisplay.Text = artikel.Os;
            laSerieNrDisplay.Text = artikel.SerieNr;
            laOvrigtDisplay.Text = artikel.Ovrigt;
        }
    }
}
