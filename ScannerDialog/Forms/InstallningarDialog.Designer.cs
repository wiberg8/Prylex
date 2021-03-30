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
            this.cbBackupOnStart = new System.Windows.Forms.CheckBox();
            this.cmdNuvarandeDbBackupAterstall = new System.Windows.Forms.Button();
            this.cmdNuvarandeDbUtforska = new System.Windows.Forms.Button();
            this.cmdDatabasAterstall = new System.Windows.Forms.Button();
            this.cmdNuvarandeDbBackupUtforska = new System.Windows.Forms.Button();
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
            this.cmdImportForval = new System.Windows.Forms.Button();
            this.cbPrinter = new System.Windows.Forms.ComboBox();
            this.laPrinter = new System.Windows.Forms.Label();
            this.gbForval = new System.Windows.Forms.GroupBox();
            this.gbUtskrift = new System.Windows.Forms.GroupBox();
            this.cmdExporteraPersoner = new System.Windows.Forms.Button();
            this.cmdExporteraArtiklar = new System.Windows.Forms.Button();
            this.gbInstallningarDb.SuspendLayout();
            this.gbForval.SuspendLayout();
            this.gbUtskrift.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInstallningarDb
            // 
            this.gbInstallningarDb.Controls.Add(this.cbBackupOnStart);
            this.gbInstallningarDb.Controls.Add(this.cmdNuvarandeDbBackupAterstall);
            this.gbInstallningarDb.Controls.Add(this.cmdNuvarandeDbUtforska);
            this.gbInstallningarDb.Controls.Add(this.cmdDatabasAterstall);
            this.gbInstallningarDb.Controls.Add(this.cmdNuvarandeDbBackupUtforska);
            this.gbInstallningarDb.Location = new System.Drawing.Point(12, 21);
            this.gbInstallningarDb.Name = "gbInstallningarDb";
            this.gbInstallningarDb.Size = new System.Drawing.Size(615, 124);
            this.gbInstallningarDb.TabIndex = 16;
            this.gbInstallningarDb.TabStop = false;
            this.gbInstallningarDb.Text = "DB";
            // 
            // cbBackupOnStart
            // 
            this.cbBackupOnStart.AutoSize = true;
            this.cbBackupOnStart.Location = new System.Drawing.Point(10, 91);
            this.cbBackupOnStart.Name = "cbBackupOnStart";
            this.cbBackupOnStart.Size = new System.Drawing.Size(113, 17);
            this.cbBackupOnStart.TabIndex = 0;
            this.cbBackupOnStart.Text = "Backup på upstart";
            this.cbBackupOnStart.UseVisualStyleBackColor = true;
            this.cbBackupOnStart.CheckedChanged += new System.EventHandler(this.cbBackupOnStart_CheckedChanged);
            // 
            // cmdNuvarandeDbBackupAterstall
            // 
            this.cmdNuvarandeDbBackupAterstall.Location = new System.Drawing.Point(514, 56);
            this.cmdNuvarandeDbBackupAterstall.Name = "cmdNuvarandeDbBackupAterstall";
            this.cmdNuvarandeDbBackupAterstall.Size = new System.Drawing.Size(75, 23);
            this.cmdNuvarandeDbBackupAterstall.TabIndex = 19;
            this.cmdNuvarandeDbBackupAterstall.Text = "Återställ";
            this.cmdNuvarandeDbBackupAterstall.UseVisualStyleBackColor = true;
            this.cmdNuvarandeDbBackupAterstall.Click += new System.EventHandler(this.cmdNuvarandeDbBackupAterstall_Click);
            // 
            // cmdNuvarandeDbUtforska
            // 
            this.cmdNuvarandeDbUtforska.Location = new System.Drawing.Point(433, 27);
            this.cmdNuvarandeDbUtforska.Name = "cmdNuvarandeDbUtforska";
            this.cmdNuvarandeDbUtforska.Size = new System.Drawing.Size(75, 23);
            this.cmdNuvarandeDbUtforska.TabIndex = 16;
            this.cmdNuvarandeDbUtforska.Text = "Utforska";
            this.cmdNuvarandeDbUtforska.UseVisualStyleBackColor = true;
            this.cmdNuvarandeDbUtforska.Click += new System.EventHandler(this.cmdNuvarandeDbUtforska_Click);
            // 
            // cmdDatabasAterstall
            // 
            this.cmdDatabasAterstall.Location = new System.Drawing.Point(514, 27);
            this.cmdDatabasAterstall.Name = "cmdDatabasAterstall";
            this.cmdDatabasAterstall.Size = new System.Drawing.Size(75, 23);
            this.cmdDatabasAterstall.TabIndex = 18;
            this.cmdDatabasAterstall.Text = "Återställ";
            this.cmdDatabasAterstall.UseVisualStyleBackColor = true;
            this.cmdDatabasAterstall.Click += new System.EventHandler(this.cmdDatabasAterstall_Click);
            // 
            // cmdNuvarandeDbBackupUtforska
            // 
            this.cmdNuvarandeDbBackupUtforska.Location = new System.Drawing.Point(433, 56);
            this.cmdNuvarandeDbBackupUtforska.Name = "cmdNuvarandeDbBackupUtforska";
            this.cmdNuvarandeDbBackupUtforska.Size = new System.Drawing.Size(75, 23);
            this.cmdNuvarandeDbBackupUtforska.TabIndex = 17;
            this.cmdNuvarandeDbBackupUtforska.Text = "Utforska";
            this.cmdNuvarandeDbBackupUtforska.UseVisualStyleBackColor = true;
            this.cmdNuvarandeDbBackupUtforska.Click += new System.EventHandler(this.cmdNuvarandeDbBackupUtforska_Click);
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
            this.lbForval.Location = new System.Drawing.Point(33, 53);
            this.lbForval.Name = "lbForval";
            this.lbForval.Size = new System.Drawing.Size(214, 186);
            this.lbForval.TabIndex = 0;
            this.lbForval.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbForval_KeyDown);
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
            this.cbForvalValj.Location = new System.Drawing.Point(32, 26);
            this.cbForvalValj.Name = "cbForvalValj";
            this.cbForvalValj.Size = new System.Drawing.Size(214, 21);
            this.cbForvalValj.TabIndex = 17;
            this.cbForvalValj.SelectedIndexChanged += new System.EventHandler(this.cbForvalValj_SelectedIndexChanged);
            // 
            // cmdForvalUpp
            // 
            this.cmdForvalUpp.Location = new System.Drawing.Point(252, 53);
            this.cmdForvalUpp.Name = "cmdForvalUpp";
            this.cmdForvalUpp.Size = new System.Drawing.Size(85, 23);
            this.cmdForvalUpp.TabIndex = 18;
            this.cmdForvalUpp.Text = "Upp";
            this.cmdForvalUpp.UseVisualStyleBackColor = true;
            this.cmdForvalUpp.Click += new System.EventHandler(this.cmdForvalUpp_Click);
            // 
            // cmdForvalNer
            // 
            this.cmdForvalNer.Location = new System.Drawing.Point(252, 83);
            this.cmdForvalNer.Name = "cmdForvalNer";
            this.cmdForvalNer.Size = new System.Drawing.Size(85, 23);
            this.cmdForvalNer.TabIndex = 19;
            this.cmdForvalNer.Text = "Ner";
            this.cmdForvalNer.UseVisualStyleBackColor = true;
            this.cmdForvalNer.Click += new System.EventHandler(this.cmdForvalNer_Click);
            // 
            // cmdForvalLaggTill
            // 
            this.cmdForvalLaggTill.Location = new System.Drawing.Point(253, 187);
            this.cmdForvalLaggTill.Name = "cmdForvalLaggTill";
            this.cmdForvalLaggTill.Size = new System.Drawing.Size(85, 23);
            this.cmdForvalLaggTill.TabIndex = 20;
            this.cmdForvalLaggTill.Text = "Lägg till";
            this.cmdForvalLaggTill.UseVisualStyleBackColor = true;
            this.cmdForvalLaggTill.Click += new System.EventHandler(this.cmdForvalLaggTill_Click);
            // 
            // cmdForvalTabort
            // 
            this.cmdForvalTabort.Location = new System.Drawing.Point(252, 216);
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
            this.laNuvarandeDbDisplay.Size = new System.Drawing.Size(346, 13);
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
            this.laNuvarandeDbBackupDisplay.Size = new System.Drawing.Size(346, 13);
            this.laNuvarandeDbBackupDisplay.TabIndex = 23;
            this.laNuvarandeDbBackupDisplay.Text = "Display";
            this.laNuvarandeDbBackupDisplay.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.laNuvarandeDbBackupDisplay.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // cmdImportForval
            // 
            this.cmdImportForval.Location = new System.Drawing.Point(131, 245);
            this.cmdImportForval.Name = "cmdImportForval";
            this.cmdImportForval.Size = new System.Drawing.Size(116, 23);
            this.cmdImportForval.TabIndex = 24;
            this.cmdImportForval.Text = "Import från DB";
            this.cmdImportForval.UseVisualStyleBackColor = true;
            this.cmdImportForval.Click += new System.EventHandler(this.cmdImportForval_Click);
            // 
            // cbPrinter
            // 
            this.cbPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrinter.FormattingEnabled = true;
            this.cbPrinter.Location = new System.Drawing.Point(20, 46);
            this.cbPrinter.Name = "cbPrinter";
            this.cbPrinter.Size = new System.Drawing.Size(199, 21);
            this.cbPrinter.TabIndex = 28;
            this.cbPrinter.SelectedIndexChanged += new System.EventHandler(this.cbPrinter_SelectedIndexChanged);
            // 
            // laPrinter
            // 
            this.laPrinter.AutoSize = true;
            this.laPrinter.Location = new System.Drawing.Point(17, 30);
            this.laPrinter.Name = "laPrinter";
            this.laPrinter.Size = new System.Drawing.Size(64, 13);
            this.laPrinter.TabIndex = 29;
            this.laPrinter.Text = "Välj skrivare";
            // 
            // gbForval
            // 
            this.gbForval.Controls.Add(this.lbForval);
            this.gbForval.Controls.Add(this.cbForvalValj);
            this.gbForval.Controls.Add(this.cmdForvalUpp);
            this.gbForval.Controls.Add(this.cmdForvalNer);
            this.gbForval.Controls.Add(this.cmdImportForval);
            this.gbForval.Controls.Add(this.cmdForvalLaggTill);
            this.gbForval.Controls.Add(this.cmdForvalTabort);
            this.gbForval.Location = new System.Drawing.Point(12, 158);
            this.gbForval.Name = "gbForval";
            this.gbForval.Size = new System.Drawing.Size(353, 283);
            this.gbForval.TabIndex = 30;
            this.gbForval.TabStop = false;
            this.gbForval.Text = "Förval";
            // 
            // gbUtskrift
            // 
            this.gbUtskrift.Controls.Add(this.cbPrinter);
            this.gbUtskrift.Controls.Add(this.laPrinter);
            this.gbUtskrift.Location = new System.Drawing.Point(382, 158);
            this.gbUtskrift.Name = "gbUtskrift";
            this.gbUtskrift.Size = new System.Drawing.Size(245, 90);
            this.gbUtskrift.TabIndex = 28;
            this.gbUtskrift.TabStop = false;
            this.gbUtskrift.Text = "Utskrift";
            // 
            // cmdExporteraPersoner
            // 
            this.cmdExporteraPersoner.Location = new System.Drawing.Point(477, 386);
            this.cmdExporteraPersoner.Name = "cmdExporteraPersoner";
            this.cmdExporteraPersoner.Size = new System.Drawing.Size(163, 23);
            this.cmdExporteraPersoner.TabIndex = 31;
            this.cmdExporteraPersoner.Text = "Exportera personer";
            this.cmdExporteraPersoner.UseVisualStyleBackColor = true;
            this.cmdExporteraPersoner.Click += new System.EventHandler(this.cmdExporteraPersoner_Click);
            // 
            // cmdExporteraArtiklar
            // 
            this.cmdExporteraArtiklar.Location = new System.Drawing.Point(477, 415);
            this.cmdExporteraArtiklar.Name = "cmdExporteraArtiklar";
            this.cmdExporteraArtiklar.Size = new System.Drawing.Size(163, 23);
            this.cmdExporteraArtiklar.TabIndex = 32;
            this.cmdExporteraArtiklar.Text = "Exportera artiklar";
            this.cmdExporteraArtiklar.UseVisualStyleBackColor = true;
            this.cmdExporteraArtiklar.Click += new System.EventHandler(this.cmdExporteraArtiklar_Click);
            // 
            // InstallningarDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 450);
            this.Controls.Add(this.cmdExporteraArtiklar);
            this.Controls.Add(this.cmdExporteraPersoner);
            this.Controls.Add(this.gbUtskrift);
            this.Controls.Add(this.gbForval);
            this.Controls.Add(this.laNuvarandeDbBackupDisplay);
            this.Controls.Add(this.laNuvarandeDbDisplay);
            this.Controls.Add(this.laNuvarandeDbBackup);
            this.Controls.Add(this.laNuvarandeDb);
            this.Controls.Add(this.gbInstallningarDb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "InstallningarDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.InstallningarDialog_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InstallningarDialog_KeyDown);
            this.gbInstallningarDb.ResumeLayout(false);
            this.gbInstallningarDb.PerformLayout();
            this.gbForval.ResumeLayout(false);
            this.gbUtskrift.ResumeLayout(false);
            this.gbUtskrift.PerformLayout();
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
        private System.Windows.Forms.Button cmdImportForval;
        private System.Windows.Forms.CheckBox cbBackupOnStart;
        private System.Windows.Forms.ComboBox cbPrinter;
        private System.Windows.Forms.Label laPrinter;
        private System.Windows.Forms.GroupBox gbForval;
        private System.Windows.Forms.GroupBox gbUtskrift;
        private System.Windows.Forms.Button cmdExporteraPersoner;
        private System.Windows.Forms.Button cmdExporteraArtiklar;
    }
}