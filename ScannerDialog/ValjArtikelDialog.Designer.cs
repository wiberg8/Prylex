namespace ScannerDialog
{
    partial class ValjArtikelDialog
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
            this.dgvArtiklar = new System.Windows.Forms.DataGridView();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBesk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDatornamn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStoldtag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSerieNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cInkop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOvrigt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPersId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdSok = new System.Windows.Forms.Button();
            this.txtSok = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtiklar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArtiklar
            // 
            this.dgvArtiklar.AllowUserToAddRows = false;
            this.dgvArtiklar.AllowUserToDeleteRows = false;
            this.dgvArtiklar.AllowUserToResizeRows = false;
            this.dgvArtiklar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArtiklar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvArtiklar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvArtiklar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArtiklar.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvArtiklar.ColumnHeadersHeight = 35;
            this.dgvArtiklar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvArtiklar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cBesk,
            this.cDatornamn,
            this.cStoldtag,
            this.cSerieNr,
            this.cMac,
            this.cOs,
            this.cInkop,
            this.cOvrigt,
            this.cPersId});
            this.dgvArtiklar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArtiklar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvArtiklar.Location = new System.Drawing.Point(12, 77);
            this.dgvArtiklar.MultiSelect = false;
            this.dgvArtiklar.Name = "dgvArtiklar";
            this.dgvArtiklar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvArtiklar.RowTemplate.Height = 28;
            this.dgvArtiklar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArtiklar.Size = new System.Drawing.Size(919, 461);
            this.dgvArtiklar.TabIndex = 0;
            this.dgvArtiklar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArtiklar_CellContentClick);
            this.dgvArtiklar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvArtiklar_MouseDoubleClick);
            // 
            // cId
            // 
            this.cId.HeaderText = "Id";
            this.cId.Name = "cId";
            // 
            // cBesk
            // 
            this.cBesk.HeaderText = "Beskrivning";
            this.cBesk.Name = "cBesk";
            // 
            // cDatornamn
            // 
            this.cDatornamn.HeaderText = "Datornamn";
            this.cDatornamn.Name = "cDatornamn";
            // 
            // cStoldtag
            // 
            this.cStoldtag.HeaderText = "Stöldtag";
            this.cStoldtag.Name = "cStoldtag";
            // 
            // cSerieNr
            // 
            this.cSerieNr.HeaderText = "SerieNr";
            this.cSerieNr.Name = "cSerieNr";
            // 
            // cMac
            // 
            this.cMac.HeaderText = "Mac";
            this.cMac.Name = "cMac";
            // 
            // cOs
            // 
            this.cOs.HeaderText = "OS";
            this.cOs.Name = "cOs";
            // 
            // cInkop
            // 
            this.cInkop.HeaderText = "Inköp";
            this.cInkop.Name = "cInkop";
            // 
            // cOvrigt
            // 
            this.cOvrigt.HeaderText = "Övrigt";
            this.cOvrigt.Name = "cOvrigt";
            // 
            // cPersId
            // 
            this.cPersId.HeaderText = "Person Id";
            this.cPersId.Name = "cPersId";
            // 
            // cmdSok
            // 
            this.cmdSok.Location = new System.Drawing.Point(833, 48);
            this.cmdSok.Name = "cmdSok";
            this.cmdSok.Size = new System.Drawing.Size(97, 23);
            this.cmdSok.TabIndex = 11;
            this.cmdSok.Text = "Sök";
            this.cmdSok.UseVisualStyleBackColor = true;
            this.cmdSok.Click += new System.EventHandler(this.cmdSok_Click);
            // 
            // txtSok
            // 
            this.txtSok.Location = new System.Drawing.Point(605, 23);
            this.txtSok.Name = "txtSok";
            this.txtSok.Size = new System.Drawing.Size(326, 20);
            this.txtSok.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dubbelklicka för att välja artikel";
            // 
            // ValjArtikelDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdSok);
            this.Controls.Add(this.txtSok);
            this.Controls.Add(this.dgvArtiklar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ValjArtikelDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ValjArtikelDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtiklar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArtiklar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBesk;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDatornamn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStoldtag;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSerieNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMac;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOs;
        private System.Windows.Forms.DataGridViewTextBoxColumn cInkop;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOvrigt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPersId;
        private System.Windows.Forms.Button cmdSok;
        private System.Windows.Forms.TextBox txtSok;
        private System.Windows.Forms.Label label1;
    }
}