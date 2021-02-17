namespace ScannerDialog
{
    partial class UpdateraPersonDialog
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
            this.cmdAvbryt = new System.Windows.Forms.Button();
            this.txtSign = new System.Windows.Forms.TextBox();
            this.cmdSpara = new System.Windows.Forms.Button();
            this.laSign = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.laTelefon = new System.Windows.Forms.Label();
            this.txtEpost = new System.Windows.Forms.TextBox();
            this.laEpost = new System.Windows.Forms.Label();
            this.gbSnabbVal = new System.Windows.Forms.GroupBox();
            this.cbTillhorighet = new System.Windows.Forms.ComboBox();
            this.laTillhorighet = new System.Windows.Forms.Label();
            this.txtEfternamn = new System.Windows.Forms.TextBox();
            this.laEfternamn = new System.Windows.Forms.Label();
            this.txtOvrigt = new System.Windows.Forms.TextBox();
            this.laOvrigt = new System.Windows.Forms.Label();
            this.txtFornamn = new System.Windows.Forms.TextBox();
            this.laFornamn = new System.Windows.Forms.Label();
            this.errorFornamn = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEfternamn = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTillhorighet = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbSnabbVal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorFornamn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEfternamn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTillhorighet)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdAvbryt
            // 
            this.cmdAvbryt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdAvbryt.Location = new System.Drawing.Point(382, 203);
            this.cmdAvbryt.Name = "cmdAvbryt";
            this.cmdAvbryt.Size = new System.Drawing.Size(87, 23);
            this.cmdAvbryt.TabIndex = 22;
            this.cmdAvbryt.Text = "Avbryt";
            this.cmdAvbryt.UseVisualStyleBackColor = true;
            // 
            // txtSign
            // 
            this.txtSign.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSign.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSign.HideSelection = false;
            this.txtSign.Location = new System.Drawing.Point(123, 124);
            this.txtSign.Name = "txtSign";
            this.txtSign.Size = new System.Drawing.Size(115, 20);
            this.txtSign.TabIndex = 15;
            // 
            // cmdSpara
            // 
            this.cmdSpara.Location = new System.Drawing.Point(245, 203);
            this.cmdSpara.Name = "cmdSpara";
            this.cmdSpara.Size = new System.Drawing.Size(87, 23);
            this.cmdSpara.TabIndex = 24;
            this.cmdSpara.Text = "Spara";
            this.cmdSpara.UseVisualStyleBackColor = true;
            // 
            // laSign
            // 
            this.laSign.AutoSize = true;
            this.laSign.Location = new System.Drawing.Point(120, 107);
            this.laSign.Name = "laSign";
            this.laSign.Size = new System.Drawing.Size(49, 13);
            this.laSign.TabIndex = 25;
            this.laSign.Text = "Signatur:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefon.HideSelection = false;
            this.txtTelefon.Location = new System.Drawing.Point(26, 204);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(213, 20);
            this.txtTelefon.TabIndex = 20;
            // 
            // laTelefon
            // 
            this.laTelefon.AutoSize = true;
            this.laTelefon.Location = new System.Drawing.Point(23, 188);
            this.laTelefon.Name = "laTelefon";
            this.laTelefon.Size = new System.Drawing.Size(46, 13);
            this.laTelefon.TabIndex = 16;
            this.laTelefon.Text = "Telefon:";
            // 
            // txtEpost
            // 
            this.txtEpost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEpost.HideSelection = false;
            this.txtEpost.Location = new System.Drawing.Point(27, 164);
            this.txtEpost.Name = "txtEpost";
            this.txtEpost.Size = new System.Drawing.Size(212, 20);
            this.txtEpost.TabIndex = 17;
            // 
            // laEpost
            // 
            this.laEpost.AutoSize = true;
            this.laEpost.Location = new System.Drawing.Point(24, 147);
            this.laEpost.Name = "laEpost";
            this.laEpost.Size = new System.Drawing.Size(40, 13);
            this.laEpost.TabIndex = 18;
            this.laEpost.Text = "E-post:";
            // 
            // gbSnabbVal
            // 
            this.gbSnabbVal.Controls.Add(this.cbTillhorighet);
            this.gbSnabbVal.Controls.Add(this.laTillhorighet);
            this.gbSnabbVal.Location = new System.Drawing.Point(244, 111);
            this.gbSnabbVal.Name = "gbSnabbVal";
            this.gbSnabbVal.Size = new System.Drawing.Size(224, 72);
            this.gbSnabbVal.TabIndex = 23;
            this.gbSnabbVal.TabStop = false;
            this.gbSnabbVal.Text = "Snabb val ";
            // 
            // cbTillhorighet
            // 
            this.cbTillhorighet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTillhorighet.FormattingEnabled = true;
            this.cbTillhorighet.Location = new System.Drawing.Point(15, 36);
            this.cbTillhorighet.Name = "cbTillhorighet";
            this.cbTillhorighet.Size = new System.Drawing.Size(202, 21);
            this.cbTillhorighet.TabIndex = 8;
            // 
            // laTillhorighet
            // 
            this.laTillhorighet.AutoSize = true;
            this.laTillhorighet.Location = new System.Drawing.Point(12, 20);
            this.laTillhorighet.Name = "laTillhorighet";
            this.laTillhorighet.Size = new System.Drawing.Size(61, 13);
            this.laTillhorighet.TabIndex = 0;
            this.laTillhorighet.Text = "Tillhörighet:";
            // 
            // txtEfternamn
            // 
            this.txtEfternamn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEfternamn.HideSelection = false;
            this.txtEfternamn.Location = new System.Drawing.Point(26, 82);
            this.txtEfternamn.Name = "txtEfternamn";
            this.txtEfternamn.Size = new System.Drawing.Size(212, 20);
            this.txtEfternamn.TabIndex = 13;
            // 
            // laEfternamn
            // 
            this.laEfternamn.AutoSize = true;
            this.laEfternamn.Location = new System.Drawing.Point(24, 66);
            this.laEfternamn.Name = "laEfternamn";
            this.laEfternamn.Size = new System.Drawing.Size(58, 13);
            this.laEfternamn.TabIndex = 14;
            this.laEfternamn.Text = "Efternamn:";
            // 
            // txtOvrigt
            // 
            this.txtOvrigt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOvrigt.HideSelection = false;
            this.txtOvrigt.Location = new System.Drawing.Point(244, 40);
            this.txtOvrigt.Multiline = true;
            this.txtOvrigt.Name = "txtOvrigt";
            this.txtOvrigt.Size = new System.Drawing.Size(224, 62);
            this.txtOvrigt.TabIndex = 21;
            // 
            // laOvrigt
            // 
            this.laOvrigt.AutoSize = true;
            this.laOvrigt.Location = new System.Drawing.Point(241, 24);
            this.laOvrigt.Name = "laOvrigt";
            this.laOvrigt.Size = new System.Drawing.Size(38, 13);
            this.laOvrigt.TabIndex = 19;
            this.laOvrigt.Text = "Övrigt:";
            // 
            // txtFornamn
            // 
            this.txtFornamn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFornamn.HideSelection = false;
            this.txtFornamn.Location = new System.Drawing.Point(26, 40);
            this.txtFornamn.Name = "txtFornamn";
            this.txtFornamn.Size = new System.Drawing.Size(212, 20);
            this.txtFornamn.TabIndex = 11;
            // 
            // laFornamn
            // 
            this.laFornamn.AutoSize = true;
            this.laFornamn.Location = new System.Drawing.Point(23, 24);
            this.laFornamn.Name = "laFornamn";
            this.laFornamn.Size = new System.Drawing.Size(51, 13);
            this.laFornamn.TabIndex = 12;
            this.laFornamn.Text = "Förnamn:";
            // 
            // errorFornamn
            // 
            this.errorFornamn.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorFornamn.ContainerControl = this;
            this.errorFornamn.RightToLeft = true;
            // 
            // errorEfternamn
            // 
            this.errorEfternamn.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorEfternamn.ContainerControl = this;
            this.errorEfternamn.RightToLeft = true;
            // 
            // errorTillhorighet
            // 
            this.errorTillhorighet.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorTillhorighet.ContainerControl = this;
            this.errorTillhorighet.RightToLeft = true;
            // 
            // UpdateraPersonDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 244);
            this.Controls.Add(this.cmdAvbryt);
            this.Controls.Add(this.txtSign);
            this.Controls.Add(this.cmdSpara);
            this.Controls.Add(this.laSign);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.laTelefon);
            this.Controls.Add(this.txtEpost);
            this.Controls.Add(this.laEpost);
            this.Controls.Add(this.gbSnabbVal);
            this.Controls.Add(this.txtEfternamn);
            this.Controls.Add(this.laEfternamn);
            this.Controls.Add(this.txtOvrigt);
            this.Controls.Add(this.laOvrigt);
            this.Controls.Add(this.txtFornamn);
            this.Controls.Add(this.laFornamn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "UpdateraPersonDialog";
            this.gbSnabbVal.ResumeLayout(false);
            this.gbSnabbVal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorFornamn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEfternamn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTillhorighet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdAvbryt;
        private System.Windows.Forms.TextBox txtSign;
        private System.Windows.Forms.Button cmdSpara;
        private System.Windows.Forms.Label laSign;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label laTelefon;
        private System.Windows.Forms.TextBox txtEpost;
        private System.Windows.Forms.Label laEpost;
        private System.Windows.Forms.GroupBox gbSnabbVal;
        private System.Windows.Forms.ComboBox cbTillhorighet;
        private System.Windows.Forms.Label laTillhorighet;
        private System.Windows.Forms.TextBox txtEfternamn;
        private System.Windows.Forms.Label laEfternamn;
        private System.Windows.Forms.TextBox txtOvrigt;
        private System.Windows.Forms.Label laOvrigt;
        private System.Windows.Forms.TextBox txtFornamn;
        private System.Windows.Forms.Label laFornamn;
        private System.Windows.Forms.ErrorProvider errorFornamn;
        private System.Windows.Forms.ErrorProvider errorEfternamn;
        private System.Windows.Forms.ErrorProvider errorTillhorighet;
    }
}