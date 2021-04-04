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
using static ScannerDialog.Program;

namespace ScannerDialog
{
    public partial class ValjPersonDialog : Form
    {
        public Person ValdPerson { get; private set; }
        private List<Person> personer;
        public ValjPersonDialog(List<Person> personer)
        {
            InitializeComponent();
            this.personer = personer;
        }

        //form events
        private void ValjPersonDialog_Load(object sender, EventArgs e)
        {
            FormStartup();
        }
        private void ValjPersonDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
        //cmd events
        private void cmdSok_Click(object sender, EventArgs e)
        {
            Sok();
        }
        //datagridview events
        private void dgvPersoner_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            PersonSelectedClick();
        }

        private void FormStartup()
        {
            FyllGrid(personer);
            dgvPersoner.ClearSelection();
        }
        private void PersonSelectedClick()
        {
            if (dgvPersoner.SelectedRows.Count > 0)
            {
                this.ValdPerson = (Person)dgvPersoner.SelectedRows[0].Tag;
                this.DialogResult = DialogResult.OK;
            }
        }
        private void Sok()
        {
            FyllGrid(DBAccess.HamtaSokPersoner(txtSok.Text));
        }
        private void FyllGrid(List<Person> lista)
        {
            dgvPersoner.Rows.Clear();
            foreach (var person in lista)
            {
                dgvPersoner.Rows.Add(person.Id, person.Efternamn, person.Fornamn, person.PersNr, person.Sign, person.Tillhorighet, person.Ovrigt);
                dgvPersoner.Rows[dgvPersoner.Rows.Count - 1].Tag = person;
            }
            DataGridLibary.SetColorVariationToRows(dgvPersoner);
        }
    }
}
