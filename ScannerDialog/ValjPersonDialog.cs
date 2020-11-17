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
    public partial class ValjPersonDialog : Form
    {
        public Person ValdPerson { get; private set; }
        private List<Person> personer;
        public ValjPersonDialog(List<Person> personer)
        {
            InitializeComponent();
            this.personer = personer;
        }

        private void ValjPersonDialog_Load(object sender, EventArgs e)
        {
            FyllDataGrid(personer);
        }

        private void FyllDataGrid(List<Person> lista)
        {
            dgvPersoner.Rows.Clear();
            foreach (var person in lista)
            {
                dgvPersoner.Rows.Add(person.Id, person.Efternamn, person.Fornamn, person.PersNr, person.Sign, person.Tillhorighet, person.Ovrigt);
                dgvPersoner.Rows[dgvPersoner.Rows.Count - 1].Tag = person;
            }
        }

        private void dgvPersoner_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvPersoner.SelectedRows.Count > 0)
            {
                this.ValdPerson = (Person)dgvPersoner.SelectedRows[0].Tag;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void cmdSok_Click(object sender, EventArgs e)
        {
            using (DataAccess dataAccess = new DataAccess())
            {
                FyllDataGrid(dataAccess.HamtaSokPersoner(txtSok.Text));
            }
        }
    }
}
