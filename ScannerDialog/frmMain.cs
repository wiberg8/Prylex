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
    public partial class frmMain : Form
    {
      
        public frmMain()
        {
            InitializeComponent();
            Installningar.Change += Installningar_Change;
            DataAccess.ArtikelChange += Artiklar_Change;
            DBHandler.ConnectionChanged += Database_Connection_Changed;
        }

        private void Database_Connection_Changed(object sender, EventArgs e)
        {
            
        }

        private void Installningar_Change(object sender, EventArgs e)
        {
            var ins = (Installningar)sender;
      
        }

        private void Artiklar_Change(object sender, EventArgs e)
        {
            //dgvArtiklar.Rows.Clear();
        }

        private void tspScan_Click(object sender, EventArgs e)
        {
            
        }

        private void tspScan_Click_1(object sender, EventArgs e)
        {

        }

        private void tspArticlesNew_Click(object sender, EventArgs e)
        {
            using(NyArtikelDialog artikelDialog = new NyArtikelDialog())
            {
                var result = artikelDialog.ShowDialog();
   
            }
        }

        private void tspPeopleNew_Click(object sender, EventArgs e)
        {
            var newPersonDialog = new NyPersonDialog();
            newPersonDialog.ShowDialog();
        }

        private void cmdTesting_Click(object sender, EventArgs e)
        {
            
        }

        private void tspFileNewDB_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Database file(*.db)|*.db";
            fileDialog.DefaultExt = "db";
            fileDialog.AddExtension = true;
            DialogResult dialogResult = fileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                DBHandler.CreateFile(fileDialog.FileName);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Installningar ins = Installningar.Hamta();
        }

        private void tspArkivInstallningar_Click(object sender, EventArgs e)
        {
            var dialog = new InstallningarDialog();
            DialogResult result = dialog.ShowDialog();
            
        }
 
        private void cmdSearch_Click(object sender, EventArgs e)
        {
            using (var dataAccess = new DataAccess())
            {
                if (rbSearchSelectArticle.Checked)
                {
                    List<Artikel> artiklar = dataAccess.HamtaSokArtiklar(txtSok.Text);
                    dataAccess.Close();
                    VisaValjArtikelDialog(artiklar);
                }
                    
                if (rbSearchSelectPerson.Checked)
                {
                    List<Person> personer = dataAccess.HamtaSokPersoner(txtSok.Text);
                    dataAccess.Close();
                    VisaValjPersonDialog(personer);
                }
            }
        }

        private void VisaValjArtikelDialog(List<Artikel> artiklar)
        {
            using (var valjDialog = new ValjArtikelDialog(artiklar))
            {
                valjDialog.ShowDialog();

                if (valjDialog.ValdArtikel != null)
                {
                    var artikelDialog = new HanteraArtikelDialog(valjDialog.ValdArtikel);
                    artikelDialog.ShowDialog();
                }
            }
        }

        private void VisaValjPersonDialog(List<Person> personer)
        {
            using (var valjDialog = new ValjPersonDialog(personer))
            {
                valjDialog.ShowDialog();

                if (valjDialog.ValdPerson != null)
                {
                    var artikelDialog = new HanteraPersonDialog(valjDialog.ValdPerson);
                    artikelDialog.ShowDialog();
                }
            }
        }

        private void cmdVisaAllaArtiklar_Click(object sender, EventArgs e)
        {
            using (var dataAccess = new DataAccess())
            {
                VisaValjArtikelDialog(dataAccess.HamtaArtiklar());
            }
        }

        private void cmdSokVisaAlla_Click(object sender, EventArgs e)
        {
            List<Artikel> artikelList = new List<Artikel>();
            List<Person> personList = new List<Person>();
            using (var dataAccess = new DataAccess())
            {
                if (rbSearchSelectArticle.Checked)
                {
                    artikelList = dataAccess.HamtaArtiklar();
                }
                else if (rbSearchSelectPerson.Checked)
                {
                    personList = dataAccess.HamtaPersoner();
                }
            }
            if (rbSearchSelectArticle.Checked)
            {
                VisaValjArtikelDialog(artikelList);
            }
            else if (rbSearchSelectPerson.Checked)
            {
                VisaValjPersonDialog(personList);
            }
        }

        private void gbSearch_Enter(object sender, EventArgs e)
        {

        }

        private void cmdSok_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtSok_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtSok_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (var dataAccess = new DataAccess())
                {
                    if (rbSearchSelectArticle.Checked)
                        VisaValjArtikelDialog(dataAccess.HamtaSokArtiklar(txtSok.Text));
                    if (rbSearchSelectPerson.Checked)
                        VisaValjPersonDialog(dataAccess.HamtaSokPersoner(txtSok.Text));
                }
            }

        }

        private void cmdScanLabel_Click(object sender, EventArgs e)
        {
            InputBox inputBox = new InputBox();
            inputBox.ShowDialog();
            if (!string.IsNullOrWhiteSpace(inputBox.Input))
            {
                Artikel artikel;
                using (DataAccess dataAccess = new DataAccess())
                {
                    artikel = dataAccess.HamtaArtikelFranSerieNr(inputBox.Input);
                }
                if (artikel != null)
                {
                    var artikelDialog = new HanteraArtikelDialog(artikel);
                    artikelDialog.ShowDialog();
                }
            }
        }

        //private void dgvArtiklar_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    if (dgvArtiklar.SelectedRows.Count > 0)
        //    {
        //        Artikel valdArtikel = (Artikel)dgvArtiklar.SelectedRows[0].Tag;
        //        using(var hanteraDialog=new HanteraArtikelDialog(valdArtikel))
        //        {
        //            hanteraDialog.ShowDialog();

        //        }
        //    }
        //}

        //private void cmdVisaAllaArtiklar_Click(object sender, EventArgs e)
        //{
        //    FyllDataGrid(DataAccess.HamtaArtiklar());
        //}
    }
}
