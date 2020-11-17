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

namespace ScannerDialog
{
    public partial class ProduktAktiveringsDialog : Form
    {
        public bool Activated { get; private set; }
        public ProduktAktiveringsDialog()
        {
            InitializeComponent();
        }

        private void ProduktAktiveringsDialog_Load(object sender, EventArgs e)
        {
            txtUUId.Text = Licensering.GetComputerUUId();
            txtUUId.SelectionStart = 0;
        }

        private void cmdAktivera_Click(object sender, EventArgs e)
        {
            try
            {
                string encryptedAktivering = txtAktiveringsNyckel.Text.Trim().Decrypt(Config.PasswordHash, Config.SaltKey, Config.VIKey);
                string aktiveringsKod = Licensering.ExtractUUID(encryptedAktivering);
                DateTime aktiveringsDatum = Licensering.ExtractDateTime(encryptedAktivering);
                MessageBox.Show(Licensering.GetComputerUUId() + "   " + aktiveringsKod);
                if (aktiveringsKod == Licensering.GetComputerUUId())
                {
                    MessageBox.Show("Aktiverad");
                }   
            }
            catch(Exception ex)
            {
                MessageBox.Show("Felaktig nyckel");
            }
           
        }

        private void cmdUUIdKopiera_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtUUId.Text);
        }
    }
}
