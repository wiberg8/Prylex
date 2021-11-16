using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrylanLibary;
using static ScannerDialog.Program;

namespace ScannerDialog
{
    public partial class BytDatabasForm : Form
    {
        public BytDatabasForm()
        {
            InitializeComponent();
            SharedEvents.AttachToAllLabelsInForm(this, this.components.Components);
        }

        private void cmdUtforska_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Filter = "db files (*.db)|*.db"
            };

            if (fileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            if (fileDialog.CheckFileExists)
            {
                AppSettings.Databas = fileDialog.FileName;
                this.Close();
                return;
            }
            MessageBox.Show("Något är fel med den utpekade filen");
        }

        private void cmdCreateDb_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog()
            {
                Filter = "db files (*.db)|*.db"
            };
            DialogResult dialogResult = fileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK
                && !fileDialog.CheckFileExists
                && fileDialog.CheckPathExists)
            {
                DataAccess.CreateFile(fileDialog.FileName);
                AppSettings.Databas = fileDialog.FileName;
                this.Close();
            }
        }

        private void cmdCloseApplication_Click(object sender, EventArgs e)
        {
            ExitApplication = true;
            this.Close();
        }
    }
}
