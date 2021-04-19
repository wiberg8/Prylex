namespace ScannerDialog.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.cmdScanLabel = new System.Windows.Forms.Button();
            this.cmdSok = new System.Windows.Forms.Button();
            this.txtSok = new System.Windows.Forms.TextBox();
            this.tspArkiv = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tspArkivNyDatabasFil = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tspArkivInstallningar = new System.Windows.Forms.ToolStripMenuItem();
            this.tspArkivAvsluta = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tspNyPerson = new System.Windows.Forms.ToolStripButton();
            this.tspNyArtikel = new System.Windows.Forms.ToolStripButton();
            this.tspMassRegistrering = new System.Windows.Forms.ToolStripButton();
            this.tspImportPersoner = new System.Windows.Forms.ToolStripButton();
            this.tspNuvarandeDb = new System.Windows.Forms.ToolStripLabel();
            this.tabArtiklarPersoner = new System.Windows.Forms.TabControl();
            this.tabArtiklar = new System.Windows.Forms.TabPage();
            this.dgvArtiklar = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBeskrivning = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDatornamn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStoldtag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serienr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInkop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPersonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPersoner = new System.Windows.Forms.TabPage();
            this.dgvPersoner = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPersNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTillhorighet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOvrigt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laDatabaseWarning = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbVisaEndast = new System.Windows.Forms.ComboBox();
            this.laGridCount = new System.Windows.Forms.Label();
            this.gbSearch.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabArtiklarPersoner.SuspendLayout();
            this.tabArtiklar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtiklar)).BeginInit();
            this.tabPersoner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.cmdScanLabel);
            this.gbSearch.Controls.Add(this.cmdSok);
            this.gbSearch.Controls.Add(this.txtSok);
            this.gbSearch.Location = new System.Drawing.Point(16, 34);
            this.gbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Padding = new System.Windows.Forms.Padding(4);
            this.gbSearch.Size = new System.Drawing.Size(466, 101);
            this.gbSearch.TabIndex = 7;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Sök";
            // 
            // cmdScanLabel
            // 
            this.cmdScanLabel.Location = new System.Drawing.Point(291, 62);
            this.cmdScanLabel.Margin = new System.Windows.Forms.Padding(4);
            this.cmdScanLabel.Name = "cmdScanLabel";
            this.cmdScanLabel.Size = new System.Drawing.Size(153, 27);
            this.cmdScanLabel.TabIndex = 11;
            this.cmdScanLabel.Text = "Skanna (Ettiket)";
            this.cmdScanLabel.UseVisualStyleBackColor = true;
            this.cmdScanLabel.Click += new System.EventHandler(this.cmdScanLabel_Click);
            // 
            // cmdSok
            // 
            this.cmdSok.Location = new System.Drawing.Point(11, 60);
            this.cmdSok.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSok.Name = "cmdSok";
            this.cmdSok.Size = new System.Drawing.Size(135, 28);
            this.cmdSok.TabIndex = 9;
            this.cmdSok.Text = "Sök";
            this.cmdSok.UseVisualStyleBackColor = true;
            this.cmdSok.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // txtSok
            // 
            this.txtSok.Location = new System.Drawing.Point(11, 30);
            this.txtSok.Margin = new System.Windows.Forms.Padding(4);
            this.txtSok.Name = "txtSok";
            this.txtSok.Size = new System.Drawing.Size(433, 22);
            this.txtSok.TabIndex = 8;
            this.txtSok.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSok_KeyDown);
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
            this.tspArkivAvsluta.Click += new System.EventHandler(this.tspArkivAvsluta_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspArkiv,
            this.tspNyPerson,
            this.tspNyArtikel,
            this.tspMassRegistrering,
            this.tspImportPersoner,
            this.tspNuvarandeDb});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1256, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tspNyPerson
            // 
            this.tspNyPerson.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tspNyPerson.Image = ((System.Drawing.Image)(resources.GetObject("tspNyPerson.Image")));
            this.tspNyPerson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspNyPerson.Name = "tspNyPerson";
            this.tspNyPerson.Size = new System.Drawing.Size(65, 22);
            this.tspNyPerson.Text = "Ny person";
            this.tspNyPerson.Click += new System.EventHandler(this.tspNyPerson_Click);
            // 
            // tspNyArtikel
            // 
            this.tspNyArtikel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tspNyArtikel.Image = ((System.Drawing.Image)(resources.GetObject("tspNyArtikel.Image")));
            this.tspNyArtikel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspNyArtikel.Name = "tspNyArtikel";
            this.tspNyArtikel.Size = new System.Drawing.Size(61, 22);
            this.tspNyArtikel.Text = "Ny artikel";
            this.tspNyArtikel.Click += new System.EventHandler(this.tspNyArtikel_Click);
            // 
            // tspMassRegistrering
            // 
            this.tspMassRegistrering.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tspMassRegistrering.Image = ((System.Drawing.Image)(resources.GetObject("tspMassRegistrering.Image")));
            this.tspMassRegistrering.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tspMassRegistrering.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspMassRegistrering.Name = "tspMassRegistrering";
            this.tspMassRegistrering.Size = new System.Drawing.Size(101, 22);
            this.tspMassRegistrering.Text = "Mass registrering";
            this.tspMassRegistrering.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tspMassRegistrering.Click += new System.EventHandler(this.tspSnabbReg_Click);
            // 
            // tspImportPersoner
            // 
            this.tspImportPersoner.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tspImportPersoner.Image = ((System.Drawing.Image)(resources.GetObject("tspImportPersoner.Image")));
            this.tspImportPersoner.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tspImportPersoner.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspImportPersoner.Name = "tspImportPersoner";
            this.tspImportPersoner.Size = new System.Drawing.Size(120, 22);
            this.tspImportPersoner.Text = "Importera (Personer)";
            this.tspImportPersoner.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tspImportPersoner.Click += new System.EventHandler(this.tspImportPersoner_Click);
            // 
            // tspNuvarandeDb
            // 
            this.tspNuvarandeDb.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tspNuvarandeDb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tspNuvarandeDb.Name = "tspNuvarandeDb";
            this.tspNuvarandeDb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tspNuvarandeDb.Size = new System.Drawing.Size(80, 22);
            this.tspNuvarandeDb.Text = "NuvarandeDb";
            // 
            // tabArtiklarPersoner
            // 
            this.tabArtiklarPersoner.Controls.Add(this.tabArtiklar);
            this.tabArtiklarPersoner.Controls.Add(this.tabPersoner);
            this.tabArtiklarPersoner.Location = new System.Drawing.Point(16, 142);
            this.tabArtiklarPersoner.Margin = new System.Windows.Forms.Padding(4);
            this.tabArtiklarPersoner.Name = "tabArtiklarPersoner";
            this.tabArtiklarPersoner.SelectedIndex = 0;
            this.tabArtiklarPersoner.Size = new System.Drawing.Size(1225, 660);
            this.tabArtiklarPersoner.TabIndex = 12;
            this.tabArtiklarPersoner.SelectedIndexChanged += new System.EventHandler(this.tabArtiklarPersoner_SelectedIndexChanged);
            // 
            // tabArtiklar
            // 
            this.tabArtiklar.BackColor = System.Drawing.SystemColors.Control;
            this.tabArtiklar.Controls.Add(this.dgvArtiklar);
            this.tabArtiklar.Location = new System.Drawing.Point(4, 25);
            this.tabArtiklar.Margin = new System.Windows.Forms.Padding(4);
            this.tabArtiklar.Name = "tabArtiklar";
            this.tabArtiklar.Padding = new System.Windows.Forms.Padding(4);
            this.tabArtiklar.Size = new System.Drawing.Size(1217, 631);
            this.tabArtiklar.TabIndex = 0;
            this.tabArtiklar.Text = "Artiklar";
            // 
            // dgvArtiklar
            // 
            this.dgvArtiklar.AllowUserToAddRows = false;
            this.dgvArtiklar.AllowUserToDeleteRows = false;
            this.dgvArtiklar.AllowUserToResizeColumns = false;
            this.dgvArtiklar.AllowUserToResizeRows = false;
            this.dgvArtiklar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArtiklar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvArtiklar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArtiklar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvArtiklar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArtiklar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArtiklar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtiklar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.clmBeskrivning,
            this.clmDatornamn,
            this.clmStoldtag,
            this.Serienr,
            this.clmMac,
            this.clmOs,
            this.clmInkop,
            this.dataGridViewTextBoxColumn2,
            this.clmPersonId});
            this.dgvArtiklar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArtiklar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArtiklar.GridColor = System.Drawing.SystemColors.Control;
            this.dgvArtiklar.Location = new System.Drawing.Point(4, 4);
            this.dgvArtiklar.Margin = new System.Windows.Forms.Padding(4);
            this.dgvArtiklar.MultiSelect = false;
            this.dgvArtiklar.Name = "dgvArtiklar";
            this.dgvArtiklar.RowHeadersVisible = false;
            this.dgvArtiklar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvArtiklar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArtiklar.ShowCellErrors = false;
            this.dgvArtiklar.ShowCellToolTips = false;
            this.dgvArtiklar.ShowEditingIcon = false;
            this.dgvArtiklar.ShowRowErrors = false;
            this.dgvArtiklar.Size = new System.Drawing.Size(1209, 623);
            this.dgvArtiklar.TabIndex = 14;
            this.dgvArtiklar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvArtiklar_MouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // clmBeskrivning
            // 
            this.clmBeskrivning.HeaderText = "Beskrivning";
            this.clmBeskrivning.Name = "clmBeskrivning";
            this.clmBeskrivning.ReadOnly = true;
            // 
            // clmDatornamn
            // 
            this.clmDatornamn.HeaderText = "Datornamn";
            this.clmDatornamn.Name = "clmDatornamn";
            this.clmDatornamn.ReadOnly = true;
            // 
            // clmStoldtag
            // 
            this.clmStoldtag.HeaderText = "Stöldtag";
            this.clmStoldtag.Name = "clmStoldtag";
            // 
            // Serienr
            // 
            this.Serienr.HeaderText = "SerieNr";
            this.Serienr.Name = "Serienr";
            this.Serienr.ReadOnly = true;
            // 
            // clmMac
            // 
            this.clmMac.HeaderText = "Mac";
            this.clmMac.Name = "clmMac";
            this.clmMac.ReadOnly = true;
            // 
            // clmOs
            // 
            this.clmOs.HeaderText = "Os";
            this.clmOs.Name = "clmOs";
            this.clmOs.ReadOnly = true;
            // 
            // clmInkop
            // 
            this.clmInkop.HeaderText = "Inköp";
            this.clmInkop.Name = "clmInkop";
            this.clmInkop.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Övrigt";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // clmPersonId
            // 
            this.clmPersonId.HeaderText = "Person id";
            this.clmPersonId.Name = "clmPersonId";
            this.clmPersonId.ReadOnly = true;
            // 
            // tabPersoner
            // 
            this.tabPersoner.BackColor = System.Drawing.SystemColors.Control;
            this.tabPersoner.Controls.Add(this.dgvPersoner);
            this.tabPersoner.Location = new System.Drawing.Point(4, 25);
            this.tabPersoner.Margin = new System.Windows.Forms.Padding(4);
            this.tabPersoner.Name = "tabPersoner";
            this.tabPersoner.Padding = new System.Windows.Forms.Padding(4);
            this.tabPersoner.Size = new System.Drawing.Size(1217, 631);
            this.tabPersoner.TabIndex = 1;
            this.tabPersoner.Text = "Personer";
            // 
            // dgvPersoner
            // 
            this.dgvPersoner.AllowUserToAddRows = false;
            this.dgvPersoner.AllowUserToDeleteRows = false;
            this.dgvPersoner.AllowUserToResizeColumns = false;
            this.dgvPersoner.AllowUserToResizeRows = false;
            this.dgvPersoner.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersoner.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPersoner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPersoner.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPersoner.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersoner.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPersoner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersoner.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmLastname,
            this.clmFirstname,
            this.clmPersNr,
            this.clmSign,
            this.clmTillhorighet,
            this.clmOvrigt});
            this.dgvPersoner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPersoner.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPersoner.GridColor = System.Drawing.SystemColors.Control;
            this.dgvPersoner.Location = new System.Drawing.Point(4, 4);
            this.dgvPersoner.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPersoner.MultiSelect = false;
            this.dgvPersoner.Name = "dgvPersoner";
            this.dgvPersoner.RowHeadersVisible = false;
            this.dgvPersoner.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPersoner.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersoner.ShowCellErrors = false;
            this.dgvPersoner.ShowCellToolTips = false;
            this.dgvPersoner.ShowEditingIcon = false;
            this.dgvPersoner.ShowRowErrors = false;
            this.dgvPersoner.Size = new System.Drawing.Size(1209, 623);
            this.dgvPersoner.TabIndex = 18;
            this.dgvPersoner.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvPersoner_MouseDoubleClick);
            // 
            // clmId
            // 
            this.clmId.HeaderText = "Id";
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            // 
            // clmLastname
            // 
            this.clmLastname.HeaderText = "Efternamn";
            this.clmLastname.Name = "clmLastname";
            this.clmLastname.ReadOnly = true;
            // 
            // clmFirstname
            // 
            this.clmFirstname.HeaderText = "Förnamn";
            this.clmFirstname.Name = "clmFirstname";
            this.clmFirstname.ReadOnly = true;
            // 
            // clmPersNr
            // 
            this.clmPersNr.HeaderText = "PersNr";
            this.clmPersNr.Name = "clmPersNr";
            this.clmPersNr.ReadOnly = true;
            // 
            // clmSign
            // 
            this.clmSign.HeaderText = "Sign";
            this.clmSign.Name = "clmSign";
            // 
            // clmTillhorighet
            // 
            this.clmTillhorighet.HeaderText = "Tillhörighet";
            this.clmTillhorighet.Name = "clmTillhorighet";
            this.clmTillhorighet.ReadOnly = true;
            // 
            // clmOvrigt
            // 
            this.clmOvrigt.HeaderText = "Övrigt";
            this.clmOvrigt.Name = "clmOvrigt";
            this.clmOvrigt.ReadOnly = true;
            // 
            // laDatabaseWarning
            // 
            this.laDatabaseWarning.AutoSize = true;
            this.laDatabaseWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laDatabaseWarning.ForeColor = System.Drawing.Color.Red;
            this.laDatabaseWarning.Location = new System.Drawing.Point(914, 99);
            this.laDatabaseWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laDatabaseWarning.Name = "laDatabaseWarning";
            this.laDatabaseWarning.Size = new System.Drawing.Size(342, 20);
            this.laDatabaseWarning.TabIndex = 13;
            this.laDatabaseWarning.Text = "Gå till inställningar och välj sökväg till databas fil";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ScannerDialog.Properties.Resources.BigLogga;
            this.pictureBox1.Location = new System.Drawing.Point(1052, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // cbVisaEndast
            // 
            this.cbVisaEndast.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVisaEndast.FormattingEnabled = true;
            this.cbVisaEndast.Location = new System.Drawing.Point(787, 137);
            this.cbVisaEndast.Margin = new System.Windows.Forms.Padding(4);
            this.cbVisaEndast.Name = "cbVisaEndast";
            this.cbVisaEndast.Size = new System.Drawing.Size(444, 24);
            this.cbVisaEndast.TabIndex = 19;
            this.cbVisaEndast.SelectedIndexChanged += new System.EventHandler(this.cbVisaEndast_SelectedIndexChanged);
            // 
            // laGridCount
            // 
            this.laGridCount.Location = new System.Drawing.Point(18, 806);
            this.laGridCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laGridCount.Name = "laGridCount";
            this.laGridCount.Size = new System.Drawing.Size(1219, 14);
            this.laGridCount.TabIndex = 20;
            this.laGridCount.Text = "antal";
            this.laGridCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 830);
            this.Controls.Add(this.laGridCount);
            this.Controls.Add(this.cbVisaEndast);
            this.Controls.Add(this.laDatabaseWarning);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabArtiklarPersoner);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabArtiklarPersoner.ResumeLayout(false);
            this.tabArtiklar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtiklar)).EndInit();
            this.tabPersoner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.TextBox txtSok;
        private System.Windows.Forms.Button cmdSok;
        private System.Windows.Forms.ToolStripDropDownButton tspArkiv;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tspArkivNyDatabasFil;
        private System.Windows.Forms.ToolStripMenuItem tspArkivInstallningar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tspArkivAvsluta;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button cmdScanLabel;
        private System.Windows.Forms.TabControl tabArtiklarPersoner;
        private System.Windows.Forms.TabPage tabArtiklar;
        private System.Windows.Forms.TabPage tabPersoner;
        private System.Windows.Forms.DataGridView dgvPersoner;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFirstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPersNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSign;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTillhorighet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOvrigt;
        private System.Windows.Forms.DataGridView dgvArtiklar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBeskrivning;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDatornamn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStoldtag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serienr;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMac;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOs;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInkop;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPersonId;
        private System.Windows.Forms.Label laDatabaseWarning;
        private System.Windows.Forms.ToolStripButton tspMassRegistrering;
        private System.Windows.Forms.ToolStripButton tspImportPersoner;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripLabel tspNuvarandeDb;
        private System.Windows.Forms.ToolStripButton tspNyPerson;
        private System.Windows.Forms.ToolStripButton tspNyArtikel;
        private System.Windows.Forms.ComboBox cbVisaEndast;
        private System.Windows.Forms.Label laGridCount;
    }
}

