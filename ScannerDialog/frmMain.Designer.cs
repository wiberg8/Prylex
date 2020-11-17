namespace ScannerDialog
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.cmdSokVisaAlla = new System.Windows.Forms.Button();
            this.cmdSok = new System.Windows.Forms.Button();
            this.txtSok = new System.Windows.Forms.TextBox();
            this.rbSearchSelectArticle = new System.Windows.Forms.RadioButton();
            this.rbSearchSelectPerson = new System.Windows.Forms.RadioButton();
            this.tspArkiv = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tspArkivNyDatabasFil = new System.Windows.Forms.ToolStripMenuItem();
            this.tspArkivStangDb = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tspArkivInstallningar = new System.Windows.Forms.ToolStripMenuItem();
            this.tspArkivAvsluta = new System.Windows.Forms.ToolStripMenuItem();
            this.tspPerson = new System.Windows.Forms.ToolStripDropDownButton();
            this.tspPersonNy = new System.Windows.Forms.ToolStripMenuItem();
            this.tspArtikel = new System.Windows.Forms.ToolStripDropDownButton();
            this.tspArtikelNy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtNuvarandeDb = new System.Windows.Forms.TextBox();
            this.laNuvarandeDb = new System.Windows.Forms.Label();
            this.cmdTesting = new System.Windows.Forms.Button();
            this.gbSearch.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.cmdSokVisaAlla);
            this.gbSearch.Controls.Add(this.cmdSok);
            this.gbSearch.Controls.Add(this.txtSok);
            this.gbSearch.Controls.Add(this.rbSearchSelectArticle);
            this.gbSearch.Controls.Add(this.rbSearchSelectPerson);
            this.gbSearch.Location = new System.Drawing.Point(12, 28);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(349, 82);
            this.gbSearch.TabIndex = 7;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Sök";
            this.gbSearch.Enter += new System.EventHandler(this.gbSearch_Enter);
            // 
            // cmdSokVisaAlla
            // 
            this.cmdSokVisaAlla.Location = new System.Drawing.Point(133, 50);
            this.cmdSokVisaAlla.Name = "cmdSokVisaAlla";
            this.cmdSokVisaAlla.Size = new System.Drawing.Size(97, 23);
            this.cmdSokVisaAlla.TabIndex = 10;
            this.cmdSokVisaAlla.Text = "Visa alla";
            this.cmdSokVisaAlla.UseVisualStyleBackColor = true;
            this.cmdSokVisaAlla.Click += new System.EventHandler(this.cmdSokVisaAlla_Click);
            // 
            // cmdSok
            // 
            this.cmdSok.Location = new System.Drawing.Point(236, 50);
            this.cmdSok.Name = "cmdSok";
            this.cmdSok.Size = new System.Drawing.Size(97, 23);
            this.cmdSok.TabIndex = 9;
            this.cmdSok.Text = "Sök";
            this.cmdSok.UseVisualStyleBackColor = true;
            this.cmdSok.Click += new System.EventHandler(this.cmdSearch_Click);
            this.cmdSok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmdSok_KeyPress);
            // 
            // txtSok
            // 
            this.txtSok.Location = new System.Drawing.Point(8, 25);
            this.txtSok.Name = "txtSok";
            this.txtSok.Size = new System.Drawing.Size(326, 20);
            this.txtSok.TabIndex = 8;
            this.txtSok.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSok_KeyDown);
            this.txtSok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSok_KeyPress);
            // 
            // rbSearchSelectArticle
            // 
            this.rbSearchSelectArticle.AutoSize = true;
            this.rbSearchSelectArticle.Checked = true;
            this.rbSearchSelectArticle.Location = new System.Drawing.Point(9, 51);
            this.rbSearchSelectArticle.Name = "rbSearchSelectArticle";
            this.rbSearchSelectArticle.Size = new System.Drawing.Size(54, 17);
            this.rbSearchSelectArticle.TabIndex = 0;
            this.rbSearchSelectArticle.TabStop = true;
            this.rbSearchSelectArticle.Text = "Artikel";
            this.rbSearchSelectArticle.UseVisualStyleBackColor = true;
            // 
            // rbSearchSelectPerson
            // 
            this.rbSearchSelectPerson.AutoSize = true;
            this.rbSearchSelectPerson.Location = new System.Drawing.Point(69, 51);
            this.rbSearchSelectPerson.Name = "rbSearchSelectPerson";
            this.rbSearchSelectPerson.Size = new System.Drawing.Size(58, 17);
            this.rbSearchSelectPerson.TabIndex = 1;
            this.rbSearchSelectPerson.Text = "Person";
            this.rbSearchSelectPerson.UseVisualStyleBackColor = true;
            // 
            // tspArkiv
            // 
            this.tspArkiv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tspArkiv.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.tspArkivNyDatabasFil,
            this.tspArkivStangDb,
            this.toolStripSeparator1,
            this.tspArkivInstallningar,
            this.tspArkivAvsluta});
            this.tspArkiv.Image = ((System.Drawing.Image)(resources.GetObject("tspArkiv.Image")));
            this.tspArkiv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspArkiv.Name = "tspArkiv";
            this.tspArkiv.Size = new System.Drawing.Size(47, 22);
            this.tspArkiv.Text = "Arkiv";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(146, 6);
            // 
            // tspArkivNyDatabasFil
            // 
            this.tspArkivNyDatabasFil.Name = "tspArkivNyDatabasFil";
            this.tspArkivNyDatabasFil.Size = new System.Drawing.Size(149, 22);
            this.tspArkivNyDatabasFil.Text = "Skapa Ny (DB)";
            this.tspArkivNyDatabasFil.Click += new System.EventHandler(this.tspFileNewDB_Click);
            // 
            // tspArkivStangDb
            // 
            this.tspArkivStangDb.Name = "tspArkivStangDb";
            this.tspArkivStangDb.Size = new System.Drawing.Size(149, 22);
            this.tspArkivStangDb.Text = "Stäng (DB)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(146, 6);
            // 
            // tspArkivInstallningar
            // 
            this.tspArkivInstallningar.Name = "tspArkivInstallningar";
            this.tspArkivInstallningar.Size = new System.Drawing.Size(149, 22);
            this.tspArkivInstallningar.Text = "Inställningar";
            this.tspArkivInstallningar.Click += new System.EventHandler(this.tspArkivInstallningar_Click);
            // 
            // tspArkivAvsluta
            // 
            this.tspArkivAvsluta.Name = "tspArkivAvsluta";
            this.tspArkivAvsluta.Size = new System.Drawing.Size(149, 22);
            this.tspArkivAvsluta.Text = "Avsluta";
            // 
            // tspPerson
            // 
            this.tspPerson.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tspPerson.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspPersonNy});
            this.tspPerson.Image = ((System.Drawing.Image)(resources.GetObject("tspPerson.Image")));
            this.tspPerson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspPerson.Name = "tspPerson";
            this.tspPerson.Size = new System.Drawing.Size(56, 22);
            this.tspPerson.Text = "Person";
            // 
            // tspPersonNy
            // 
            this.tspPersonNy.Name = "tspPersonNy";
            this.tspPersonNy.Size = new System.Drawing.Size(89, 22);
            this.tspPersonNy.Text = "Ny";
            this.tspPersonNy.Click += new System.EventHandler(this.tspPeopleNew_Click);
            // 
            // tspArtikel
            // 
            this.tspArtikel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tspArtikel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspArtikelNy});
            this.tspArtikel.Image = ((System.Drawing.Image)(resources.GetObject("tspArtikel.Image")));
            this.tspArtikel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspArtikel.Name = "tspArtikel";
            this.tspArtikel.Size = new System.Drawing.Size(54, 22);
            this.tspArtikel.Text = "Artikel";
            // 
            // tspArtikelNy
            // 
            this.tspArtikelNy.Name = "tspArtikelNy";
            this.tspArtikelNy.Size = new System.Drawing.Size(89, 22);
            this.tspArtikelNy.Text = "Ny";
            this.tspArtikelNy.Click += new System.EventHandler(this.tspArticlesNew_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspArkiv,
            this.tspPerson,
            this.tspArtikel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(829, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txtNuvarandeDb
            // 
            this.txtNuvarandeDb.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtNuvarandeDb.HideSelection = false;
            this.txtNuvarandeDb.Location = new System.Drawing.Point(388, 53);
            this.txtNuvarandeDb.Name = "txtNuvarandeDb";
            this.txtNuvarandeDb.ReadOnly = true;
            this.txtNuvarandeDb.Size = new System.Drawing.Size(285, 20);
            this.txtNuvarandeDb.TabIndex = 12;
            this.txtNuvarandeDb.TabStop = false;
            // 
            // laNuvarandeDb
            // 
            this.laNuvarandeDb.AutoSize = true;
            this.laNuvarandeDb.Location = new System.Drawing.Point(385, 37);
            this.laNuvarandeDb.Name = "laNuvarandeDb";
            this.laNuvarandeDb.Size = new System.Drawing.Size(104, 13);
            this.laNuvarandeDb.TabIndex = 13;
            this.laNuvarandeDb.Text = "Nuvarande databas:";
            // 
            // cmdTesting
            // 
            this.cmdTesting.Location = new System.Drawing.Point(388, 78);
            this.cmdTesting.Name = "cmdTesting";
            this.cmdTesting.Size = new System.Drawing.Size(75, 23);
            this.cmdTesting.TabIndex = 15;
            this.cmdTesting.Text = "Testing";
            this.cmdTesting.UseVisualStyleBackColor = true;
            this.cmdTesting.Click += new System.EventHandler(this.cmdTesting_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 494);
            this.Controls.Add(this.cmdTesting);
            this.Controls.Add(this.laNuvarandeDb);
            this.Controls.Add(this.txtNuvarandeDb);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prlyan";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.RadioButton rbSearchSelectPerson;
        private System.Windows.Forms.RadioButton rbSearchSelectArticle;
        private System.Windows.Forms.TextBox txtSok;
        private System.Windows.Forms.Button cmdSok;
        private System.Windows.Forms.ToolStripDropDownButton tspArkiv;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tspArkivNyDatabasFil;
        private System.Windows.Forms.ToolStripMenuItem tspArkivStangDb;
        private System.Windows.Forms.ToolStripMenuItem tspArkivInstallningar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tspArkivAvsluta;
        private System.Windows.Forms.ToolStripDropDownButton tspPerson;
        private System.Windows.Forms.ToolStripMenuItem tspPersonNy;
        private System.Windows.Forms.ToolStripDropDownButton tspArtikel;
        private System.Windows.Forms.ToolStripMenuItem tspArtikelNy;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox txtNuvarandeDb;
        private System.Windows.Forms.Label laNuvarandeDb;
        private System.Windows.Forms.Button cmdTesting;
        private System.Windows.Forms.Button cmdSokVisaAlla;
    }
}

