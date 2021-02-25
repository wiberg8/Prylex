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
using PrylanLibary.Enums;
using PrylanLibary.Models;

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
            List<Handelse> handelser;
            using (DataAccess dataAccess = new DataAccess())
            {
                registreradPerson = dataAccess.HamtaPersonFranId(artikelAttEditera.PersId);
                if(registreradPerson != null)
                {
                    txtRegistredPerson.Text = registreradPerson.ToString();
                }
                handelser = dataAccess.HamtaHandelserArtikel(artikelAttEditera);
            }   
            lbHandelser.DataSource = handelser;
            cmdRegisterPerson.Visible = artikelAttEditera.Status == Status.INNE;
            cmdUnregisterPerson.Visible = artikelAttEditera.Status == Status.UTE;
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
                        Handelse handelse = new Handelse() { ArtikelId = artikelAttEditera.Id, PersId = artikelAttEditera.PersId, Typ = HandelseTyp.REGISTRERING};
                        dataAccess.InfogaHandelse(handelse);
                        lbHandelser.DataSource =  dataAccess.HamtaHandelserArtikel(artikelAttEditera);
                    }
                }
                SetArtikelEditStatus();
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
                        lbHandelser.DataSource = dataAccess.HamtaHandelserArtikel(artikelAttEditera);
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
            }
            else
            {
                cmdUnregisterPerson.Visible = true;
                cmdRegisterPerson.Visible = false;
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
            Clipboard.SetText(((Label)sender).Text);
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
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
                Printing.PrintLabel(artikelAttEditera.DatorNamn, registreradPerson.GetNamn(), artikelAttEditera.SerieNr, registreradPerson.Tillhorighet);
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
                    lbHandelser.DataSource = dataAccess.HamtaHandelserArtikel(artikelAttEditera);
                }
            }
        }

        private void lbHandelser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbHandelser.SelectedItem != null)
            {
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
        }
    }
}
