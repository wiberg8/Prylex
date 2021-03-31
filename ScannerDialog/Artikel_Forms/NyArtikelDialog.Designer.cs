namespace ScannerDialog
{
    partial class NyArtikelDialog
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
            this.cbBeskrivningar = new System.Windows.Forms.ComboBox();
            this.laBeskrivningar = new System.Windows.Forms.Label();
            this.gbSnabbVal = new System.Windows.Forms.GroupBox();
            this.checkOsFritext = new System.Windows.Forms.CheckBox();
            this.cbOS = new System.Windows.Forms.ComboBox();
            this.laOS = new System.Windows.Forms.Label();
            this.dtpInkop = new System.Windows.Forms.DateTimePicker();
            this.laInkop = new System.Windows.Forms.Label();
            this.checkBeskrivningarFritext = new System.Windows.Forms.CheckBox();
            this.txtDatornamn = new System.Windows.Forms.TextBox();
            this.laDatornamn = new System.Windows.Forms.Label();
            this.txtStoldtag = new System.Windows.Forms.TextBox();
            this.laStoldtag = new System.Windows.Forms.Label();
            this.txtSerieNr = new System.Windows.Forms.TextBox();
            this.laSerieNr = new System.Windows.Forms.Label();
            this.gbFalt = new System.Windows.Forms.GroupBox();
            this.txtMAC = new System.Windows.Forms.TextBox();
            this.laMAC = new System.Windows.Forms.Label();
            this.txtOvrigt = new System.Windows.Forms.TextBox();
            this.laOvrigt = new System.Windows.Forms.Label();
            this.cmdSpara = new System.Windows.Forms.Button();
            this.cmdAvbryt = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbErrors = new System.Windows.Forms.ListBox();
            this.cbPrintEttiket = new System.Windows.Forms.CheckBox();
            this.gbSnabbVal.SuspendLayout();
            this.gbFalt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cbBeskrivningar
            // 
            this.cbBeskrivningar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBeskrivningar.FormattingEnabled = true;
            this.cbBeskrivningar.Location = new System.Drawing.Point(9, 36);
            this.cbBeskrivningar.Name = "cbBeskrivningar";
            this.cbBeskrivningar.Size = new System.Drawing.Size(207, 21);
            this.cbBeskrivningar.TabIndex = 0;
            this.cbBeskrivningar.TabStop = false;
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
            // gbSnabbVal
            // 
            this.gbSnabbVal.Controls.Add(this.cbPrintEttiket);
            this.gbSnabbVal.Controls.Add(this.checkOsFritext);
            this.gbSnabbVal.Controls.Add(this.cbOS);
            this.gbSnabbVal.Controls.Add(this.laOS);
            this.gbSnabbVal.Controls.Add(this.dtpInkop);
            this.gbSnabbVal.Controls.Add(this.laInkop);
            this.gbSnabbVal.Controls.Add(this.checkBeskrivningarFritext);
            this.gbSnabbVal.Controls.Add(this.cbBeskrivningar);
            this.gbSnabbVal.Controls.Add(this.laBeskrivningar);
            this.gbSnabbVal.Location = new System.Drawing.Point(333, 9);
            this.gbSnabbVal.Name = "gbSnabbVal";
            this.gbSnabbVal.Size = new System.Drawing.Size(225, 160);
            this.gbSnabbVal.TabIndex = 0;
            this.gbSnabbVal.TabStop = false;
            this.gbSnabbVal.Text = "Info - Snabb val ";
            this.gbSnabbVal.Enter += new System.EventHandler(this.gbStaticFields_Enter);
            // 
            // checkOsFritext
            // 
            this.checkOsFritext.AutoSize = true;
            this.checkOsFritext.Location = new System.Drawing.Point(162, 60);
            this.checkOsFritext.Name = "checkOsFritext";
            this.checkOsFritext.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkOsFritext.Size = new System.Drawing.Size(54, 17);
            this.checkOsFritext.TabIndex = 4;
            this.checkOsFritext.TabStop = false;
            this.checkOsFritext.Text = "Fritext";
            this.checkOsFritext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.checkOsFritext.UseVisualStyleBackColor = true;
            this.checkOsFritext.CheckedChanged += new System.EventHandler(this.checkOsFritext_CheckedChanged);
            // 
            // cbOS
            // 
            this.cbOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOS.FormattingEnabled = true;
            this.cbOS.Location = new System.Drawing.Point(9, 79);
            this.cbOS.Name = "cbOS";
            this.cbOS.Size = new System.Drawing.Size(207, 21);
            this.cbOS.TabIndex = 2;
            this.cbOS.TabStop = false;
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
            // dtpInkop
            // 
            this.dtpInkop.Checked = false;
            this.dtpInkop.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInkop.Location = new System.Drawing.Point(9, 126);
            this.dtpInkop.Name = "dtpInkop";
            this.dtpInkop.Size = new System.Drawing.Size(106, 20);
            this.dtpInkop.TabIndex = 3;
            this.dtpInkop.TabStop = false;
            this.dtpInkop.Value = new System.DateTime(2020, 6, 23, 13, 10, 47, 0);
            this.dtpInkop.ValueChanged += new System.EventHandler(this.dtpInkop_ValueChanged);
            // 
            // laInkop
            // 
            this.laInkop.AutoSize = true;
            this.laInkop.Location = new System.Drawing.Point(7, 108);
            this.laInkop.Name = "laInkop";
            this.laInkop.Size = new System.Drawing.Size(76, 13);
            this.laInkop.TabIndex = 3;
            this.laInkop.Text = "Inköps Datum:";
            // 
            // checkBeskrivningarFritext
            // 
            this.checkBeskrivningarFritext.AutoSize = true;
            this.checkBeskrivningarFritext.Location = new System.Drawing.Point(162, 16);
            this.checkBeskrivningarFritext.Name = "checkBeskrivningarFritext";
            this.checkBeskrivningarFritext.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBeskrivningarFritext.Size = new System.Drawing.Size(54, 17);
            this.checkBeskrivningarFritext.TabIndex = 1;
            this.checkBeskrivningarFritext.TabStop = false;
            this.checkBeskrivningarFritext.Text = "Fritext";
            this.checkBeskrivningarFritext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.checkBeskrivningarFritext.UseVisualStyleBackColor = true;
            this.checkBeskrivningarFritext.CheckedChanged += new System.EventHandler(this.cbInputChoose_CheckedChanged);
            // 
            // txtDatornamn
            // 
            this.txtDatornamn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDatornamn.HideSelection = false;
            this.txtDatornamn.Location = new System.Drawing.Point(15, 163);
            this.txtDatornamn.Name = "txtDatornamn";
            this.txtDatornamn.Size = new System.Drawing.Size(289, 20);
            this.txtDatornamn.TabIndex = 7;
            // 
            // laDatornamn
            // 
            this.laDatornamn.AutoSize = true;
            this.laDatornamn.Location = new System.Drawing.Point(12, 147);
            this.laDatornamn.Name = "laDatornamn";
            this.laDatornamn.Size = new System.Drawing.Size(62, 13);
            this.laDatornamn.TabIndex = 7;
            this.laDatornamn.Text = "Datornamn:";
            // 
            // txtStoldtag
            // 
            this.txtStoldtag.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStoldtag.HideSelection = false;
            this.txtStoldtag.Location = new System.Drawing.Point(15, 121);
            this.txtStoldtag.Name = "txtStoldtag";
            this.txtStoldtag.Size = new System.Drawing.Size(289, 20);
            this.txtStoldtag.TabIndex = 6;
            this.txtStoldtag.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // laStoldtag
            // 
            this.laStoldtag.AutoSize = true;
            this.laStoldtag.Location = new System.Drawing.Point(13, 105);
            this.laStoldtag.Name = "laStoldtag";
            this.laStoldtag.Size = new System.Drawing.Size(49, 13);
            this.laStoldtag.TabIndex = 6;
            this.laStoldtag.Text = "Stöldtag:";
            // 
            // txtSerieNr
            // 
            this.txtSerieNr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSerieNr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSerieNr.HideSelection = false;
            this.txtSerieNr.Location = new System.Drawing.Point(15, 37);
            this.txtSerieNr.Name = "txtSerieNr";
            this.txtSerieNr.Size = new System.Drawing.Size(289, 20);
            this.txtSerieNr.TabIndex = 4;
            this.txtSerieNr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // laSerieNr
            // 
            this.laSerieNr.AutoSize = true;
            this.laSerieNr.Location = new System.Drawing.Point(12, 21);
            this.laSerieNr.Name = "laSerieNr";
            this.laSerieNr.Size = new System.Drawing.Size(45, 13);
            this.laSerieNr.TabIndex = 4;
            this.laSerieNr.Text = "SerieNr:";
            // 
            // gbFalt
            // 
            this.gbFalt.Controls.Add(this.txtMAC);
            this.gbFalt.Controls.Add(this.laMAC);
            this.gbFalt.Controls.Add(this.txtOvrigt);
            this.gbFalt.Controls.Add(this.laOvrigt);
            this.gbFalt.Controls.Add(this.txtStoldtag);
            this.gbFalt.Controls.Add(this.txtDatornamn);
            this.gbFalt.Controls.Add(this.txtSerieNr);
            this.gbFalt.Controls.Add(this.laStoldtag);
            this.gbFalt.Controls.Add(this.laDatornamn);
            this.gbFalt.Controls.Add(this.laSerieNr);
            this.gbFalt.Location = new System.Drawing.Point(12, 9);
            this.gbFalt.Name = "gbFalt";
            this.gbFalt.Size = new System.Drawing.Size(315, 283);
            this.gbFalt.TabIndex = 1;
            this.gbFalt.TabStop = false;
            this.gbFalt.Text = "Info";
            // 
            // txtMAC
            // 
            this.txtMAC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMAC.HideSelection = false;
            this.txtMAC.Location = new System.Drawing.Point(15, 79);
            this.txtMAC.Name = "txtMAC";
            this.txtMAC.Size = new System.Drawing.Size(289, 20);
            this.txtMAC.TabIndex = 5;
            this.txtMAC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // laMAC
            // 
            this.laMAC.AutoSize = true;
            this.laMAC.Location = new System.Drawing.Point(13, 63);
            this.laMAC.Name = "laMAC";
            this.laMAC.Size = new System.Drawing.Size(68, 13);
            this.laMAC.TabIndex = 5;
            this.laMAC.Text = "MAC-Adress:";
            // 
            // txtOvrigt
            // 
            this.txtOvrigt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOvrigt.HideSelection = false;
            this.txtOvrigt.Location = new System.Drawing.Point(15, 205);
            this.txtOvrigt.Multiline = true;
            this.txtOvrigt.Name = "txtOvrigt";
            this.txtOvrigt.Size = new System.Drawing.Size(289, 66);
            this.txtOvrigt.TabIndex = 8;
            this.txtOvrigt.TextChanged += new System.EventHandler(this.txtOther_TextChanged);
            // 
            // laOvrigt
            // 
            this.laOvrigt.AutoSize = true;
            this.laOvrigt.Location = new System.Drawing.Point(12, 189);
            this.laOvrigt.Name = "laOvrigt";
            this.laOvrigt.Size = new System.Drawing.Size(38, 13);
            this.laOvrigt.TabIndex = 8;
            this.laOvrigt.Text = "Övrigt:";
            this.laOvrigt.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmdSpara
            // 
            this.cmdSpara.Location = new System.Drawing.Point(333, 269);
            this.cmdSpara.Name = "cmdSpara";
            this.cmdSpara.Size = new System.Drawing.Size(88, 23);
            this.cmdSpara.TabIndex = 8;
            this.cmdSpara.Text = "Spara";
            this.cmdSpara.UseVisualStyleBackColor = true;
            this.cmdSpara.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdAvbryt
            // 
            this.cmdAvbryt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdAvbryt.Location = new System.Drawing.Point(470, 269);
            this.cmdAvbryt.Name = "cmdAvbryt";
            this.cmdAvbryt.Size = new System.Drawing.Size(88, 23);
            this.cmdAvbryt.TabIndex = 9;
            this.cmdAvbryt.Text = "Avbryt";
            this.cmdAvbryt.UseVisualStyleBackColor = true;
            this.cmdAvbryt.Click += new System.EventHandler(this.cmdAvbryt_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // lbErrors
            // 
            this.lbErrors.FormattingEnabled = true;
            this.lbErrors.Location = new System.Drawing.Point(333, 175);
            this.lbErrors.Name = "lbErrors";
            this.lbErrors.Size = new System.Drawing.Size(225, 82);
            this.lbErrors.TabIndex = 17;
            // 
            // cbPrintEttiket
            // 
            this.cbPrintEttiket.AutoSize = true;
            this.cbPrintEttiket.Location = new System.Drawing.Point(124, 128);
            this.cbPrintEttiket.Name = "cbPrintEttiket";
            this.cbPrintEttiket.Size = new System.Drawing.Size(94, 17);
            this.cbPrintEttiket.TabIndex = 29;
            this.cbPrintEttiket.Text = "Skriv ut ettiket";
            this.cbPrintEttiket.UseVisualStyleBackColor = true;
            // 
            // NyArtikelDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.cmdAvbryt;
            this.ClientSize = new System.Drawing.Size(572, 299);
            this.Controls.Add(this.lbErrors);
            this.Controls.Add(this.cmdAvbryt);
            this.Controls.Add(this.cmdSpara);
            this.Controls.Add(this.gbFalt);
            this.Controls.Add(this.gbSnabbVal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NyArtikelDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.NyArtikelDialog_Load);
            this.gbSnabbVal.ResumeLayout(false);
            this.gbSnabbVal.PerformLayout();
            this.gbFalt.ResumeLayout(false);
            this.gbFalt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBeskrivningar;
        private System.Windows.Forms.Label laBeskrivningar;
        private System.Windows.Forms.GroupBox gbSnabbVal;
        private System.Windows.Forms.CheckBox checkBeskrivningarFritext;
        private System.Windows.Forms.DateTimePicker dtpInkop;
        private System.Windows.Forms.ComboBox cbOS;
        private System.Windows.Forms.Label laOS;
        private System.Windows.Forms.TextBox txtDatornamn;
        private System.Windows.Forms.Label laDatornamn;
        private System.Windows.Forms.TextBox txtStoldtag;
        private System.Windows.Forms.Label laStoldtag;
        private System.Windows.Forms.TextBox txtSerieNr;
        private System.Windows.Forms.Label laSerieNr;
        private System.Windows.Forms.GroupBox gbFalt;
        private System.Windows.Forms.TextBox txtOvrigt;
        private System.Windows.Forms.Label laOvrigt;
        private System.Windows.Forms.Button cmdSpara;
        private System.Windows.Forms.Button cmdAvbryt;
        private System.Windows.Forms.TextBox txtMAC;
        private System.Windows.Forms.Label laMAC;
        private System.Windows.Forms.Label laInkop;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.CheckBox checkOsFritext;
        private System.Windows.Forms.ListBox lbErrors;
        private System.Windows.Forms.CheckBox cbPrintEttiket;
    }
}