﻿namespace MovieDB
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolbar = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picCover = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupMovieInfo = new System.Windows.Forms.GroupBox();
            this.lblCurrNotes = new System.Windows.Forms.Label();
            this.txtCurrNotes = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCurrMyRate = new System.Windows.Forms.Label();
            this.cmbCurrMyRate = new System.Windows.Forms.ComboBox();
            this.lblCurrMovieLocatio = new System.Windows.Forms.Label();
            this.txtCurrMovieLocation = new System.Windows.Forms.TextBox();
            this.lblCurrDirectors = new System.Windows.Forms.Label();
            this.lbCurrDirectors = new System.Windows.Forms.ListBox();
            this.lblCurrCast = new System.Windows.Forms.Label();
            this.lbCurrCast = new System.Windows.Forms.ListBox();
            this.lblCurrAveRate = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.lblCurrWatched = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.lblCurrTime = new System.Windows.Forms.Label();
            this.cmbCurrTime = new System.Windows.Forms.ComboBox();
            this.lblCurrMPAA = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lblCurrYear = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblCurrGenre = new System.Windows.Forms.Label();
            this.linkCurrTitle = new System.Windows.Forms.LinkLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtCurrTitle = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbTitles = new System.Windows.Forms.ListBox();
            this.btnSearchClear = new System.Windows.Forms.Button();
            this.txtSearchTitle = new System.Windows.Forms.TextBox();
            this.groupFilters = new System.Windows.Forms.GroupBox();
            this.lbFilter1 = new System.Windows.Forms.ListBox();
            this.lbFilter2 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sbLabelMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.menu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.toolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupMovieInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1043, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDatabaseToolStripMenuItem,
            this.openDatabaseToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newDatabaseToolStripMenuItem
            // 
            this.newDatabaseToolStripMenuItem.Name = "newDatabaseToolStripMenuItem";
            this.newDatabaseToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.newDatabaseToolStripMenuItem.Text = "&New Database";
            // 
            // openDatabaseToolStripMenuItem
            // 
            this.openDatabaseToolStripMenuItem.Name = "openDatabaseToolStripMenuItem";
            this.openDatabaseToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.openDatabaseToolStripMenuItem.Text = "&Open Database";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.toolToolStripMenuItem.Text = "&Tool";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolbarToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // showToolbarToolStripMenuItem
            // 
            this.showToolbarToolStripMenuItem.Checked = true;
            this.showToolbarToolStripMenuItem.CheckOnClick = true;
            this.showToolbarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showToolbarToolStripMenuItem.Name = "showToolbarToolStripMenuItem";
            this.showToolbarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showToolbarToolStripMenuItem.Text = "Show &Toolbar";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbLabelMain});
            this.statusBar.Location = new System.Drawing.Point(0, 580);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1043, 22);
            this.statusBar.SizingGrip = false;
            this.statusBar.TabIndex = 1;
            // 
            // toolbar
            // 
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolbar.Location = new System.Drawing.Point(0, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(1043, 25);
            this.toolbar.TabIndex = 2;
            this.toolbar.Text = "toolStrip1";
            this.toolbar.Visible = false;
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.test2ToolStripMenuItem,
            this.test3ToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // test2ToolStripMenuItem
            // 
            this.test2ToolStripMenuItem.Checked = true;
            this.test2ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
            this.test2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.test2ToolStripMenuItem.Text = "Test2";
            // 
            // test3ToolStripMenuItem
            // 
            this.test3ToolStripMenuItem.Name = "test3ToolStripMenuItem";
            this.test3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.test3ToolStripMenuItem.Text = "Test3";
            // 
            // picCover
            // 
            this.picCover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picCover.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCover.Image = ((System.Drawing.Image)(resources.GetObject("picCover.Image")));
            this.picCover.Location = new System.Drawing.Point(606, 24);
            this.picCover.Name = "picCover";
            this.picCover.Size = new System.Drawing.Size(439, 463);
            this.picCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCover.TabIndex = 6;
            this.picCover.TabStop = false;
            this.picCover.UseWaitCursor = true;
            this.picCover.WaitOnLoad = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupMovieInfo);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupFilters);
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 553);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // groupMovieInfo
            // 
            this.groupMovieInfo.AutoSize = true;
            this.groupMovieInfo.Controls.Add(this.lblCurrNotes);
            this.groupMovieInfo.Controls.Add(this.txtCurrNotes);
            this.groupMovieInfo.Controls.Add(this.maskedTextBox1);
            this.groupMovieInfo.Controls.Add(this.label2);
            this.groupMovieInfo.Controls.Add(this.lblCurrMyRate);
            this.groupMovieInfo.Controls.Add(this.cmbCurrMyRate);
            this.groupMovieInfo.Controls.Add(this.lblCurrMovieLocatio);
            this.groupMovieInfo.Controls.Add(this.txtCurrMovieLocation);
            this.groupMovieInfo.Controls.Add(this.lblCurrDirectors);
            this.groupMovieInfo.Controls.Add(this.lbCurrDirectors);
            this.groupMovieInfo.Controls.Add(this.lblCurrCast);
            this.groupMovieInfo.Controls.Add(this.lbCurrCast);
            this.groupMovieInfo.Controls.Add(this.lblCurrAveRate);
            this.groupMovieInfo.Controls.Add(this.comboBox6);
            this.groupMovieInfo.Controls.Add(this.lblCurrWatched);
            this.groupMovieInfo.Controls.Add(this.comboBox5);
            this.groupMovieInfo.Controls.Add(this.lblCurrTime);
            this.groupMovieInfo.Controls.Add(this.cmbCurrTime);
            this.groupMovieInfo.Controls.Add(this.lblCurrMPAA);
            this.groupMovieInfo.Controls.Add(this.comboBox3);
            this.groupMovieInfo.Controls.Add(this.lblCurrYear);
            this.groupMovieInfo.Controls.Add(this.comboBox2);
            this.groupMovieInfo.Controls.Add(this.lblCurrGenre);
            this.groupMovieInfo.Controls.Add(this.linkCurrTitle);
            this.groupMovieInfo.Controls.Add(this.comboBox1);
            this.groupMovieInfo.Controls.Add(this.txtCurrTitle);
            this.groupMovieInfo.Location = new System.Drawing.Point(265, 19);
            this.groupMovieInfo.Name = "groupMovieInfo";
            this.groupMovieInfo.Size = new System.Drawing.Size(285, 511);
            this.groupMovieInfo.TabIndex = 14;
            this.groupMovieInfo.TabStop = false;
            this.groupMovieInfo.Text = "             Movie Information";
            // 
            // lblCurrNotes
            // 
            this.lblCurrNotes.AutoSize = true;
            this.lblCurrNotes.Location = new System.Drawing.Point(143, 276);
            this.lblCurrNotes.Name = "lblCurrNotes";
            this.lblCurrNotes.Size = new System.Drawing.Size(67, 13);
            this.lblCurrNotes.TabIndex = 27;
            this.lblCurrNotes.Text = "Movie Notes";
            // 
            // txtCurrNotes
            // 
            this.txtCurrNotes.Location = new System.Drawing.Point(143, 300);
            this.txtCurrNotes.Multiline = true;
            this.txtCurrNotes.Name = "txtCurrNotes";
            this.txtCurrNotes.Size = new System.Drawing.Size(130, 85);
            this.txtCurrNotes.TabIndex = 26;
            this.txtCurrNotes.Text = "This is an area to write notes about a movie.\r\nIt allows multi-line text.";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(204, 231);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(61, 20);
            this.maskedTextBox1.TabIndex = 25;
            this.maskedTextBox1.Text = "02262013";
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Date Added";
            // 
            // lblCurrMyRate
            // 
            this.lblCurrMyRate.AutoSize = true;
            this.lblCurrMyRate.Location = new System.Drawing.Point(212, 257);
            this.lblCurrMyRate.Name = "lblCurrMyRate";
            this.lblCurrMyRate.Size = new System.Drawing.Size(55, 13);
            this.lblCurrMyRate.TabIndex = 23;
            this.lblCurrMyRate.Text = "My Rating";
            // 
            // cmbCurrMyRate
            // 
            this.cmbCurrMyRate.FormattingEnabled = true;
            this.cmbCurrMyRate.Location = new System.Drawing.Point(215, 273);
            this.cmbCurrMyRate.Name = "cmbCurrMyRate";
            this.cmbCurrMyRate.Size = new System.Drawing.Size(50, 21);
            this.cmbCurrMyRate.TabIndex = 22;
            this.cmbCurrMyRate.Text = "2.5";
            // 
            // lblCurrMovieLocatio
            // 
            this.lblCurrMovieLocatio.AutoSize = true;
            this.lblCurrMovieLocatio.Location = new System.Drawing.Point(11, 393);
            this.lblCurrMovieLocatio.Name = "lblCurrMovieLocatio";
            this.lblCurrMovieLocatio.Size = new System.Drawing.Size(99, 13);
            this.lblCurrMovieLocatio.TabIndex = 21;
            this.lblCurrMovieLocatio.Text = "Movie File Location";
            // 
            // txtCurrMovieLocation
            // 
            this.txtCurrMovieLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCurrMovieLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtCurrMovieLocation.Location = new System.Drawing.Point(9, 409);
            this.txtCurrMovieLocation.Name = "txtCurrMovieLocation";
            this.txtCurrMovieLocation.Size = new System.Drawing.Size(226, 20);
            this.txtCurrMovieLocation.TabIndex = 20;
            this.txtCurrMovieLocation.Text = "C:\\";
            this.txtCurrMovieLocation.WordWrap = false;
            // 
            // lblCurrDirectors
            // 
            this.lblCurrDirectors.AutoSize = true;
            this.lblCurrDirectors.Location = new System.Drawing.Point(146, 144);
            this.lblCurrDirectors.Name = "lblCurrDirectors";
            this.lblCurrDirectors.Size = new System.Drawing.Size(55, 13);
            this.lblCurrDirectors.TabIndex = 17;
            this.lblCurrDirectors.Text = "Director(s)";
            // 
            // lbCurrDirectors
            // 
            this.lbCurrDirectors.FormattingEnabled = true;
            this.lbCurrDirectors.Items.AddRange(new object[] {
            "Director Name 1",
            "Director Name 2"});
            this.lbCurrDirectors.Location = new System.Drawing.Point(146, 160);
            this.lbCurrDirectors.Name = "lbCurrDirectors";
            this.lbCurrDirectors.Size = new System.Drawing.Size(120, 43);
            this.lbCurrDirectors.TabIndex = 16;
            // 
            // lblCurrCast
            // 
            this.lblCurrCast.AutoSize = true;
            this.lblCurrCast.Location = new System.Drawing.Point(9, 144);
            this.lblCurrCast.Name = "lblCurrCast";
            this.lblCurrCast.Size = new System.Drawing.Size(28, 13);
            this.lblCurrCast.TabIndex = 15;
            this.lblCurrCast.Text = "Cast";
            // 
            // lbCurrCast
            // 
            this.lbCurrCast.FormattingEnabled = true;
            this.lbCurrCast.Items.AddRange(new object[] {
            "Adam Campbell",
            "Alyson Hannigan",
            "Eddie Griffin",
            "Fred Willard",
            "Jennifer Coolidge",
            "Mauricio Sánchez",
            "Sophie Monk"});
            this.lbCurrCast.Location = new System.Drawing.Point(9, 160);
            this.lbCurrCast.Name = "lbCurrCast";
            this.lbCurrCast.Size = new System.Drawing.Size(128, 225);
            this.lbCurrCast.TabIndex = 14;
            // 
            // lblCurrAveRate
            // 
            this.lblCurrAveRate.AutoSize = true;
            this.lblCurrAveRate.Location = new System.Drawing.Point(160, 100);
            this.lblCurrAveRate.Name = "lblCurrAveRate";
            this.lblCurrAveRate.Size = new System.Drawing.Size(60, 13);
            this.lblCurrAveRate.TabIndex = 13;
            this.lblCurrAveRate.Text = "Ave Rating";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(163, 116);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(57, 21);
            this.comboBox6.TabIndex = 12;
            this.comboBox6.Text = "2.5";
            // 
            // lblCurrWatched
            // 
            this.lblCurrWatched.AutoSize = true;
            this.lblCurrWatched.Location = new System.Drawing.Point(143, 214);
            this.lblCurrWatched.Name = "lblCurrWatched";
            this.lblCurrWatched.Size = new System.Drawing.Size(57, 13);
            this.lblCurrWatched.TabIndex = 11;
            this.lblCurrWatched.Text = "Watched?";
            // 
            // comboBox5
            // 
            this.comboBox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.comboBox5.Location = new System.Drawing.Point(146, 230);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(50, 21);
            this.comboBox5.TabIndex = 10;
            this.comboBox5.Text = "Yes";
            // 
            // lblCurrTime
            // 
            this.lblCurrTime.AutoSize = true;
            this.lblCurrTime.Location = new System.Drawing.Point(225, 100);
            this.lblCurrTime.Name = "lblCurrTime";
            this.lblCurrTime.Size = new System.Drawing.Size(30, 13);
            this.lblCurrTime.TabIndex = 9;
            this.lblCurrTime.Text = "Time";
            this.lblCurrTime.Click += new System.EventHandler(this.lblCurrTime_Click);
            // 
            // cmbCurrTime
            // 
            this.cmbCurrTime.FormattingEnabled = true;
            this.cmbCurrTime.Location = new System.Drawing.Point(226, 116);
            this.cmbCurrTime.Name = "cmbCurrTime";
            this.cmbCurrTime.Size = new System.Drawing.Size(47, 21);
            this.cmbCurrTime.TabIndex = 8;
            this.cmbCurrTime.Text = "120";
            this.cmbCurrTime.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // lblCurrMPAA
            // 
            this.lblCurrMPAA.AutoSize = true;
            this.lblCurrMPAA.Location = new System.Drawing.Point(86, 100);
            this.lblCurrMPAA.Name = "lblCurrMPAA";
            this.lblCurrMPAA.Size = new System.Drawing.Size(71, 13);
            this.lblCurrMPAA.TabIndex = 7;
            this.lblCurrMPAA.Text = "MPAA Rating";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(89, 116);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(68, 21);
            this.comboBox3.TabIndex = 6;
            this.comboBox3.Text = "R";
            // 
            // lblCurrYear
            // 
            this.lblCurrYear.AutoSize = true;
            this.lblCurrYear.Location = new System.Drawing.Point(6, 100);
            this.lblCurrYear.Name = "lblCurrYear";
            this.lblCurrYear.Size = new System.Drawing.Size(77, 13);
            this.lblCurrYear.TabIndex = 5;
            this.lblCurrYear.Text = "Year Released";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970",
            "1969",
            "1968",
            "1967",
            "1966",
            "1965",
            "1964",
            "1963",
            "1962",
            "1961",
            "1960",
            "1959",
            "1958",
            "1957",
            "1956",
            "1955",
            "1954",
            "1953",
            "1952",
            "1951",
            "1950",
            "1949",
            "1948",
            "1947",
            "1946",
            "1945",
            "1944",
            "1943",
            "1942",
            "1941",
            "1940",
            "1939",
            "1938",
            "1937",
            "1936",
            "1935",
            "1934",
            "1933",
            "1932",
            "1931",
            "1930",
            "1929",
            "1928",
            "1927",
            "1926",
            "1925",
            "1924",
            "1923",
            "1922",
            "1921",
            "1920",
            "1919",
            "1918",
            "1917"});
            this.comboBox2.Location = new System.Drawing.Point(9, 116);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(74, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.Text = "2006";
            // 
            // lblCurrGenre
            // 
            this.lblCurrGenre.AutoSize = true;
            this.lblCurrGenre.Location = new System.Drawing.Point(6, 57);
            this.lblCurrGenre.Name = "lblCurrGenre";
            this.lblCurrGenre.Size = new System.Drawing.Size(47, 13);
            this.lblCurrGenre.TabIndex = 3;
            this.lblCurrGenre.Text = "Genre(s)";
            // 
            // linkCurrTitle
            // 
            this.linkCurrTitle.AutoSize = true;
            this.linkCurrTitle.Location = new System.Drawing.Point(6, 24);
            this.linkCurrTitle.Name = "linkCurrTitle";
            this.linkCurrTitle.Size = new System.Drawing.Size(27, 13);
            this.linkCurrTitle.TabIndex = 2;
            this.linkCurrTitle.TabStop = true;
            this.linkCurrTitle.Text = "Title";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Action & Adventure",
            "Anime",
            "Children & Family",
            "Comedy",
            "Documentary",
            "Drama",
            "Fantasy",
            "Foreign",
            "Horror",
            "Independent",
            "Mystery",
            "SciFi",
            "SciFi & Fantasy",
            "Suspense",
            "Thriller",
            "Western"});
            this.comboBox1.Location = new System.Drawing.Point(7, 73);
            this.comboBox1.MaxDropDownItems = 15;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(266, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Comedy";
            // 
            // txtCurrTitle
            // 
            this.txtCurrTitle.Location = new System.Drawing.Point(6, 38);
            this.txtCurrTitle.Name = "txtCurrTitle";
            this.txtCurrTitle.Size = new System.Drawing.Size(267, 20);
            this.txtCurrTitle.TabIndex = 0;
            this.txtCurrTitle.Text = "Date Movie";
            this.txtCurrTitle.WordWrap = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbTitles);
            this.groupBox2.Controls.Add(this.btnSearchClear);
            this.groupBox2.Controls.Add(this.txtSearchTitle);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 300);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Title Search";
            // 
            // lbTitles
            // 
            this.lbTitles.FormattingEnabled = true;
            this.lbTitles.Items.AddRange(new object[] {
            "Date Movie"});
            this.lbTitles.Location = new System.Drawing.Point(6, 43);
            this.lbTitles.Name = "lbTitles";
            this.lbTitles.ScrollAlwaysVisible = true;
            this.lbTitles.Size = new System.Drawing.Size(241, 251);
            this.lbTitles.TabIndex = 5;
            // 
            // btnSearchClear
            // 
            this.btnSearchClear.Location = new System.Drawing.Point(148, 19);
            this.btnSearchClear.Name = "btnSearchClear";
            this.btnSearchClear.Size = new System.Drawing.Size(40, 23);
            this.btnSearchClear.TabIndex = 4;
            this.btnSearchClear.Text = "&Clear";
            this.btnSearchClear.UseVisualStyleBackColor = true;
            // 
            // txtSearchTitle
            // 
            this.txtSearchTitle.Location = new System.Drawing.Point(7, 21);
            this.txtSearchTitle.Name = "txtSearchTitle";
            this.txtSearchTitle.Size = new System.Drawing.Size(145, 20);
            this.txtSearchTitle.TabIndex = 3;
            // 
            // groupFilters
            // 
            this.groupFilters.Controls.Add(this.lbFilter1);
            this.groupFilters.Controls.Add(this.lbFilter2);
            this.groupFilters.Location = new System.Drawing.Point(8, 325);
            this.groupFilters.Name = "groupFilters";
            this.groupFilters.Size = new System.Drawing.Size(251, 203);
            this.groupFilters.TabIndex = 12;
            this.groupFilters.TabStop = false;
            this.groupFilters.Text = "   Filters";
            // 
            // lbFilter1
            // 
            this.lbFilter1.FormattingEnabled = true;
            this.lbFilter1.Items.AddRange(new object[] {
            "-RESET ALL-",
            "Actor/Actress",
            "Date Added",
            "Directors",
            "Drive Letter",
            "Genre",
            "MPAA Rating",
            "My Rating",
            "Ave Rating",
            "Notes",
            "Redownload?",
            "Tags",
            "Watched",
            "Year Released",
            "Time",
            "Index",
            "Random",
            "Database Mgmt"});
            this.lbFilter1.Location = new System.Drawing.Point(6, 19);
            this.lbFilter1.Name = "lbFilter1";
            this.lbFilter1.Size = new System.Drawing.Size(117, 173);
            this.lbFilter1.TabIndex = 7;
            // 
            // lbFilter2
            // 
            this.lbFilter2.FormattingEnabled = true;
            this.lbFilter2.Items.AddRange(new object[] {
            "Additional Filters Here"});
            this.lbFilter2.Location = new System.Drawing.Point(129, 19);
            this.lbFilter2.Name = "lbFilter2";
            this.lbFilter2.Size = new System.Drawing.Size(117, 173);
            this.lbFilter2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(588, 493);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(439, 84);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = "This is an area to write notes about a movie.\r\nIt allows multi-line text.";
            // 
            // sbLabelMain
            // 
            this.sbLabelMain.Name = "sbLabelMain";
            this.sbLabelMain.Size = new System.Drawing.Size(39, 17);
            this.sbLabelMain.Text = "Ready";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 602);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picCover);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.toolbar);
            this.MainMenuStrip = this.menu;
            this.Name = "formMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Database";
            this.Resize += new System.EventHandler(this.formMain_Resize);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupMovieInfo.ResumeLayout(false);
            this.groupMovieInfo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupFilters.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStrip toolbar;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test3ToolStripMenuItem;
        private System.Windows.Forms.PictureBox picCover;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbTitles;
        private System.Windows.Forms.Button btnSearchClear;
        private System.Windows.Forms.TextBox txtSearchTitle;
        private System.Windows.Forms.GroupBox groupFilters;
        private System.Windows.Forms.ListBox lbFilter1;
        private System.Windows.Forms.ListBox lbFilter2;
        private System.Windows.Forms.GroupBox groupMovieInfo;
        private System.Windows.Forms.TextBox txtCurrTitle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblCurrDirectors;
        private System.Windows.Forms.ListBox lbCurrDirectors;
        private System.Windows.Forms.Label lblCurrCast;
        private System.Windows.Forms.ListBox lbCurrCast;
        private System.Windows.Forms.Label lblCurrAveRate;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label lblCurrWatched;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label lblCurrTime;
        private System.Windows.Forms.ComboBox cmbCurrTime;
        private System.Windows.Forms.Label lblCurrMPAA;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label lblCurrYear;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblCurrGenre;
        private System.Windows.Forms.LinkLabel linkCurrTitle;
        private System.Windows.Forms.Label lblCurrMyRate;
        private System.Windows.Forms.ComboBox cmbCurrMyRate;
        private System.Windows.Forms.Label lblCurrMovieLocatio;
        private System.Windows.Forms.TextBox txtCurrMovieLocation;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCurrNotes;
        private System.Windows.Forms.TextBox txtCurrNotes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel sbLabelMain;
    }
}

