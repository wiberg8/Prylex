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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tspArkivInstallningar = new System.Windows.Forms.ToolStripMenuItem();
            this.tspArkivAvsluta = new System.Windows.Forms.ToolStripMenuItem();
            this.tspPerson = new System.Windows.Forms.ToolStripDropDownButton();
            this.tspPersonNy = new System.Windows.Forms.ToolStripMenuItem();
            this.tspArtikel = new System.Windows.Forms.ToolStripDropDownButton();
            this.tspArtikelNy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cmdScanLabel = new System.Windows.Forms.Button();
            this.tabPersoner = new System.Windows.Forms.TabControl();
            this.tabArtiklar = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbSearch.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabPersoner.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(969, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cmdScanLabel
            // 
            this.cmdScanLabel.Location = new System.Drawing.Point(367, 28);
            this.cmdScanLabel.Name = "cmdScanLabel";
            this.cmdScanLabel.Size = new System.Drawing.Size(337, 82);
            this.cmdScanLabel.TabIndex = 11;
            this.cmdScanLabel.Text = "Skanna ettiket";
            this.cmdScanLabel.UseVisualStyleBackColor = true;
            this.cmdScanLabel.Click += new System.EventHandler(this.cmdScanLabel_Click);
            // 
            // tabPersoner
            // 
            this.tabPersoner.Controls.Add(this.tabArtiklar);
            this.tabPersoner.Controls.Add(this.tabPage2);
            this.tabPersoner.Location = new System.Drawing.Point(12, 116);
            this.tabPersoner.Name = "tabPersoner";
            this.tabPersoner.SelectedIndex = 0;
            this.tabPersoner.Size = new System.Drawing.Size(947, 421);
            this.tabPersoner.TabIndex = 12;
            // 
            // tabArtiklar
            // 
            this.tabArtiklar.Location = new System.Drawing.Point(4, 22);
            this.tabArtiklar.Name = "tabArtiklar";
            this.tabArtiklar.Padding = new System.Windows.Forms.Padding(3);
            this.tabArtiklar.Size = new System.Drawing.Size(939, 395);
            this.tabArtiklar.TabIndex = 0;
            this.tabArtiklar.Text = "Artiklar";
            this.tabArtiklar.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(939, 395);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Personer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 543);
            this.Controls.Add(this.tabPersoner);
            this.Controls.Add(this.cmdScanLabel);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hkn";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPersoner.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem tspArkivInstallningar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tspArkivAvsluta;
        private System.Windows.Forms.ToolStripDropDownButton tspPerson;
        private System.Windows.Forms.ToolStripMenuItem tspPersonNy;
        private System.Windows.Forms.ToolStripDropDownButton tspArtikel;
        private System.Windows.Forms.ToolStripMenuItem tspArtikelNy;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button cmdSokVisaAlla;
        private System.Windows.Forms.Button cmdScanLabel;
        private System.Windows.Forms.TabControl tabPersoner;
        private System.Windows.Forms.TabPage tabArtiklar;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

