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

        //form events
        private void InputBoxHandelse_Load(object sender, EventArgs e) => FormStartup();
        private void InputScanner_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Ok();
            }
        }

        //cmd events
        private void cmdOk_Click_1(object sender, EventArgs e) => Ok();

        private void FormStartup()
        {
            cbHandelser.Items.AddRange(DBAccess.GetUniqueHandelser().ToArray());
            if (cbHandelser.Items.Count > 0)
            {
                cbHandelser.SelectedIndex = 0;
            }
        }
        private void Ok()
        {
            if (string.IsNullOrWhiteSpace(cbHandelser.Text))
                return;
            this.Input = cbHandelser.Text.Trim();
            this.DialogResult = DialogResult.OK;
        }
    }
}
