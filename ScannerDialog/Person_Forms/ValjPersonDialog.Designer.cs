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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmdSok = new System.Windows.Forms.Button();
            this.txtSok = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPersoner = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPersNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTillhorighet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOvrigt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoner)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdSok
            // 
            this.cmdSok.Location = new System.Drawing.Point(1063, 63);
            this.cmdSok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdSok.Name = "cmdSok";
            this.cmdSok.Size = new System.Drawing.Size(129, 28);
            this.cmdSok.TabIndex = 9;
            this.cmdSok.Text = "Sök";
            this.cmdSok.UseVisualStyleBackColor = true;
            this.cmdSok.Click += new System.EventHandler(this.cmdSok_Click);
            // 
            // txtSok
            // 
            this.txtSok.Location = new System.Drawing.Point(759, 32);
            this.txtSok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSok.Name = "txtSok";
            this.txtSok.Size = new System.Drawing.Size(433, 22);
            this.txtSok.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(29, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Dubbelklicka för att välja person";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersoner.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPersoner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersoner.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmLastname,
            this.clmFirstname,
            this.clmPersNr,
            this.clmSign,
            this.clmTillhorighet,
            this.clmOvrigt});
            this.dgvPersoner.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPersoner.GridColor = System.Drawing.SystemColors.Control;
            this.dgvPersoner.Location = new System.Drawing.Point(33, 106);
            this.dgvPersoner.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPersoner.MultiSelect = false;
            this.dgvPersoner.Name = "dgvPersoner";
            this.dgvPersoner.RowHeadersVisible = false;
            this.dgvPersoner.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPersoner.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersoner.ShowCellErrors = false;
            this.dgvPersoner.ShowCellToolTips = false;
            this.dgvPersoner.ShowEditingIcon = false;
            this.dgvPersoner.ShowRowErrors = false;
            this.dgvPersoner.Size = new System.Drawing.Size(1160, 546);
            this.dgvPersoner.TabIndex = 14;
            this.dgvPersoner.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvPersoner_MouseDoubleClick_1);
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
            // ValjPersonDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 678);
            this.Controls.Add(this.dgvPersoner);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdSok);
            this.Controls.Add(this.txtSok);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ValjPersonDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ValjPersonDialog_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValjPersonDialog_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdSok;
        private System.Windows.Forms.TextBox txtSok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPersoner;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFirstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPersNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSign;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTillhorighet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOvrigt;
    }
}