
namespace ScannerDialog.Forms
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
            this.txtImportFil = new System.Windows.Forms.TextBox();
            this.cmdImportFilUtforska = new System.Windows.Forms.Button();
            this.laImportFil = new System.Windows.Forms.Label();
            this.lbPersoner = new System.Windows.Forms.ListBox();
            this.cmdLasFranFil = new System.Windows.Forms.Button();
            this.cmdVerkstallImport = new System.Windows.Forms.Button();
            this.lbPersonerErrosSuccess = new System.Windows.Forms.ListBox();
            this.cbTillhorighet = new System.Windows.Forms.ComboBox();
            this.laTillhorighet = new System.Windows.Forms.Label();
            this.laPersoner = new System.Windows.Forms.Label();
            this.rbLyckade = new System.Windows.Forms.RadioButton();
            this.rbMisslyckade = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtImportFil
            // 
            this.txtImportFil.Location = new System.Drawing.Point(29, 34);
            this.txtImportFil.Name = "txtImportFil";
            this.txtImportFil.ReadOnly = true;
            this.txtImportFil.Size = new System.Drawing.Size(565, 20);
            this.txtImportFil.TabIndex = 0;
            this.txtImportFil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdImportFilUtforska
            // 
            this.cmdImportFilUtforska.Location = new System.Drawing.Point(600, 32);
            this.cmdImportFilUtforska.Name = "cmdImportFilUtforska";
            this.cmdImportFilUtforska.Size = new System.Drawing.Size(75, 23);
            this.cmdImportFilUtforska.TabIndex = 1;
            this.cmdImportFilUtforska.Text = "Utforska";
            this.cmdImportFilUtforska.UseVisualStyleBackColor = true;
            this.cmdImportFilUtforska.Click += new System.EventHandler(this.cmdImportFilUtforska_Click);
            // 
            // laImportFil
            // 
            this.laImportFil.AutoSize = true;
            this.laImportFil.Location = new System.Drawing.Point(29, 15);
            this.laImportFil.Name = "laImportFil";
            this.laImportFil.Size = new System.Drawing.Size(46, 13);
            this.laImportFil.TabIndex = 2;
            this.laImportFil.Text = "Import fil";
            // 
            // lbPersoner
            // 
            this.lbPersoner.FormattingEnabled = true;
            this.lbPersoner.Location = new System.Drawing.Point(29, 132);
            this.lbPersoner.Name = "lbPersoner";
            this.lbPersoner.Size = new System.Drawing.Size(406, 277);
            this.lbPersoner.TabIndex = 3;
            this.lbPersoner.SelectedIndexChanged += new System.EventHandler(this.lbPersoner_SelectedIndexChanged);
            // 
            // cmdLasFranFil
            // 
            this.cmdLasFranFil.Location = new System.Drawing.Point(29, 77);
            this.cmdLasFranFil.Name = "cmdLasFranFil";
            this.cmdLasFranFil.Size = new System.Drawing.Size(139, 23);
            this.cmdLasFranFil.TabIndex = 4;
            this.cmdLasFranFil.Text = "Läs från fil";
            this.cmdLasFranFil.UseVisualStyleBackColor = true;
            this.cmdLasFranFil.Click += new System.EventHandler(this.cmdLasFranFil_Click);
            // 
            // cmdVerkstallImport
            // 
            this.cmdVerkstallImport.Location = new System.Drawing.Point(382, 77);
            this.cmdVerkstallImport.Name = "cmdVerkstallImport";
            this.cmdVerkstallImport.Size = new System.Drawing.Size(139, 23);
            this.cmdVerkstallImport.TabIndex = 5;
            this.cmdVerkstallImport.Text = "Verkställ import";
            this.cmdVerkstallImport.UseVisualStyleBackColor = true;
            this.cmdVerkstallImport.Click += new System.EventHandler(this.cmdVerkstallImport_Click);
            // 
            // lbPersonerErrosSuccess
            // 
            this.lbPersonerErrosSuccess.FormattingEnabled = true;
            this.lbPersonerErrosSuccess.Location = new System.Drawing.Point(441, 132);
            this.lbPersonerErrosSuccess.Name = "lbPersonerErrosSuccess";
            this.lbPersonerErrosSuccess.Size = new System.Drawing.Size(406, 277);
            this.lbPersonerErrosSuccess.TabIndex = 7;
            // 
            // cbTillhorighet
            // 
            this.cbTillhorighet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTillhorighet.FormattingEnabled = true;
            this.cbTillhorighet.Location = new System.Drawing.Point(174, 78);
            this.cbTillhorighet.Name = "cbTillhorighet";
            this.cbTillhorighet.Size = new System.Drawing.Size(202, 21);
            this.cbTillhorighet.TabIndex = 11;
            this.cbTillhorighet.TabStop = false;
            this.cbTillhorighet.SelectedIndexChanged += new System.EventHandler(this.cbTillhorighet_SelectedIndexChanged);
            // 
            // laTillhorighet
            // 
            this.laTillhorighet.AutoSize = true;
            this.laTillhorighet.Location = new System.Drawing.Point(171, 62);
            this.laTillhorighet.Name = "laTillhorighet";
            this.laTillhorighet.Size = new System.Drawing.Size(61, 13);
            this.laTillhorighet.TabIndex = 10;
            this.laTillhorighet.Text = "Tillhörighet:";
            this.laTillhorighet.Click += new System.EventHandler(this.laTillhorighet_Click);
            // 
            // laPersoner
            // 
            this.laPersoner.AutoSize = true;
            this.laPersoner.Location = new System.Drawing.Point(26, 116);
            this.laPersoner.Name = "laPersoner";
            this.laPersoner.Size = new System.Drawing.Size(82, 13);
            this.laPersoner.TabIndex = 12;
            this.laPersoner.Text = "Inlästa personer";
            // 
            // rbLyckade
            // 
            this.rbLyckade.AutoSize = true;
            this.rbLyckade.Checked = true;
            this.rbLyckade.Location = new System.Drawing.Point(441, 112);
            this.rbLyckade.Name = "rbLyckade";
            this.rbLyckade.Size = new System.Drawing.Size(85, 17);
            this.rbLyckade.TabIndex = 13;
            this.rbLyckade.TabStop = true;
            this.rbLyckade.Text = "Visa lyckade";
            this.rbLyckade.UseVisualStyleBackColor = true;
            this.rbLyckade.CheckedChanged += new System.EventHandler(this.rbLyckade_CheckedChanged);
            // 
            // rbMisslyckade
            // 
            this.rbMisslyckade.AutoSize = true;
            this.rbMisslyckade.Location = new System.Drawing.Point(532, 112);
            this.rbMisslyckade.Name = "rbMisslyckade";
            this.rbMisslyckade.Size = new System.Drawing.Size(105, 17);
            this.rbMisslyckade.TabIndex = 14;
            this.rbMisslyckade.Text = "Visa misslyckade";
            this.rbMisslyckade.UseVisualStyleBackColor = true;
            this.rbMisslyckade.CheckedChanged += new System.EventHandler(this.rbMisslyckade_CheckedChanged);
            // 
            // ImportDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 441);
            this.Controls.Add(this.rbMisslyckade);
            this.Controls.Add(this.rbLyckade);
            this.Controls.Add(this.laPersoner);
            this.Controls.Add(this.cbTillhorighet);
            this.Controls.Add(this.laTillhorighet);
            this.Controls.Add(this.lbPersonerErrosSuccess);
            this.Controls.Add(this.cmdVerkstallImport);
            this.Controls.Add(this.cmdLasFranFil);
            this.Controls.Add(this.lbPersoner);
            this.Controls.Add(this.laImportFil);
            this.Controls.Add(this.cmdImportFilUtforska);
            this.Controls.Add(this.txtImportFil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ImportDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ImportDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImportFil;
        private System.Windows.Forms.Button cmdImportFilUtforska;
        private System.Windows.Forms.Label laImportFil;
        private System.Windows.Forms.ListBox lbPersoner;
        private System.Windows.Forms.Button cmdLasFranFil;
        private System.Windows.Forms.Button cmdVerkstallImport;
        private System.Windows.Forms.ListBox lbPersonerErrosSuccess;
        private System.Windows.Forms.ComboBox cbTillhorighet;
        private System.Windows.Forms.Label laTillhorighet;
        private System.Windows.Forms.Label laPersoner;
        private System.Windows.Forms.RadioButton rbLyckade;
        private System.Windows.Forms.RadioButton rbMisslyckade;
    }
}