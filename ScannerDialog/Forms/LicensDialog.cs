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
using PrylanLibary.Models.Pocos;

namespace ScannerDialog.Forms
{
    public partial class LicensDialog : Form
    {
        private readonly Licensering licensering = new Licensering();
        public bool SuccesfulAuthentication { get; set; }
        public Guid SuccesfulLicense { get; set; }

        public LicensDialog()
        {
            InitializeComponent();
        }

        private async void cmdOk_Click(object sender, EventArgs e)
        {
            SuccesfulLicense = new Guid();
            SuccesfulAuthentication = true;
            this.DialogResult = DialogResult.OK;
            //if (Guid.TryParse(txtLicense.Text, out Guid guid))
            //{
            //    this.Enabled = false;
            //    LicenseWrapper wrapper = await licensering.AuenticateLicenseAsync(guid);
            //    this.Enabled = true;
            //    if (wrapper is null)
            //    {
            //        MessageBox.Show("Problem med nätverk eller så ligger licens servern nere");
            //        return; 
            //    }
            //    else
            //    {
            //        MessageBox.Show(wrapper.Message);
            //        if (!wrapper.AuthenticationFailed)
            //        {
            //            SuccesfulAuthentication = !wrapper.HasExpired;
            //            SuccesfulLicense = guid;
            //            this.DialogResult = DialogResult.OK;
            //        }
            //    }
            //    return;
            //}
            //else
            //{
            //    MessageBox.Show("Ej giltigt format på licensen");
            //}
            
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            SuccesfulAuthentication = false;
            this.DialogResult = DialogResult.Cancel;
        }

        private void LicensDialog_Load_1(object sender, EventArgs e)
        {
           
        }

        private void txtLicense_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
