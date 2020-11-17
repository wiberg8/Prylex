namespace ScannerDialog
{
    partial class ProduktAktiveringsDialog
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
            this.laTitel = new System.Windows.Forms.Label();
            this.txtUUId = new System.Windows.Forms.TextBox();
            this.txtAktiveringsNyckel = new System.Windows.Forms.TextBox();
            this.cmdAktivera = new System.Windows.Forms.Button();
            this.laAktiveringsNyckel = new System.Windows.Forms.Label();
            this.laUUId = new System.Windows.Forms.Label();
            this.cmdUUIdKopiera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // laTitel
            // 
            this.laTitel.AutoSize = true;
            this.laTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTitel.Location = new System.Drawing.Point(159, 9);
            this.laTitel.Name = "laTitel";
            this.laTitel.Size = new System.Drawing.Size(134, 20);
            this.laTitel.TabIndex = 0;
            this.laTitel.Text = "Prylan - Aktivering";
            // 
            // txtUUId
            // 
            this.txtUUId.Location = new System.Drawing.Point(22, 61);
            this.txtUUId.Name = "txtUUId";
            this.txtUUId.ReadOnly = true;
            this.txtUUId.Size = new System.Drawing.Size(388, 20);
            this.txtUUId.TabIndex = 1;
            this.txtUUId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAktiveringsNyckel
            // 
            this.txtAktiveringsNyckel.Location = new System.Drawing.Point(22, 118);
            this.txtAktiveringsNyckel.Name = "txtAktiveringsNyckel";
            this.txtAktiveringsNyckel.Size = new System.Drawing.Size(388, 20);
            this.txtAktiveringsNyckel.TabIndex = 2;
            this.txtAktiveringsNyckel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdAktivera
            // 
            this.cmdAktivera.Location = new System.Drawing.Point(286, 144);
            this.cmdAktivera.Name = "cmdAktivera";
            this.cmdAktivera.Size = new System.Drawing.Size(124, 23);
            this.cmdAktivera.TabIndex = 3;
            this.cmdAktivera.Text = "Aktivera";
            this.cmdAktivera.UseVisualStyleBackColor = true;
            this.cmdAktivera.Click += new System.EventHandler(this.cmdAktivera_Click);
            // 
            // laAktiveringsNyckel
            // 
            this.laAktiveringsNyckel.AutoSize = true;
            this.laAktiveringsNyckel.Location = new System.Drawing.Point(19, 101);
            this.laAktiveringsNyckel.Name = "laAktiveringsNyckel";
            this.laAktiveringsNyckel.Size = new System.Drawing.Size(80, 13);
            this.laAktiveringsNyckel.TabIndex = 4;
            this.laAktiveringsNyckel.Text = "Aktiveringskod:";
            // 
            // laUUId
            // 
            this.laUUId.AutoSize = true;
            this.laUUId.Location = new System.Drawing.Point(19, 45);
            this.laUUId.Name = "laUUId";
            this.laUUId.Size = new System.Drawing.Size(318, 13);
            this.laUUId.TabIndex = 5;
            this.laUUId.Text = "Ditt dator id (Den kod som mailas till prylan.aktivering@gmail.com):";
            // 
            // cmdUUIdKopiera
            // 
            this.cmdUUIdKopiera.Location = new System.Drawing.Point(286, 87);
            this.cmdUUIdKopiera.Name = "cmdUUIdKopiera";
            this.cmdUUIdKopiera.Size = new System.Drawing.Size(124, 23);
            this.cmdUUIdKopiera.TabIndex = 6;
            this.cmdUUIdKopiera.Text = "Kopiera";
            this.cmdUUIdKopiera.UseVisualStyleBackColor = true;
            this.cmdUUIdKopiera.Click += new System.EventHandler(this.cmdUUIdKopiera_Click);
            // 
            // ProduktAktiveringsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 175);
            this.Controls.Add(this.cmdUUIdKopiera);
            this.Controls.Add(this.laUUId);
            this.Controls.Add(this.laAktiveringsNyckel);
            this.Controls.Add(this.cmdAktivera);
            this.Controls.Add(this.txtAktiveringsNyckel);
            this.Controls.Add(this.txtUUId);
            this.Controls.Add(this.laTitel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ProduktAktiveringsDialog";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.ProduktAktiveringsDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laTitel;
        private System.Windows.Forms.TextBox txtUUId;
        private System.Windows.Forms.TextBox txtAktiveringsNyckel;
        private System.Windows.Forms.Button cmdAktivera;
        private System.Windows.Forms.Label laAktiveringsNyckel;
        private System.Windows.Forms.Label laUUId;
        private System.Windows.Forms.Button cmdUUIdKopiera;
    }
}