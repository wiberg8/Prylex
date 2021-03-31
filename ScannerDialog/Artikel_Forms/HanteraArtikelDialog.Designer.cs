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
            this.cmdRegistreraScanna = new System.Windows.Forms.Button();
            this.cmdSkrivUtEttiket = new System.Windows.Forms.Button();
            this.txtRegistredPerson = new System.Windows.Forms.TextBox();
            this.cmdRegisterPerson = new System.Windows.Forms.Button();
            this.cmdUnregisterPerson = new System.Windows.Forms.Button();
            this.laArtikelId = new System.Windows.Forms.Label();
            this.laMAC = new System.Windows.Forms.Label();
            this.laOvrigt = new System.Windows.Forms.Label();
            this.gbFalt = new System.Windows.Forms.GroupBox();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
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
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHandelsePerson = new System.Windows.Forms.TextBox();
            this.lbHandelser = new System.Windows.Forms.ListBox();
            this.cmdNyHandelse = new System.Windows.Forms.Button();
            this.laHandelsePersId = new System.Windows.Forms.Label();
            this.cmdEttiketSerieNr = new System.Windows.Forms.Button();
            this.gbRegisterPerson.SuspendLayout();
            this.gbFalt.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRegisterPerson
            // 
            this.gbRegisterPerson.Controls.Add(this.cmdEttiketSerieNr);
            this.gbRegisterPerson.Controls.Add(this.cmdRegistreraScanna);
            this.gbRegisterPerson.Controls.Add(this.cmdSkrivUtEttiket);
            this.gbRegisterPerson.Controls.Add(this.txtRegistredPerson);
            this.gbRegisterPerson.Controls.Add(this.cmdRegisterPerson);
            this.gbRegisterPerson.Controls.Add(this.cmdUnregisterPerson);
            this.gbRegisterPerson.Location = new System.Drawing.Point(12, 249);
            this.gbRegisterPerson.Name = "gbRegisterPerson";
            this.gbRegisterPerson.Size = new System.Drawing.Size(330, 122);
            this.gbRegisterPerson.TabIndex = 13;
            this.gbRegisterPerson.TabStop = false;
            this.gbRegisterPerson.Text = "Registrera / Avregistrera person";
            // 
            // cmdRegistreraScanna
            // 
            this.cmdRegistreraScanna.Location = new System.Drawing.Point(13, 69);
            this.cmdRegistreraScanna.Name = "cmdRegistreraScanna";
            this.cmdRegistreraScanna.Size = new System.Drawing.Size(150, 23);
            this.cmdRegistreraScanna.TabIndex = 16;
            this.cmdRegistreraScanna.Text = "Registrera (Scanna)";
            this.cmdRegistreraScanna.UseVisualStyleBackColor = true;
            this.cmdRegistreraScanna.Click += new System.EventHandler(this.cmdRegistreraScanna_Click);
            // 
            // cmdSkrivUtEttiket
            // 
            this.cmdSkrivUtEttiket.Location = new System.Drawing.Point(169, 69);
            this.cmdSkrivUtEttiket.Name = "cmdSkrivUtEttiket";
            this.cmdSkrivUtEttiket.Size = new System.Drawing.Size(153, 23);
            this.cmdSkrivUtEttiket.TabIndex = 15;
            this.cmdSkrivUtEttiket.Text = "Ettiket (Streckkod / Namn)";
            this.cmdSkrivUtEttiket.UseVisualStyleBackColor = true;
            this.cmdSkrivUtEttiket.Click += new System.EventHandler(this.cmdSkrivUtEttiket_Click);
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
            this.cmdRegisterPerson.Size = new System.Drawing.Size(150, 23);
            this.cmdRegisterPerson.TabIndex = 14;
            this.cmdRegisterPerson.Text = "Registrera...";
            this.cmdRegisterPerson.UseVisualStyleBackColor = true;
            this.cmdRegisterPerson.Click += new System.EventHandler(this.cmdRegisterPerson_Click);
            // 
            // cmdUnregisterPerson
            // 
            this.cmdUnregisterPerson.Location = new System.Drawing.Point(169, 46);
            this.cmdUnregisterPerson.Name = "cmdUnregisterPerson";
            this.cmdUnregisterPerson.Size = new System.Drawing.Size(153, 23);
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
            this.gbFalt.Controls.Add(this.cmdDelete);
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
            this.gbFalt.Size = new System.Drawing.Size(330, 235);
            this.gbFalt.TabIndex = 19;
            this.gbFalt.TabStop = false;
            this.gbFalt.Text = "Info";
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(13, 201);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(89, 23);
            this.cmdDelete.TabIndex = 33;
            this.cmdDelete.Text = "Radera";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.Location = new System.Drawing.Point(235, 201);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(89, 23);
            this.cmdEdit.TabIndex = 15;
            this.cmdEdit.Text = "Ändra..";
            this.cmdEdit.UseVisualStyleBackColor = true;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
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
            this.laInkopDisplay.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.laInkopDisplay.MouseLeave += new System.EventHandler(this.mouseLeave);
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
            this.laOSDisplay.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.laOSDisplay.MouseLeave += new System.EventHandler(this.mouseLeave);
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
            this.laArtikelDisplay.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.laArtikelDisplay.MouseLeave += new System.EventHandler(this.mouseLeave);
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
            this.laBeskrivningDisplay.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.laBeskrivningDisplay.MouseLeave += new System.EventHandler(this.mouseLeave);
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
            this.laOvrigtDisplay.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.laOvrigtDisplay.MouseLeave += new System.EventHandler(this.mouseLeave);
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
            this.laDatornamnDisplay.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.laDatornamnDisplay.MouseLeave += new System.EventHandler(this.mouseLeave);
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
            this.laStoldtagDisplay.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.laStoldtagDisplay.MouseLeave += new System.EventHandler(this.mouseLeave);
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
            this.laMACDisplay.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.laMACDisplay.MouseLeave += new System.EventHandler(this.mouseLeave);
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
            this.laSerieNrDisplay.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.laSerieNrDisplay.MouseLeave += new System.EventHandler(this.mouseLeave);
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
            this.cmdAvbryt.Location = new System.Drawing.Point(593, 339);
            this.cmdAvbryt.Name = "cmdAvbryt";
            this.cmdAvbryt.Size = new System.Drawing.Size(88, 23);
            this.cmdAvbryt.TabIndex = 22;
            this.cmdAvbryt.Text = "Avbryt";
            this.cmdAvbryt.UseVisualStyleBackColor = true;
            this.cmdAvbryt.Click += new System.EventHandler(this.cmdAvbryt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHandelsePerson);
            this.groupBox1.Controls.Add(this.lbHandelser);
            this.groupBox1.Controls.Add(this.cmdNyHandelse);
            this.groupBox1.Controls.Add(this.laHandelsePersId);
            this.groupBox1.Location = new System.Drawing.Point(348, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 243);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Händelser";
            // 
            // txtHandelsePerson
            // 
            this.txtHandelsePerson.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHandelsePerson.HideSelection = false;
            this.txtHandelsePerson.Location = new System.Drawing.Point(18, 211);
            this.txtHandelsePerson.Name = "txtHandelsePerson";
            this.txtHandelsePerson.ReadOnly = true;
            this.txtHandelsePerson.Size = new System.Drawing.Size(183, 20);
            this.txtHandelsePerson.TabIndex = 16;
            // 
            // lbHandelser
            // 
            this.lbHandelser.FormattingEnabled = true;
            this.lbHandelser.Location = new System.Drawing.Point(18, 31);
            this.lbHandelser.Name = "lbHandelser";
            this.lbHandelser.Size = new System.Drawing.Size(300, 160);
            this.lbHandelser.TabIndex = 15;
            this.lbHandelser.SelectedIndexChanged += new System.EventHandler(this.lbHandelser_SelectedIndexChanged);
            // 
            // cmdNyHandelse
            // 
            this.cmdNyHandelse.Location = new System.Drawing.Point(216, 209);
            this.cmdNyHandelse.Name = "cmdNyHandelse";
            this.cmdNyHandelse.Size = new System.Drawing.Size(94, 23);
            this.cmdNyHandelse.TabIndex = 16;
            this.cmdNyHandelse.Text = "Ny ";
            this.cmdNyHandelse.UseVisualStyleBackColor = true;
            this.cmdNyHandelse.Click += new System.EventHandler(this.cmdNyHandelse_Click_1);
            // 
            // laHandelsePersId
            // 
            this.laHandelsePersId.AutoSize = true;
            this.laHandelsePersId.Location = new System.Drawing.Point(15, 194);
            this.laHandelsePersId.Name = "laHandelsePersId";
            this.laHandelsePersId.Size = new System.Drawing.Size(43, 13);
            this.laHandelsePersId.TabIndex = 34;
            this.laHandelsePersId.Text = "Person:";
            // 
            // cmdEttiketSerieNr
            // 
            this.cmdEttiketSerieNr.Location = new System.Drawing.Point(169, 93);
            this.cmdEttiketSerieNr.Name = "cmdEttiketSerieNr";
            this.cmdEttiketSerieNr.Size = new System.Drawing.Size(153, 23);
            this.cmdEttiketSerieNr.TabIndex = 17;
            this.cmdEttiketSerieNr.Text = "Ettiket (Steckkod)";
            this.cmdEttiketSerieNr.UseVisualStyleBackColor = true;
            this.cmdEttiketSerieNr.Click += new System.EventHandler(this.cmdEttiketSerieNr_Click);
            // 
            // HanteraArtikelDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 374);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdAvbryt);
            this.Controls.Add(this.gbFalt);
            this.Controls.Add(this.gbRegisterPerson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HanteraArtikelDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "                                     ";
            this.Load += new System.EventHandler(this.ManageArticle_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HanteraArtikelDialog_KeyDown);
            this.gbRegisterPerson.ResumeLayout(false);
            this.gbRegisterPerson.PerformLayout();
            this.gbFalt.ResumeLayout(false);
            this.gbFalt.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdSkrivUtEttiket;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbHandelser;
        private System.Windows.Forms.Button cmdNyHandelse;
        private System.Windows.Forms.Label laHandelsePersId;
        private System.Windows.Forms.TextBox txtHandelsePerson;
        private System.Windows.Forms.Button cmdRegistreraScanna;
        private System.Windows.Forms.Button cmdEttiketSerieNr;
    }
}