namespace ScannerDialog
{
    partial class ValjPersonDialog
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
            this.dgvPersoner = new System.Windows.Forms.DataGridView();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEfternamn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFornamn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPersNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTillhoriget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOvrigt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdSok = new System.Windows.Forms.Button();
            this.txtSok = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoner)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersoner
            // 
            this.dgvPersoner.AllowUserToAddRows = false;
            this.dgvPersoner.AllowUserToDeleteRows = false;
            this.dgvPersoner.AllowUserToResizeRows = false;
            this.dgvPersoner.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersoner.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvPersoner.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPersoner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPersoner.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvPersoner.ColumnHeadersHeight = 35;
            this.dgvPersoner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPersoner.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cEfternamn,
            this.cFornamn,
            this.cPersNr,
            this.cSign,
            this.cTillhoriget,
            this.cOvrigt});
            this.dgvPersoner.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPersoner.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPersoner.Location = new System.Drawing.Point(25, 80);
            this.dgvPersoner.MultiSelect = false;
            this.dgvPersoner.Name = "dgvPersoner";
            this.dgvPersoner.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvPersoner.RowTemplate.Height = 28;
            this.dgvPersoner.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersoner.Size = new System.Drawing.Size(873, 484);
            this.dgvPersoner.TabIndex = 1;
            this.dgvPersoner.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvPersoner_MouseDoubleClick);
            // 
            // cId
            // 
            this.cId.HeaderText = "Id";
            this.cId.Name = "cId";
            // 
            // cEfternamn
            // 
            this.cEfternamn.HeaderText = "Efternamn";
            this.cEfternamn.Name = "cEfternamn";
            // 
            // cFornamn
            // 
            this.cFornamn.HeaderText = "Förnamn";
            this.cFornamn.Name = "cFornamn";
            // 
            // cPersNr
            // 
            this.cPersNr.HeaderText = "PersNr";
            this.cPersNr.Name = "cPersNr";
            // 
            // cSign
            // 
            this.cSign.HeaderText = "Sign";
            this.cSign.Name = "cSign";
            // 
            // cTillhoriget
            // 
            this.cTillhoriget.HeaderText = "Tillhöriget";
            this.cTillhoriget.Name = "cTillhoriget";
            // 
            // cOvrigt
            // 
            this.cOvrigt.HeaderText = "Övrigt";
            this.cOvrigt.Name = "cOvrigt";
            // 
            // cmdSok
            // 
            this.cmdSok.Location = new System.Drawing.Point(797, 51);
            this.cmdSok.Name = "cmdSok";
            this.cmdSok.Size = new System.Drawing.Size(97, 23);
            this.cmdSok.TabIndex = 9;
            this.cmdSok.Text = "Sök";
            this.cmdSok.UseVisualStyleBackColor = true;
            this.cmdSok.Click += new System.EventHandler(this.cmdSok_Click);
            // 
            // txtSok
            // 
            this.txtSok.Location = new System.Drawing.Point(569, 26);
            this.txtSok.Name = "txtSok";
            this.txtSok.Size = new System.Drawing.Size(326, 20);
            this.txtSok.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(22, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Dubbelklicka för att välja person";
            // 
            // ValjPersonDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 576);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdSok);
            this.Controls.Add(this.txtSok);
            this.Controls.Add(this.dgvPersoner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ValjPersonDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ValjPersonDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersoner;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEfternamn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFornamn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPersNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSign;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTillhoriget;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOvrigt;
        private System.Windows.Forms.Button cmdSok;
        private System.Windows.Forms.TextBox txtSok;
        private System.Windows.Forms.Label label1;
    }
}