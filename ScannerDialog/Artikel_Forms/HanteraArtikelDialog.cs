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
        private Label clickedLabel;
        private Artikel artikelAttEditera;
        private Person registreradPerson;
        private string noPersonBound = "Ingen person knyten till händelsen";
        public HanteraArtikelDialog(Artikel _artikelAttEditera)
        {
            InitializeComponent();
            artikelAttEditera = _artikelAttEditera;
            FyllFalt(artikelAttEditera);
        }

        private void ManageArticle_Load(object sender, EventArgs e)
        {
            txtHandelsePerson.Text = noPersonBound;
            using (DataAccess dataAccess = new DataAccess())
            {
                registreradPerson = dataAccess.HamtaPersonFranId(artikelAttEditera.PersId);
                if(registreradPerson != null)
                {
                    txtRegistredPerson.Text = registreradPerson.ToString();
                }
                FyllHandelser(dataAccess.HamtaHandelserArtikel(artikelAttEditera));
            }
            cmdRegisterPerson.Visible = artikelAttEditera.Status == Status.INNE;
            cmdRegistreraScanna.Visible = artikelAttEditera.Status == Status.INNE;
            cmdUnregisterPerson.Visible = artikelAttEditera.Status == Status.UTE;
            cmdSkrivUtEttiket.Visible = artikelAttEditera.Status == Status.UTE;
        }

        private void gbFields_Enter(object sender, EventArgs e)
        {

        }

        private void laSerial_Click(object sender, EventArgs e)
        {

        }

        private void txtSerial_TextChanged(object sender, EventArgs e)
        {

        }

        private void laDescription_Click(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void laOS_Click(object sender, EventArgs e)
        {

        }

        private void txtOs_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMAC_TextChanged(object sender, EventArgs e)
        {

        }

        private void laMAC_Click(object sender, EventArgs e)
        {

        }

        private void laTag_Click(object sender, EventArgs e)
        {

        }

        private void txtTag_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdArticleEdit_Click(object sender, EventArgs e)
        {

        }

        private void cmdNyHandelse_Click(object sender, EventArgs e)
        {
           
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

        private void cmdArtikelEditera_Click(object sender, EventArgs e)
        {

        }

        private void cmdArtikelAndra_Click(object sender, EventArgs e)
        {
            var nyArtikelDialog = new NyArtikelDialog(artikelAttEditera);
            var dialogResult = nyArtikelDialog.ShowDialog();
            //if (nyArtikelDialog.Updaterad)
            //{
            //    //artikelAttEditera = nyArtikelDialog.UpdateradArtikel;
            //    FyllFalt(artikelAttEditera);
            //}
        }

        private void cmdAvbryt_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void cmdRegisterPerson_Click(object sender, EventArgs e)
        {
            ValjPersonDialog dialog;
            using (DataAccess dataAccess = new DataAccess())
            { 
                dialog = new ValjPersonDialog(dataAccess.HamtaPersoner());
            }
            dialog.ShowDialog();
            if (dialog.ValdPerson != null)
            { 
                txtRegistredPerson.Text = dialog.ValdPerson.ToString();
                using (DataAccess dataAccess = new DataAccess())
                {
                    dataAccess.RegisterArtikelToPerson(dialog.ValdPerson, artikelAttEditera);
                    artikelAttEditera = dataAccess.HamtaArtikelFranId(artikelAttEditera.Id);
                    if (artikelAttEditera != null )
                    {
                        if(artikelAttEditera.PersId == dialog.ValdPerson.Id)
                        {
                            registreradPerson = dialog.ValdPerson;
                        }
                        Handelse handelse = new Handelse() { ArtikelId = artikelAttEditera.Id, PersId = artikelAttEditera.PersId, Typ = HandelseTyp.REGISTRERING};
                        dataAccess.InfogaHandelse(handelse);
                        FyllHandelser(dataAccess.HamtaHandelserArtikel(artikelAttEditera));
                    }
                }
                SetArtikelEditStatus();
            }   
        }

        private void RegistreraPerson(Person person)
        {
            txtRegistredPerson.Text = person.ToString();
            using (DataAccess dataAccess = new DataAccess())
            {
                dataAccess.RegisterArtikelToPerson(person, artikelAttEditera);
                artikelAttEditera = dataAccess.HamtaArtikelFranId(artikelAttEditera.Id);
                if (artikelAttEditera != null)
                {
                    if (artikelAttEditera.PersId == person.Id)
                    {
                        registreradPerson = person;
                    }
                    Handelse handelse = new Handelse() { ArtikelId = artikelAttEditera.Id, PersId = artikelAttEditera.PersId, Typ = HandelseTyp.REGISTRERING };
                    dataAccess.InfogaHandelse(handelse);
                    FyllHandelser(dataAccess.HamtaHandelserArtikel(artikelAttEditera));
                }
            }
            SetArtikelEditStatus();
        }

        private void FyllHandelser(List<Handelse> handelser)
        {
            lbHandelser.Items.Clear();
            foreach (Handelse handelse in handelser)
            {
                lbHandelser.Items.Add(handelse);
            }
        }

        private void cmdUnregisterPerson_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Är du säker på att avregistrera artikeln från personen?", "Prylex", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (DataAccess dataAccess = new DataAccess())
                {
                    int unregisterPersId = artikelAttEditera.PersId; 
                    dataAccess.UnregisterArtikelFromPerson(artikelAttEditera);
                    artikelAttEditera = dataAccess.HamtaArtikelFranId(artikelAttEditera.Id);
                    if (artikelAttEditera != null && artikelAttEditera.Status == Status.INNE)
                    {
                        Handelse handelse = new Handelse() { ArtikelId = artikelAttEditera.Id, PersId = unregisterPersId, Typ = HandelseTyp.AVREGISTRERING };
                        dataAccess.InfogaHandelse(handelse);
                        FyllHandelser(dataAccess.HamtaHandelserArtikel(artikelAttEditera));
                    }
                }
                FyllFalt(artikelAttEditera);
                SetArtikelEditStatus();
            }
        }

        private void SetArtikelEditStatus()
        {
            if (artikelAttEditera.Status == Status.INNE)
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

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            var updateraArtikelDialog = new UpdateraArtikelDialog(this.artikelAttEditera);
            updateraArtikelDialog.ShowDialog();
            if (updateraArtikelDialog.Result != null)
            {
                using (DataAccess dataAccess = new DataAccess())
                {
                    dataAccess.UpdateraArtikel(updateraArtikelDialog.Result);
                    Artikel artikelFromDb = dataAccess.HamtaArtikelFranId(updateraArtikelDialog.Result.Id);
                    if (artikelFromDb != null)
                    {
                        this.artikelAttEditera = artikelFromDb;
                        FyllFalt(this.artikelAttEditera);
                    }
                }
            }
        }

     

        private void laDisplay_DoubleClick(object sender, MouseEventArgs e)
        {
            if (sender is null)
                return;
            Clipboard.SetText(((Label)sender).Text);
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if(artikelAttEditera.Status == Status.UTE)
            {
                MessageBox.Show("Du måste avregistrera artikeln från personen");
                return;
            }
            if (MessageBox.Show("Är du säker?", "Prylex", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (DataAccess dataAccess = new DataAccess())
                {
                    dataAccess.RaderaArtikel(this.artikelAttEditera);
                }
                this.DialogResult = DialogResult.OK;
            }
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

        private void cmdSkrivUtEttiket_Click(object sender, EventArgs e)
        {
            if (artikelAttEditera is null || registreradPerson is null)
                return;
            if (artikelAttEditera.Status == Status.UTE)
            {
                Printing.PrintLabel(artikelAttEditera, registreradPerson, AppSettings.Skrivare);
                if (!string.IsNullOrWhiteSpace(Printing.exception))
                {
                    MessageBox.Show(Printing.exception);
                }
            }
        }

        private void cmdNyHandelse_Click_1(object sender, EventArgs e)
        {
            var x = new InputBoxHandelse();
            if (x.ShowDialog() == DialogResult.OK)
            {
                Handelse handelse = new Handelse() { ArtikelId = artikelAttEditera.Id, FriText = x.Input, Typ = HandelseTyp.FRITEXT };
                if(artikelAttEditera.Status == Status.UTE)
                {
                    handelse.PersId = artikelAttEditera.PersId;
                }
                
                using (DataAccess dataAccess = new DataAccess())
                {
                    dataAccess.InfogaHandelse(handelse);
                    FyllHandelser(dataAccess.HamtaHandelserArtikel(artikelAttEditera));
                }
            }
        }

        private void lbHandelser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbHandelser.SelectedItem is null)
                return;
            Handelse handelse = (Handelse)lbHandelser.SelectedItem;
            Person personFromId;
            using (DataAccess dataAccess = new DataAccess())
            {
                personFromId = dataAccess.HamtaPersonFranId(handelse.PersId);
            }
            if (personFromId is null)
            {
                txtHandelsePerson.Text = noPersonBound;
            }
            else
            {
                txtHandelsePerson.Text = personFromId.ToString();
            }
        }

        private void HanteraArtikelDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void cmdRegistreraScanna_Click(object sender, EventArgs e)
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
            using (DataAccess dataAccess = new DataAccess())
            {
                personFromInput = dataAccess.HamtaPersonFranPersNr(scannedPersNr);
            }
            if(personFromInput is null)
            {
                var result = MessageBox.Show("Ingen träff, Vill du skapa en person med detta pers nr?", string.Empty, MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    var dialog = new NyPersonSimpelDialog(scannedPersNr);
                    dialog.ShowDialog();
                    if (dialog.Person != null)
                    {
                        bool existerarPerson;
                        using (DataAccess dataAccess = new DataAccess())
                        {
                            existerarPerson = dataAccess.ExisterarPerson(dialog.Person.PersNr);
                        }
                        if (existerarPerson)
                        {
                            MessageBox.Show("PersNr existerar redan");
                        }
                        else
                        {
                            Person personFromPersNr;
                            using (DataAccess dataAccess = new DataAccess())
                            {
                                dataAccess.InfogaPerson(dialog.Person);
                                personFromPersNr = dataAccess.HamtaPersonFranPersNr(dialog.Person.PersNr);
                            }
                            if(personFromPersNr != null)
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
    }
}
