namespace ScannerDialog
{
    partial class InstallningarDialog
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
            this.gbInstallningarDb = new System.Windows.Forms.GroupBox();
            this.cmdNuvarandeDbBackupAterstall = new System.Windows.Forms.Button();
            this.cmdDatabasAterstall = new System.Windows.Forms.Button();
            this.cmdNuvarandeDbBackupUtforska = new System.Windows.Forms.Button();
            this.cmdNuvarandeDbUtforska = new System.Windows.Forms.Button();
            this.laNuvarandeDbBackup = new System.Windows.Forms.Label();
            this.laNuvarandeDb = new System.Windows.Forms.Label();
            this.lbForval = new System.Windows.Forms.ListBox();
            this.cbForvalValj = new System.Windows.Forms.ComboBox();
            this.cmdForvalUpp = new System.Windows.Forms.Button();
            this.cmdForvalNer = new System.Windows.Forms.Button();
            this.cmdForvalLaggTill = new System.Windows.Forms.Button();
            this.cmdForvalTabort = new System.Windows.Forms.Button();
            this.laNuvarandeDbDisplay = new System.Windows.Forms.Label();
            this.laNuvarandeDbBackupDisplay = new System.Windows.Forms.Label();
            this.cmdForvalImport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gbInstallningarDb
            // 
            this.gbInstallningarDb.Location = new System.Drawing.Point(12, 21);
            this.gbInstallningarDb.Name = "gbInstallningarDb";
            this.gbInstallningarDb.Size = new System.Drawing.Size(465, 109);
            this.gbInstallningarDb.TabIndex = 16;
            this.gbInstallningarDb.TabStop = false;
            this.gbInstallningarDb.Text = "DB";
            // 
            // cmdNuvarandeDbBackupAterstall
            // 
            this.cmdNuvarandeDbBackupAterstall.Location = new System.Drawing.Point(393, 82);
            this.cmdNuvarandeDbBackupAterstall.Name = "cmdNuvarandeDbBackupAterstall";
            this.cmdNuvarandeDbBackupAterstall.Size = new System.Drawing.Size(75, 23);
            this.cmdNuvarandeDbBackupAterstall.TabIndex = 19;
            this.cmdNuvarandeDbBackupAterstall.Text = "Återställ";
            this.cmdNuvarandeDbBackupAterstall.UseVisualStyleBackColor = true;
            this.cmdNuvarandeDbBackupAterstall.Click += new System.EventHandler(this.cmdNuvarandeDbBackupAterstall_Click);
            // 
            // cmdDatabasAterstall
            // 
            this.cmdDatabasAterstall.Location = new System.Drawing.Point(393, 53);
            this.cmdDatabasAterstall.Name = "cmdDatabasAterstall";
            this.cmdDatabasAterstall.Size = new System.Drawing.Size(75, 23);
            this.cmdDatabasAterstall.TabIndex = 18;
            this.cmdDatabasAterstall.Text = "Återställ";
            this.cmdDatabasAterstall.UseVisualStyleBackColor = true;
            this.cmdDatabasAterstall.Click += new System.EventHandler(this.cmdDatabasAterstall_Click);
            // 
            // cmdNuvarandeDbBackupUtforska
            // 
            this.cmdNuvarandeDbBackupUtforska.Location = new System.Drawing.Point(312, 82);
            this.cmdNuvarandeDbBackupUtforska.Name = "cmdNuvarandeDbBackupUtforska";
            this.cmdNuvarandeDbBackupUtforska.Size = new System.Drawing.Size(75, 23);
            this.cmdNuvarandeDbBackupUtforska.TabIndex = 17;
            this.cmdNuvarandeDbBackupUtforska.Text = "Utforska";
            this.cmdNuvarandeDbBackupUtforska.UseVisualStyleBackColor = true;
            this.cmdNuvarandeDbBackupUtforska.Click += new System.EventHandler(this.cmdNuvarandeDbBackupUtforska_Click);
            // 
            // cmdNuvarandeDbUtforska
            // 
            this.cmdNuvarandeDbUtforska.Location = new System.Drawing.Point(312, 53);
            this.cmdNuvarandeDbUtforska.Name = "cmdNuvarandeDbUtforska";
            this.cmdNuvarandeDbUtforska.Size = new System.Drawing.Size(75, 23);
            this.cmdNuvarandeDbUtforska.TabIndex = 16;
            this.cmdNuvarandeDbUtforska.Text = "Utforska";
            this.cmdNuvarandeDbUtforska.UseVisualStyleBackColor = true;
            this.cmdNuvarandeDbUtforska.Click += new System.EventHandler(this.cmdNuvarandeDbUtforska_Click);
            // 
            // laNuvarandeDbBackup
            // 
            this.laNuvarandeDbBackup.AutoSize = true;
            this.laNuvarandeDbBackup.Location = new System.Drawing.Point(19, 82);
            this.laNuvarandeDbBackup.Name = "laNuvarandeDbBackup";
            this.laNuvarandeDbBackup.Size = new System.Drawing.Size(47, 13);
            this.laNuvarandeDbBackup.TabIndex = 15;
            this.laNuvarandeDbBackup.Text = "Backup:";
            // 
            // laNuvarandeDb
            // 
            this.laNuvarandeDb.AutoSize = true;
            this.laNuvarandeDb.Location = new System.Drawing.Point(19, 58);
            this.laNuvarandeDb.Name = "laNuvarandeDb";
            this.laNuvarandeDb.Size = new System.Drawing.Size(63, 13);
            this.laNuvarandeDb.TabIndex = 13;
            this.laNuvarandeDb.Text = "Nuvarande:";
            // 
            // lbForval
            // 
            this.lbForval.FormattingEnabled = true;
            this.lbForval.Location = new System.Drawing.Point(508, 64);
            this.lbForval.Name = "lbForval";
            this.lbForval.Size = new System.Drawing.Size(214, 186);
            this.lbForval.TabIndex = 0;
            // 
            // cbForvalValj
            // 
            this.cbForvalValj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbForvalValj.FormattingEnabled = true;
            this.cbForvalValj.Items.AddRange(new object[] {
            "Beskrivningar",
            "Händelser",
            "Os",
            "Tillhörighet"});
            this.cbForvalValj.Location = new System.Drawing.Point(507, 37);
            this.cbForvalValj.Name = "cbForvalValj";
            this.cbForvalValj.Size = new System.Drawing.Size(214, 21);
            this.cbForvalValj.TabIndex = 17;
            this.cbForvalValj.SelectedIndexChanged += new System.EventHandler(this.cbForvalValj_SelectedIndexChanged);
            // 
            // cmdForvalUpp
            // 
            this.cmdForvalUpp.Location = new System.Drawing.Point(636, 259);
            this.cmdForvalUpp.Name = "cmdForvalUpp";
            this.cmdForvalUpp.Size = new System.Drawing.Size(85, 23);
            this.cmdForvalUpp.TabIndex = 18;
            this.cmdForvalUpp.Text = "Upp";
            this.cmdForvalUpp.UseVisualStyleBackColor = true;
            this.cmdForvalUpp.Click += new System.EventHandler(this.cmdForvalUpp_Click);
            // 
            // cmdForvalNer
            // 
            this.cmdForvalNer.Location = new System.Drawing.Point(636, 288);
            this.cmdForvalNer.Name = "cmdForvalNer";
            this.cmdForvalNer.Size = new System.Drawing.Size(85, 23);
            this.cmdForvalNer.TabIndex = 19;
            this.cmdForvalNer.Text = "Ner";
            this.cmdForvalNer.UseVisualStyleBackColor = true;
            this.cmdForvalNer.Click += new System.EventHandler(this.cmdForvalNer_Click);
            // 
            // cmdForvalLaggTill
            // 
            this.cmdForvalLaggTill.Location = new System.Drawing.Point(507, 259);
            this.cmdForvalLaggTill.Name = "cmdForvalLaggTill";
            this.cmdForvalLaggTill.Size = new System.Drawing.Size(85, 23);
            this.cmdForvalLaggTill.TabIndex = 20;
            this.cmdForvalLaggTill.Text = "Lägg till";
            this.cmdForvalLaggTill.UseVisualStyleBackColor = true;
            this.cmdForvalLaggTill.Click += new System.EventHandler(this.cmdForvalLaggTill_Click);
            // 
            // cmdForvalTabort
            // 
            this.cmdForvalTabort.Location = new System.Drawing.Point(508, 288);
            this.cmdForvalTabort.Name = "cmdForvalTabort";
            this.cmdForvalTabort.Size = new System.Drawing.Size(85, 23);
            this.cmdForvalTabort.TabIndex = 21;
            this.cmdForvalTabort.Text = "Ta bort";
            this.cmdForvalTabort.UseVisualStyleBackColor = true;
            this.cmdForvalTabort.Click += new System.EventHandler(this.cmdForvalTabort_Click);
            // 
            // laNuvarandeDbDisplay
            // 
            this.laNuvarandeDbDisplay.Location = new System.Drawing.Point(93, 58);
            this.laNuvarandeDbDisplay.Name = "laNuvarandeDbDisplay";
            this.laNuvarandeDbDisplay.Size = new System.Drawing.Size(213, 13);
            this.laNuvarandeDbDisplay.TabIndex = 22;
            this.laNuvarandeDbDisplay.Text = "Display";
            this.laNuvarandeDbDisplay.DoubleClick += new System.EventHandler(this.laNuvarandeDbDisplay_DoubleClick);
            this.laNuvarandeDbDisplay.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.laNuvarandeDbDisplay.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // laNuvarandeDbBackupDisplay
            // 
            this.laNuvarandeDbBackupDisplay.Location = new System.Drawing.Point(93, 82);
            this.laNuvarandeDbBackupDisplay.Name = "laNuvarandeDbBackupDisplay";
            this.laNuvarandeDbBackupDisplay.Size = new System.Drawing.Size(213, 13);
            this.laNuvarandeDbBackupDisplay.TabIndex = 23;
            this.laNuvarandeDbBackupDisplay.Text = "Display";
            this.laNuvarandeDbBackupDisplay.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.laNuvarandeDbBackupDisplay.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // cmdForvalImport
            // 
            this.cmdForvalImport.Location = new System.Drawing.Point(507, 8);
            this.cmdForvalImport.Name = "cmdForvalImport";
            this.cmdForvalImport.Size = new System.Drawing.Size(214, 23);
            this.cmdForvalImport.TabIndex = 24;
            this.cmdForvalImport.Text = "Importera från DB";
            this.cmdForvalImport.UseVisualStyleBackColor = true;
            this.cmdForvalImport.Click += new System.EventHandler(this.cmdForvalImport_Click);
            // 
            // InstallningarDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 353);
            this.Controls.Add(this.cmdForvalImport);
            this.Controls.Add(this.cmdNuvarandeDbBackupAterstall);
            this.Controls.Add(this.cmdDatabasAterstall);
            this.Controls.Add(this.laNuvarandeDbBackupDisplay);
            this.Controls.Add(this.laNuvarandeDbDisplay);
            this.Controls.Add(this.cmdNuvarandeDbBackupUtforska);
            this.Controls.Add(this.cmdForvalTabort);
            this.Controls.Add(this.cmdNuvarandeDbUtforska);
            this.Controls.Add(this.cmdForvalLaggTill);
            this.Controls.Add(this.laNuvarandeDbBackup);
            this.Controls.Add(this.cmdForvalNer);
            this.Controls.Add(this.cmdForvalUpp);
            this.Controls.Add(this.cbForvalValj);
            this.Controls.Add(this.laNuvarandeDb);
            this.Controls.Add(this.lbForval);
            this.Controls.Add(this.gbInstallningarDb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "InstallningarDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.InstallningarDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInstallningarDb;
        private System.Windows.Forms.Label laNuvarandeDbBackup;
        private System.Windows.Forms.Label laNuvarandeDb;
        private System.Windows.Forms.Button cmdNuvarandeDbBackupUtforska;
        private System.Windows.Forms.Button cmdNuvarandeDbUtforska;
        private System.Windows.Forms.ListBox lbForval;
        private System.Windows.Forms.ComboBox cbForvalValj;
        private System.Windows.Forms.Button cmdForvalUpp;
        private System.Windows.Forms.Button cmdForvalNer;
        private System.Windows.Forms.Button cmdForvalLaggTill;
        private System.Windows.Forms.Button cmdForvalTabort;
        private System.Windows.Forms.Button cmdNuvarandeDbBackupAterstall;
        private System.Windows.Forms.Button cmdDatabasAterstall;
        private System.Windows.Forms.Label laNuvarandeDbDisplay;
        private System.Windows.Forms.Label laNuvarandeDbBackupDisplay;
        private System.Windows.Forms.Button cmdForvalImport;
    }
}