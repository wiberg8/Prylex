﻿namespace ScannerDialog
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
            this.txtRegistredPerson = new System.Windows.Forms.TextBox();
            this.cmdRegisterPerson = new System.Windows.Forms.Button();
            this.cmdUnregisterPerson = new System.Windows.Forms.Button();
            this.cmdEttiketSerieNr = new System.Windows.Forms.Button();
            this.cmdSkrivUtEttiket = new System.Windows.Forms.Button();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSelectHandelseTyp = new System.Windows.Forms.ComboBox();
            this.txtHandelsePerson = new System.Windows.Forms.TextBox();
            this.lbHandelser = new System.Windows.Forms.ListBox();
            this.cmdNyHandelse = new System.Windows.Forms.Button();
            this.laHandelsePersId = new System.Windows.Forms.Label();
            this.gbSkrivUt = new System.Windows.Forms.GroupBox();
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.gbRegisterPerson.SuspendLayout();
            this.gbFalt.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbSkrivUt.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRegisterPerson
            // 
            this.gbRegisterPerson.Controls.Add(this.cmdRegistreraScanna);
            this.gbRegisterPerson.Controls.Add(this.txtRegistredPerson);
            this.gbRegisterPerson.Controls.Add(this.cmdRegisterPerson);
            this.gbRegisterPerson.Controls.Add(this.cmdUnregisterPerson);
            this.gbRegisterPerson.Location = new System.Drawing.Point(16, 352);
            this.gbRegisterPerson.Margin = new System.Windows.Forms.Padding(4);
            this.gbRegisterPerson.Name = "gbRegisterPerson";
            this.gbRegisterPerson.Padding = new System.Windows.Forms.Padding(4);
            this.gbRegisterPerson.Size = new System.Drawing.Size(440, 126);
            this.gbRegisterPerson.TabIndex = 13;
            this.gbRegisterPerson.TabStop = false;
            this.gbRegisterPerson.Text = "Registrera / Avregistrera person";
            // 
            // cmdRegistreraScanna
            // 
            this.cmdRegistreraScanna.Location = new System.Drawing.Point(17, 85);
            this.cmdRegistreraScanna.Margin = new System.Windows.Forms.Padding(4);
            this.cmdRegistreraScanna.Name = "cmdRegistreraScanna";
            this.cmdRegistreraScanna.Size = new System.Drawing.Size(200, 28);
            this.cmdRegistreraScanna.TabIndex = 16;
            this.cmdRegistreraScanna.Text = "Registrera (Legitimation)";
            this.cmdRegistreraScanna.UseVisualStyleBackColor = true;
            this.cmdRegistreraScanna.Click += new System.EventHandler(this.cmdRegistreraScanna_Click);
            // 
            // txtRegistredPerson
            // 
            this.txtRegistredPerson.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegistredPerson.HideSelection = false;
            this.txtRegistredPerson.Location = new System.Drawing.Point(17, 23);
            this.txtRegistredPerson.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegistredPerson.Name = "txtRegistredPerson";
            this.txtRegistredPerson.ReadOnly = true;
            this.txtRegistredPerson.Size = new System.Drawing.Size(411, 22);
            this.txtRegistredPerson.TabIndex = 14;
            // 
            // cmdRegisterPerson
            // 
            this.cmdRegisterPerson.Location = new System.Drawing.Point(17, 55);
            this.cmdRegisterPerson.Margin = new System.Windows.Forms.Padding(4);
            this.cmdRegisterPerson.Name = "cmdRegisterPerson";
            this.cmdRegisterPerson.Size = new System.Drawing.Size(200, 28);
            this.cmdRegisterPerson.TabIndex = 14;
            this.cmdRegisterPerson.Text = "Registrera...";
            this.cmdRegisterPerson.UseVisualStyleBackColor = true;
            this.cmdRegisterPerson.Click += new System.EventHandler(this.cmdRegisterPerson_Click);
            // 
            // cmdUnregisterPerson
            // 
            this.cmdUnregisterPerson.Location = new System.Drawing.Point(225, 55);
            this.cmdUnregisterPerson.Margin = new System.Windows.Forms.Padding(4);
            this.cmdUnregisterPerson.Name = "cmdUnregisterPerson";
            this.cmdUnregisterPerson.Size = new System.Drawing.Size(204, 28);
            this.cmdUnregisterPerson.TabIndex = 13;
            this.cmdUnregisterPerson.Text = "Avregistrera...";
            this.cmdUnregisterPerson.UseVisualStyleBackColor = true;
            this.cmdUnregisterPerson.Click += new System.EventHandler(this.cmdUnregisterPerson_Click);
            // 
            // cmdEttiketSerieNr
            // 
            this.cmdEttiketSerieNr.Location = new System.Drawing.Point(24, 31);
            this.cmdEttiketSerieNr.Margin = new System.Windows.Forms.Padding(4);
            this.cmdEttiketSerieNr.Name = "cmdEttiketSerieNr";
            this.cmdEttiketSerieNr.Size = new System.Drawing.Size(204, 28);
            this.cmdEttiketSerieNr.TabIndex = 17;
            this.cmdEttiketSerieNr.Text = "Ettiket (Steckkod)";
            this.cmdEttiketSerieNr.UseVisualStyleBackColor = true;
            this.cmdEttiketSerieNr.Click += new System.EventHandler(this.cmdEttiketSerieNr_Click);
            // 
            // cmdSkrivUtEttiket
            // 
            this.cmdSkrivUtEttiket.Location = new System.Drawing.Point(24, 66);
            this.cmdSkrivUtEttiket.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSkrivUtEttiket.Name = "cmdSkrivUtEttiket";
            this.cmdSkrivUtEttiket.Size = new System.Drawing.Size(204, 28);
            this.cmdSkrivUtEttiket.TabIndex = 15;
            this.cmdSkrivUtEttiket.Text = "Ettiket (Streckkod / Namn)";
            this.cmdSkrivUtEttiket.UseVisualStyleBackColor = true;
            this.cmdSkrivUtEttiket.Click += new System.EventHandler(this.cmdSkrivUtEttiket_Click);
            // 
            // laArtikelId
            // 
            this.laArtikelId.Location = new System.Drawing.Point(16, 27);
            this.laArtikelId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laArtikelId.Name = "laArtikelId";
            this.laArtikelId.Size = new System.Drawing.Size(87, 16);
            this.laArtikelId.TabIndex = 24;
            this.laArtikelId.Text = "Id:";
            // 
            // laMAC
            // 
            this.laMAC.AutoSize = true;
            this.laMAC.Location = new System.Drawing.Point(16, 150);
            this.laMAC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laMAC.Name = "laMAC";
            this.laMAC.Size = new System.Drawing.Size(87, 16);
            this.laMAC.TabIndex = 5;
            this.laMAC.Text = "MAC-Adress:";
            // 
            // laOvrigt
            // 
            this.laOvrigt.AutoSize = true;
            this.laOvrigt.Location = new System.Drawing.Point(16, 224);
            this.laOvrigt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laOvrigt.Name = "laOvrigt";
            this.laOvrigt.Size = new System.Drawing.Size(46, 16);
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
            this.gbFalt.Location = new System.Drawing.Point(16, 10);
            this.gbFalt.Margin = new System.Windows.Forms.Padding(4);
            this.gbFalt.Name = "gbFalt";
            this.gbFalt.Padding = new System.Windows.Forms.Padding(4);
            this.gbFalt.Size = new System.Drawing.Size(440, 289);
            this.gbFalt.TabIndex = 19;
            this.gbFalt.TabStop = false;
            this.gbFalt.Text = "Info";
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(17, 247);
            this.cmdDelete.Margin = new System.Windows.Forms.Padding(4);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(119, 28);
            this.cmdDelete.TabIndex = 33;
            this.cmdDelete.Text = "Radera";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.Location = new System.Drawing.Point(313, 247);
            this.cmdEdit.Margin = new System.Windows.Forms.Padding(4);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(119, 28);
            this.cmdEdit.TabIndex = 15;
            this.cmdEdit.Text = "Ändra..";
            this.cmdEdit.UseVisualStyleBackColor = true;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // laInkopDisplay
            // 
            this.laInkopDisplay.Location = new System.Drawing.Point(124, 199);
            this.laInkopDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laInkopDisplay.Name = "laInkopDisplay";
            this.laInkopDisplay.Size = new System.Drawing.Size(252, 16);
            this.laInkopDisplay.TabIndex = 31;
            this.laInkopDisplay.Text = "Display";
            this.laInkopDisplay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.laDisplay_DoubleClick);
            // 
            // laOSDisplay
            // 
            this.laOSDisplay.Location = new System.Drawing.Point(124, 175);
            this.laOSDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laOSDisplay.Name = "laOSDisplay";
            this.laOSDisplay.Size = new System.Drawing.Size(252, 16);
            this.laOSDisplay.TabIndex = 30;
            this.laOSDisplay.Text = "Display";
            this.laOSDisplay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.laDisplay_DoubleClick);
            // 
            // laArtikelDisplay
            // 
            this.laArtikelDisplay.Location = new System.Drawing.Point(124, 27);
            this.laArtikelDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laArtikelDisplay.Name = "laArtikelDisplay";
            this.laArtikelDisplay.Size = new System.Drawing.Size(252, 16);
            this.laArtikelDisplay.TabIndex = 32;
            this.laArtikelDisplay.Text = "Display";
            this.laArtikelDisplay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.laDisplay_DoubleClick);
            // 
            // laBeskrivningDisplay
            // 
            this.laBeskrivningDisplay.Location = new System.Drawing.Point(124, 52);
            this.laBeskrivningDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laBeskrivningDisplay.Name = "laBeskrivningDisplay";
            this.laBeskrivningDisplay.Size = new System.Drawing.Size(252, 16);
            this.laBeskrivningDisplay.TabIndex = 29;
            this.laBeskrivningDisplay.Text = "Display";
            this.laBeskrivningDisplay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.laDisplay_DoubleClick);
            // 
            // laInkop
            // 
            this.laInkop.AutoSize = true;
            this.laInkop.Location = new System.Drawing.Point(16, 199);
            this.laInkop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laInkop.Name = "laInkop";
            this.laInkop.Size = new System.Drawing.Size(93, 16);
            this.laInkop.TabIndex = 3;
            this.laInkop.Text = "Inköps Datum:";
            // 
            // laOvrigtDisplay
            // 
            this.laOvrigtDisplay.Location = new System.Drawing.Point(124, 224);
            this.laOvrigtDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laOvrigtDisplay.Name = "laOvrigtDisplay";
            this.laOvrigtDisplay.Size = new System.Drawing.Size(252, 16);
            this.laOvrigtDisplay.TabIndex = 27;
            this.laOvrigtDisplay.Text = "Display";
            this.laOvrigtDisplay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.laDisplay_DoubleClick);
            // 
            // laDatornamnDisplay
            // 
            this.laDatornamnDisplay.Location = new System.Drawing.Point(124, 76);
            this.laDatornamnDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laDatornamnDisplay.Name = "laDatornamnDisplay";
            this.laDatornamnDisplay.Size = new System.Drawing.Size(252, 16);
            this.laDatornamnDisplay.TabIndex = 26;
            this.laDatornamnDisplay.Text = "Display";
            this.laDatornamnDisplay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.laDisplay_DoubleClick);
            // 
            // laOS
            // 
            this.laOS.AutoSize = true;
            this.laOS.Location = new System.Drawing.Point(16, 175);
            this.laOS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laOS.Name = "laOS";
            this.laOS.Size = new System.Drawing.Size(30, 16);
            this.laOS.TabIndex = 2;
            this.laOS.Text = "OS:";
            // 
            // laStoldtagDisplay
            // 
            this.laStoldtagDisplay.Location = new System.Drawing.Point(124, 101);
            this.laStoldtagDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laStoldtagDisplay.Name = "laStoldtagDisplay";
            this.laStoldtagDisplay.Size = new System.Drawing.Size(252, 16);
            this.laStoldtagDisplay.TabIndex = 25;
            this.laStoldtagDisplay.Text = "Display";
            this.laStoldtagDisplay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.laDisplay_DoubleClick);
            // 
            // laMACDisplay
            // 
            this.laMACDisplay.Location = new System.Drawing.Point(124, 150);
            this.laMACDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laMACDisplay.Name = "laMACDisplay";
            this.laMACDisplay.Size = new System.Drawing.Size(252, 16);
            this.laMACDisplay.TabIndex = 24;
            this.laMACDisplay.Text = "Display";
            this.laMACDisplay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.laDisplay_DoubleClick);
            // 
            // laBeskrivning
            // 
            this.laBeskrivning.AutoSize = true;
            this.laBeskrivning.Location = new System.Drawing.Point(16, 52);
            this.laBeskrivning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laBeskrivning.Name = "laBeskrivning";
            this.laBeskrivning.Size = new System.Drawing.Size(81, 16);
            this.laBeskrivning.TabIndex = 0;
            this.laBeskrivning.Text = "Beskrivning:";
            // 
            // laSerieNrDisplay
            // 
            this.laSerieNrDisplay.Location = new System.Drawing.Point(124, 126);
            this.laSerieNrDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laSerieNrDisplay.Name = "laSerieNrDisplay";
            this.laSerieNrDisplay.Size = new System.Drawing.Size(252, 16);
            this.laSerieNrDisplay.TabIndex = 23;
            this.laSerieNrDisplay.Text = "Display";
            this.laSerieNrDisplay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.laDisplay_DoubleClick);
            // 
            // laStoldtag
            // 
            this.laStoldtag.AutoSize = true;
            this.laStoldtag.Location = new System.Drawing.Point(16, 101);
            this.laStoldtag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laStoldtag.Name = "laStoldtag";
            this.laStoldtag.Size = new System.Drawing.Size(61, 16);
            this.laStoldtag.TabIndex = 6;
            this.laStoldtag.Text = "Stöldtag:";
            // 
            // laDatornamn
            // 
            this.laDatornamn.AutoSize = true;
            this.laDatornamn.Location = new System.Drawing.Point(16, 76);
            this.laDatornamn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laDatornamn.Name = "laDatornamn";
            this.laDatornamn.Size = new System.Drawing.Size(77, 16);
            this.laDatornamn.TabIndex = 7;
            this.laDatornamn.Text = "Datornamn:";
            // 
            // laSerieNr
            // 
            this.laSerieNr.AutoSize = true;
            this.laSerieNr.Location = new System.Drawing.Point(16, 126);
            this.laSerieNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laSerieNr.Name = "laSerieNr";
            this.laSerieNr.Size = new System.Drawing.Size(57, 16);
            this.laSerieNr.TabIndex = 4;
            this.laSerieNr.Text = "SerieNr:";
            // 
            // cmdAvbryt
            // 
            this.cmdAvbryt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdAvbryt.Location = new System.Drawing.Point(880, 450);
            this.cmdAvbryt.Margin = new System.Windows.Forms.Padding(4);
            this.cmdAvbryt.Name = "cmdAvbryt";
            this.cmdAvbryt.Size = new System.Drawing.Size(117, 28);
            this.cmdAvbryt.TabIndex = 22;
            this.cmdAvbryt.Text = "Avbryt";
            this.cmdAvbryt.UseVisualStyleBackColor = true;
            this.cmdAvbryt.Click += new System.EventHandler(this.cmdAvbryt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSelectHandelseTyp);
            this.groupBox1.Controls.Add(this.txtHandelsePerson);
            this.groupBox1.Controls.Add(this.lbHandelser);
            this.groupBox1.Controls.Add(this.cmdNyHandelse);
            this.groupBox1.Controls.Add(this.laHandelsePersId);
            this.groupBox1.Location = new System.Drawing.Point(464, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(533, 340);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Händelser";
            // 
            // cbSelectHandelseTyp
            // 
            this.cbSelectHandelseTyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectHandelseTyp.FormattingEnabled = true;
            this.cbSelectHandelseTyp.Location = new System.Drawing.Point(24, 36);
            this.cbSelectHandelseTyp.Margin = new System.Windows.Forms.Padding(4);
            this.cbSelectHandelseTyp.Name = "cbSelectHandelseTyp";
            this.cbSelectHandelseTyp.Size = new System.Drawing.Size(477, 24);
            this.cbSelectHandelseTyp.TabIndex = 36;
            this.cbSelectHandelseTyp.SelectedIndexChanged += new System.EventHandler(this.cbSelectHandelseTyp_SelectedIndexChanged);
            // 
            // txtHandelsePerson
            // 
            this.txtHandelsePerson.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHandelsePerson.HideSelection = false;
            this.txtHandelsePerson.Location = new System.Drawing.Point(24, 290);
            this.txtHandelsePerson.Margin = new System.Windows.Forms.Padding(4);
            this.txtHandelsePerson.Name = "txtHandelsePerson";
            this.txtHandelsePerson.ReadOnly = true;
            this.txtHandelsePerson.Size = new System.Drawing.Size(344, 22);
            this.txtHandelsePerson.TabIndex = 16;
            // 
            // lbHandelser
            // 
            this.lbHandelser.FormattingEnabled = true;
            this.lbHandelser.ItemHeight = 16;
            this.lbHandelser.Location = new System.Drawing.Point(24, 69);
            this.lbHandelser.Margin = new System.Windows.Forms.Padding(4);
            this.lbHandelser.Name = "lbHandelser";
            this.lbHandelser.Size = new System.Drawing.Size(477, 196);
            this.lbHandelser.TabIndex = 15;
            this.lbHandelser.SelectedIndexChanged += new System.EventHandler(this.lbHandelser_SelectedIndexChanged);
            // 
            // cmdNyHandelse
            // 
            this.cmdNyHandelse.Location = new System.Drawing.Point(377, 288);
            this.cmdNyHandelse.Margin = new System.Windows.Forms.Padding(4);
            this.cmdNyHandelse.Name = "cmdNyHandelse";
            this.cmdNyHandelse.Size = new System.Drawing.Size(125, 28);
            this.cmdNyHandelse.TabIndex = 16;
            this.cmdNyHandelse.Text = "Ny ";
            this.cmdNyHandelse.UseVisualStyleBackColor = true;
            this.cmdNyHandelse.Click += new System.EventHandler(this.cmdNyHandelse_Click_1);
            // 
            // laHandelsePersId
            // 
            this.laHandelsePersId.AutoSize = true;
            this.laHandelsePersId.Location = new System.Drawing.Point(20, 270);
            this.laHandelsePersId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laHandelsePersId.Name = "laHandelsePersId";
            this.laHandelsePersId.Size = new System.Drawing.Size(54, 16);
            this.laHandelsePersId.TabIndex = 34;
            this.laHandelsePersId.Text = "Person:";
            // 
            // gbSkrivUt
            // 
            this.gbSkrivUt.Controls.Add(this.cmdEttiketSerieNr);
            this.gbSkrivUt.Controls.Add(this.cmdSkrivUtEttiket);
            this.gbSkrivUt.Location = new System.Drawing.Point(464, 363);
            this.gbSkrivUt.Margin = new System.Windows.Forms.Padding(4);
            this.gbSkrivUt.Name = "gbSkrivUt";
            this.gbSkrivUt.Padding = new System.Windows.Forms.Padding(4);
            this.gbSkrivUt.Size = new System.Drawing.Size(249, 116);
            this.gbSkrivUt.TabIndex = 24;
            this.gbSkrivUt.TabStop = false;
            this.gbSkrivUt.Text = "Skriv ut";
            // 
            // HanteraArtikelDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 496);
            this.Controls.Add(this.gbSkrivUt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdAvbryt);
            this.Controls.Add(this.gbFalt);
            this.Controls.Add(this.gbRegisterPerson);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HanteraArtikelDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "                                     ";
            this.Load += new System.EventHandler(this.HanteraArtikelDialog_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HanteraArtikelDialog_KeyDown);
            this.gbRegisterPerson.ResumeLayout(false);
            this.gbRegisterPerson.PerformLayout();
            this.gbFalt.ResumeLayout(false);
            this.gbFalt.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbSkrivUt.ResumeLayout(false);
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
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdSkrivUtEttiket;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbHandelser;
        private System.Windows.Forms.Button cmdNyHandelse;
        private System.Windows.Forms.Label laHandelsePersId;
        private System.Windows.Forms.TextBox txtHandelsePerson;
        private System.Windows.Forms.Button cmdRegistreraScanna;
        private System.Windows.Forms.Button cmdEttiketSerieNr;
        private System.Windows.Forms.GroupBox gbSkrivUt;
        private System.Windows.Forms.ComboBox cbSelectHandelseTyp;
        private System.Windows.Forms.ToolTip toolTipHelp;
    }
}