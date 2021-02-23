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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.tspPerson = new System.Windows.Forms.ToolStripDropDownButton();
            this.tspPersonNy = new System.Windows.Forms.ToolStripMenuItem();
            this.tspArtikel = new System.Windows.Forms.ToolStripDropDownButton();
            this.tspArtikelNy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
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
            this.cmdSokAlla = new System.Windows.Forms.Button();
            this.gbSearch.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabArtiklarPersoner.SuspendLayout();
            this.tabArtiklar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtiklar)).BeginInit();
            this.tabPersoner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoner)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.cmdSokAlla);
            this.gbSearch.Controls.Add(this.cmdScanLabel);
            this.gbSearch.Controls.Add(this.cmdSok);
            this.gbSearch.Controls.Add(this.txtSok);
            this.gbSearch.Location = new System.Drawing.Point(12, 28);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(349, 82);
            this.gbSearch.TabIndex = 7;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Sök";
            this.gbSearch.Enter += new System.EventHandler(this.gbSearch_Enter);
            // 
            // cmdScanLabel
            // 
            this.cmdScanLabel.Location = new System.Drawing.Point(8, 51);
            this.cmdScanLabel.Name = "cmdScanLabel";
            this.cmdScanLabel.Size = new System.Drawing.Size(99, 22);
            this.cmdScanLabel.TabIndex = 11;
            this.cmdScanLabel.Text = "Skanna";
            this.cmdScanLabel.UseVisualStyleBackColor = true;
            this.cmdScanLabel.Click += new System.EventHandler(this.cmdScanLabel_Click);
            // 
            // cmdSok
            // 
            this.cmdSok.Location = new System.Drawing.Point(232, 50);
            this.cmdSok.Name = "cmdSok";
            this.cmdSok.Size = new System.Drawing.Size(101, 23);
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
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // tspArkivNyDatabasFil
            // 
            this.tspArkivNyDatabasFil.Name = "tspArkivNyDatabasFil";
            this.tspArkivNyDatabasFil.Size = new System.Drawing.Size(180, 22);
            this.tspArkivNyDatabasFil.Text = "Skapa Ny (DB)";
            this.tspArkivNyDatabasFil.Click += new System.EventHandler(this.tspFileNewDB_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // tspArkivInstallningar
            // 
            this.tspArkivInstallningar.Name = "tspArkivInstallningar";
            this.tspArkivInstallningar.Size = new System.Drawing.Size(180, 22);
            this.tspArkivInstallningar.Text = "Inställningar";
            this.tspArkivInstallningar.Click += new System.EventHandler(this.tspArkivInstallningar_Click);
            // 
            // tspArkivAvsluta
            // 
            this.tspArkivAvsluta.Name = "tspArkivAvsluta";
            this.tspArkivAvsluta.Size = new System.Drawing.Size(180, 22);
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
            this.tspPersonNy.Size = new System.Drawing.Size(180, 22);
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
            this.tspArtikelNy.Size = new System.Drawing.Size(180, 22);
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
            this.toolStrip1.Size = new System.Drawing.Size(942, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tabArtiklarPersoner
            // 
            this.tabArtiklarPersoner.Controls.Add(this.tabArtiklar);
            this.tabArtiklarPersoner.Controls.Add(this.tabPersoner);
            this.tabArtiklarPersoner.Location = new System.Drawing.Point(12, 116);
            this.tabArtiklarPersoner.Name = "tabArtiklarPersoner";
            this.tabArtiklarPersoner.SelectedIndex = 0;
            this.tabArtiklarPersoner.Size = new System.Drawing.Size(919, 536);
            this.tabArtiklarPersoner.TabIndex = 12;
            this.tabArtiklarPersoner.SelectedIndexChanged += new System.EventHandler(this.tabArtiklarPersoner_SelectedIndexChanged);
            // 
            // tabArtiklar
            // 
            this.tabArtiklar.BackColor = System.Drawing.SystemColors.Control;
            this.tabArtiklar.Controls.Add(this.dgvArtiklar);
            this.tabArtiklar.Location = new System.Drawing.Point(4, 22);
            this.tabArtiklar.Name = "tabArtiklar";
            this.tabArtiklar.Padding = new System.Windows.Forms.Padding(3);
            this.tabArtiklar.Size = new System.Drawing.Size(911, 510);
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArtiklar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
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
            this.dgvArtiklar.Location = new System.Drawing.Point(3, 3);
            this.dgvArtiklar.MultiSelect = false;
            this.dgvArtiklar.Name = "dgvArtiklar";
            this.dgvArtiklar.RowHeadersVisible = false;
            this.dgvArtiklar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvArtiklar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArtiklar.ShowCellErrors = false;
            this.dgvArtiklar.ShowCellToolTips = false;
            this.dgvArtiklar.ShowEditingIcon = false;
            this.dgvArtiklar.ShowRowErrors = false;
            this.dgvArtiklar.Size = new System.Drawing.Size(905, 504);
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
            this.tabPersoner.Location = new System.Drawing.Point(4, 22);
            this.tabPersoner.Name = "tabPersoner";
            this.tabPersoner.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersoner.Size = new System.Drawing.Size(911, 510);
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersoner.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            this.dgvPersoner.Location = new System.Drawing.Point(3, 3);
            this.dgvPersoner.MultiSelect = false;
            this.dgvPersoner.Name = "dgvPersoner";
            this.dgvPersoner.RowHeadersVisible = false;
            this.dgvPersoner.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPersoner.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersoner.ShowCellErrors = false;
            this.dgvPersoner.ShowCellToolTips = false;
            this.dgvPersoner.ShowEditingIcon = false;
            this.dgvPersoner.ShowRowErrors = false;
            this.dgvPersoner.Size = new System.Drawing.Size(905, 504);
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
            // cmdSokAlla
            // 
            this.cmdSokAlla.Location = new System.Drawing.Point(113, 51);
            this.cmdSokAlla.Name = "cmdSokAlla";
            this.cmdSokAlla.Size = new System.Drawing.Size(113, 22);
            this.cmdSokAlla.TabIndex = 12;
            this.cmdSokAlla.Text = "Sök (Alla)";
            this.cmdSokAlla.UseVisualStyleBackColor = true;
            this.cmdSokAlla.Click += new System.EventHandler(this.cmdSokAlla_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 655);
            this.Controls.Add(this.tabArtiklarPersoner);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prylex";
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
        private System.Windows.Forms.ToolStripDropDownButton tspPerson;
        private System.Windows.Forms.ToolStripMenuItem tspPersonNy;
        private System.Windows.Forms.ToolStripDropDownButton tspArtikel;
        private System.Windows.Forms.ToolStripMenuItem tspArtikelNy;
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
        private System.Windows.Forms.Button cmdSokAlla;
    }
}

