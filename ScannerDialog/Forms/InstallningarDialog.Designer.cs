using System;

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
            this.components = new System.ComponentModel.Container();
            this.gbInstallningarDb = new System.Windows.Forms.GroupBox();
            this.cbBackupOnStart = new System.Windows.Forms.CheckBox();
            this.cmdNuvarandeDbBackupAterstall = new System.Windows.Forms.Button();
            this.cmdNuvarandeDbBackupUtforska = new System.Windows.Forms.Button();
            this.laNuvarandeDbBackup = new System.Windows.Forms.Label();
            this.laNuvarandeDbBackupDisplay = new System.Windows.Forms.Label();
            this.cbPrinter = new System.Windows.Forms.ComboBox();
            this.laPrinter = new System.Windows.Forms.Label();
            this.gbUtskrift = new System.Windows.Forms.GroupBox();
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.cmdSelectDb = new System.Windows.Forms.Button();
            this.txtBusinessName = new System.Windows.Forms.TextBox();
            this.laBusinessName = new System.Windows.Forms.Label();
            this.gbInstallningarDb.SuspendLayout();
            this.gbUtskrift.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInstallningarDb
            // 
            this.gbInstallningarDb.Controls.Add(this.cbBackupOnStart);
            this.gbInstallningarDb.Controls.Add(this.cmdNuvarandeDbBackupAterstall);
            this.gbInstallningarDb.Controls.Add(this.cmdNuvarandeDbBackupUtforska);
            this.gbInstallningarDb.Location = new System.Drawing.Point(16, 26);
            this.gbInstallningarDb.Margin = new System.Windows.Forms.Padding(4);
            this.gbInstallningarDb.Name = "gbInstallningarDb";
            this.gbInstallningarDb.Padding = new System.Windows.Forms.Padding(4);
            this.gbInstallningarDb.Size = new System.Drawing.Size(795, 96);
            this.gbInstallningarDb.TabIndex = 16;
            this.gbInstallningarDb.TabStop = false;
            this.gbInstallningarDb.Text = "DB";
            // 
            // cbBackupOnStart
            // 
            this.cbBackupOnStart.AutoSize = true;
            this.cbBackupOnStart.Location = new System.Drawing.Point(13, 62);
            this.cbBackupOnStart.Margin = new System.Windows.Forms.Padding(4);
            this.cbBackupOnStart.Name = "cbBackupOnStart";
            this.cbBackupOnStart.Size = new System.Drawing.Size(134, 20);
            this.cbBackupOnStart.TabIndex = 0;
            this.cbBackupOnStart.Text = "Backup på upstart";
            this.cbBackupOnStart.UseVisualStyleBackColor = true;
            this.cbBackupOnStart.CheckedChanged += new System.EventHandler(this.cbBackupOnStart_CheckedChanged);
            // 
            // cmdNuvarandeDbBackupAterstall
            // 
            this.cmdNuvarandeDbBackupAterstall.Location = new System.Drawing.Point(685, 25);
            this.cmdNuvarandeDbBackupAterstall.Margin = new System.Windows.Forms.Padding(4);
            this.cmdNuvarandeDbBackupAterstall.Name = "cmdNuvarandeDbBackupAterstall";
            this.cmdNuvarandeDbBackupAterstall.Size = new System.Drawing.Size(100, 28);
            this.cmdNuvarandeDbBackupAterstall.TabIndex = 19;
            this.cmdNuvarandeDbBackupAterstall.Text = "Återställ";
            this.cmdNuvarandeDbBackupAterstall.UseVisualStyleBackColor = true;
            // 
            // cmdNuvarandeDbBackupUtforska
            // 
            this.cmdNuvarandeDbBackupUtforska.Location = new System.Drawing.Point(577, 25);
            this.cmdNuvarandeDbBackupUtforska.Margin = new System.Windows.Forms.Padding(4);
            this.cmdNuvarandeDbBackupUtforska.Name = "cmdNuvarandeDbBackupUtforska";
            this.cmdNuvarandeDbBackupUtforska.Size = new System.Drawing.Size(100, 28);
            this.cmdNuvarandeDbBackupUtforska.TabIndex = 17;
            this.cmdNuvarandeDbBackupUtforska.Text = "Utforska";
            this.cmdNuvarandeDbBackupUtforska.UseVisualStyleBackColor = true;
            this.cmdNuvarandeDbBackupUtforska.Click += new System.EventHandler(this.cmdNuvarandeDbBackupUtforska_Click);
            // 
            // laNuvarandeDbBackup
            // 
            this.laNuvarandeDbBackup.AutoSize = true;
            this.laNuvarandeDbBackup.Location = new System.Drawing.Point(25, 57);
            this.laNuvarandeDbBackup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laNuvarandeDbBackup.Name = "laNuvarandeDbBackup";
            this.laNuvarandeDbBackup.Size = new System.Drawing.Size(56, 16);
            this.laNuvarandeDbBackup.TabIndex = 15;
            this.laNuvarandeDbBackup.Text = "Backup:";
            // 
            // laNuvarandeDbBackupDisplay
            // 
            this.laNuvarandeDbBackupDisplay.Location = new System.Drawing.Point(124, 57);
            this.laNuvarandeDbBackupDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laNuvarandeDbBackupDisplay.Name = "laNuvarandeDbBackupDisplay";
            this.laNuvarandeDbBackupDisplay.Size = new System.Drawing.Size(461, 16);
            this.laNuvarandeDbBackupDisplay.TabIndex = 23;
            this.laNuvarandeDbBackupDisplay.Text = "Display";
            // 
            // cbPrinter
            // 
            this.cbPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrinter.FormattingEnabled = true;
            this.cbPrinter.Location = new System.Drawing.Point(27, 57);
            this.cbPrinter.Margin = new System.Windows.Forms.Padding(4);
            this.cbPrinter.Name = "cbPrinter";
            this.cbPrinter.Size = new System.Drawing.Size(279, 24);
            this.cbPrinter.TabIndex = 28;
            this.cbPrinter.SelectedIndexChanged += new System.EventHandler(this.cbPrinter_SelectedIndexChanged);
            // 
            // laPrinter
            // 
            this.laPrinter.AutoSize = true;
            this.laPrinter.Location = new System.Drawing.Point(23, 37);
            this.laPrinter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laPrinter.Name = "laPrinter";
            this.laPrinter.Size = new System.Drawing.Size(81, 16);
            this.laPrinter.TabIndex = 29;
            this.laPrinter.Text = "Välj skrivare";
            // 
            // gbUtskrift
            // 
            this.gbUtskrift.Controls.Add(this.laBusinessName);
            this.gbUtskrift.Controls.Add(this.txtBusinessName);
            this.gbUtskrift.Controls.Add(this.cbPrinter);
            this.gbUtskrift.Controls.Add(this.laPrinter);
            this.gbUtskrift.Location = new System.Drawing.Point(16, 130);
            this.gbUtskrift.Margin = new System.Windows.Forms.Padding(4);
            this.gbUtskrift.Name = "gbUtskrift";
            this.gbUtskrift.Padding = new System.Windows.Forms.Padding(4);
            this.gbUtskrift.Size = new System.Drawing.Size(327, 157);
            this.gbUtskrift.TabIndex = 28;
            this.gbUtskrift.TabStop = false;
            this.gbUtskrift.Text = "Utskrift";
            // 
            // cmdSelectDb
            // 
            this.cmdSelectDb.Location = new System.Drawing.Point(593, 239);
            this.cmdSelectDb.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSelectDb.Name = "cmdSelectDb";
            this.cmdSelectDb.Size = new System.Drawing.Size(217, 28);
            this.cmdSelectDb.TabIndex = 33;
            this.cmdSelectDb.Text = "Välj annan databas";
            this.cmdSelectDb.UseVisualStyleBackColor = true;
            this.cmdSelectDb.Click += new System.EventHandler(this.cmdSelectDb_Click);
            // 
            // txtBusinessName
            // 
            this.txtBusinessName.Location = new System.Drawing.Point(27, 109);
            this.txtBusinessName.Name = "txtBusinessName";
            this.txtBusinessName.Size = new System.Drawing.Size(279, 22);
            this.txtBusinessName.TabIndex = 30;
            this.txtBusinessName.TextChanged += new System.EventHandler(this.txtBusinessName_TextChanged);
            // 
            // laBusinessName
            // 
            this.laBusinessName.AutoSize = true;
            this.laBusinessName.Location = new System.Drawing.Point(24, 90);
            this.laBusinessName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laBusinessName.Name = "laBusinessName";
            this.laBusinessName.Size = new System.Drawing.Size(119, 16);
            this.laBusinessName.TabIndex = 31;
            this.laBusinessName.Text = "Verksamhetsnamn";
            // 
            // InstallningarDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 297);
            this.Controls.Add(this.cmdSelectDb);
            this.Controls.Add(this.gbUtskrift);
            this.Controls.Add(this.laNuvarandeDbBackupDisplay);
            this.Controls.Add(this.laNuvarandeDbBackup);
            this.Controls.Add(this.gbInstallningarDb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "InstallningarDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.InstallningarDialog_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InstallningarDialog_KeyDown);
            this.gbInstallningarDb.ResumeLayout(false);
            this.gbInstallningarDb.PerformLayout();
            this.gbUtskrift.ResumeLayout(false);
            this.gbUtskrift.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInstallningarDb;
        private System.Windows.Forms.Label laNuvarandeDbBackup;
        private System.Windows.Forms.Button cmdNuvarandeDbBackupAterstall;
        private System.Windows.Forms.Label laNuvarandeDbBackupDisplay;
        private System.Windows.Forms.CheckBox cbBackupOnStart;
        private System.Windows.Forms.ComboBox cbPrinter;
        private System.Windows.Forms.Label laPrinter;
        private System.Windows.Forms.GroupBox gbUtskrift;
        private System.Windows.Forms.ToolTip toolTipHelp;
        private System.Windows.Forms.Button cmdNuvarandeDbBackupUtforska;
        private System.Windows.Forms.Button cmdSelectDb;
        private System.Windows.Forms.Label laBusinessName;
        private System.Windows.Forms.TextBox txtBusinessName;
    }
}