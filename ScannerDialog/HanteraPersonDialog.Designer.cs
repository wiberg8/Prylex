namespace ScannerDialog
{
    partial class HanteraPersonDialog
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
            this.components = new System.ComponentModel.Container();
            this.gbFalt = new System.Windows.Forms.GroupBox();
            this.laPersonIdDisplay = new System.Windows.Forms.Label();
            this.laOvrigtDisplay = new System.Windows.Forms.Label();
            this.laTillhorighetDisplay = new System.Windows.Forms.Label();
            this.laTelefonDisplay = new System.Windows.Forms.Label();
            this.laEpostDisplay = new System.Windows.Forms.Label();
            this.laSignDisplay = new System.Windows.Forms.Label();
            this.laPersNrDisplay = new System.Windows.Forms.Label();
            this.laEfternamnDisplay = new System.Windows.Forms.Label();
            this.laFornamnDisplay = new System.Windows.Forms.Label();
            this.laTillhorighet = new System.Windows.Forms.Label();
            this.laTelefon = new System.Windows.Forms.Label();
            this.laPersonId = new System.Windows.Forms.Label();
            this.laEpost = new System.Windows.Forms.Label();
            this.laPersNr = new System.Windows.Forms.Label();
            this.laFornamn = new System.Windows.Forms.Label();
            this.laSign = new System.Windows.Forms.Label();
            this.laOvrigt = new System.Windows.Forms.Label();
            this.laEfternamn = new System.Windows.Forms.Label();
            this.lbRegistreradeArtiklar = new System.Windows.Forms.ListBox();
            this.gbRegistreradeArtiklar = new System.Windows.Forms.GroupBox();
            this.cmdRegistreraArtikel = new System.Windows.Forms.Button();
            this.cmdShowAllRegistrerade = new System.Windows.Forms.Button();
            this.txtArtikelSok = new System.Windows.Forms.TextBox();
            this.cmdArtikelAvregistrera = new System.Windows.Forms.Button();
            this.cmdArtikelSok = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cmdNyHandelse = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.gbFalt.SuspendLayout();
            this.gbRegistreradeArtiklar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFalt
            // 
            this.gbFalt.Controls.Add(this.cmdEdit);
            this.gbFalt.Controls.Add(this.cmdDelete);
            this.gbFalt.Controls.Add(this.laPersonIdDisplay);
            this.gbFalt.Controls.Add(this.laOvrigtDisplay);
            this.gbFalt.Controls.Add(this.laTillhorighetDisplay);
            this.gbFalt.Controls.Add(this.laTelefonDisplay);
            this.gbFalt.Controls.Add(this.laEpostDisplay);
            this.gbFalt.Controls.Add(this.laSignDisplay);
            this.gbFalt.Controls.Add(this.laPersNrDisplay);
            this.gbFalt.Controls.Add(this.laEfternamnDisplay);
            this.gbFalt.Controls.Add(this.laFornamnDisplay);
            this.gbFalt.Controls.Add(this.laTillhorighet);
            this.gbFalt.Controls.Add(this.laTelefon);
            this.gbFalt.Controls.Add(this.laPersonId);
            this.gbFalt.Controls.Add(this.laEpost);
            this.gbFalt.Controls.Add(this.laPersNr);
            this.gbFalt.Controls.Add(this.laFornamn);
            this.gbFalt.Controls.Add(this.laSign);
            this.gbFalt.Controls.Add(this.laOvrigt);
            this.gbFalt.Controls.Add(this.laEfternamn);
            this.gbFalt.Location = new System.Drawing.Point(12, 12);
            this.gbFalt.Name = "gbFalt";
            this.gbFalt.Size = new System.Drawing.Size(311, 253);
            this.gbFalt.TabIndex = 1;
            this.gbFalt.TabStop = false;
            this.gbFalt.Text = "Info";
            // 
            // laPersonIdDisplay
            // 
            this.laPersonIdDisplay.Location = new System.Drawing.Point(102, 28);
            this.laPersonIdDisplay.Name = "laPersonIdDisplay";
            this.laPersonIdDisplay.Size = new System.Drawing.Size(189, 13);
            this.laPersonIdDisplay.TabIndex = 38;
            this.laPersonIdDisplay.Text = "Display";
            this.toolTip1.SetToolTip(this.laPersonIdDisplay, "Kopiera (Dubbelklicka)");
            this.laPersonIdDisplay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.laDisplay_DoubleClick);
            this.laPersonIdDisplay.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.laPersonIdDisplay.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // laOvrigtDisplay
            // 
            this.laOvrigtDisplay.Location = new System.Drawing.Point(102, 188);
            this.laOvrigtDisplay.Name = "laOvrigtDisplay";
            this.laOvrigtDisplay.Size = new System.Drawing.Size(189, 13);
            this.laOvrigtDisplay.TabIndex = 37;
            this.laOvrigtDisplay.Text = "Display";
            this.toolTip1.SetToolTip(this.laOvrigtDisplay, "Kopiera (Dubbelklicka)");
            this.laOvrigtDisplay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.laDisplay_DoubleClick);
            this.laOvrigtDisplay.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.laOvrigtDisplay.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // laTillhorighetDisplay
            // 
            this.laTillhorighetDisplay.Location = new System.Drawing.Point(102, 168);
            this.laTillhorighetDisplay.Name = "laTillhorighetDisplay";
            this.laTillhorighetDisplay.Size = new System.Drawing.Size(189, 13);
            this.laTillhorighetDisplay.TabIndex = 36;
            this.laTillhorighetDisplay.Text = "Display";
            this.toolTip1.SetToolTip(this.laTillhorighetDisplay, "Kopiera (Dubbelklicka)");
            this.laTillhorighetDisplay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.laDisplay_DoubleClick);
            this.laTillhorighetDisplay.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.laTillhorighetDisplay.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // laTelefonDisplay
            // 
            this.laTelefonDisplay.Location = new System.Drawing.Point(102, 148);
            this.laTelefonDisplay.Name = "laTelefonDisplay";
            this.laTelefonDisplay.Size = new System.Drawing.Size(189, 13);
            this.laTelefonDisplay.TabIndex = 35;
            this.laTelefonDisplay.Text = "Display";
            this.toolTip1.SetToolTip(this.laTelefonDisplay, "Kopiera (Dubbelklicka)");
            this.laTelefonDisplay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.laDisplay_DoubleClick);
            this.laTelefonDisplay.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.laTelefonDisplay.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // laEpostDisplay
            // 
            this.laEpostDisplay.Location = new System.Drawing.Point(102, 128);
            this.laEpostDisplay.Name = "laEpostDisplay";
            this.laEpostDisplay.Size = new System.Drawing.Size(189, 13);
            this.laEpostDisplay.TabIndex = 34;
            this.laEpostDisplay.Text = "Display";
            this.toolTip1.SetToolTip(this.laEpostDisplay, "Kopiera (Dubbelklicka)");
            this.laEpostDisplay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.laDisplay_DoubleClick);
            this.laEpostDisplay.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.laEpostDisplay.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // laSignDisplay
            // 
            this.laSignDisplay.Location = new System.Drawing.Point(102, 108);
            this.laSignDisplay.Name = "laSignDisplay";
            this.laSignDisplay.Size = new System.Drawing.Size(189, 13);
            this.laSignDisplay.TabIndex = 33;
            this.laSignDisplay.Text = "Display";
            this.toolTip1.SetToolTip(this.laSignDisplay, "Kopiera (Dubbelklicka)");
            this.laSignDisplay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.laDisplay_DoubleClick);
            this.laSignDisplay.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.laSignDisplay.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // laPersNrDisplay
            // 
            this.laPersNrDisplay.Location = new System.Drawing.Point(102, 88);
            this.laPersNrDisplay.Name = "laPersNrDisplay";
            this.laPersNrDisplay.Size = new System.Drawing.Size(189, 13);
            this.laPersNrDisplay.TabIndex = 32;
            this.laPersNrDisplay.Text = "Display";
            this.toolTip1.SetToolTip(this.laPersNrDisplay, "Kopiera (Dubbelklicka)");
            this.laPersNrDisplay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.laDisplay_DoubleClick);
            this.laPersNrDisplay.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.laPersNrDisplay.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // laEfternamnDisplay
            // 
            this.laEfternamnDisplay.Location = new System.Drawing.Point(102, 68);
            this.laEfternamnDisplay.Name = "laEfternamnDisplay";
            this.laEfternamnDisplay.Size = new System.Drawing.Size(189, 13);
            this.laEfternamnDisplay.TabIndex = 31;
            this.laEfternamnDisplay.Text = "Display";
            this.toolTip1.SetToolTip(this.laEfternamnDisplay, "Kopiera (Dubbelklicka)");
            this.laEfternamnDisplay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.laDisplay_DoubleClick);
            this.laEfternamnDisplay.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.laEfternamnDisplay.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // laFornamnDisplay
            // 
            this.laFornamnDisplay.Location = new System.Drawing.Point(102, 48);
            this.laFornamnDisplay.Name = "laFornamnDisplay";
            this.laFornamnDisplay.Size = new System.Drawing.Size(189, 13);
            this.laFornamnDisplay.TabIndex = 30;
            this.laFornamnDisplay.Text = "Display";
            this.toolTip1.SetToolTip(this.laFornamnDisplay, "Kopiera (Dubbelklicka)");
            this.laFornamnDisplay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.laDisplay_DoubleClick);
            this.laFornamnDisplay.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.laFornamnDisplay.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // laTillhorighet
            // 
            this.laTillhorighet.AutoSize = true;
            this.laTillhorighet.Location = new System.Drawing.Point(20, 168);
            this.laTillhorighet.Name = "laTillhorighet";
            this.laTillhorighet.Size = new System.Drawing.Size(61, 13);
            this.laTillhorighet.TabIndex = 0;
            this.laTillhorighet.Text = "Tillhörighet:";
            this.laTillhorighet.Click += new System.EventHandler(this.laTillhorighet_Click);
            // 
            // laTelefon
            // 
            this.laTelefon.AutoSize = true;
            this.laTelefon.Location = new System.Drawing.Point(20, 148);
            this.laTelefon.Name = "laTelefon";
            this.laTelefon.Size = new System.Drawing.Size(46, 13);
            this.laTelefon.TabIndex = 3;
            this.laTelefon.Text = "Telefon:";
            // 
            // laPersonId
            // 
            this.laPersonId.Location = new System.Drawing.Point(20, 28);
            this.laPersonId.Name = "laPersonId";
            this.laPersonId.Size = new System.Drawing.Size(82, 13);
            this.laPersonId.TabIndex = 15;
            this.laPersonId.Text = "Id:";
            // 
            // laEpost
            // 
            this.laEpost.AutoSize = true;
            this.laEpost.Location = new System.Drawing.Point(22, 128);
            this.laEpost.Name = "laEpost";
            this.laEpost.Size = new System.Drawing.Size(40, 13);
            this.laEpost.TabIndex = 4;
            this.laEpost.Text = "E-post:";
            // 
            // laPersNr
            // 
            this.laPersNr.AutoSize = true;
            this.laPersNr.Location = new System.Drawing.Point(20, 88);
            this.laPersNr.Name = "laPersNr";
            this.laPersNr.Size = new System.Drawing.Size(42, 13);
            this.laPersNr.TabIndex = 2;
            this.laPersNr.Text = "PersNr:";
            // 
            // laFornamn
            // 
            this.laFornamn.AutoSize = true;
            this.laFornamn.Location = new System.Drawing.Point(20, 48);
            this.laFornamn.Name = "laFornamn";
            this.laFornamn.Size = new System.Drawing.Size(51, 13);
            this.laFornamn.TabIndex = 0;
            this.laFornamn.Text = "Förnamn:";
            // 
            // laSign
            // 
            this.laSign.AutoSize = true;
            this.laSign.Location = new System.Drawing.Point(20, 108);
            this.laSign.Name = "laSign";
            this.laSign.Size = new System.Drawing.Size(49, 13);
            this.laSign.TabIndex = 10;
            this.laSign.Text = "Signatur:";
            // 
            // laOvrigt
            // 
            this.laOvrigt.AutoSize = true;
            this.laOvrigt.Location = new System.Drawing.Point(20, 188);
            this.laOvrigt.Name = "laOvrigt";
            this.laOvrigt.Size = new System.Drawing.Size(38, 13);
            this.laOvrigt.TabIndex = 5;
            this.laOvrigt.Text = "Övrigt:";
            // 
            // laEfternamn
            // 
            this.laEfternamn.AutoSize = true;
            this.laEfternamn.Location = new System.Drawing.Point(20, 68);
            this.laEfternamn.Name = "laEfternamn";
            this.laEfternamn.Size = new System.Drawing.Size(58, 13);
            this.laEfternamn.TabIndex = 1;
            this.laEfternamn.Text = "Efternamn:";
            // 
            // lbRegistreradeArtiklar
            // 
            this.lbRegistreradeArtiklar.FormattingEnabled = true;
            this.lbRegistreradeArtiklar.Location = new System.Drawing.Point(23, 54);
            this.lbRegistreradeArtiklar.Name = "lbRegistreradeArtiklar";
            this.lbRegistreradeArtiklar.Size = new System.Drawing.Size(315, 186);
            this.lbRegistreradeArtiklar.TabIndex = 3;
            // 
            // gbRegistreradeArtiklar
            // 
            this.gbRegistreradeArtiklar.Controls.Add(this.cmdRegistreraArtikel);
            this.gbRegistreradeArtiklar.Controls.Add(this.cmdShowAllRegistrerade);
            this.gbRegistreradeArtiklar.Controls.Add(this.txtArtikelSok);
            this.gbRegistreradeArtiklar.Controls.Add(this.cmdArtikelAvregistrera);
            this.gbRegistreradeArtiklar.Controls.Add(this.lbRegistreradeArtiklar);
            this.gbRegistreradeArtiklar.Controls.Add(this.cmdArtikelSok);
            this.gbRegistreradeArtiklar.Location = new System.Drawing.Point(12, 271);
            this.gbRegistreradeArtiklar.Name = "gbRegistreradeArtiklar";
            this.gbRegistreradeArtiklar.Size = new System.Drawing.Size(364, 281);
            this.gbRegistreradeArtiklar.TabIndex = 17;
            this.gbRegistreradeArtiklar.TabStop = false;
            this.gbRegistreradeArtiklar.Text = "Registrerade artiklar";
            // 
            // cmdRegistreraArtikel
            // 
            this.cmdRegistreraArtikel.Location = new System.Drawing.Point(133, 246);
            this.cmdRegistreraArtikel.Name = "cmdRegistreraArtikel";
            this.cmdRegistreraArtikel.Size = new System.Drawing.Size(94, 23);
            this.cmdRegistreraArtikel.TabIndex = 20;
            this.cmdRegistreraArtikel.Text = "Registrera";
            this.cmdRegistreraArtikel.UseVisualStyleBackColor = true;
            this.cmdRegistreraArtikel.Click += new System.EventHandler(this.cmdRegistreraArtikel_Click);
            // 
            // cmdShowAllRegistrerade
            // 
            this.cmdShowAllRegistrerade.Location = new System.Drawing.Point(23, 246);
            this.cmdShowAllRegistrerade.Name = "cmdShowAllRegistrerade";
            this.cmdShowAllRegistrerade.Size = new System.Drawing.Size(104, 23);
            this.cmdShowAllRegistrerade.TabIndex = 19;
            this.cmdShowAllRegistrerade.Text = "Visa alla";
            this.cmdShowAllRegistrerade.UseVisualStyleBackColor = true;
            this.cmdShowAllRegistrerade.Click += new System.EventHandler(this.cmdShowAllRegistrerade_Click);
            // 
            // txtArtikelSok
            // 
            this.txtArtikelSok.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtArtikelSok.HideSelection = false;
            this.txtArtikelSok.Location = new System.Drawing.Point(23, 28);
            this.txtArtikelSok.Name = "txtArtikelSok";
            this.txtArtikelSok.Size = new System.Drawing.Size(204, 20);
            this.txtArtikelSok.TabIndex = 17;
            // 
            // cmdArtikelAvregistrera
            // 
            this.cmdArtikelAvregistrera.Location = new System.Drawing.Point(234, 246);
            this.cmdArtikelAvregistrera.Name = "cmdArtikelAvregistrera";
            this.cmdArtikelAvregistrera.Size = new System.Drawing.Size(104, 23);
            this.cmdArtikelAvregistrera.TabIndex = 17;
            this.cmdArtikelAvregistrera.Text = "Avregistrera";
            this.cmdArtikelAvregistrera.UseVisualStyleBackColor = true;
            this.cmdArtikelAvregistrera.Click += new System.EventHandler(this.cmdArtikelAvregistrera_Click);
            // 
            // cmdArtikelSok
            // 
            this.cmdArtikelSok.Location = new System.Drawing.Point(233, 26);
            this.cmdArtikelSok.Name = "cmdArtikelSok";
            this.cmdArtikelSok.Size = new System.Drawing.Size(104, 23);
            this.cmdArtikelSok.TabIndex = 18;
            this.cmdArtikelSok.Text = "Sök";
            this.cmdArtikelSok.UseVisualStyleBackColor = true;
            this.cmdArtikelSok.Click += new System.EventHandler(this.cmdArtikelSok_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.cmdNyHandelse);
            this.groupBox1.Location = new System.Drawing.Point(329, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 236);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Händelser";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(18, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(338, 160);
            this.listBox1.TabIndex = 15;
            // 
            // cmdNyHandelse
            // 
            this.cmdNyHandelse.Location = new System.Drawing.Point(276, 195);
            this.cmdNyHandelse.Name = "cmdNyHandelse";
            this.cmdNyHandelse.Size = new System.Drawing.Size(80, 23);
            this.cmdNyHandelse.TabIndex = 16;
            this.cmdNyHandelse.Text = "Ny ";
            this.cmdNyHandelse.UseVisualStyleBackColor = true;
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(23, 213);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(89, 23);
            this.cmdDelete.TabIndex = 35;
            this.cmdDelete.Text = "Radera";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.Location = new System.Drawing.Point(202, 213);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(89, 23);
            this.cmdEdit.TabIndex = 34;
            this.cmdEdit.Text = "Ändra..";
            this.cmdEdit.UseVisualStyleBackColor = true;
            // 
            // HanteraPersonDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 564);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbRegistreradeArtiklar);
            this.Controls.Add(this.gbFalt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "HanteraPersonDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.HanteraPersonDialogcs_Load);
            this.gbFalt.ResumeLayout(false);
            this.gbFalt.PerformLayout();
            this.gbRegistreradeArtiklar.ResumeLayout(false);
            this.gbRegistreradeArtiklar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFalt;
        private System.Windows.Forms.Label laTillhorighet;
        private System.Windows.Forms.Label laSign;
        private System.Windows.Forms.Label laTelefon;
        private System.Windows.Forms.Label laEpost;
        private System.Windows.Forms.Label laEfternamn;
        private System.Windows.Forms.Label laPersNr;
        private System.Windows.Forms.Label laOvrigt;
        private System.Windows.Forms.Label laFornamn;
        private System.Windows.Forms.Label laPersonId;
        private System.Windows.Forms.ListBox lbRegistreradeArtiklar;
        private System.Windows.Forms.GroupBox gbRegistreradeArtiklar;
        private System.Windows.Forms.TextBox txtArtikelSok;
        private System.Windows.Forms.Button cmdArtikelAvregistrera;
        private System.Windows.Forms.Button cmdArtikelSok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button cmdNyHandelse;
        private System.Windows.Forms.Button cmdShowAllRegistrerade;
        private System.Windows.Forms.Button cmdRegistreraArtikel;
        private System.Windows.Forms.Label laOvrigtDisplay;
        private System.Windows.Forms.Label laTillhorighetDisplay;
        private System.Windows.Forms.Label laTelefonDisplay;
        private System.Windows.Forms.Label laEpostDisplay;
        private System.Windows.Forms.Label laSignDisplay;
        private System.Windows.Forms.Label laPersNrDisplay;
        private System.Windows.Forms.Label laEfternamnDisplay;
        private System.Windows.Forms.Label laFornamnDisplay;
        private System.Windows.Forms.Label laPersonIdDisplay;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button cmdEdit;
        private System.Windows.Forms.Button cmdDelete;
    }
}