
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
            this.cbTillhorighet = new System.Windows.Forms.ComboBox();
            this.laTillhorighet = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.laCurrentImportPerson = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtImportFil
            // 
            this.txtImportFil.Location = new System.Drawing.Point(28, 51);
            this.txtImportFil.Name = "txtImportFil";
            this.txtImportFil.ReadOnly = true;
            this.txtImportFil.Size = new System.Drawing.Size(398, 20);
            this.txtImportFil.TabIndex = 0;
            this.txtImportFil.TabStop = false;
            this.txtImportFil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdImportFilUtforska
            // 
            this.cmdImportFilUtforska.Location = new System.Drawing.Point(432, 49);
            this.cmdImportFilUtforska.Name = "cmdImportFilUtforska";
            this.cmdImportFilUtforska.Size = new System.Drawing.Size(95, 23);
            this.cmdImportFilUtforska.TabIndex = 1;
            this.cmdImportFilUtforska.Text = "Utforska";
            this.cmdImportFilUtforska.UseVisualStyleBackColor = true;
            this.cmdImportFilUtforska.Click += new System.EventHandler(this.cmdImportFilUtforska_Click);
            // 
            // laImportFil
            // 
            this.laImportFil.AutoSize = true;
            this.laImportFil.Location = new System.Drawing.Point(25, 32);
            this.laImportFil.Name = "laImportFil";
            this.laImportFil.Size = new System.Drawing.Size(262, 13);
            this.laImportFil.TabIndex = 2;
            this.laImportFil.Text = "Import fil: PersNr; Efternamn; Förnamn (UTF-8 / ASCII)";
            // 
            // lbPersoner
            // 
            this.lbPersoner.FormattingEnabled = true;
            this.lbPersoner.Location = new System.Drawing.Point(31, 122);
            this.lbPersoner.Name = "lbPersoner";
            this.lbPersoner.Size = new System.Drawing.Size(493, 277);
            this.lbPersoner.TabIndex = 3;
            // 
            // cmdLasFranFil
            // 
            this.cmdLasFranFil.Location = new System.Drawing.Point(31, 93);
            this.cmdLasFranFil.Name = "cmdLasFranFil";
            this.cmdLasFranFil.Size = new System.Drawing.Size(139, 23);
            this.cmdLasFranFil.TabIndex = 4;
            this.cmdLasFranFil.Text = "Läs från fil";
            this.cmdLasFranFil.UseVisualStyleBackColor = true;
            this.cmdLasFranFil.Click += new System.EventHandler(this.cmdLasFranFil_Click);
            // 
            // cmdVerkstallImport
            // 
            this.cmdVerkstallImport.Location = new System.Drawing.Point(385, 93);
            this.cmdVerkstallImport.Name = "cmdVerkstallImport";
            this.cmdVerkstallImport.Size = new System.Drawing.Size(139, 23);
            this.cmdVerkstallImport.TabIndex = 5;
            this.cmdVerkstallImport.Text = "Verkställ import";
            this.cmdVerkstallImport.UseVisualStyleBackColor = true;
            this.cmdVerkstallImport.Visible = false;
            this.cmdVerkstallImport.Click += new System.EventHandler(this.cmdVerkstallImport_Click);
            // 
            // cbTillhorighet
            // 
            this.cbTillhorighet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTillhorighet.FormattingEnabled = true;
            this.cbTillhorighet.Location = new System.Drawing.Point(177, 94);
            this.cbTillhorighet.Name = "cbTillhorighet";
            this.cbTillhorighet.Size = new System.Drawing.Size(202, 21);
            this.cbTillhorighet.TabIndex = 11;
            this.cbTillhorighet.TabStop = false;
            this.cbTillhorighet.Visible = false;
            // 
            // laTillhorighet
            // 
            this.laTillhorighet.AutoSize = true;
            this.laTillhorighet.Location = new System.Drawing.Point(174, 78);
            this.laTillhorighet.Name = "laTillhorighet";
            this.laTillhorighet.Size = new System.Drawing.Size(61, 13);
            this.laTillhorighet.TabIndex = 10;
            this.laTillhorighet.Text = "Tillhörighet:";
            this.laTillhorighet.Visible = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(31, 421);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(493, 23);
            this.progressBar.TabIndex = 12;
            this.progressBar.Visible = false;
            // 
            // laCurrentImportPerson
            // 
            this.laCurrentImportPerson.AutoSize = true;
            this.laCurrentImportPerson.Location = new System.Drawing.Point(29, 404);
            this.laCurrentImportPerson.Name = "laCurrentImportPerson";
            this.laCurrentImportPerson.Size = new System.Drawing.Size(41, 13);
            this.laCurrentImportPerson.TabIndex = 13;
            this.laCurrentImportPerson.Text = "Display";
            this.laCurrentImportPerson.Visible = false;
            // 
            // ImportDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 449);
            this.Controls.Add(this.laCurrentImportPerson);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.cbTillhorighet);
            this.Controls.Add(this.laTillhorighet);
            this.Controls.Add(this.cmdVerkstallImport);
            this.Controls.Add(this.cmdLasFranFil);
            this.Controls.Add(this.lbPersoner);
            this.Controls.Add(this.laImportFil);
            this.Controls.Add(this.cmdImportFilUtforska);
            this.Controls.Add(this.txtImportFil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ImportDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ImportDialog_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ImportDialog_KeyDown);
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
        private System.Windows.Forms.ComboBox cbTillhorighet;
        private System.Windows.Forms.Label laTillhorighet;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label laCurrentImportPerson;
    }
}