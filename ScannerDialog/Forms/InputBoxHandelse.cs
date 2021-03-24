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
using static ScannerDialog.Program;

namespace ScannerDialog
{
    public partial class InputBoxHandelse : Form
    {
        public string Input { get; private set; } = string.Empty;
        public InputBoxHandelse()
        {
            InitializeComponent();
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            Ok();
        }

        private void Ok()
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text))
                return;
            this.Input = comboBox1.Text.Trim();
            this.DialogResult = DialogResult.OK;
        }

        private void InputScanner_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Ok();
            }
        }

        private void cmdOk_Click_1(object sender, EventArgs e)
        {
            Ok();
        }

        private void InputBoxHandelse_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = AppSettings.Handelser;
            if(comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }
    }
}
