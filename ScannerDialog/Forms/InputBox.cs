using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScannerDialog
{
    public partial class InputBox : Form
    {
        public string Input { get; private set; } = string.Empty;
        public string PromptText { get { return lbPrompt.Text; } set { lbPrompt.Text = value; } }
        public InputBox()
        {
            InitializeComponent();
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            Ok();
        }

        private void Ok()
        {
            this.Input = txtScannedResult.Text.Trim();
            this.DialogResult = DialogResult.OK;
        }

        private void InputScanner_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txtScannedResult.Text))
            {
                Ok();
            }
        }

        private void cmdOk_Click_1(object sender, EventArgs e)
        {
            Ok();
        }
    }
}
