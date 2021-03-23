namespace ScannerDialog
{
    partial class UpdateraArtikelDialog
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
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmdSpara = new System.Windows.Forms.Button();
            this.txtOvrigt = new System.Windows.Forms.TextBox();
            this.laOvrigt = new System.Windows.Forms.Label();
            this.gbFalt = new System.Windows.Forms.GroupBox();
            this.txtStoldtag = new System.Windows.Forms.TextBox();
            this.txtDatornamn = new System.Windows.Forms.TextBox();
            this.laStoldtag = new System.Windows.Forms.Label();
            this.laDatornamn = new System.Windows.Forms.Label();
            this.cbOS = new System.Windows.Forms.ComboBox();
            this.laOS = new System.Windows.Forms.Label();
            this.gbSnabbVal = new System.Windows.Forms.GroupBox();
            this.cbBeskrivningar = new System.Windows.Forms.ComboBox();
            this.laBeskrivningar = new System.Windows.Forms.Label();
            this.cmdAvbryt = new System.Windows.Forms.Button();
            this.lbErrors = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.gbFalt.SuspendLayout();
            this.gbSnabbVal.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // cmdSpara
            // 
            this.cmdSpara.Location = new System.Drawing.Point(333, 191);
            this.cmdSpara.Name = "cmdSpara";
            this.cmdSpara.Size = new System.Drawing.Size(88, 23);
            this.cmdSpara.TabIndex = 12;
            this.cmdSpara.Text = "Spara";
            this.cmdSpara.UseVisualStyleBackColor = true;
            this.cmdSpara.Click += new System.EventHandler(this.cmdSpara_Click);
            // 
            // txtOvrigt
            // 
            this.txtOvrigt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOvrigt.HideSelection = false;
            this.txtOvrigt.Location = new System.Drawing.Point(20, 122);
            this.txtOvrigt.Multiline = true;
            this.txtOvrigt.Name = "txtOvrigt";
            this.txtOvrigt.Size = new System.Drawing.Size(289, 66);
            this.txtOvrigt.TabIndex = 8;
            // 
            // laOvrigt
            // 
            this.laOvrigt.AutoSize = true;
            this.laOvrigt.Location = new System.Drawing.Point(17, 106);
            this.laOvrigt.Name = "laOvrigt";
            this.laOvrigt.Size = new System.Drawing.Size(38, 13);
            this.laOvrigt.TabIndex = 8;
            this.laOvrigt.Text = "Övrigt:";
            // 
            // gbFalt
            // 
            this.gbFalt.Controls.Add(this.txtOvrigt);
            this.gbFalt.Controls.Add(this.laOvrigt);
            this.gbFalt.Controls.Add(this.txtStoldtag);
            this.gbFalt.Controls.Add(this.txtDatornamn);
            this.gbFalt.Controls.Add(this.laStoldtag);
            this.gbFalt.Controls.Add(this.laDatornamn);
            this.gbFalt.Location = new System.Drawing.Point(12, 12);
            this.gbFalt.Name = "gbFalt";
            this.gbFalt.Size = new System.Drawing.Size(315, 202);
            this.gbFalt.TabIndex = 11;
            this.gbFalt.TabStop = false;
            this.gbFalt.Text = "Info";
            // 
            // txtStoldtag
            // 
            this.txtStoldtag.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStoldtag.HideSelection = false;
            this.txtStoldtag.Location = new System.Drawing.Point(20, 38);
            this.txtStoldtag.Name = "txtStoldtag";
            this.txtStoldtag.Size = new System.Drawing.Size(289, 20);
            this.txtStoldtag.TabIndex = 6;
            // 
            // txtDatornamn
            // 
            this.txtDatornamn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDatornamn.HideSelection = false;
            this.txtDatornamn.Location = new System.Drawing.Point(20, 80);
            this.txtDatornamn.Name = "txtDatornamn";
            this.txtDatornamn.Size = new System.Drawing.Size(289, 20);
            this.txtDatornamn.TabIndex = 7;
            // 
            // laStoldtag
            // 
            this.laStoldtag.AutoSize = true;
            this.laStoldtag.Location = new System.Drawing.Point(18, 22);
            this.laStoldtag.Name = "laStoldtag";
            this.laStoldtag.Size = new System.Drawing.Size(49, 13);
            this.laStoldtag.TabIndex = 6;
            this.laStoldtag.Text = "Stöldtag:";
            // 
            // laDatornamn
            // 
            this.laDatornamn.AutoSize = true;
            this.laDatornamn.Location = new System.Drawing.Point(17, 64);
            this.laDatornamn.Name = "laDatornamn";
            this.laDatornamn.Size = new System.Drawing.Size(62, 13);
            this.laDatornamn.TabIndex = 7;
            this.laDatornamn.Text = "Datornamn:";
            // 
            // cbOS
            // 
            this.cbOS.FormattingEnabled = true;
            this.cbOS.Location = new System.Drawing.Point(9, 79);
            this.cbOS.Name = "cbOS";
            this.cbOS.Size = new System.Drawing.Size(207, 21);
            this.cbOS.TabIndex = 2;
            // 
            // laOS
            // 
            this.laOS.AutoSize = true;
            this.laOS.Location = new System.Drawing.Point(7, 64);
            this.laOS.Name = "laOS";
            this.laOS.Size = new System.Drawing.Size(50, 13);
            this.laOS.TabIndex = 2;
            this.laOS.Text = "Operativ:";
            // 
            // gbSnabbVal
            // 
            this.gbSnabbVal.Controls.Add(this.cbOS);
            this.gbSnabbVal.Controls.Add(this.laOS);
            this.gbSnabbVal.Controls.Add(this.cbBeskrivningar);
            this.gbSnabbVal.Controls.Add(this.laBeskrivningar);
            this.gbSnabbVal.Location = new System.Drawing.Point(333, 12);
            this.gbSnabbVal.Name = "gbSnabbVal";
            this.gbSnabbVal.Size = new System.Drawing.Size(225, 119);
            this.gbSnabbVal.TabIndex = 10;
            this.gbSnabbVal.TabStop = false;
            this.gbSnabbVal.Text = "Info - Snabb val ";
            // 
            // cbBeskrivningar
            // 
            this.cbBeskrivningar.FormattingEnabled = true;
            this.cbBeskrivningar.Location = new System.Drawing.Point(9, 36);
            this.cbBeskrivningar.Name = "cbBeskrivningar";
            this.cbBeskrivningar.Size = new System.Drawing.Size(207, 21);
            this.cbBeskrivningar.TabIndex = 0;
            // 
            // laBeskrivningar
            // 
            this.laBeskrivningar.AutoSize = true;
            this.laBeskrivningar.Location = new System.Drawing.Point(6, 20);
            this.laBeskrivningar.Name = "laBeskrivningar";
            this.laBeskrivningar.Size = new System.Drawing.Size(65, 13);
            this.laBeskrivningar.TabIndex = 0;
            this.laBeskrivningar.Text = "Beskrivning:";
            // 
            // cmdAvbryt
            // 
            this.cmdAvbryt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdAvbryt.Location = new System.Drawing.Point(470, 191);
            this.cmdAvbryt.Name = "cmdAvbryt";
            this.cmdAvbryt.Size = new System.Drawing.Size(88, 23);
            this.cmdAvbryt.TabIndex = 13;
            this.cmdAvbryt.Text = "Avbryt";
            this.cmdAvbryt.UseVisualStyleBackColor = true;
            // 
            // lbErrors
            // 
            this.lbErrors.FormattingEnabled = true;
            this.lbErrors.Location = new System.Drawing.Point(333, 132);
            this.lbErrors.Name = "lbErrors";
            this.lbErrors.Size = new System.Drawing.Size(225, 56);
            this.lbErrors.TabIndex = 18;
            // 
            // UpdateraArtikelDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 224);
            this.Controls.Add(this.lbErrors);
            this.Controls.Add(this.cmdSpara);
            this.Controls.Add(this.gbFalt);
            this.Controls.Add(this.gbSnabbVal);
            this.Controls.Add(this.cmdAvbryt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UpdateraArtikelDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.UpdateraArtikelDialog_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UpdateraArtikelDialog_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.gbFalt.ResumeLayout(false);
            this.gbFalt.PerformLayout();
            this.gbSnabbVal.ResumeLayout(false);
            this.gbSnabbVal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button cmdSpara;
        private System.Windows.Forms.GroupBox gbFalt;
        private System.Windows.Forms.TextBox txtOvrigt;
        private System.Windows.Forms.Label laOvrigt;
        private System.Windows.Forms.TextBox txtStoldtag;
        private System.Windows.Forms.TextBox txtDatornamn;
        private System.Windows.Forms.Label laStoldtag;
        private System.Windows.Forms.Label laDatornamn;
        private System.Windows.Forms.GroupBox gbSnabbVal;
        private System.Windows.Forms.ComboBox cbOS;
        private System.Windows.Forms.Label laOS;
        private System.Windows.Forms.ComboBox cbBeskrivningar;
        private System.Windows.Forms.Label laBeskrivningar;
        private System.Windows.Forms.Button cmdAvbryt;
        private System.Windows.Forms.ListBox lbErrors;
    }
}