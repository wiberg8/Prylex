using System;

namespace ScannerDialog
{
    partial class BytDatabasForm
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
            this.cmdCloseApplication = new System.Windows.Forms.Button();
            this.cmdUtforska = new System.Windows.Forms.Button();
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.laImportFil = new System.Windows.Forms.Label();
            this.txtImportFil = new System.Windows.Forms.TextBox();
            this.cmdCreateDb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdCloseApplication
            // 
            this.cmdCloseApplication.Location = new System.Drawing.Point(415, 73);
            this.cmdCloseApplication.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCloseApplication.Name = "cmdCloseApplication";
            this.cmdCloseApplication.Size = new System.Drawing.Size(100, 28);
            this.cmdCloseApplication.TabIndex = 19;
            this.cmdCloseApplication.Text = "Avsluta";
            this.cmdCloseApplication.UseVisualStyleBackColor = true;
            this.cmdCloseApplication.Click += new System.EventHandler(this.cmdCloseApplication_Click);
            // 
            // cmdUtforska
            // 
            this.cmdUtforska.Location = new System.Drawing.Point(13, 73);
            this.cmdUtforska.Margin = new System.Windows.Forms.Padding(4);
            this.cmdUtforska.Name = "cmdUtforska";
            this.cmdUtforska.Size = new System.Drawing.Size(100, 28);
            this.cmdUtforska.TabIndex = 17;
            this.cmdUtforska.Text = "Utforska";
            this.cmdUtforska.UseVisualStyleBackColor = true;
            this.cmdUtforska.Click += new System.EventHandler(this.cmdUtforska_Click);
            // 
            // laImportFil
            // 
            this.laImportFil.AutoSize = true;
            this.laImportFil.Location = new System.Drawing.Point(9, 19);
            this.laImportFil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laImportFil.Name = "laImportFil";
            this.laImportFil.Size = new System.Drawing.Size(216, 16);
            this.laImportFil.TabIndex = 22;
            this.laImportFil.Text = "Du måste välja / skapa en databas";
            // 
            // txtImportFil
            // 
            this.txtImportFil.Location = new System.Drawing.Point(13, 43);
            this.txtImportFil.Margin = new System.Windows.Forms.Padding(4);
            this.txtImportFil.Name = "txtImportFil";
            this.txtImportFil.ReadOnly = true;
            this.txtImportFil.Size = new System.Drawing.Size(502, 22);
            this.txtImportFil.TabIndex = 21;
            this.txtImportFil.TabStop = false;
            this.txtImportFil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdCreateDb
            // 
            this.cmdCreateDb.Location = new System.Drawing.Point(121, 73);
            this.cmdCreateDb.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCreateDb.Name = "cmdCreateDb";
            this.cmdCreateDb.Size = new System.Drawing.Size(100, 28);
            this.cmdCreateDb.TabIndex = 23;
            this.cmdCreateDb.Text = "Skapa";
            this.cmdCreateDb.UseVisualStyleBackColor = true;
            this.cmdCreateDb.Click += new System.EventHandler(this.cmdCreateDb_Click);
            // 
            // BytDatabasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 106);
            this.Controls.Add(this.cmdCreateDb);
            this.Controls.Add(this.laImportFil);
            this.Controls.Add(this.txtImportFil);
            this.Controls.Add(this.cmdCloseApplication);
            this.Controls.Add(this.cmdUtforska);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "BytDatabasForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdUtforska;
        private System.Windows.Forms.Button cmdCloseApplication;
        private System.Windows.Forms.ToolTip toolTipHelp;
        private System.Windows.Forms.Label laImportFil;
        private System.Windows.Forms.TextBox txtImportFil;
        private System.Windows.Forms.Button cmdCreateDb;
    }
}