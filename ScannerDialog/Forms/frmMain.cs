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
using System.IO;
using PrylanLibary.Validators;
using System.Text.RegularExpressions;
using ScannerDialog;
using static ScannerDialog.Program;


//Refresh datagrid måste göras om till dataaccess med FyllArtiklar, FyllPersoner funktioner
namespace ScannerDialog.Forms
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
            AppSettings.PropertyChanged += Installningar_Change;
            DBAccess.ArtikelChange += Artiklar_Change;
            DBAccess.ConnectionChanged += Database_Connection_Changed;
            this.Icon = Properties.Resources.ApplikationIkon;
        }

        private void Database_Connection_Changed(object sender, EventArgs e)
        {
            ClearGrids();
        }

        private void Installningar_Change(object sender, EventArgs e)
        {
            var ins = (Installningar)sender;
            laDatabaseWarning.Visible = !File.Exists(ins.Databas);
            tspNuvarandeDb.Text = ins.Databas;
            LaddaTillhorighet();
        }

        private void Artiklar_Change(object sender, EventArgs e)
        {
            //dgvArtiklar.Rows.Clear();
        }

        //frm events
        private void frmMain_Load(object sender, EventArgs e) => FormStartup();

        //cmd events
        private void cmdSearch_Click(object sender, EventArgs e) => SearchSelectedGrid();
        private void cmdScanLabel_Click(object sender, EventArgs e) => SkannaEttiket();
        private void cmdSokAlla_Click(object sender, EventArgs e) => RefreshSelectedGrid();
        private void cmdSnabbReg_Click(object sender, EventArgs e) => VisaSnabbRegistreringDialog();
        //toolstrip events
        private void tspArkivInstallningar_Click(object sender, EventArgs e) => VisaInstallnigarDialog();
        private void tspNyPerson_Click(object sender, EventArgs e) => VisaNyPersonDialog();
        private void tspNyArtikel_Click(object sender, EventArgs e) => VisaNyArtikelDialog();
        private void tspFileNewDB_Click(object sender, EventArgs e) => NyDatabas();
        private void tspSnabbReg_Click(object sender, EventArgs e) => VisaSnabbRegistrering();
        private void tspImportPersoner_Click(object sender, EventArgs e) => VisaImportDialog();
        private void tspArkivAvsluta_Click(object sender, EventArgs e) => Application.Exit();

        //textbox events
        private void txtSok_KeyDown(object sender, KeyEventArgs e) => SearchSelectedGrid();

        //datagridview events
        private void dgvArtiklar_MouseDoubleClick(object sender, MouseEventArgs e) => ArtikelSelectedGrid();
        private void dgvPersoner_MouseDoubleClick(object sender, MouseEventArgs e) => PersonSelectedGrid();

        private void tabArtiklarPersoner_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearGrids();
            RefreshSelectedGrid();
        }
   

        private void VisaImportDialog()
        {
            ImportDialog importDialog = new ImportDialog();
            importDialog.ShowDialog();
            RefreshSelectedGrid();
        }

        private static void VisaSnabbRegistreringDialog()
        {
            SnabbRegistering snabbRegistering = new SnabbRegistering();
            snabbRegistering.ShowDialog();
        }

        private void VisaSnabbRegistrering()
        {
            SnabbRegistering snabbRegistering = new SnabbRegistering();
            ClearGrids();
            snabbRegistering.ShowDialog();
            RefreshSelectedGrid();
        }

        private void VisaNyArtikelDialog()
        {
            NyArtikelDialog artikelDialog = new NyArtikelDialog();
            ClearGrids();
            artikelDialog.ShowDialog();
            RefreshSelectedGrid();
        }

        private void VisaNyPersonDialog()
        {
            var newPersonDialog = new NyPersonDialog();
            ClearGrids();
            newPersonDialog.ShowDialog();
            RefreshSelectedGrid();
        }

        private void VisaInstallnigarDialog()
        {
            var dialog = new InstallningarDialog();
            dialog.ShowDialog();
            RefreshSelectedGrid();
        }

        private void NyDatabas()
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Database file(*.db)|*.db";
            fileDialog.DefaultExt = "db";
            fileDialog.AddExtension = true;
            DialogResult dialogResult = fileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                if (!DBAccess.CreateFile(fileDialog.FileName))
                {
                    MessageBox.Show(Locales.CouldNotCreateDatabaseFile);
                }
            }
        }

        private void SkannaEttiket()
        {
            InputBox inputBox = new InputBox
            {
                PromptText = Locales.SkannaSerieNr
            };
            inputBox.ShowDialog();
            string scannedInput = inputBox.Input.ToUpper();
            if (string.IsNullOrWhiteSpace(scannedInput))
            {
                return;
            }

            Artikel artikelFromDb;
            artikelFromDb = DBAccess.HamtaArtikelFranSerieNr(scannedInput);
            if (artikelFromDb is null)
            {
                MessageBox.Show(Locales.IngenTraff);
            }
            else
            {
                var artikelDialog = new HanteraArtikelDialog(artikelFromDb);
                artikelDialog.ShowDialog();
                RefreshSelectedGrid();
            }
        }


        private void ClearGrids()
        {
            dgvArtiklar.Rows.Clear();
            dgvPersoner.Rows.Clear();
        }


        private void SearchSelectedGrid()
        {
            switch (tabArtiklarPersoner.SelectedTab.Name)
            {
                case "tabArtiklar":
                    List<Artikel> artiklar = DBAccess.HamtaSokArtiklar(txtSok.Text);
                    FyllGrid(artiklar);
                    break;
                case "tabPersoner":
                    List<Person> personer;
                    if (cbTillhorighet.SelectedIndex  == 0)
                        personer = DBAccess.HamtaSokPersoner(txtSok.Text);
                    else
                        personer = DBAccess.HamtaSokPersoner(txtSok.Text).Where(p => p.Tillhorighet == cbTillhorighet.Text).ToList();
                    FyllGrid(personer);
                    break;
            }
        }

        private void FormStartup()
        {
            laDatabaseWarning.Visible = !File.Exists(AppSettings.Databas);
            LaddaTillhorighet();
            tspNuvarandeDb.Text = AppSettings.Databas;
            RefreshSelectedGrid();
        }

        private void LaddaTillhorighet()
        {
            cbTillhorighet.Items.Clear();
            cbTillhorighet.Items.Add(Locales.ValjTillhorighet);
            cbTillhorighet.SelectedIndex = 0;
            cbTillhorighet.Items.AddRange(AppSettings.Tillhorigheter.ToArray());
        }

        private void RefreshSelectedGrid()
        {
            switch (tabArtiklarPersoner.SelectedTab.Name)
            {
                case "tabArtiklar":
                    FyllGrid(DBAccess.HamtaArtiklar());
                    cbTillhorighet.Visible = false;
                    break;
                case "tabPersoner":
                    FyllGrid(DBAccess.HamtaPersoner());
                    cbTillhorighet.Visible = true;
                    break;
            }
        }

        private void FyllGrid(List<Artikel> artiklar)
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
            dgvArtiklar.SetColorVariationToRows();
        }

        private void FyllGrid(List<Person> lista)
        {
            dgvPersoner.Rows.Clear();
            foreach (var person in lista)
            {
                dgvPersoner.Rows.Add(person.Id, person.Efternamn, person.Fornamn, person.PersNr, person.Sign, person.Tillhorighet, person.Ovrigt);
                dgvPersoner.Rows[dgvPersoner.Rows.Count - 1].Tag = person;
            }
            dgvPersoner.ClearSelection();
            dgvArtiklar.SetColorVariationToRows();
        }
        
        private void ArtikelSelectedGrid()
        {
            if (dgvArtiklar.SelectedRows.Count > 0)
            {
                Artikel a = (Artikel)dgvArtiklar.SelectedRows[0].Tag;
                dgvArtiklar.Rows.Clear();
                var hanteraArtikelDialog = new HanteraArtikelDialog(a);
                hanteraArtikelDialog.ShowDialog();
                FyllGrid(DBAccess.HamtaArtiklar());
            }
        }

        private void PersonSelectedGrid()
        {
            if (dgvPersoner.SelectedRows.Count > 0)
            {
                Person p = (Person)dgvPersoner.SelectedRows[0].Tag;
                dgvPersoner.Rows.Clear();
                var hanteraPersonDialog = new HanteraPersonDialog(p);
                hanteraPersonDialog.ShowDialog();
                FyllGrid(DBAccess.HamtaPersoner());
            }
        }
    }
}
