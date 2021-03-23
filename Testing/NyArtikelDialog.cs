using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using PrylanLibary.Models;

using static Testing.Program;


namespace Testing
{
    public partial class NyArtikelDialog : Form
    {

        public NyArtikelDialog()
        {
            InitializeComponent();
        }

        public NyArtikelDialog(Artikel artikel)
        {
            InitializeComponent();
        }

        private void cbInputChoose_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gbStaticFields_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtOther_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSerial_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
          
        }

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void checkBuyDate_CheckedChanged(object sender, EventArgs e)
        {
    
        }

        private void NyArtikelDialog_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 150;
          
           
           
            //if (editerar)
            //{
            //    FyllFalt(this.artikelAttEditera);
            //}
            //else
            //{
            //    txtArtikelId.Visible = false;
            //    laArtikelId.Visible = false;
            //}
        }

        private bool IsAllaFaltTomma(Artikel artikel)
        {
            return string.IsNullOrWhiteSpace(artikel.DatorNamn) && string.IsNullOrWhiteSpace(artikel.StoldTag) && string.IsNullOrWhiteSpace(artikel.Mac) && string.IsNullOrWhiteSpace(artikel.SerieNr) && string.IsNullOrWhiteSpace(artikel.Ovrigt);
        }


        private void cmdAvbryt_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dtpInkop_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            CreateTestImportFile();
            //AppSettings.Skrivare = "kalle";
            //this.Enabled = false;
            //while (progressBar1.Value != 150)
            //{
            //    await Task.Run(() => Thread.Sleep(100));
            //    progressBar1.Increment(1);
            //}
            //this.Enabled = true;
            //progressBar1.Value = 0;
            //MessageBox.Show("Import verkställd");
        }

        private void CreateTestImportFile()
        {
            List<Person> pExport = new List<Person>();
            List<string> lines = new List<string>();
            for (int i = 0; i <= 80000; i++)
            {
                Person p = new Person();
                p.Fornamn = Functions.RandomGeneratedString(6);
                p.Efternamn = Functions.RandomGeneratedString(6);
                p.PersNr = Functions.RandomGeneratedString(6, true) + "-" + Functions.RandomGeneratedString(4, true);
                pExport.Add(p);
            }
            foreach (Person p in pExport)
            {
                lines.Add(p.Fornamn + ";" + p.Efternamn + ";" + p.PersNr);
            }
            File.WriteAllLines("export.csv", lines);
        }

        private void txtSerieNr_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
