
namespace ScannerDialog.Forms
{
    partial class ImportResultDialog
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
            this.lbPersonerErrosSuccess = new System.Windows.Forms.ListBox();
            this.rbLyckade = new System.Windows.Forms.RadioButton();
            this.rbMisslyckade = new System.Windows.Forms.RadioButton();
            this.rbExists = new System.Windows.Forms.RadioButton();
            this.lbPersonErrors = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbPersonerErrosSuccess
            // 
            this.lbPersonerErrosSuccess.FormattingEnabled = true;
            this.lbPersonerErrosSuccess.Location = new System.Drawing.Point(25, 46);
            this.lbPersonerErrosSuccess.Name = "lbPersonerErrosSuccess";
            this.lbPersonerErrosSuccess.Size = new System.Drawing.Size(406, 277);
            this.lbPersonerErrosSuccess.TabIndex = 7;
            this.lbPersonerErrosSuccess.SelectedIndexChanged += new System.EventHandler(this.lbPersonerErrosSuccess_SelectedIndexChanged);
            // 
            // rbLyckade
            // 
            this.rbLyckade.AutoSize = true;
            this.rbLyckade.Checked = true;
            this.rbLyckade.Location = new System.Drawing.Point(25, 26);
            this.rbLyckade.Name = "rbLyckade";
            this.rbLyckade.Size = new System.Drawing.Size(85, 17);
            this.rbLyckade.TabIndex = 13;
            this.rbLyckade.TabStop = true;
            this.rbLyckade.Text = "Visa lyckade";
            this.rbLyckade.UseVisualStyleBackColor = true;
            this.rbLyckade.CheckedChanged += new System.EventHandler(this.rbLyckade_CheckedChanged);
            // 
            // rbMisslyckade
            // 
            this.rbMisslyckade.AutoSize = true;
            this.rbMisslyckade.Location = new System.Drawing.Point(116, 26);
            this.rbMisslyckade.Name = "rbMisslyckade";
            this.rbMisslyckade.Size = new System.Drawing.Size(105, 17);
            this.rbMisslyckade.TabIndex = 14;
            this.rbMisslyckade.Text = "Visa misslyckade";
            this.rbMisslyckade.UseVisualStyleBackColor = true;
            this.rbMisslyckade.CheckedChanged += new System.EventHandler(this.rbMisslyckade_CheckedChanged);
            // 
            // rbExists
            // 
            this.rbExists.AutoSize = true;
            this.rbExists.Location = new System.Drawing.Point(227, 26);
            this.rbExists.Name = "rbExists";
            this.rbExists.Size = new System.Drawing.Size(132, 17);
            this.rbExists.TabIndex = 15;
            this.rbExists.Text = "Visa redan existerande";
            this.rbExists.UseVisualStyleBackColor = true;
            this.rbExists.CheckedChanged += new System.EventHandler(this.rbExists_CheckedChanged_1);
            // 
            // lbPersonErrors
            // 
            this.lbPersonErrors.FormattingEnabled = true;
            this.lbPersonErrors.Location = new System.Drawing.Point(437, 46);
            this.lbPersonErrors.Name = "lbPersonErrors";
            this.lbPersonErrors.Size = new System.Drawing.Size(406, 277);
            this.lbPersonErrors.TabIndex = 17;
            // 
            // ImportResultDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 336);
            this.Controls.Add(this.lbPersonErrors);
            this.Controls.Add(this.rbExists);
            this.Controls.Add(this.rbMisslyckade);
            this.Controls.Add(this.rbLyckade);
            this.Controls.Add(this.lbPersonerErrosSuccess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ImportResultDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ImportResultDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbPersonerErrosSuccess;
        private System.Windows.Forms.RadioButton rbLyckade;
        private System.Windows.Forms.RadioButton rbMisslyckade;
        private System.Windows.Forms.RadioButton rbExists;
        private System.Windows.Forms.ListBox lbPersonErrors;
    }
}