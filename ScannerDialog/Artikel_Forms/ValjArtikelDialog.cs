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
using static ScannerDialog.Program;

namespace ScannerDialog
{
    public partial class ValjArtikelDialog : Form
    {
        public Artikel ValdArtikel { get; private set; }
        private List<Artikel> artiklar;

        public ValjArtikelDialog(List<Artikel> artiklar)
        {
            InitializeComponent();
            this.artiklar = artiklar;
        }

        //form events
        private void ValjArtikelDialog_Load(object sender, EventArgs e) => FormStartup();
        private void ValjArtikelDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
        //cmd events
        private void cmdSok_Click(object sender, EventArgs e) => FyllGrid(SearchEngine.Search(DBAccess.HamtaLedigaArtiklar(), txtSok.Text));
        //datagridview events
        private void dgvArtiklar_DoubleClick(object sender, EventArgs e) => ArtikelSelectedClick();

        private void FormStartup()
        {
            FyllGrid(this.artiklar);
            dgvArtiklar.ClearSelection();
        }
        private void ArtikelSelectedClick()
        {
            if (dgvArtiklar.SelectedRows.Count > 0)
            {
                this.ValdArtikel = (Artikel)dgvArtiklar.SelectedRows[0].Tag;
                this.DialogResult = DialogResult.OK;
            }
        }
        private void FyllGrid(IEnumerable<Artikel> artiklar)
        {
            dgvArtiklar.Rows.Clear();
            foreach (Artikel artikel in artiklar)
            {
                string persId = string.Empty;
                if (artikel.Status == Status.UTE)
                    persId = artikel.PersId.ToString();
                dgvArtiklar.Rows.Add(artikel.Id, artikel.Besk, artikel.DatorNamn, artikel.StoldTag, artikel.SerieNr, artikel.Mac, artikel.Os, artikel.Inkop, artikel.Ovrigt, persId);
                dgvArtiklar.Rows[dgvArtiklar.Rows.Count - 1].Tag = artikel;
            }
            DataGridLibary.SetColorVariationToRows(dgvArtiklar);
        }
    }
}
