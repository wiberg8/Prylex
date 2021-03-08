namespace ScannerDialog
{
    partial class ImportDialog
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
            this.cmdImportFilUtforska = new System.Windows.Forms.Button();
            this.cmdTestImport = new System.Windows.Forms.Button();
            this.txtImportFil = new System.Windows.Forms.TextBox();
            this.laImportFil = new System.Windows.Forms.Label();
            this.lbPersoner = new System.Windows.Forms.ListBox();
            this.cbTillhorighet = new System.Windows.Forms.ComboBox();
            this.laTillhorighet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdImportFilUtforska
            // 
            this.cmdImportFilUtforska.Location = new System.Drawing.Point(528, 39);
            this.cmdImportFilUtforska.Name = "cmdImportFilUtforska";
            this.cmdImportFilUtforska.Size = new System.Drawing.Size(118, 23);
            this.cmdImportFilUtforska.TabIndex = 16;
            this.cmdImportFilUtforska.Text = "Utforska";
            this.cmdImportFilUtforska.UseVisualStyleBackColor = true;
            this.cmdImportFilUtforska.Click += new System.EventHandler(this.cmdImportFilUtforska_Click);
            // 
            // cmdTestImport
            // 
            this.cmdTestImport.Location = new System.Drawing.Point(32, 76);
            this.cmdTestImport.Name = "cmdTestImport";
            this.cmdTestImport.Size = new System.Drawing.Size(118, 23);
            this.cmdTestImport.TabIndex = 24;
            this.cmdTestImport.Text = "Test import";
            this.cmdTestImport.UseVisualStyleBackColor = true;
            this.cmdTestImport.Click += new System.EventHandler(this.cmdTestImport_Click);
            // 
            // txtImportFil
            // 
            this.txtImportFil.Location = new System.Drawing.Point(32, 41);
            this.txtImportFil.Name = "txtImportFil";
            this.txtImportFil.ReadOnly = true;
            this.txtImportFil.Size = new System.Drawing.Size(490, 20);
            this.txtImportFil.TabIndex = 25;
            // 
            // laImportFil
            // 
            this.laImportFil.AutoSize = true;
            this.laImportFil.Location = new System.Drawing.Point(29, 25);
            this.laImportFil.Name = "laImportFil";
            this.laImportFil.Size = new System.Drawing.Size(46, 13);
            this.laImportFil.TabIndex = 26;
            this.laImportFil.Text = "Import fil";
            // 
            // lbPersoner
            // 
            this.lbPersoner.FormattingEnabled = true;
            this.lbPersoner.Location = new System.Drawing.Point(32, 105);
            this.lbPersoner.Name = "lbPersoner";
            this.lbPersoner.Size = new System.Drawing.Size(394, 251);
            this.lbPersoner.TabIndex = 27;
            // 
            // cbTillhorighet
            // 
            this.cbTillhorighet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTillhorighet.FormattingEnabled = true;
            this.cbTillhorighet.Location = new System.Drawing.Point(224, 78);
            this.cbTillhorighet.Name = "cbTillhorighet";
            this.cbTillhorighet.Size = new System.Drawing.Size(202, 21);
            this.cbTillhorighet.TabIndex = 29;
            this.cbTillhorighet.TabStop = false;
            // 
            // laTillhorighet
            // 
            this.laTillhorighet.AutoSize = true;
            this.laTillhorighet.Location = new System.Drawing.Point(221, 62);
            this.laTillhorighet.Name = "laTillhorighet";
            this.laTillhorighet.Size = new System.Drawing.Size(61, 13);
            this.laTillhorighet.TabIndex = 28;
            this.laTillhorighet.Text = "Tillhörighet:";
            // 
            // ImportDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 411);
            this.Controls.Add(this.cbTillhorighet);
            this.Controls.Add(this.laTillhorighet);
            this.Controls.Add(this.lbPersoner);
            this.Controls.Add(this.laImportFil);
            this.Controls.Add(this.txtImportFil);
            this.Controls.Add(this.cmdTestImport);
            this.Controls.Add(this.cmdImportFilUtforska);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ImportDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ImportDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdImportFilUtforska;
        private System.Windows.Forms.Button cmdTestImport;
        private System.Windows.Forms.TextBox txtImportFil;
        private System.Windows.Forms.Label laImportFil;
        private System.Windows.Forms.ListBox lbPersoner;
        private System.Windows.Forms.ComboBox cbTillhorighet;
        private System.Windows.Forms.Label laTillhorighet;
    }
}