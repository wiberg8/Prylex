
namespace ScannerDialog.Forms
{
    partial class LicensDialog
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
            this.cmdOk = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.laKundNamn = new System.Windows.Forms.Label();
            this.laPinKod = new System.Windows.Forms.Label();
            this.txtPinKod = new System.Windows.Forms.TextBox();
            this.txtKundNamn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdOk
            // 
            this.cmdOk.Location = new System.Drawing.Point(37, 127);
            this.cmdOk.Margin = new System.Windows.Forms.Padding(4);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(237, 28);
            this.cmdOk.TabIndex = 2;
            this.cmdOk.Text = "Ok";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(282, 127);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(197, 28);
            this.cmdCancel.TabIndex = 3;
            this.cmdCancel.Text = "Avbryt";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // laKundNamn
            // 
            this.laKundNamn.AutoSize = true;
            this.laKundNamn.Location = new System.Drawing.Point(34, 22);
            this.laKundNamn.Name = "laKundNamn";
            this.laKundNamn.Size = new System.Drawing.Size(77, 16);
            this.laKundNamn.TabIndex = 6;
            this.laKundNamn.Text = "Kund namn:";
            // 
            // laPinKod
            // 
            this.laPinKod.AutoSize = true;
            this.laPinKod.Location = new System.Drawing.Point(34, 72);
            this.laPinKod.Name = "laPinKod";
            this.laPinKod.Size = new System.Drawing.Size(56, 16);
            this.laPinKod.TabIndex = 8;
            this.laPinKod.Text = "Pin kod:";
            // 
            // txtPinKod
            // 
            this.txtPinKod.Location = new System.Drawing.Point(37, 92);
            this.txtPinKod.Margin = new System.Windows.Forms.Padding(4);
            this.txtPinKod.Name = "txtPinKod";
            this.txtPinKod.Size = new System.Drawing.Size(441, 22);
            this.txtPinKod.TabIndex = 1;
            // 
            // txtKundNamn
            // 
            this.txtKundNamn.Location = new System.Drawing.Point(37, 42);
            this.txtKundNamn.Margin = new System.Windows.Forms.Padding(4);
            this.txtKundNamn.Name = "txtKundNamn";
            this.txtKundNamn.Size = new System.Drawing.Size(441, 22);
            this.txtKundNamn.TabIndex = 0;
            // 
            // LicensDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 180);
            this.Controls.Add(this.laPinKod);
            this.Controls.Add(this.txtPinKod);
            this.Controls.Add(this.laKundNamn);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.txtKundNamn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LicensDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LicensDialog_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Label laKundNamn;
        private System.Windows.Forms.Label laPinKod;
        private System.Windows.Forms.TextBox txtPinKod;
        private System.Windows.Forms.TextBox txtKundNamn;
    }
}