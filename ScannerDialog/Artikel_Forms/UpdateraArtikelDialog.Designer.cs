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
            this.cmdAvbryt = new System.Windows.Forms.Button();
            this.lbErrors = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.gbFalt.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // cmdSpara
            // 
            this.cmdSpara.Location = new System.Drawing.Point(444, 278);
            this.cmdSpara.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSpara.Name = "cmdSpara";
            this.cmdSpara.Size = new System.Drawing.Size(117, 28);
            this.cmdSpara.TabIndex = 12;
            this.cmdSpara.Text = "Spara";
            this.cmdSpara.UseVisualStyleBackColor = true;
            this.cmdSpara.Click += new System.EventHandler(this.cmdSpara_Click);
            // 
            // txtOvrigt
            // 
            this.txtOvrigt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOvrigt.HideSelection = false;
            this.txtOvrigt.Location = new System.Drawing.Point(26, 196);
            this.txtOvrigt.Margin = new System.Windows.Forms.Padding(4);
            this.txtOvrigt.Multiline = true;
            this.txtOvrigt.Name = "txtOvrigt";
            this.txtOvrigt.Size = new System.Drawing.Size(384, 80);
            this.txtOvrigt.TabIndex = 8;
            // 
            // laOvrigt
            // 
            this.laOvrigt.AutoSize = true;
            this.laOvrigt.Location = new System.Drawing.Point(22, 176);
            this.laOvrigt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laOvrigt.Name = "laOvrigt";
            this.laOvrigt.Size = new System.Drawing.Size(46, 16);
            this.laOvrigt.TabIndex = 8;
            this.laOvrigt.Text = "Övrigt:";
            // 
            // gbFalt
            // 
            this.gbFalt.Controls.Add(this.cbOS);
            this.gbFalt.Controls.Add(this.laOS);
            this.gbFalt.Controls.Add(this.txtOvrigt);
            this.gbFalt.Controls.Add(this.laOvrigt);
            this.gbFalt.Controls.Add(this.txtStoldtag);
            this.gbFalt.Controls.Add(this.txtDatornamn);
            this.gbFalt.Controls.Add(this.laStoldtag);
            this.gbFalt.Controls.Add(this.laDatornamn);
            this.gbFalt.Location = new System.Drawing.Point(16, 15);
            this.gbFalt.Margin = new System.Windows.Forms.Padding(4);
            this.gbFalt.Name = "gbFalt";
            this.gbFalt.Padding = new System.Windows.Forms.Padding(4);
            this.gbFalt.Size = new System.Drawing.Size(420, 291);
            this.gbFalt.TabIndex = 11;
            this.gbFalt.TabStop = false;
            this.gbFalt.Text = "Info";
            // 
            // txtStoldtag
            // 
            this.txtStoldtag.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStoldtag.HideSelection = false;
            this.txtStoldtag.Location = new System.Drawing.Point(27, 47);
            this.txtStoldtag.Margin = new System.Windows.Forms.Padding(4);
            this.txtStoldtag.Name = "txtStoldtag";
            this.txtStoldtag.Size = new System.Drawing.Size(384, 22);
            this.txtStoldtag.TabIndex = 6;
            // 
            // txtDatornamn
            // 
            this.txtDatornamn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDatornamn.HideSelection = false;
            this.txtDatornamn.Location = new System.Drawing.Point(27, 98);
            this.txtDatornamn.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatornamn.Name = "txtDatornamn";
            this.txtDatornamn.Size = new System.Drawing.Size(384, 22);
            this.txtDatornamn.TabIndex = 7;
            // 
            // laStoldtag
            // 
            this.laStoldtag.AutoSize = true;
            this.laStoldtag.Location = new System.Drawing.Point(24, 27);
            this.laStoldtag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laStoldtag.Name = "laStoldtag";
            this.laStoldtag.Size = new System.Drawing.Size(61, 16);
            this.laStoldtag.TabIndex = 6;
            this.laStoldtag.Text = "Stöldtag:";
            // 
            // laDatornamn
            // 
            this.laDatornamn.AutoSize = true;
            this.laDatornamn.Location = new System.Drawing.Point(23, 79);
            this.laDatornamn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laDatornamn.Name = "laDatornamn";
            this.laDatornamn.Size = new System.Drawing.Size(77, 16);
            this.laDatornamn.TabIndex = 7;
            this.laDatornamn.Text = "Datornamn:";
            // 
            // cbOS
            // 
            this.cbOS.FormattingEnabled = true;
            this.cbOS.Location = new System.Drawing.Point(27, 144);
            this.cbOS.Margin = new System.Windows.Forms.Padding(4);
            this.cbOS.Name = "cbOS";
            this.cbOS.Size = new System.Drawing.Size(275, 24);
            this.cbOS.TabIndex = 2;
            this.cbOS.SelectedIndexChanged += new System.EventHandler(this.cbOS_SelectedIndexChanged);
            // 
            // laOS
            // 
            this.laOS.AutoSize = true;
            this.laOS.Location = new System.Drawing.Point(24, 126);
            this.laOS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laOS.Name = "laOS";
            this.laOS.Size = new System.Drawing.Size(62, 16);
            this.laOS.TabIndex = 2;
            this.laOS.Text = "Operativ:";
            this.laOS.Click += new System.EventHandler(this.laOS_Click);
            // 
            // cmdAvbryt
            // 
            this.cmdAvbryt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdAvbryt.Location = new System.Drawing.Point(627, 278);
            this.cmdAvbryt.Margin = new System.Windows.Forms.Padding(4);
            this.cmdAvbryt.Name = "cmdAvbryt";
            this.cmdAvbryt.Size = new System.Drawing.Size(117, 28);
            this.cmdAvbryt.TabIndex = 13;
            this.cmdAvbryt.Text = "Avbryt";
            this.cmdAvbryt.UseVisualStyleBackColor = true;
            // 
            // lbErrors
            // 
            this.lbErrors.FormattingEnabled = true;
            this.lbErrors.ItemHeight = 16;
            this.lbErrors.Location = new System.Drawing.Point(444, 24);
            this.lbErrors.Margin = new System.Windows.Forms.Padding(4);
            this.lbErrors.Name = "lbErrors";
            this.lbErrors.Size = new System.Drawing.Size(299, 244);
            this.lbErrors.TabIndex = 18;
            // 
            // UpdateraArtikelDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 319);
            this.Controls.Add(this.lbErrors);
            this.Controls.Add(this.cmdSpara);
            this.Controls.Add(this.gbFalt);
            this.Controls.Add(this.cmdAvbryt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "UpdateraArtikelDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.UpdateraArtikelDialog_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UpdateraArtikelDialog_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.gbFalt.ResumeLayout(false);
            this.gbFalt.PerformLayout();
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
        private System.Windows.Forms.ComboBox cbOS;
        private System.Windows.Forms.Label laOS;
        private System.Windows.Forms.Button cmdAvbryt;
        private System.Windows.Forms.ListBox lbErrors;
    }
}