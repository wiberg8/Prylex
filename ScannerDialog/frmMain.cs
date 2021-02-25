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
using PrylanLibary.Enums;

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
            laDatabaseWarning.Visible = !System.IO.File.Exists(ins.Databas);
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
            NyArtikelDialog artikelDialog = new NyArtikelDialog();
            dgvArtiklar.Rows.Clear();
            dgvPersoner.Rows.Clear();
            artikelDialog.ShowDialog();
        }

        private void tspPeopleNew_Click(object sender, EventArgs e)
        {
            var newPersonDialog = new NyPersonDialog();
            dgvArtiklar.Rows.Clear();
            dgvPersoner.Rows.Clear();
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
            var ins = Installningar.Hamta();
            laDatabaseWarning.Visible = !System.IO.File.Exists(ins.Databas);
        }

        private void tspArkivInstallningar_Click(object sender, EventArgs e)
        {
            var dialog = new InstallningarDialog();
            dialog.ShowDialog();
        }
 
        private void cmdSearch_Click(object sender, EventArgs e)
        {
            using (var dataAccess = new DataAccess())
            {
                if (tabArtiklarPersoner.SelectedTab == tabArtiklar)
                {
                    List<Artikel> artiklar = dataAccess.HamtaSokArtiklar(txtSok.Text);
                    FyllDataGrid(artiklar);
                }
                    
                if (tabArtiklarPersoner.SelectedTab == tabPersoner)
                {
                    List<Person> personer = dataAccess.HamtaSokPersoner(txtSok.Text);
                    FyllDataGrid(personer);
                }
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
                    if (tabArtiklarPersoner.SelectedTab == tabArtiklar)
                        FyllDataGrid(dataAccess.HamtaSokArtiklar(txtSok.Text));
                    if (tabArtiklarPersoner.SelectedTab == tabPersoner)
                        FyllDataGrid(dataAccess.HamtaSokArtiklar(txtSok.Text));
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
                if(artikel is null)
                {
                    MessageBox.Show("Inga träffar");
                }
                else
                {
                    var artikelDialog = new HanteraArtikelDialog(artikel);
                    artikelDialog.ShowDialog();
                }
            }
        }

        private void tabPersoner_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tabArtiklarPersoner_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tabArtiklarPersoner_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvArtiklar.Rows.Clear();
            dgvPersoner.Rows.Clear();
        }

        private void RefreshDataGrids()
        {
            using (DataAccess dataAccess = new DataAccess())
            {
                if (tabArtiklarPersoner.SelectedTab == tabArtiklar)
                {
                    FyllDataGrid(dataAccess.HamtaArtiklar());
                }
                if (tabArtiklarPersoner.SelectedTab == tabPersoner)
                {
                    FyllDataGrid(dataAccess.HamtaPersoner());
                }
            }
        }

        private void FyllDataGrid(List<Artikel> artiklar)
        {
            dgvArtiklar.Rows.Clear();
            foreach (Artikel artikel in artiklar)
            {
                string persId = string.Empty;
                if (artikel.Status == Status.UTE)
                    persId = artikel.PersId.ToString();
                dgvArtiklar.Rows.Add(artikel.Id, artikel.Beskrivning, artikel.DatorNamn, artikel.StoldTag, artikel.SerieNr, artikel.Mac, artikel.Os, artikel.Inkop, artikel.Ovrigt, persId);
                dgvArtiklar.Rows[dgvArtiklar.Rows.Count - 1].Tag = artikel;
            }
            dgvArtiklar.ClearSelection();
            DataGridLibary.SetColorVariationToRows(dgvArtiklar);
        }

        private void FyllDataGrid(List<Person> lista)
        {
            dgvPersoner.Rows.Clear();
            foreach (var person in lista)
            {
                dgvPersoner.Rows.Add(person.Id, person.Efternamn, person.Fornamn, person.PersNr, person.Sign, person.Tillhorighet, person.Ovrigt);
                dgvPersoner.Rows[dgvPersoner.Rows.Count - 1].Tag = person;
            }
            dgvPersoner.ClearSelection();
            DataGridLibary.SetColorVariationToRows(dgvPersoner);
        }

        private void dgvArtiklar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvArtiklar.SelectedRows.Count > 0)
            {
                Artikel a = (Artikel)dgvArtiklar.SelectedRows[0].Tag;
                dgvArtiklar.Rows.Clear();
                var hanteraArtikelDialog = new HanteraArtikelDialog(a);
                hanteraArtikelDialog.ShowDialog();
                var dataAccess = new DataAccess();
                FyllDataGrid(dataAccess.HamtaArtiklar());
                dataAccess.Close();
            }
        }

        private void dgvPersoner_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvPersoner.SelectedRows.Count > 0)
            {
                Person p = (Person)dgvPersoner.SelectedRows[0].Tag;
                dgvPersoner.Rows.Clear();
                var hanteraPersonDialog = new HanteraPersonDialog(p);
                hanteraPersonDialog.ShowDialog();
                var dataAccess = new DataAccess();
                FyllDataGrid(dataAccess.HamtaPersoner());
                dataAccess.Close();
            }
        }

        private void cmdSokAlla_Click(object sender, EventArgs e)
        {
            RefreshDataGrids();
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
