using PrylanLibary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScannerDialog.Forms
{
    public partial class LicensDialog : Form
    {
        private Licensering licensering = new Licensering();
        public bool SuccesfulAuthentication { get; set; }
        public string SuccesfulKundNamn { get; set; }

        public LicensDialog()
        {
            InitializeComponent();
        }

        private async void cmdOk_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            var wrapper = await licensering.LogInAsync(txtKundNamn.Text, txtPinKod.Text);
            this.Enabled = true;
            if (wrapper is null)
            {
                MessageBox.Show("Problem med nätverk eller så ligger licens servern nere");
                return;
            }
            else
            {
                MessageBox.Show(wrapper.Message);
                if(wrapper.Message != "Felaktiga upgifter")
                {
                    SuccesfulAuthentication = !wrapper.HasExpired;
                    SuccesfulKundNamn = txtKundNamn.Text;
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            SuccesfulAuthentication = false;
            this.DialogResult = DialogResult.Cancel;
        }

        private void LicensDialog_Load_1(object sender, EventArgs e)
        {
            txtKundNamn.Text = Program.AppSettings.SuccesfulKundNamn;
        }
    }
}
