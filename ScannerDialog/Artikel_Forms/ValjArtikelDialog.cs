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
    public partial class ValjArtikelDialog : Form
    {
        public Artikel ValdArtikel { get; private set; }
        private List<Artikel> artiklar;
        private bool endastLediga;
        public ValjArtikelDialog(List<Artikel> artiklar, bool endastLediga = false)
        {
            InitializeComponent();
            this.artiklar = artiklar;
            this.endastLediga = endastLediga;
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
            DataGridLibary.SetColorVariationToRows(dgvArtiklar);
        }

        private void ValjArtikelDialog_Load(object sender, EventArgs e)
        {
            FyllDataGrid(this.artiklar);
            dgvArtiklar.ClearSelection();
        }

        private void dgvArtiklar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdSok_Click(object sender, EventArgs e)
        {
            if (endastLediga)
            {
                using (DataAccess dataAccess = new DataAccess())
                {
                    FyllDataGrid(dataAccess.HamtaSokArtiklarLediga(txtSok.Text));
                }
            }
            else
            {
                using (DataAccess dataAccess = new DataAccess())
                {
                    FyllDataGrid(dataAccess.HamtaSokArtiklar(txtSok.Text));
                }
            }
        }

        private void dgvArtiklar_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            if (dgvArtiklar.SelectedRows.Count > 0)
            {
                this.ValdArtikel = (Artikel)dgvArtiklar.SelectedRows[0].Tag;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
