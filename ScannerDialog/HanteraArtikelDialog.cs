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
    public partial class HanteraArtikelDialog : Form
    {
        private Artikel artikelAttEditera;
        private Person registreradPerson;
        public HanteraArtikelDialog(Artikel _artikelAttEditera)
        {
            InitializeComponent();
            artikelAttEditera = _artikelAttEditera;
            FyllFalt(artikelAttEditera);
        }

        private void ManageArticle_Load(object sender, EventArgs e)
        {
            using (DataAccess dataAccess = new DataAccess())
            {
                registreradPerson = dataAccess.HamtaPersonFranId(artikelAttEditera.PersId);
                if(registreradPerson != null)
                {
                    txtRegistredPerson.Text = registreradPerson.ToString();
                }
            }
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
            if (artikel.AndvandInkop)
                laInkopDisplay.Text = artikel.Inkop;
            else
                laInkopDisplay.Text = string.Empty;
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
                    dataAccess.UnregisterArtikelFromPerson(artikelAttEditera);
                    artikelAttEditera = dataAccess.HamtaArtikelFranId(artikelAttEditera.Id);
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
    }
}
