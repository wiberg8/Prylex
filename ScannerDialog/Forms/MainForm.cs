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

namespace ScannerDialog.Forms
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.ApplikationIkon;
        }

        private void Database_Connection_Changed(object sender, EventArgs e)
        {
            ClearGrids();
        }

        private void Installningar_Change(object sender, PropertyChangedEventArgs e)
        {
            
        }

        //frm events
        private void frmMain_Load(object sender, EventArgs e) => FormStartup();

        //cmd events
        private void cmdSearch_Click(object sender, EventArgs e) => SearchSelectedGrid();
        private void cmdScanLabel_Click(object sender, EventArgs e) => SkannaEttiket();
        private void cmdSokAlla_Click(object sender, EventArgs e) => SearchSelectedGrid();
        private void cmdSnabbReg_Click(object sender, EventArgs e) => VisaSnabbRegistreringDialog();
        //toolstrip events
        private void tspArkivInstallningar_Click(object sender, EventArgs e) => VisaInstallnigarDialog();
        private void tspNyPerson_Click(object sender, EventArgs e) => VisaNyPersonDialog();
        private void tspNyArtikel_Click(object sender, EventArgs e) => VisaNyArtikelDialog();
        private void tspSnabbReg_Click(object sender, EventArgs e) => VisaSnabbRegistrering();
        private void tspImportPersoner_Click(object sender, EventArgs e) => VisaImportDialog();
        private void tspArkivAvsluta_Click(object sender, EventArgs e) => Application.Exit();

        //textbox events
        private void txtSok_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SearchSelectedGrid();
            }
        }

        //datagridview events
        private void dgvArtiklar_MouseDoubleClick(object sender, MouseEventArgs e) => ArtikelSelectedInGrid();
        private void dgvPersoner_MouseDoubleClick(object sender, MouseEventArgs e) => PersonSelectedInGrid();

        //tab events
        private void tabArtiklarPersoner_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearGrids();
            switch (tabArtiklarPersoner.SelectedTab.Name)
            {
                case nameof(tabArtiklar):
                    FyllVisaEndast(DBAccess.GetUniqueBesk());
                    break;
                case nameof(tabPersoner):
                    FyllVisaEndast(DBAccess.GetUniqueTillhorighet());
                    break;
            }
        }

        private void FormStartup()
        {
            tspNuvarandeDb.Text = AppSettings.Databas;
            FyllVisaEndast(DBAccess.GetUniqueBesk());
            SearchSelectedGrid();
        }

        private void VisaImportDialog()
        {
            ImportDialog importDialog = new ImportDialog();
            importDialog.ShowDialog();
            SearchSelectedGrid();
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
            SearchSelectedGrid();
        }

        private void VisaNyArtikelDialog()
        {
            NyArtikelDialog artikelDialog = new NyArtikelDialog();
            ClearGrids();
            artikelDialog.ShowDialog();
            RefreshVisaEndast();
            SearchSelectedGrid();
        }

        private void RefreshVisaEndast()
        {
            switch (tabArtiklarPersoner.SelectedTab.Name)
            {
                case nameof(tabArtiklar):
                    FyllVisaEndast(DBAccess.GetUniqueBesk());
                    break;
                case nameof(tabPersoner):
                    FyllVisaEndast(DBAccess.GetUniqueTillhorighet());
                    break;
            }
        }

        private void VisaNyPersonDialog()
        {
            NyPersonDialog newPersonDialog = new NyPersonDialog();
            ClearGrids();
            newPersonDialog.ShowDialog();
            RefreshVisaEndast();
            SearchSelectedGrid();
        }

        private void VisaInstallnigarDialog()
        {
            InstallningarDialog dialog = new InstallningarDialog();
            dialog.ShowDialog();
            if(AppSettings.Databas == string.Empty)
            {
                this.Close();
                return;
            }
            SearchSelectedGrid();
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
                SearchSelectedGrid();
            }
        }

        private void ClearGrids()
        {
            dgvArtiklar.Rows.Clear();
            dgvPersoner.Rows.Clear();
            laGridCount.Text = 0.ToString();
        }

        private void SearchSelectedGrid()
        {
            switch (tabArtiklarPersoner.SelectedTab.Name)
            {
                case nameof(tabArtiklar):
                    IEnumerable<Artikel> artiklar;
                    if (cbVisaEndast.SelectedIndex == 0)
                    {
                        if (string.IsNullOrWhiteSpace(txtSok.Text))
                        {
                            artiklar = DBAccess.HamtaArtiklar();
                        }
                        else
                        {
                            artiklar = SearchEngine.Search(DBAccess.HamtaArtiklar(), txtSok.Text);
                        }
                    }
                    else
                    {
                        if (string.IsNullOrWhiteSpace(txtSok.Text))
                        {
                            artiklar = DBAccess.HamtaArtiklarFranBesk(cbVisaEndast.Text);
                        }
                        else
                        {
                            artiklar = SearchEngine.Search(DBAccess.HamtaArtiklarFranBesk(cbVisaEndast.Text), txtSok.Text);
                        }
                    }
                    FyllGrid(artiklar);
                    break;
                case nameof(tabPersoner):
                    IEnumerable<Person> personer;
                    if (cbVisaEndast.SelectedIndex == 0) 
                    {
                        if (string.IsNullOrWhiteSpace(txtSok.Text))
                        {
                            personer = DBAccess.HamtaPersoner();
                        }
                        else
                        {
                            personer = SearchEngine.Search(DBAccess.HamtaPersoner(), txtSok.Text);
                        }
                    }
                    else
                    {
                        if (string.IsNullOrWhiteSpace(txtSok.Text))
                        {
                            personer = DBAccess.HamtaPersonerFranTillhorighet(cbVisaEndast.Text);
                        }
                        else
                        {
                            personer = SearchEngine.Search(DBAccess.HamtaPersonerFranTillhorighet(cbVisaEndast.Text), txtSok.Text);
                        }
                    }
                    FyllGrid(personer);
                    break;
            }
        }

        private void FyllVisaEndast(List<string> items)
        {
            cbVisaEndast.Items.Clear();
            cbVisaEndast.Items.Add(Locales.VisaAlla);
            cbVisaEndast.SelectedIndex = 0;
            cbVisaEndast.Items.AddRange(items.ToArray());
        }

        private void ArtikelSelectedInGrid()
        {
            if (dgvArtiklar.SelectedRows.Count > 0)
            {
                Artikel a = (Artikel)dgvArtiklar.SelectedRows[0].Tag;
                dgvArtiklar.Rows.Clear();
                var hanteraArtikelDialog = new HanteraArtikelDialog(a);
                hanteraArtikelDialog.ShowDialog();
                SearchSelectedGrid();
            }
        }

        private void PersonSelectedInGrid()
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

        private void FyllGrid(IEnumerable<Artikel> artiklar)
        {
            this.Enabled = false;
            dgvArtiklar.Rows.Clear();
            foreach (Artikel artikel in artiklar)
            {
                string persId = string.Empty;
                if (artikel.Status == Status.UTE)
                    persId = artikel.PersId.ToString();
                dgvArtiklar.Rows.Add(artikel.Id, artikel.Besk, artikel.DatorNamn, artikel.StoldTag, artikel.SerieNr, artikel.Mac, artikel.Os, artikel.Inkop, artikel.Ovrigt, persId);
                dgvArtiklar.Rows[dgvArtiklar.Rows.Count - 1].Tag = artikel;
            }
            dgvArtiklar.ClearSelection();
            laGridCount.Text = dgvArtiklar.Rows.Count.ToString();
            dgvArtiklar.SetColorVariationToRows();
            this.Enabled = true;
        }

        private void FyllGrid(IEnumerable<Person> lista)
        {
            this.Enabled = false;
            dgvPersoner.Rows.Clear();
            foreach (var person in lista)
            {
                dgvPersoner.Rows.Add(person.Id, person.Efternamn, person.Fornamn, person.PersNr, person.Sign, person.Tillhorighet, person.Ovrigt);
                dgvPersoner.Rows[dgvPersoner.Rows.Count - 1].Tag = person;
            }
            dgvPersoner.ClearSelection();
            laGridCount.Text = dgvPersoner.Rows.Count.ToString();
            dgvPersoner.SetColorVariationToRows();
            this.Enabled = true;
        }

        private void txtSok_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbVisaEndast_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchSelectedGrid();
        }
    }
}
