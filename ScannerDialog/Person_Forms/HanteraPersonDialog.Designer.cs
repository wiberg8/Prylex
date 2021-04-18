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
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
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
            this.laAntalRegArtiklar = new System.Windows.Forms.Label();
            this.cmdRegistreraSkanna = new System.Windows.Forms.Button();
            this.cmdShowAllRegistrerade = new System.Windows.Forms.Button();
            this.cbPrintOnScan = new System.Windows.Forms.CheckBox();
            this.cmdArtikelAvregistrera = new System.Windows.Forms.Button();
            this.cmdSkrivUtEttiket = new System.Windows.Forms.Button();
            this.cmdRegistreraArtikel = new System.Windows.Forms.Button();
            this.txtArtikelSok = new System.Windows.Forms.TextBox();
            this.cmdArtikelSok = new System.Windows.Forms.Button();
            this.cmdExporteraDatornamn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdNyHandelse = new System.Windows.Forms.Button();
            this.cbSelectHandelseTyp = new System.Windows.Forms.ComboBox();
            this.txtHandelseArtikel = new System.Windows.Forms.TextBox();
            this.lbHandelser = new System.Windows.Forms.ListBox();
            this.laHandelseArtikel = new System.Windows.Forms.Label();
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
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
            this.gbFalt.Location = new System.Drawing.Point(16, 15);
            this.gbFalt.Margin = new System.Windows.Forms.Padding(4);
            this.gbFalt.Name = "gbFalt";
            this.gbFalt.Padding = new System.Windows.Forms.Padding(4);
            this.gbFalt.Size = new System.Drawing.Size(415, 311);
            this.gbFalt.TabIndex = 1;
            this.gbFalt.TabStop = false;
            this.gbFalt.Text = "Info";
            // 
            // cmdEdit
            // 
            this.cmdEdit.Location = new System.Drawing.Point(269, 262);
            this.cmdEdit.Margin = new System.Windows.Forms.Padding(4);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(119, 28);
            this.cmdEdit.TabIndex = 34;
            this.cmdEdit.Text = "Ändra..";
            this.cmdEdit.UseVisualStyleBackColor = true;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(31, 262);
            this.cmdDelete.Margin = new System.Windows.Forms.Padding(4);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(119, 28);
            this.cmdDelete.TabIndex = 35;
            this.cmdDelete.Text = "Radera";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // laPersonIdDisplay
            // 
            this.laPersonIdDisplay.Location = new System.Drawing.Point(136, 34);
            this.laPersonIdDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laPersonIdDisplay.Name = "laPersonIdDisplay";
            this.laPersonIdDisplay.Size = new System.Drawing.Size(252, 16);
            this.laPersonIdDisplay.TabIndex = 38;
            this.laPersonIdDisplay.Text = "Display";
            // 
            // laOvrigtDisplay
            // 
            this.laOvrigtDisplay.Location = new System.Drawing.Point(136, 231);
            this.laOvrigtDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laOvrigtDisplay.Name = "laOvrigtDisplay";
            this.laOvrigtDisplay.Size = new System.Drawing.Size(252, 16);
            this.laOvrigtDisplay.TabIndex = 37;
            this.laOvrigtDisplay.Text = "Display";
            // 
            // laTillhorighetDisplay
            // 
            this.laTillhorighetDisplay.Location = new System.Drawing.Point(136, 207);
            this.laTillhorighetDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laTillhorighetDisplay.Name = "laTillhorighetDisplay";
            this.laTillhorighetDisplay.Size = new System.Drawing.Size(252, 16);
            this.laTillhorighetDisplay.TabIndex = 36;
            this.laTillhorighetDisplay.Text = "Display";
            // 
            // laTelefonDisplay
            // 
            this.laTelefonDisplay.Location = new System.Drawing.Point(136, 182);
            this.laTelefonDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laTelefonDisplay.Name = "laTelefonDisplay";
            this.laTelefonDisplay.Size = new System.Drawing.Size(252, 16);
            this.laTelefonDisplay.TabIndex = 35;
            this.laTelefonDisplay.Text = "Display";
            // 
            // laEpostDisplay
            // 
            this.laEpostDisplay.Location = new System.Drawing.Point(136, 158);
            this.laEpostDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laEpostDisplay.Name = "laEpostDisplay";
            this.laEpostDisplay.Size = new System.Drawing.Size(252, 16);
            this.laEpostDisplay.TabIndex = 34;
            this.laEpostDisplay.Text = "Display";
            // 
            // laSignDisplay
            // 
            this.laSignDisplay.Location = new System.Drawing.Point(136, 133);
            this.laSignDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laSignDisplay.Name = "laSignDisplay";
            this.laSignDisplay.Size = new System.Drawing.Size(252, 16);
            this.laSignDisplay.TabIndex = 33;
            this.laSignDisplay.Text = "Display";
            // 
            // laPersNrDisplay
            // 
            this.laPersNrDisplay.Location = new System.Drawing.Point(136, 108);
            this.laPersNrDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laPersNrDisplay.Name = "laPersNrDisplay";
            this.laPersNrDisplay.Size = new System.Drawing.Size(252, 16);
            this.laPersNrDisplay.TabIndex = 32;
            this.laPersNrDisplay.Text = "Display";
            // 
            // laEfternamnDisplay
            // 
            this.laEfternamnDisplay.Location = new System.Drawing.Point(136, 84);
            this.laEfternamnDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laEfternamnDisplay.Name = "laEfternamnDisplay";
            this.laEfternamnDisplay.Size = new System.Drawing.Size(252, 16);
            this.laEfternamnDisplay.TabIndex = 31;
            this.laEfternamnDisplay.Text = "Display";
            // 
            // laFornamnDisplay
            // 
            this.laFornamnDisplay.Location = new System.Drawing.Point(136, 59);
            this.laFornamnDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laFornamnDisplay.Name = "laFornamnDisplay";
            this.laFornamnDisplay.Size = new System.Drawing.Size(252, 16);
            this.laFornamnDisplay.TabIndex = 30;
            this.laFornamnDisplay.Text = "Display";
            // 
            // laTillhorighet
            // 
            this.laTillhorighet.AutoSize = true;
            this.laTillhorighet.Location = new System.Drawing.Point(27, 207);
            this.laTillhorighet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laTillhorighet.Name = "laTillhorighet";
            this.laTillhorighet.Size = new System.Drawing.Size(77, 16);
            this.laTillhorighet.TabIndex = 0;
            this.laTillhorighet.Text = "Tillhörighet:";
            // 
            // laTelefon
            // 
            this.laTelefon.AutoSize = true;
            this.laTelefon.Location = new System.Drawing.Point(27, 182);
            this.laTelefon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laTelefon.Name = "laTelefon";
            this.laTelefon.Size = new System.Drawing.Size(57, 16);
            this.laTelefon.TabIndex = 3;
            this.laTelefon.Text = "Telefon:";
            // 
            // laPersonId
            // 
            this.laPersonId.Location = new System.Drawing.Point(27, 34);
            this.laPersonId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laPersonId.Name = "laPersonId";
            this.laPersonId.Size = new System.Drawing.Size(109, 16);
            this.laPersonId.TabIndex = 15;
            this.laPersonId.Text = "Id:";
            // 
            // laEpost
            // 
            this.laEpost.AutoSize = true;
            this.laEpost.Location = new System.Drawing.Point(29, 158);
            this.laEpost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laEpost.Name = "laEpost";
            this.laEpost.Size = new System.Drawing.Size(50, 16);
            this.laEpost.TabIndex = 4;
            this.laEpost.Text = "E-post:";
            // 
            // laPersNr
            // 
            this.laPersNr.AutoSize = true;
            this.laPersNr.Location = new System.Drawing.Point(27, 108);
            this.laPersNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laPersNr.Name = "laPersNr";
            this.laPersNr.Size = new System.Drawing.Size(53, 16);
            this.laPersNr.TabIndex = 2;
            this.laPersNr.Text = "PersNr:";
            // 
            // laFornamn
            // 
            this.laFornamn.AutoSize = true;
            this.laFornamn.Location = new System.Drawing.Point(27, 59);
            this.laFornamn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laFornamn.Name = "laFornamn";
            this.laFornamn.Size = new System.Drawing.Size(64, 16);
            this.laFornamn.TabIndex = 0;
            this.laFornamn.Text = "Förnamn:";
            // 
            // laSign
            // 
            this.laSign.AutoSize = true;
            this.laSign.Location = new System.Drawing.Point(27, 133);
            this.laSign.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laSign.Name = "laSign";
            this.laSign.Size = new System.Drawing.Size(60, 16);
            this.laSign.TabIndex = 10;
            this.laSign.Text = "Signatur:";
            // 
            // laOvrigt
            // 
            this.laOvrigt.AutoSize = true;
            this.laOvrigt.Location = new System.Drawing.Point(27, 231);
            this.laOvrigt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laOvrigt.Name = "laOvrigt";
            this.laOvrigt.Size = new System.Drawing.Size(46, 16);
            this.laOvrigt.TabIndex = 5;
            this.laOvrigt.Text = "Övrigt:";
            // 
            // laEfternamn
            // 
            this.laEfternamn.AutoSize = true;
            this.laEfternamn.Location = new System.Drawing.Point(27, 84);
            this.laEfternamn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laEfternamn.Name = "laEfternamn";
            this.laEfternamn.Size = new System.Drawing.Size(71, 16);
            this.laEfternamn.TabIndex = 1;
            this.laEfternamn.Text = "Efternamn:";
            // 
            // lbRegistreradeArtiklar
            // 
            this.lbRegistreradeArtiklar.FormattingEnabled = true;
            this.lbRegistreradeArtiklar.ItemHeight = 16;
            this.lbRegistreradeArtiklar.Location = new System.Drawing.Point(31, 66);
            this.lbRegistreradeArtiklar.Margin = new System.Windows.Forms.Padding(4);
            this.lbRegistreradeArtiklar.Name = "lbRegistreradeArtiklar";
            this.lbRegistreradeArtiklar.Size = new System.Drawing.Size(543, 228);
            this.lbRegistreradeArtiklar.TabIndex = 3;
            // 
            // gbRegistreradeArtiklar
            // 
            this.gbRegistreradeArtiklar.Controls.Add(this.laAntalRegArtiklar);
            this.gbRegistreradeArtiklar.Controls.Add(this.cmdRegistreraSkanna);
            this.gbRegistreradeArtiklar.Controls.Add(this.cmdShowAllRegistrerade);
            this.gbRegistreradeArtiklar.Controls.Add(this.cbPrintOnScan);
            this.gbRegistreradeArtiklar.Controls.Add(this.cmdArtikelAvregistrera);
            this.gbRegistreradeArtiklar.Controls.Add(this.cmdSkrivUtEttiket);
            this.gbRegistreradeArtiklar.Controls.Add(this.cmdRegistreraArtikel);
            this.gbRegistreradeArtiklar.Controls.Add(this.txtArtikelSok);
            this.gbRegistreradeArtiklar.Controls.Add(this.lbRegistreradeArtiklar);
            this.gbRegistreradeArtiklar.Controls.Add(this.cmdArtikelSok);
            this.gbRegistreradeArtiklar.Controls.Add(this.cmdExporteraDatornamn);
            this.gbRegistreradeArtiklar.Location = new System.Drawing.Point(16, 345);
            this.gbRegistreradeArtiklar.Margin = new System.Windows.Forms.Padding(4);
            this.gbRegistreradeArtiklar.Name = "gbRegistreradeArtiklar";
            this.gbRegistreradeArtiklar.Padding = new System.Windows.Forms.Padding(4);
            this.gbRegistreradeArtiklar.Size = new System.Drawing.Size(784, 343);
            this.gbRegistreradeArtiklar.TabIndex = 17;
            this.gbRegistreradeArtiklar.TabStop = false;
            this.gbRegistreradeArtiklar.Text = "Registrerade artiklar";
            // 
            // laAntalRegArtiklar
            // 
            this.laAntalRegArtiklar.Location = new System.Drawing.Point(29, 304);
            this.laAntalRegArtiklar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laAntalRegArtiklar.Name = "laAntalRegArtiklar";
            this.laAntalRegArtiklar.Size = new System.Drawing.Size(360, 23);
            this.laAntalRegArtiklar.TabIndex = 26;
            this.laAntalRegArtiklar.Text = "Antal:";
            // 
            // cmdRegistreraSkanna
            // 
            this.cmdRegistreraSkanna.Location = new System.Drawing.Point(583, 66);
            this.cmdRegistreraSkanna.Margin = new System.Windows.Forms.Padding(4);
            this.cmdRegistreraSkanna.Name = "cmdRegistreraSkanna";
            this.cmdRegistreraSkanna.Size = new System.Drawing.Size(177, 28);
            this.cmdRegistreraSkanna.TabIndex = 21;
            this.cmdRegistreraSkanna.Text = "Registrera (Skanna)";
            this.cmdRegistreraSkanna.UseVisualStyleBackColor = true;
            this.cmdRegistreraSkanna.Click += new System.EventHandler(this.cmdRegistreraSkanna_Click);
            // 
            // cmdShowAllRegistrerade
            // 
            this.cmdShowAllRegistrerade.Location = new System.Drawing.Point(455, 32);
            this.cmdShowAllRegistrerade.Margin = new System.Windows.Forms.Padding(4);
            this.cmdShowAllRegistrerade.Name = "cmdShowAllRegistrerade";
            this.cmdShowAllRegistrerade.Size = new System.Drawing.Size(120, 28);
            this.cmdShowAllRegistrerade.TabIndex = 19;
            this.cmdShowAllRegistrerade.Text = "Visa alla";
            this.cmdShowAllRegistrerade.UseVisualStyleBackColor = true;
            this.cmdShowAllRegistrerade.Click += new System.EventHandler(this.cmdShowAllRegistrerade_Click);
            // 
            // cbPrintOnScan
            // 
            this.cbPrintOnScan.AutoSize = true;
            this.cbPrintOnScan.Location = new System.Drawing.Point(583, 167);
            this.cbPrintOnScan.Margin = new System.Windows.Forms.Padding(4);
            this.cbPrintOnScan.Name = "cbPrintOnScan";
            this.cbPrintOnScan.Size = new System.Drawing.Size(161, 20);
            this.cbPrintOnScan.TabIndex = 25;
            this.cbPrintOnScan.Text = "Skriv ut vid registrering";
            this.cbPrintOnScan.UseVisualStyleBackColor = true;
            // 
            // cmdArtikelAvregistrera
            // 
            this.cmdArtikelAvregistrera.Location = new System.Drawing.Point(583, 267);
            this.cmdArtikelAvregistrera.Margin = new System.Windows.Forms.Padding(4);
            this.cmdArtikelAvregistrera.Name = "cmdArtikelAvregistrera";
            this.cmdArtikelAvregistrera.Size = new System.Drawing.Size(177, 28);
            this.cmdArtikelAvregistrera.TabIndex = 17;
            this.cmdArtikelAvregistrera.Text = "Avregistrera";
            this.cmdArtikelAvregistrera.UseVisualStyleBackColor = true;
            this.cmdArtikelAvregistrera.Click += new System.EventHandler(this.cmdArtikelAvregistrera_Click);
            // 
            // cmdSkrivUtEttiket
            // 
            this.cmdSkrivUtEttiket.Location = new System.Drawing.Point(583, 231);
            this.cmdSkrivUtEttiket.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSkrivUtEttiket.Name = "cmdSkrivUtEttiket";
            this.cmdSkrivUtEttiket.Size = new System.Drawing.Size(177, 28);
            this.cmdSkrivUtEttiket.TabIndex = 19;
            this.cmdSkrivUtEttiket.Text = "Ettiket";
            this.cmdSkrivUtEttiket.UseVisualStyleBackColor = true;
            this.cmdSkrivUtEttiket.Click += new System.EventHandler(this.cmdSkrivUtEttiket_Click);
            // 
            // cmdRegistreraArtikel
            // 
            this.cmdRegistreraArtikel.Location = new System.Drawing.Point(583, 102);
            this.cmdRegistreraArtikel.Margin = new System.Windows.Forms.Padding(4);
            this.cmdRegistreraArtikel.Name = "cmdRegistreraArtikel";
            this.cmdRegistreraArtikel.Size = new System.Drawing.Size(177, 28);
            this.cmdRegistreraArtikel.TabIndex = 20;
            this.cmdRegistreraArtikel.Text = "Registrera";
            this.cmdRegistreraArtikel.UseVisualStyleBackColor = true;
            this.cmdRegistreraArtikel.Click += new System.EventHandler(this.cmdRegistreraArtikel_Click);
            // 
            // txtArtikelSok
            // 
            this.txtArtikelSok.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtArtikelSok.HideSelection = false;
            this.txtArtikelSok.Location = new System.Drawing.Point(31, 34);
            this.txtArtikelSok.Margin = new System.Windows.Forms.Padding(4);
            this.txtArtikelSok.Name = "txtArtikelSok";
            this.txtArtikelSok.Size = new System.Drawing.Size(279, 22);
            this.txtArtikelSok.TabIndex = 17;
            // 
            // cmdArtikelSok
            // 
            this.cmdArtikelSok.Location = new System.Drawing.Point(319, 32);
            this.cmdArtikelSok.Margin = new System.Windows.Forms.Padding(4);
            this.cmdArtikelSok.Name = "cmdArtikelSok";
            this.cmdArtikelSok.Size = new System.Drawing.Size(128, 28);
            this.cmdArtikelSok.TabIndex = 18;
            this.cmdArtikelSok.Text = "Sök";
            this.cmdArtikelSok.UseVisualStyleBackColor = true;
            this.cmdArtikelSok.Click += new System.EventHandler(this.cmdArtikelSok_Click);
            // 
            // cmdExporteraDatornamn
            // 
            this.cmdExporteraDatornamn.Location = new System.Drawing.Point(397, 303);
            this.cmdExporteraDatornamn.Margin = new System.Windows.Forms.Padding(4);
            this.cmdExporteraDatornamn.Name = "cmdExporteraDatornamn";
            this.cmdExporteraDatornamn.Size = new System.Drawing.Size(177, 28);
            this.cmdExporteraDatornamn.TabIndex = 22;
            this.cmdExporteraDatornamn.Text = "Exportera (Artikel lista)";
            this.cmdExporteraDatornamn.UseVisualStyleBackColor = true;
            this.cmdExporteraDatornamn.Click += new System.EventHandler(this.cmdExporteraDatornamn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdNyHandelse);
            this.groupBox1.Controls.Add(this.cbSelectHandelseTyp);
            this.groupBox1.Controls.Add(this.txtHandelseArtikel);
            this.groupBox1.Controls.Add(this.lbHandelser);
            this.groupBox1.Controls.Add(this.laHandelseArtikel);
            this.groupBox1.Location = new System.Drawing.Point(439, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(497, 330);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Händelser";
            // 
            // cmdNyHandelse
            // 
            this.cmdNyHandelse.Location = new System.Drawing.Point(345, 283);
            this.cmdNyHandelse.Margin = new System.Windows.Forms.Padding(4);
            this.cmdNyHandelse.Name = "cmdNyHandelse";
            this.cmdNyHandelse.Size = new System.Drawing.Size(125, 28);
            this.cmdNyHandelse.TabIndex = 25;
            this.cmdNyHandelse.Text = "Ny ";
            this.cmdNyHandelse.UseVisualStyleBackColor = true;
            this.cmdNyHandelse.Click += new System.EventHandler(this.cmdNyHandelse_Click);
            // 
            // cbSelectHandelseTyp
            // 
            this.cbSelectHandelseTyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectHandelseTyp.FormattingEnabled = true;
            this.cbSelectHandelseTyp.Location = new System.Drawing.Point(24, 31);
            this.cbSelectHandelseTyp.Margin = new System.Windows.Forms.Padding(4);
            this.cbSelectHandelseTyp.Name = "cbSelectHandelseTyp";
            this.cbSelectHandelseTyp.Size = new System.Drawing.Size(445, 24);
            this.cbSelectHandelseTyp.TabIndex = 35;
            this.cbSelectHandelseTyp.SelectedIndexChanged += new System.EventHandler(this.cbSelectHandelseTyp_SelectedIndexChanged);
            // 
            // txtHandelseArtikel
            // 
            this.txtHandelseArtikel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHandelseArtikel.HideSelection = false;
            this.txtHandelseArtikel.Location = new System.Drawing.Point(24, 286);
            this.txtHandelseArtikel.Margin = new System.Windows.Forms.Padding(4);
            this.txtHandelseArtikel.Name = "txtHandelseArtikel";
            this.txtHandelseArtikel.ReadOnly = true;
            this.txtHandelseArtikel.Size = new System.Drawing.Size(312, 22);
            this.txtHandelseArtikel.TabIndex = 16;
            // 
            // lbHandelser
            // 
            this.lbHandelser.FormattingEnabled = true;
            this.lbHandelser.ItemHeight = 16;
            this.lbHandelser.Location = new System.Drawing.Point(24, 64);
            this.lbHandelser.Margin = new System.Windows.Forms.Padding(4);
            this.lbHandelser.Name = "lbHandelser";
            this.lbHandelser.Size = new System.Drawing.Size(445, 196);
            this.lbHandelser.TabIndex = 15;
            this.lbHandelser.SelectedIndexChanged += new System.EventHandler(this.lbHandelser_SelectedIndexChanged);
            // 
            // laHandelseArtikel
            // 
            this.laHandelseArtikel.AutoSize = true;
            this.laHandelseArtikel.Location = new System.Drawing.Point(20, 265);
            this.laHandelseArtikel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laHandelseArtikel.Name = "laHandelseArtikel";
            this.laHandelseArtikel.Size = new System.Drawing.Size(48, 16);
            this.laHandelseArtikel.TabIndex = 34;
            this.laHandelseArtikel.Text = "Artikel:";
            // 
            // HanteraPersonDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 702);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbRegistreradeArtiklar);
            this.Controls.Add(this.gbFalt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HanteraPersonDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.Load += new System.EventHandler(this.HanteraPersonDialogcs_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HanteraPersonDialog_KeyDown);
            this.gbFalt.ResumeLayout(false);
            this.gbFalt.PerformLayout();
            this.gbRegistreradeArtiklar.ResumeLayout(false);
            this.gbRegistreradeArtiklar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button cmdEdit;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdSkrivUtEttiket;
        private System.Windows.Forms.Button cmdRegistreraSkanna;
        private System.Windows.Forms.Button cmdExporteraDatornamn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHandelseArtikel;
        private System.Windows.Forms.ListBox lbHandelser;
        private System.Windows.Forms.Label laHandelseArtikel;
        private System.Windows.Forms.CheckBox cbPrintOnScan;
        private System.Windows.Forms.Label laAntalRegArtiklar;
        private System.Windows.Forms.ComboBox cbSelectHandelseTyp;
        private System.Windows.Forms.Button cmdNyHandelse;
        private System.Windows.Forms.ToolTip toolTipHelp;
    }
}