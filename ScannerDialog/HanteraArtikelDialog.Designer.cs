namespace ScannerDialog
{
    partial class HanteraArtikelDialog
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
            this.gbRegisterPerson = new System.Windows.Forms.GroupBox();
            this.txtRegistredPerson = new System.Windows.Forms.TextBox();
            this.cmdRegisterPerson = new System.Windows.Forms.Button();
            this.cmdUnregisterPerson = new System.Windows.Forms.Button();
            this.laArtikelId = new System.Windows.Forms.Label();
            this.laMAC = new System.Windows.Forms.Label();
            this.laOvrigt = new System.Windows.Forms.Label();
            this.gbFalt = new System.Windows.Forms.GroupBox();
            this.laInkopDisplay = new System.Windows.Forms.Label();
            this.laOSDisplay = new System.Windows.Forms.Label();
            this.laArtikelDisplay = new System.Windows.Forms.Label();
            this.laBeskrivningDisplay = new System.Windows.Forms.Label();
            this.laInkop = new System.Windows.Forms.Label();
            this.laOvrigtDisplay = new System.Windows.Forms.Label();
            this.laDatornamnDisplay = new System.Windows.Forms.Label();
            this.laOS = new System.Windows.Forms.Label();
            this.laStoldtagDisplay = new System.Windows.Forms.Label();
            this.laMACDisplay = new System.Windows.Forms.Label();
            this.laBeskrivning = new System.Windows.Forms.Label();
            this.laSerieNrDisplay = new System.Windows.Forms.Label();
            this.laStoldtag = new System.Windows.Forms.Label();
            this.laDatornamn = new System.Windows.Forms.Label();
            this.laSerieNr = new System.Windows.Forms.Label();
            this.cmdAvbryt = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.gbRegisterPerson.SuspendLayout();
            this.gbFalt.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRegisterPerson
            // 
            this.gbRegisterPerson.Controls.Add(this.txtRegistredPerson);
            this.gbRegisterPerson.Controls.Add(this.cmdRegisterPerson);
            this.gbRegisterPerson.Controls.Add(this.cmdUnregisterPerson);
            this.gbRegisterPerson.Location = new System.Drawing.Point(12, 245);
            this.gbRegisterPerson.Name = "gbRegisterPerson";
            this.gbRegisterPerson.Size = new System.Drawing.Size(330, 79);
            this.gbRegisterPerson.TabIndex = 13;
            this.gbRegisterPerson.TabStop = false;
            this.gbRegisterPerson.Text = "Registrera / Avregistrera person";
            // 
            // txtRegistredPerson
            // 
            this.txtRegistredPerson.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegistredPerson.HideSelection = false;
            this.txtRegistredPerson.Location = new System.Drawing.Point(13, 19);
            this.txtRegistredPerson.Name = "txtRegistredPerson";
            this.txtRegistredPerson.ReadOnly = true;
            this.txtRegistredPerson.Size = new System.Drawing.Size(309, 20);
            this.txtRegistredPerson.TabIndex = 14;
            // 
            // cmdRegisterPerson
            // 
            this.cmdRegisterPerson.Location = new System.Drawing.Point(13, 45);
            this.cmdRegisterPerson.Name = "cmdRegisterPerson";
            this.cmdRegisterPerson.Size = new System.Drawing.Size(89, 23);
            this.cmdRegisterPerson.TabIndex = 14;
            this.cmdRegisterPerson.Text = "Registrera...";
            this.cmdRegisterPerson.UseVisualStyleBackColor = true;
            this.cmdRegisterPerson.Click += new System.EventHandler(this.cmdRegisterPerson_Click);
            // 
            // cmdUnregisterPerson
            // 
            this.cmdUnregisterPerson.Location = new System.Drawing.Point(233, 46);
            this.cmdUnregisterPerson.Name = "cmdUnregisterPerson";
            this.cmdUnregisterPerson.Size = new System.Drawing.Size(89, 23);
            this.cmdUnregisterPerson.TabIndex = 13;
            this.cmdUnregisterPerson.Text = "Avregistrera...";
            this.cmdUnregisterPerson.UseVisualStyleBackColor = true;
            this.cmdUnregisterPerson.Click += new System.EventHandler(this.cmdUnregisterPerson_Click);
            // 
            // laArtikelId
            // 
            this.laArtikelId.Location = new System.Drawing.Point(12, 22);
            this.laArtikelId.Name = "laArtikelId";
            this.laArtikelId.Size = new System.Drawing.Size(65, 13);
            this.laArtikelId.TabIndex = 24;
            this.laArtikelId.Text = "Id:";
            // 
            // laMAC
            // 
            this.laMAC.AutoSize = true;
            this.laMAC.Location = new System.Drawing.Point(12, 122);
            this.laMAC.Name = "laMAC";
            this.laMAC.Size = new System.Drawing.Size(68, 13);
            this.laMAC.TabIndex = 5;
            this.laMAC.Text = "MAC-Adress:";
            // 
            // laOvrigt
            // 
            this.laOvrigt.AutoSize = true;
            this.laOvrigt.Location = new System.Drawing.Point(12, 182);
            this.laOvrigt.Name = "laOvrigt";
            this.laOvrigt.Size = new System.Drawing.Size(38, 13);
            this.laOvrigt.TabIndex = 8;
            this.laOvrigt.Text = "Övrigt:";
            // 
            // gbFalt
            // 
            this.gbFalt.Controls.Add(this.cmdEdit);
            this.gbFalt.Controls.Add(this.laArtikelId);
            this.gbFalt.Controls.Add(this.laInkopDisplay);
            this.gbFalt.Controls.Add(this.laOSDisplay);
            this.gbFalt.Controls.Add(this.laArtikelDisplay);
            this.gbFalt.Controls.Add(this.laBeskrivningDisplay);
            this.gbFalt.Controls.Add(this.laInkop);
            this.gbFalt.Controls.Add(this.laOvrigtDisplay);
            this.gbFalt.Controls.Add(this.laDatornamnDisplay);
            this.gbFalt.Controls.Add(this.laOS);
            this.gbFalt.Controls.Add(this.laStoldtagDisplay);
            this.gbFalt.Controls.Add(this.laMACDisplay);
            this.gbFalt.Controls.Add(this.laBeskrivning);
            this.gbFalt.Controls.Add(this.laSerieNrDisplay);
            this.gbFalt.Controls.Add(this.laMAC);
            this.gbFalt.Controls.Add(this.laOvrigt);
            this.gbFalt.Controls.Add(this.laStoldtag);
            this.gbFalt.Controls.Add(this.laDatornamn);
            this.gbFalt.Controls.Add(this.laSerieNr);
            this.gbFalt.Location = new System.Drawing.Point(12, 8);
            this.gbFalt.Name = "gbFalt";
            this.gbFalt.Size = new System.Drawing.Size(330, 231);
            this.gbFalt.TabIndex = 19;
            this.gbFalt.TabStop = false;
            this.gbFalt.Text = "Info";
            // 
            // laInkopDisplay
            // 
            this.laInkopDisplay.Location = new System.Drawing.Point(93, 162);
            this.laInkopDisplay.Name = "laInkopDisplay";
            this.laInkopDisplay.Size = new System.Drawing.Size(189, 13);
            this.laInkopDisplay.TabIndex = 31;
            this.laInkopDisplay.Text = "Display";
            this.toolTipHelp.SetToolTip(this.laInkopDisplay, "Kopiera (Dubbelklicka)");
            this.laInkopDisplay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.laDisplay_DoubleClick);
            // 
            // laOSDisplay
            // 
            this.laOSDisplay.Location = new System.Drawing.Point(93, 142);
            this.laOSDisplay.Name = "laOSDisplay";
            this.laOSDisplay.Size = new System.Drawing.Size(189, 13);
            this.laOSDisplay.TabIndex = 30;
            this.laOSDisplay.Text = "Display";
            this.toolTipHelp.SetToolTip(this.laOSDisplay, "Kopiera (Dubbelklicka)");
            this.laOSDisplay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.laDisplay_DoubleClick);
            // 
            // laArtikelDisplay
            // 
            this.laArtikelDisplay.Location = new System.Drawing.Point(93, 22);
            this.laArtikelDisplay.Name = "laArtikelDisplay";
            this.laArtikelDisplay.Size = new System.Drawing.Size(189, 13);
            this.laArtikelDisplay.TabIndex = 32;
            this.laArtikelDisplay.Text = "Display";
            this.toolTipHelp.SetToolTip(this.laArtikelDisplay, "Kopiera (Dubbelklicka)");
            this.laArtikelDisplay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.laDisplay_DoubleClick);
            // 
            // laBeskrivningDisplay
            // 
            this.laBeskrivningDisplay.Location = new System.Drawing.Point(93, 42);
            this.laBeskrivningDisplay.Name = "laBeskrivningDisplay";
            this.laBeskrivningDisplay.Size = new System.Drawing.Size(189, 13);
            this.laBeskrivningDisplay.TabIndex = 29;
            this.laBeskrivningDisplay.Text = "Display";
            this.toolTipHelp.SetToolTip(this.laBeskrivningDisplay, "Kopiera (Dubbelklicka)");
            this.laBeskrivningDisplay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.laDisplay_DoubleClick);
            // 
            // laInkop
            // 
            this.laInkop.AutoSize = true;
            this.laInkop.Location = new System.Drawing.Point(12, 162);
            this.laInkop.Name = "laInkop";
            this.laInkop.Size = new System.Drawing.Size(76, 13);
            this.laInkop.TabIndex = 3;
            this.laInkop.Text = "Inköps Datum:";
            // 
            // laOvrigtDisplay
            // 
            this.laOvrigtDisplay.Location = new System.Drawing.Point(93, 182);
            this.laOvrigtDisplay.Name = "laOvrigtDisplay";
            this.laOvrigtDisplay.Size = new System.Drawing.Size(189, 13);
            this.laOvrigtDisplay.TabIndex = 27;
            this.laOvrigtDisplay.Text = "Display";
            this.toolTipHelp.SetToolTip(this.laOvrigtDisplay, "Kopiera (Dubbelklicka)");
            this.laOvrigtDisplay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.laDisplay_DoubleClick);
            // 
            // laDatornamnDisplay
            // 
            this.laDatornamnDisplay.Location = new System.Drawing.Point(93, 62);
            this.laDatornamnDisplay.Name = "laDatornamnDisplay";
            this.laDatornamnDisplay.Size = new System.Drawing.Size(189, 13);
            this.laDatornamnDisplay.TabIndex = 26;
            this.laDatornamnDisplay.Text = "Display";
            this.toolTipHelp.SetToolTip(this.laDatornamnDisplay, "Kopiera (Dubbelklicka)");
            this.laDatornamnDisplay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.laDisplay_DoubleClick);
            // 
            // laOS
            // 
            this.laOS.AutoSize = true;
            this.laOS.Location = new System.Drawing.Point(12, 142);
            this.laOS.Name = "laOS";
            this.laOS.Size = new System.Drawing.Size(25, 13);
            this.laOS.TabIndex = 2;
            this.laOS.Text = "OS:";
            // 
            // laStoldtagDisplay
            // 
            this.laStoldtagDisplay.Location = new System.Drawing.Point(93, 82);
            this.laStoldtagDisplay.Name = "laStoldtagDisplay";
            this.laStoldtagDisplay.Size = new System.Drawing.Size(189, 13);
            this.laStoldtagDisplay.TabIndex = 25;
            this.laStoldtagDisplay.Text = "Display";
            this.toolTipHelp.SetToolTip(this.laStoldtagDisplay, "Kopiera (Dubbelklicka)");
            this.laStoldtagDisplay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.laDisplay_DoubleClick);
            // 
            // laMACDisplay
            // 
            this.laMACDisplay.Location = new System.Drawing.Point(93, 122);
            this.laMACDisplay.Name = "laMACDisplay";
            this.laMACDisplay.Size = new System.Drawing.Size(189, 13);
            this.laMACDisplay.TabIndex = 24;
            this.laMACDisplay.Text = "Display";
            this.toolTipHelp.SetToolTip(this.laMACDisplay, "Kopiera (Dubbelklicka)");
            this.laMACDisplay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.laDisplay_DoubleClick);
            // 
            // laBeskrivning
            // 
            this.laBeskrivning.AutoSize = true;
            this.laBeskrivning.Location = new System.Drawing.Point(12, 42);
            this.laBeskrivning.Name = "laBeskrivning";
            this.laBeskrivning.Size = new System.Drawing.Size(65, 13);
            this.laBeskrivning.TabIndex = 0;
            this.laBeskrivning.Text = "Beskrivning:";
            // 
            // laSerieNrDisplay
            // 
            this.laSerieNrDisplay.Location = new System.Drawing.Point(93, 102);
            this.laSerieNrDisplay.Name = "laSerieNrDisplay";
            this.laSerieNrDisplay.Size = new System.Drawing.Size(189, 13);
            this.laSerieNrDisplay.TabIndex = 23;
            this.laSerieNrDisplay.Text = "Display";
            this.toolTipHelp.SetToolTip(this.laSerieNrDisplay, "Kopiera (Dubbelklicka)");
            this.laSerieNrDisplay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.laDisplay_DoubleClick);
            // 
            // laStoldtag
            // 
            this.laStoldtag.AutoSize = true;
            this.laStoldtag.Location = new System.Drawing.Point(12, 82);
            this.laStoldtag.Name = "laStoldtag";
            this.laStoldtag.Size = new System.Drawing.Size(49, 13);
            this.laStoldtag.TabIndex = 6;
            this.laStoldtag.Text = "Stöldtag:";
            // 
            // laDatornamn
            // 
            this.laDatornamn.AutoSize = true;
            this.laDatornamn.Location = new System.Drawing.Point(12, 62);
            this.laDatornamn.Name = "laDatornamn";
            this.laDatornamn.Size = new System.Drawing.Size(62, 13);
            this.laDatornamn.TabIndex = 7;
            this.laDatornamn.Text = "Datornamn:";
            // 
            // laSerieNr
            // 
            this.laSerieNr.AutoSize = true;
            this.laSerieNr.Location = new System.Drawing.Point(12, 102);
            this.laSerieNr.Name = "laSerieNr";
            this.laSerieNr.Size = new System.Drawing.Size(45, 13);
            this.laSerieNr.TabIndex = 4;
            this.laSerieNr.Text = "SerieNr:";
            // 
            // cmdAvbryt
            // 
            this.cmdAvbryt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdAvbryt.Location = new System.Drawing.Point(578, 300);
            this.cmdAvbryt.Name = "cmdAvbryt";
            this.cmdAvbryt.Size = new System.Drawing.Size(88, 23);
            this.cmdAvbryt.TabIndex = 22;
            this.cmdAvbryt.Text = "Avbryt";
            this.cmdAvbryt.UseVisualStyleBackColor = true;
            this.cmdAvbryt.Click += new System.EventHandler(this.cmdAvbryt_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.Location = new System.Drawing.Point(233, 198);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(89, 23);
            this.cmdEdit.TabIndex = 15;
            this.cmdEdit.Text = "Ändra..";
            this.cmdEdit.UseVisualStyleBackColor = true;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // HanteraArtikelDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 335);
            this.Controls.Add(this.cmdAvbryt);
            this.Controls.Add(this.gbFalt);
            this.Controls.Add(this.gbRegisterPerson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HanteraArtikelDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ManageArticle_Load);
            this.gbRegisterPerson.ResumeLayout(false);
            this.gbRegisterPerson.PerformLayout();
            this.gbFalt.ResumeLayout(false);
            this.gbFalt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbRegisterPerson;
        private System.Windows.Forms.Button cmdUnregisterPerson;
        private System.Windows.Forms.Button cmdRegisterPerson;
        private System.Windows.Forms.TextBox txtRegistredPerson;
        private System.Windows.Forms.Label laArtikelId;
        private System.Windows.Forms.GroupBox gbFalt;
        private System.Windows.Forms.Label laMAC;
        private System.Windows.Forms.Label laOvrigt;
        private System.Windows.Forms.Label laStoldtag;
        private System.Windows.Forms.Label laDatornamn;
        private System.Windows.Forms.Label laSerieNr;
        private System.Windows.Forms.Label laOS;
        private System.Windows.Forms.Label laInkop;
        private System.Windows.Forms.Label laBeskrivning;
        private System.Windows.Forms.Button cmdAvbryt;
        private System.Windows.Forms.Label laBeskrivningDisplay;
        private System.Windows.Forms.Label laOvrigtDisplay;
        private System.Windows.Forms.Label laDatornamnDisplay;
        private System.Windows.Forms.Label laStoldtagDisplay;
        private System.Windows.Forms.Label laMACDisplay;
        private System.Windows.Forms.Label laSerieNrDisplay;
        private System.Windows.Forms.Label laInkopDisplay;
        private System.Windows.Forms.Label laOSDisplay;
        private System.Windows.Forms.Label laArtikelDisplay;
        private System.Windows.Forms.Button cmdEdit;
        private System.Windows.Forms.ToolTip toolTipHelp;
    }
}