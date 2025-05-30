﻿namespace ScannerDialog
{
    partial class NyPersonSimpelDialog
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
            this.gbFalt = new System.Windows.Forms.GroupBox();
            this.cbTillhorighet = new System.Windows.Forms.ComboBox();
            this.laTillhorighet = new System.Windows.Forms.Label();
            this.cmdAvbryt = new System.Windows.Forms.Button();
            this.txtSign = new System.Windows.Forms.TextBox();
            this.cmdSpara = new System.Windows.Forms.Button();
            this.laSign = new System.Windows.Forms.Label();
            this.txtPersNr = new System.Windows.Forms.MaskedTextBox();
            this.txtEfternamn = new System.Windows.Forms.TextBox();
            this.laEfternamn = new System.Windows.Forms.Label();
            this.laPersNr = new System.Windows.Forms.Label();
            this.txtFornamn = new System.Windows.Forms.TextBox();
            this.laFornamn = new System.Windows.Forms.Label();
            this.lbErrors = new System.Windows.Forms.ListBox();
            this.gbFalt.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFalt
            // 
            this.gbFalt.Controls.Add(this.cbTillhorighet);
            this.gbFalt.Controls.Add(this.laTillhorighet);
            this.gbFalt.Controls.Add(this.cmdAvbryt);
            this.gbFalt.Controls.Add(this.txtSign);
            this.gbFalt.Controls.Add(this.cmdSpara);
            this.gbFalt.Controls.Add(this.laSign);
            this.gbFalt.Controls.Add(this.txtPersNr);
            this.gbFalt.Controls.Add(this.txtEfternamn);
            this.gbFalt.Controls.Add(this.laEfternamn);
            this.gbFalt.Controls.Add(this.laPersNr);
            this.gbFalt.Controls.Add(this.txtFornamn);
            this.gbFalt.Controls.Add(this.laFornamn);
            this.gbFalt.Location = new System.Drawing.Point(16, 20);
            this.gbFalt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbFalt.Name = "gbFalt";
            this.gbFalt.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbFalt.Size = new System.Drawing.Size(320, 295);
            this.gbFalt.TabIndex = 0;
            this.gbFalt.TabStop = false;
            this.gbFalt.Text = "Info";
            // 
            // cbTillhorighet
            // 
            this.cbTillhorighet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTillhorighet.FormattingEnabled = true;
            this.cbTillhorighet.Location = new System.Drawing.Point(21, 203);
            this.cbTillhorighet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTillhorighet.Name = "cbTillhorighet";
            this.cbTillhorighet.Size = new System.Drawing.Size(280, 24);
            this.cbTillhorighet.TabIndex = 8;
            this.cbTillhorighet.TabStop = false;
            // 
            // laTillhorighet
            // 
            this.laTillhorighet.AutoSize = true;
            this.laTillhorighet.Location = new System.Drawing.Point(17, 183);
            this.laTillhorighet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laTillhorighet.Name = "laTillhorighet";
            this.laTillhorighet.Size = new System.Drawing.Size(77, 16);
            this.laTillhorighet.TabIndex = 0;
            this.laTillhorighet.Text = "Tillhörighet:";
            // 
            // cmdAvbryt
            // 
            this.cmdAvbryt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdAvbryt.Location = new System.Drawing.Point(187, 246);
            this.cmdAvbryt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdAvbryt.Name = "cmdAvbryt";
            this.cmdAvbryt.Size = new System.Drawing.Size(116, 28);
            this.cmdAvbryt.TabIndex = 9;
            this.cmdAvbryt.Text = "Avbryt";
            this.cmdAvbryt.UseVisualStyleBackColor = true;
            // 
            // txtSign
            // 
            this.txtSign.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSign.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSign.HideSelection = false;
            this.txtSign.Location = new System.Drawing.Point(149, 149);
            this.txtSign.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSign.Name = "txtSign";
            this.txtSign.Size = new System.Drawing.Size(152, 22);
            this.txtSign.TabIndex = 3;
            // 
            // cmdSpara
            // 
            this.cmdSpara.Location = new System.Drawing.Point(20, 246);
            this.cmdSpara.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdSpara.Name = "cmdSpara";
            this.cmdSpara.Size = new System.Drawing.Size(116, 28);
            this.cmdSpara.TabIndex = 8;
            this.cmdSpara.Text = "Spara";
            this.cmdSpara.UseVisualStyleBackColor = true;
            this.cmdSpara.Click += new System.EventHandler(this.cmdSpara_Click);
            // 
            // laSign
            // 
            this.laSign.AutoSize = true;
            this.laSign.Location = new System.Drawing.Point(145, 128);
            this.laSign.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laSign.Name = "laSign";
            this.laSign.Size = new System.Drawing.Size(60, 16);
            this.laSign.TabIndex = 10;
            this.laSign.Text = "Signatur:";
            // 
            // txtPersNr
            // 
            this.txtPersNr.Culture = new System.Globalization.CultureInfo("");
            this.txtPersNr.Enabled = false;
            this.txtPersNr.Location = new System.Drawing.Point(21, 149);
            this.txtPersNr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPersNr.Mask = "######-####";
            this.txtPersNr.Name = "txtPersNr";
            this.txtPersNr.ReadOnly = true;
            this.txtPersNr.Size = new System.Drawing.Size(119, 22);
            this.txtPersNr.TabIndex = 2;
            this.txtPersNr.TabStop = false;
            // 
            // txtEfternamn
            // 
            this.txtEfternamn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEfternamn.HideSelection = false;
            this.txtEfternamn.Location = new System.Drawing.Point(20, 97);
            this.txtEfternamn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEfternamn.Name = "txtEfternamn";
            this.txtEfternamn.Size = new System.Drawing.Size(281, 22);
            this.txtEfternamn.TabIndex = 1;
            // 
            // laEfternamn
            // 
            this.laEfternamn.AutoSize = true;
            this.laEfternamn.Location = new System.Drawing.Point(17, 78);
            this.laEfternamn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laEfternamn.Name = "laEfternamn";
            this.laEfternamn.Size = new System.Drawing.Size(71, 16);
            this.laEfternamn.TabIndex = 1;
            this.laEfternamn.Text = "Efternamn:";
            // 
            // laPersNr
            // 
            this.laPersNr.AutoSize = true;
            this.laPersNr.Location = new System.Drawing.Point(17, 129);
            this.laPersNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laPersNr.Name = "laPersNr";
            this.laPersNr.Size = new System.Drawing.Size(53, 16);
            this.laPersNr.TabIndex = 2;
            this.laPersNr.Text = "PersNr:";
            // 
            // txtFornamn
            // 
            this.txtFornamn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFornamn.HideSelection = false;
            this.txtFornamn.Location = new System.Drawing.Point(20, 46);
            this.txtFornamn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFornamn.Name = "txtFornamn";
            this.txtFornamn.Size = new System.Drawing.Size(281, 22);
            this.txtFornamn.TabIndex = 0;
            // 
            // laFornamn
            // 
            this.laFornamn.AutoSize = true;
            this.laFornamn.Location = new System.Drawing.Point(16, 26);
            this.laFornamn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laFornamn.Name = "laFornamn";
            this.laFornamn.Size = new System.Drawing.Size(64, 16);
            this.laFornamn.TabIndex = 0;
            this.laFornamn.Text = "Förnamn:";
            // 
            // lbErrors
            // 
            this.lbErrors.FormattingEnabled = true;
            this.lbErrors.ItemHeight = 16;
            this.lbErrors.Location = new System.Drawing.Point(343, 25);
            this.lbErrors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbErrors.Name = "lbErrors";
            this.lbErrors.Size = new System.Drawing.Size(281, 292);
            this.lbErrors.TabIndex = 16;
            // 
            // NyPersonSimpelDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdAvbryt;
            this.ClientSize = new System.Drawing.Size(641, 325);
            this.Controls.Add(this.lbErrors);
            this.Controls.Add(this.gbFalt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NyPersonSimpelDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.NyPersonDialog_Load);
            this.gbFalt.ResumeLayout(false);
            this.gbFalt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFalt;
        private System.Windows.Forms.TextBox txtEfternamn;
        private System.Windows.Forms.Label laEfternamn;
        private System.Windows.Forms.TextBox txtFornamn;
        private System.Windows.Forms.Label laPersNr;
        private System.Windows.Forms.Label laFornamn;
        private System.Windows.Forms.ComboBox cbTillhorighet;
        private System.Windows.Forms.Label laTillhorighet;
        private System.Windows.Forms.Button cmdAvbryt;
        private System.Windows.Forms.Button cmdSpara;
        private System.Windows.Forms.MaskedTextBox txtPersNr;
        private System.Windows.Forms.ListBox lbErrors;
        private System.Windows.Forms.TextBox txtSign;
        private System.Windows.Forms.Label laSign;
    }
}