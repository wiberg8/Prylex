namespace ScannerDialog
{
    partial class SnabbRegistering
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
            this.lbRegistreradeArtiklar = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbPersoner = new System.Windows.Forms.ListBox();
            this.cbTillhorighet = new System.Windows.Forms.ComboBox();
            this.laRegistreradeArtiklar = new System.Windows.Forms.Label();
            this.cbPrintOnScan = new System.Windows.Forms.CheckBox();
            this.cmdRegistreraSkanna = new System.Windows.Forms.Button();
            this.cmdRegistreraArtikel = new System.Windows.Forms.Button();
            this.cmdSok = new System.Windows.Forms.Button();
            this.txtSok = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbRegistreradeArtiklar
            // 
            this.lbRegistreradeArtiklar.Enabled = false;
            this.lbRegistreradeArtiklar.FormattingEnabled = true;
            this.lbRegistreradeArtiklar.ItemHeight = 16;
            this.lbRegistreradeArtiklar.Location = new System.Drawing.Point(473, 79);
            this.lbRegistreradeArtiklar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbRegistreradeArtiklar.Name = "lbRegistreradeArtiklar";
            this.lbRegistreradeArtiklar.Size = new System.Drawing.Size(475, 308);
            this.lbRegistreradeArtiklar.TabIndex = 3;
            // 
            // lbPersoner
            // 
            this.lbPersoner.FormattingEnabled = true;
            this.lbPersoner.ItemHeight = 16;
            this.lbPersoner.Location = new System.Drawing.Point(16, 79);
            this.lbPersoner.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbPersoner.Name = "lbPersoner";
            this.lbPersoner.Size = new System.Drawing.Size(448, 308);
            this.lbPersoner.TabIndex = 4;
            this.lbPersoner.SelectedIndexChanged += new System.EventHandler(this.lbPersoner_SelectedIndexChanged);
            // 
            // cbTillhorighet
            // 
            this.cbTillhorighet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTillhorighet.FormattingEnabled = true;
            this.cbTillhorighet.Location = new System.Drawing.Point(16, 47);
            this.cbTillhorighet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTillhorighet.Name = "cbTillhorighet";
            this.cbTillhorighet.Size = new System.Drawing.Size(444, 24);
            this.cbTillhorighet.TabIndex = 18;
            this.cbTillhorighet.SelectedIndexChanged += new System.EventHandler(this.cbTillhorighet_SelectedIndexChanged);
            // 
            // laRegistreradeArtiklar
            // 
            this.laRegistreradeArtiklar.AutoSize = true;
            this.laRegistreradeArtiklar.Location = new System.Drawing.Point(469, 58);
            this.laRegistreradeArtiklar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laRegistreradeArtiklar.Name = "laRegistreradeArtiklar";
            this.laRegistreradeArtiklar.Size = new System.Drawing.Size(130, 16);
            this.laRegistreradeArtiklar.TabIndex = 19;
            this.laRegistreradeArtiklar.Text = "Registrerade artiklar";
            // 
            // cbPrintOnScan
            // 
            this.cbPrintOnScan.AutoSize = true;
            this.cbPrintOnScan.Location = new System.Drawing.Point(772, 53);
            this.cbPrintOnScan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPrintOnScan.Name = "cbPrintOnScan";
            this.cbPrintOnScan.Size = new System.Drawing.Size(161, 20);
            this.cbPrintOnScan.TabIndex = 28;
            this.cbPrintOnScan.Text = "Skriv ut vid registrering";
            this.cbPrintOnScan.UseVisualStyleBackColor = true;
            // 
            // cmdRegistreraSkanna
            // 
            this.cmdRegistreraSkanna.Location = new System.Drawing.Point(591, 12);
            this.cmdRegistreraSkanna.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdRegistreraSkanna.Name = "cmdRegistreraSkanna";
            this.cmdRegistreraSkanna.Size = new System.Drawing.Size(177, 28);
            this.cmdRegistreraSkanna.TabIndex = 27;
            this.cmdRegistreraSkanna.Text = "Registrera (Skanna)";
            this.cmdRegistreraSkanna.UseVisualStyleBackColor = true;
            this.cmdRegistreraSkanna.Click += new System.EventHandler(this.cmdRegistreraSkanna_Click_1);
            // 
            // cmdRegistreraArtikel
            // 
            this.cmdRegistreraArtikel.Location = new System.Drawing.Point(776, 12);
            this.cmdRegistreraArtikel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdRegistreraArtikel.Name = "cmdRegistreraArtikel";
            this.cmdRegistreraArtikel.Size = new System.Drawing.Size(177, 28);
            this.cmdRegistreraArtikel.TabIndex = 26;
            this.cmdRegistreraArtikel.Text = "Registrera";
            this.cmdRegistreraArtikel.UseVisualStyleBackColor = true;
            this.cmdRegistreraArtikel.Click += new System.EventHandler(this.cmdRegistreraArtikel_Click_1);
            // 
            // cmdSok
            // 
            this.cmdSok.Location = new System.Drawing.Point(327, 12);
            this.cmdSok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdSok.Name = "cmdSok";
            this.cmdSok.Size = new System.Drawing.Size(135, 28);
            this.cmdSok.TabIndex = 30;
            this.cmdSok.Text = "Sök";
            this.cmdSok.UseVisualStyleBackColor = true;
            this.cmdSok.Click += new System.EventHandler(this.cmdSok_Click);
            // 
            // txtSok
            // 
            this.txtSok.Location = new System.Drawing.Point(16, 15);
            this.txtSok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSok.Name = "txtSok";
            this.txtSok.Size = new System.Drawing.Size(301, 22);
            this.txtSok.TabIndex = 29;
            // 
            // SnabbRegistering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 401);
            this.Controls.Add(this.cmdSok);
            this.Controls.Add(this.txtSok);
            this.Controls.Add(this.cbPrintOnScan);
            this.Controls.Add(this.cmdRegistreraSkanna);
            this.Controls.Add(this.cmdRegistreraArtikel);
            this.Controls.Add(this.laRegistreradeArtiklar);
            this.Controls.Add(this.cbTillhorighet);
            this.Controls.Add(this.lbPersoner);
            this.Controls.Add(this.lbRegistreradeArtiklar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SnabbRegistering";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.HanteraPersonDialogcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbRegistreradeArtiklar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListBox lbPersoner;
        private System.Windows.Forms.ComboBox cbTillhorighet;
        private System.Windows.Forms.Label laRegistreradeArtiklar;
        private System.Windows.Forms.CheckBox cbPrintOnScan;
        private System.Windows.Forms.Button cmdRegistreraSkanna;
        private System.Windows.Forms.Button cmdRegistreraArtikel;
        private System.Windows.Forms.Button cmdSok;
        private System.Windows.Forms.TextBox txtSok;
    }
}