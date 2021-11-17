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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmdSok = new System.Windows.Forms.Button();
            this.txtSok = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvArtiklar = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBeskrivning = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDatornamn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStoldtag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serienr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInkop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOvrigt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPersonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtiklar)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdSok
            // 
            this.cmdSok.Location = new System.Drawing.Point(1111, 59);
            this.cmdSok.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSok.Name = "cmdSok";
            this.cmdSok.Size = new System.Drawing.Size(129, 28);
            this.cmdSok.TabIndex = 11;
            this.cmdSok.Text = "Sök";
            this.cmdSok.UseVisualStyleBackColor = true;
            this.cmdSok.Click += new System.EventHandler(this.cmdSok_Click);
            // 
            // txtSok
            // 
            this.txtSok.Location = new System.Drawing.Point(807, 28);
            this.txtSok.Margin = new System.Windows.Forms.Padding(4);
            this.txtSok.Name = "txtSok";
            this.txtSok.Size = new System.Drawing.Size(433, 22);
            this.txtSok.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(16, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dubbelklicka för att välja artikel";
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
            this.clmId,
            this.clmBeskrivning,
            this.clmDatornamn,
            this.clmStoldtag,
            this.Serienr,
            this.clmMac,
            this.clmOs,
            this.clmInkop,
            this.clmOvrigt,
            this.clmPersonId});
            this.dgvArtiklar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArtiklar.GridColor = System.Drawing.SystemColors.Control;
            this.dgvArtiklar.Location = new System.Drawing.Point(20, 106);
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
            this.dgvArtiklar.Size = new System.Drawing.Size(1224, 640);
            this.dgvArtiklar.TabIndex = 13;
            this.dgvArtiklar.DoubleClick += new System.EventHandler(this.dgvArtiklar_DoubleClick);
            // 
            // clmId
            // 
            this.clmId.HeaderText = "Id";
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
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
            // clmOvrigt
            // 
            this.clmOvrigt.HeaderText = "Övrigt";
            this.clmOvrigt.Name = "clmOvrigt";
            this.clmOvrigt.ReadOnly = true;
            // 
            // clmPersonId
            // 
            this.clmPersonId.HeaderText = "Person id";
            this.clmPersonId.Name = "clmPersonId";
            this.clmPersonId.ReadOnly = true;
            // 
            // ValjArtikelDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 764);
            this.Controls.Add(this.dgvArtiklar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdSok);
            this.Controls.Add(this.txtSok);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ValjArtikelDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ValjArtikelDialog_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValjArtikelDialog_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtiklar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdSok;
        private System.Windows.Forms.TextBox txtSok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvArtiklar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBeskrivning;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDatornamn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStoldtag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serienr;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMac;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOs;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInkop;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOvrigt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPersonId;
    }
}