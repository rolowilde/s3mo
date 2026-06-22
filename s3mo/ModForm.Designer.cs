namespace s3mo
{
    partial class ModForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.informationTabPage = new System.Windows.Forms.TabPage();
            this.informationNoteTextBox = new System.Windows.Forms.TextBox();
            this.informationURLTextBox = new System.Windows.Forms.TextBox();
            this.informationURLLabel = new System.Windows.Forms.Label();
            this.informationNoteLabel = new System.Windows.Forms.Label();
            this.contentTabPage = new System.Windows.Forms.TabPage();
            this.packageSplitContainer = new System.Windows.Forms.SplitContainer();
            this.packageGroupBox = new System.Windows.Forms.GroupBox();
            this.packageListView = new System.Windows.Forms.ListView();
            this.packageHeader = new System.Windows.Forms.ColumnHeader();
            this.packageFlagHeader = new System.Windows.Forms.ColumnHeader();
            this.resourceSplitContainer = new System.Windows.Forms.SplitContainer();
            this.resourceGroupBox = new System.Windows.Forms.GroupBox();
            this.resourceProgressLabel = new System.Windows.Forms.Label();
            this.resourceProgressBar = new System.Windows.Forms.ProgressBar();
            this.resourceListView = new System.Windows.Forms.ListView();
            this.itemHeader = new System.Windows.Forms.ColumnHeader();
            this.resourceNameHeader = new System.Windows.Forms.ColumnHeader();
            this.resourceTagHeader = new System.Windows.Forms.ColumnHeader();
            this.resourceTypeHeader = new System.Windows.Forms.ColumnHeader();
            this.resourceGroupHeader = new System.Windows.Forms.ColumnHeader();
            this.resourceInstanceHeader = new System.Windows.Forms.ColumnHeader();
            this.resourceDataGroupBox = new System.Windows.Forms.GroupBox();
            this.resourceDataTextBox = new System.Windows.Forms.TextBox();
            this.resourceDataPictureBox = new System.Windows.Forms.PictureBox();
            this.conflictTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.losingGroupBox = new System.Windows.Forms.GroupBox();
            this.losingListView = new System.Windows.Forms.ListView();
            this.losingResourceHeader = new System.Windows.Forms.ColumnHeader();
            this.losingTagHeader = new System.Windows.Forms.ColumnHeader();
            this.losingPackageHeader1 = new System.Windows.Forms.ColumnHeader();
            this.losingBlankHeader = new System.Windows.Forms.ColumnHeader();
            this.losingModHeader = new System.Windows.Forms.ColumnHeader();
            this.losingPackageHeader2 = new System.Windows.Forms.ColumnHeader();
            this.winningGroupBox = new System.Windows.Forms.GroupBox();
            this.winningListView = new System.Windows.Forms.ListView();
            this.winningResourceHeader = new System.Windows.Forms.ColumnHeader();
            this.winningTagHeader = new System.Windows.Forms.ColumnHeader();
            this.winningPackageHeader1 = new System.Windows.Forms.ColumnHeader();
            this.winningBlankHeader = new System.Windows.Forms.ColumnHeader();
            this.winningModHeader = new System.Windows.Forms.ColumnHeader();
            this.winningPackageHeader2 = new System.Windows.Forms.ColumnHeader();
            this.resourceDataBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.tabControl.SuspendLayout();
            this.informationTabPage.SuspendLayout();
            this.contentTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packageSplitContainer)).BeginInit();
            this.packageSplitContainer.Panel1.SuspendLayout();
            this.packageSplitContainer.SuspendLayout();
            this.packageGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resourceSplitContainer)).BeginInit();
            this.resourceSplitContainer.Panel1.SuspendLayout();
            this.resourceSplitContainer.Panel2.SuspendLayout();
            this.resourceSplitContainer.SuspendLayout();
            this.resourceGroupBox.SuspendLayout();
            this.resourceDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resourceDataPictureBox)).BeginInit();
            this.conflictTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.losingGroupBox.SuspendLayout();
            this.winningGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.informationTabPage);
            this.tabControl.Controls.Add(this.contentTabPage);
            this.tabControl.Controls.Add(this.conflictTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(833, 553);
            this.tabControl.TabIndex = 0;
            // 
            // informationTabPage
            // 
            this.informationTabPage.Controls.Add(this.informationNoteTextBox);
            this.informationTabPage.Controls.Add(this.informationURLTextBox);
            this.informationTabPage.Controls.Add(this.informationURLLabel);
            this.informationTabPage.Controls.Add(this.informationNoteLabel);
            this.informationTabPage.Location = new System.Drawing.Point(4, 24);
            this.informationTabPage.Name = "informationTabPage";
            this.informationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.informationTabPage.Size = new System.Drawing.Size(825, 525);
            this.informationTabPage.TabIndex = 3;
            this.informationTabPage.Text = "Information";
            this.informationTabPage.UseVisualStyleBackColor = true;
            // 
            // informationNoteTextBox
            // 
            this.informationNoteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.informationNoteTextBox.Location = new System.Drawing.Point(20, 83);
            this.informationNoteTextBox.Multiline = true;
            this.informationNoteTextBox.Name = "informationNoteTextBox";
            this.informationNoteTextBox.Size = new System.Drawing.Size(784, 414);
            this.informationNoteTextBox.TabIndex = 3;
            // 
            // informationURLTextBox
            // 
            this.informationURLTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.informationURLTextBox.Location = new System.Drawing.Point(20, 29);
            this.informationURLTextBox.Name = "informationURLTextBox";
            this.informationURLTextBox.Size = new System.Drawing.Size(784, 23);
            this.informationURLTextBox.TabIndex = 2;
            // 
            // informationURLLabel
            // 
            this.informationURLLabel.AutoSize = true;
            this.informationURLLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.informationURLLabel.Location = new System.Drawing.Point(20, 11);
            this.informationURLLabel.Name = "informationURLLabel";
            this.informationURLLabel.Size = new System.Drawing.Size(28, 15);
            this.informationURLLabel.TabIndex = 1;
            this.informationURLLabel.Text = "URL";
            // 
            // informationNoteLabel
            // 
            this.informationNoteLabel.AutoSize = true;
            this.informationNoteLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.informationNoteLabel.Location = new System.Drawing.Point(20, 65);
            this.informationNoteLabel.Name = "informationNoteLabel";
            this.informationNoteLabel.Size = new System.Drawing.Size(33, 15);
            this.informationNoteLabel.TabIndex = 0;
            this.informationNoteLabel.Text = "Note";
            // 
            // contentTabPage
            // 
            this.contentTabPage.Controls.Add(this.packageSplitContainer);
            this.contentTabPage.Controls.Add(this.resourceSplitContainer);
            this.contentTabPage.Location = new System.Drawing.Point(4, 24);
            this.contentTabPage.Name = "contentTabPage";
            this.contentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.contentTabPage.Size = new System.Drawing.Size(825, 525);
            this.contentTabPage.TabIndex = 2;
            this.contentTabPage.Text = "Content";
            this.contentTabPage.UseVisualStyleBackColor = true;
            // 
            // packageSplitContainer
            // 
            this.packageSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.packageSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.packageSplitContainer.Name = "packageSplitContainer";
            // 
            // packageSplitContainer.Panel1
            // 
            this.packageSplitContainer.Panel1.Controls.Add(this.packageGroupBox);
            this.packageSplitContainer.Size = new System.Drawing.Size(819, 519);
            this.packageSplitContainer.SplitterDistance = 491;
            this.packageSplitContainer.TabIndex = 7;
            this.packageSplitContainer.Visible = false;
            // 
            // packageGroupBox
            // 
            this.packageGroupBox.Controls.Add(this.packageListView);
            this.packageGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.packageGroupBox.Location = new System.Drawing.Point(0, 0);
            this.packageGroupBox.Name = "packageGroupBox";
            this.packageGroupBox.Size = new System.Drawing.Size(491, 519);
            this.packageGroupBox.TabIndex = 4;
            this.packageGroupBox.TabStop = false;
            this.packageGroupBox.Text = "Package";
            // 
            // packageListView
            // 
            this.packageListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.packageHeader,
            this.packageFlagHeader});
            this.packageListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.packageListView.FullRowSelect = true;
            this.packageListView.Location = new System.Drawing.Point(3, 19);
            this.packageListView.Name = "packageListView";
            this.packageListView.OwnerDraw = true;
            this.packageListView.Size = new System.Drawing.Size(485, 497);
            this.packageListView.TabIndex = 3;
            this.packageListView.UseCompatibleStateImageBehavior = false;
            this.packageListView.View = System.Windows.Forms.View.Details;
            this.packageListView.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.packageListView_DrawColumnHeader);
            this.packageListView.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.packageListView_DrawSubItem);
            this.packageListView.SelectedIndexChanged += new System.EventHandler(this.packageListView_SelectedIndexChanged);
            this.packageListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.packageListView_MouseDoubleClick);
            // 
            // packageHeader
            // 
            this.packageHeader.Text = "Package";
            this.packageHeader.Width = 350;
            // 
            // packageFlagHeader
            // 
            this.packageFlagHeader.Text = "Flag";
            this.packageFlagHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.packageFlagHeader.Width = 50;
            // 
            // resourceSplitContainer
            // 
            this.resourceSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resourceSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.resourceSplitContainer.Name = "resourceSplitContainer";
            // 
            // resourceSplitContainer.Panel1
            // 
            this.resourceSplitContainer.Panel1.Controls.Add(this.resourceGroupBox);
            // 
            // resourceSplitContainer.Panel2
            // 
            this.resourceSplitContainer.Panel2.Controls.Add(this.resourceDataGroupBox);
            this.resourceSplitContainer.Size = new System.Drawing.Size(819, 519);
            this.resourceSplitContainer.SplitterDistance = 434;
            this.resourceSplitContainer.TabIndex = 6;
            this.resourceSplitContainer.Visible = false;
            // 
            // resourceGroupBox
            // 
            this.resourceGroupBox.Controls.Add(this.resourceProgressLabel);
            this.resourceGroupBox.Controls.Add(this.resourceProgressBar);
            this.resourceGroupBox.Controls.Add(this.resourceListView);
            this.resourceGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resourceGroupBox.Location = new System.Drawing.Point(0, 0);
            this.resourceGroupBox.Name = "resourceGroupBox";
            this.resourceGroupBox.Padding = new System.Windows.Forms.Padding(5, 3, 5, 10);
            this.resourceGroupBox.Size = new System.Drawing.Size(434, 519);
            this.resourceGroupBox.TabIndex = 3;
            this.resourceGroupBox.TabStop = false;
            this.resourceGroupBox.Text = "Resource";
            // 
            // resourceProgressLabel
            // 
            this.resourceProgressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resourceProgressLabel.Location = new System.Drawing.Point(62, 498);
            this.resourceProgressLabel.Name = "resourceProgressLabel";
            this.resourceProgressLabel.Size = new System.Drawing.Size(222, 15);
            this.resourceProgressLabel.TabIndex = 4;
            this.resourceProgressLabel.Text = "Reading";
            this.resourceProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resourceProgressLabel.Visible = false;
            // 
            // resourceProgressBar
            // 
            this.resourceProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resourceProgressBar.Location = new System.Drawing.Point(290, 499);
            this.resourceProgressBar.Name = "resourceProgressBar";
            this.resourceProgressBar.Size = new System.Drawing.Size(138, 14);
            this.resourceProgressBar.Step = 1;
            this.resourceProgressBar.TabIndex = 3;
            this.resourceProgressBar.Visible = false;
            // 
            // resourceListView
            // 
            this.resourceListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resourceListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemHeader,
            this.resourceNameHeader,
            this.resourceTagHeader,
            this.resourceTypeHeader,
            this.resourceGroupHeader,
            this.resourceInstanceHeader});
            this.resourceListView.FullRowSelect = true;
            this.resourceListView.Location = new System.Drawing.Point(4, 19);
            this.resourceListView.Name = "resourceListView";
            this.resourceListView.Size = new System.Drawing.Size(426, 475);
            this.resourceListView.TabIndex = 2;
            this.resourceListView.UseCompatibleStateImageBehavior = false;
            this.resourceListView.View = System.Windows.Forms.View.Details;
            this.resourceListView.SelectedIndexChanged += new System.EventHandler(this.resourceListView_SelectedIndexChanged);
            // 
            // itemHeader
            // 
            this.itemHeader.DisplayIndex = 5;
            this.itemHeader.Text = "";
            this.itemHeader.Width = 0;
            // 
            // resourceNameHeader
            // 
            this.resourceNameHeader.DisplayIndex = 0;
            this.resourceNameHeader.Text = "Name";
            // 
            // resourceTagHeader
            // 
            this.resourceTagHeader.DisplayIndex = 1;
            this.resourceTagHeader.Text = "Tag";
            this.resourceTagHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resourceTagHeader.Width = 50;
            // 
            // resourceTypeHeader
            // 
            this.resourceTypeHeader.DisplayIndex = 2;
            this.resourceTypeHeader.Text = "Type";
            this.resourceTypeHeader.Width = 80;
            // 
            // resourceGroupHeader
            // 
            this.resourceGroupHeader.DisplayIndex = 3;
            this.resourceGroupHeader.Text = "Group";
            this.resourceGroupHeader.Width = 80;
            // 
            // resourceInstanceHeader
            // 
            this.resourceInstanceHeader.DisplayIndex = 4;
            this.resourceInstanceHeader.Text = "Instance";
            this.resourceInstanceHeader.Width = 135;
            // 
            // resourceDataGroupBox
            // 
            this.resourceDataGroupBox.Controls.Add(this.resourceDataTextBox);
            this.resourceDataGroupBox.Controls.Add(this.resourceDataPictureBox);
            this.resourceDataGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resourceDataGroupBox.Location = new System.Drawing.Point(0, 0);
            this.resourceDataGroupBox.Name = "resourceDataGroupBox";
            this.resourceDataGroupBox.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.resourceDataGroupBox.Size = new System.Drawing.Size(381, 519);
            this.resourceDataGroupBox.TabIndex = 4;
            this.resourceDataGroupBox.TabStop = false;
            // 
            // resourceDataTextBox
            // 
            this.resourceDataTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resourceDataTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resourceDataTextBox.Location = new System.Drawing.Point(3, 16);
            this.resourceDataTextBox.Multiline = true;
            this.resourceDataTextBox.Name = "resourceDataTextBox";
            this.resourceDataTextBox.ReadOnly = true;
            this.resourceDataTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resourceDataTextBox.Size = new System.Drawing.Size(375, 500);
            this.resourceDataTextBox.TabIndex = 0;
            this.resourceDataTextBox.Visible = false;
            this.resourceDataTextBox.WordWrap = false;
            // 
            // resourceDataPictureBox
            // 
            this.resourceDataPictureBox.BackgroundImage = global::s3mo.Properties.Resources.checkerboard_500;
            this.resourceDataPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resourceDataPictureBox.Location = new System.Drawing.Point(3, 16);
            this.resourceDataPictureBox.Name = "resourceDataPictureBox";
            this.resourceDataPictureBox.Size = new System.Drawing.Size(375, 500);
            this.resourceDataPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resourceDataPictureBox.TabIndex = 1;
            this.resourceDataPictureBox.TabStop = false;
            this.resourceDataPictureBox.Visible = false;
            // 
            // conflictTabPage
            // 
            this.conflictTabPage.Controls.Add(this.splitContainer1);
            this.conflictTabPage.Location = new System.Drawing.Point(4, 24);
            this.conflictTabPage.Name = "conflictTabPage";
            this.conflictTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.conflictTabPage.Size = new System.Drawing.Size(825, 525);
            this.conflictTabPage.TabIndex = 1;
            this.conflictTabPage.Text = "Conflicts";
            this.conflictTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.losingGroupBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.winningGroupBox);
            this.splitContainer1.Size = new System.Drawing.Size(819, 519);
            this.splitContainer1.SplitterDistance = 258;
            this.splitContainer1.TabIndex = 0;
            // 
            // losingGroupBox
            // 
            this.losingGroupBox.Controls.Add(this.losingListView);
            this.losingGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.losingGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.losingGroupBox.Location = new System.Drawing.Point(0, 0);
            this.losingGroupBox.Name = "losingGroupBox";
            this.losingGroupBox.Size = new System.Drawing.Size(819, 258);
            this.losingGroupBox.TabIndex = 2;
            this.losingGroupBox.TabStop = false;
            this.losingGroupBox.Text = "The list below shows the resources from other mods that will be replaced by this " +
    "mod";
            // 
            // losingListView
            // 
            this.losingListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.losingListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.losingResourceHeader,
            this.losingTagHeader,
            this.losingPackageHeader1,
            this.losingBlankHeader,
            this.losingModHeader,
            this.losingPackageHeader2});
            this.losingListView.FullRowSelect = true;
            this.losingListView.Location = new System.Drawing.Point(14, 19);
            this.losingListView.Name = "losingListView";
            this.losingListView.OwnerDraw = true;
            this.losingListView.Size = new System.Drawing.Size(791, 230);
            this.losingListView.TabIndex = 1;
            this.losingListView.UseCompatibleStateImageBehavior = false;
            this.losingListView.View = System.Windows.Forms.View.Details;
            this.losingListView.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.losingListView_DrawColumnHeader);
            this.losingListView.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.losingListView_DrawSubItem);
            // 
            // losingResourceHeader
            // 
            this.losingResourceHeader.DisplayIndex = 1;
            this.losingResourceHeader.Text = "Resource";
            this.losingResourceHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.losingResourceHeader.Width = 270;
            // 
            // losingTagHeader
            // 
            this.losingTagHeader.DisplayIndex = 0;
            this.losingTagHeader.Text = "Tag";
            this.losingTagHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // losingPackageHeader1
            // 
            this.losingPackageHeader1.Text = "Package";
            this.losingPackageHeader1.Width = 30;
            // 
            // losingBlankHeader
            // 
            this.losingBlankHeader.Text = "";
            this.losingBlankHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.losingBlankHeader.Width = 20;
            // 
            // losingModHeader
            // 
            this.losingModHeader.Text = "Mod";
            this.losingModHeader.Width = 250;
            // 
            // losingPackageHeader2
            // 
            this.losingPackageHeader2.Text = "Package";
            this.losingPackageHeader2.Width = 30;
            // 
            // winningGroupBox
            // 
            this.winningGroupBox.Controls.Add(this.winningListView);
            this.winningGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.winningGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.winningGroupBox.Location = new System.Drawing.Point(0, 0);
            this.winningGroupBox.Name = "winningGroupBox";
            this.winningGroupBox.Size = new System.Drawing.Size(819, 257);
            this.winningGroupBox.TabIndex = 3;
            this.winningGroupBox.TabStop = false;
            this.winningGroupBox.Text = "The list below shows the resources from other mods that will replace this mod";
            // 
            // winningListView
            // 
            this.winningListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.winningListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.winningResourceHeader,
            this.winningTagHeader,
            this.winningPackageHeader1,
            this.winningBlankHeader,
            this.winningModHeader,
            this.winningPackageHeader2});
            this.winningListView.FullRowSelect = true;
            this.winningListView.Location = new System.Drawing.Point(14, 19);
            this.winningListView.Name = "winningListView";
            this.winningListView.OwnerDraw = true;
            this.winningListView.Size = new System.Drawing.Size(791, 233);
            this.winningListView.TabIndex = 2;
            this.winningListView.UseCompatibleStateImageBehavior = false;
            this.winningListView.View = System.Windows.Forms.View.Details;
            this.winningListView.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.winningListView_DrawColumnHeader);
            this.winningListView.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.winningListView_DrawSubItem);
            // 
            // winningResourceHeader
            // 
            this.winningResourceHeader.DisplayIndex = 1;
            this.winningResourceHeader.Text = "Resource";
            this.winningResourceHeader.Width = 270;
            // 
            // winningTagHeader
            // 
            this.winningTagHeader.DisplayIndex = 0;
            this.winningTagHeader.Text = "Tag";
            this.winningTagHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // winningPackageHeader1
            // 
            this.winningPackageHeader1.Text = "Package";
            this.winningPackageHeader1.Width = 30;
            // 
            // winningBlankHeader
            // 
            this.winningBlankHeader.Text = "";
            this.winningBlankHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.winningBlankHeader.Width = 20;
            // 
            // winningModHeader
            // 
            this.winningModHeader.Text = "Mod";
            this.winningModHeader.Width = 250;
            // 
            // winningPackageHeader2
            // 
            this.winningPackageHeader2.Text = "Package";
            this.winningPackageHeader2.Width = 30;
            // 
            // resourceDataBackgroundWorker
            // 
            this.resourceDataBackgroundWorker.WorkerReportsProgress = true;
            this.resourceDataBackgroundWorker.WorkerSupportsCancellation = true;
            this.resourceDataBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.resourceDataBackgroundWorker_DoWork);
            this.resourceDataBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.resourceDataBackgroundWorker_ProgressChanged);
            this.resourceDataBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.resourceDataBackgroundWorker_RunWorkerCompleted);
            // 
            // ModForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 553);
            this.Controls.Add(this.tabControl);
            this.MinimizeBox = false;
            this.Name = "ModForm";
            this.ShowIcon = false;
            this.Text = "ModForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModForm_FormClosing);
            this.Load += new System.EventHandler(this.ModForm_Load);
            this.tabControl.ResumeLayout(false);
            this.informationTabPage.ResumeLayout(false);
            this.informationTabPage.PerformLayout();
            this.contentTabPage.ResumeLayout(false);
            this.packageSplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.packageSplitContainer)).EndInit();
            this.packageSplitContainer.ResumeLayout(false);
            this.packageGroupBox.ResumeLayout(false);
            this.resourceSplitContainer.Panel1.ResumeLayout(false);
            this.resourceSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resourceSplitContainer)).EndInit();
            this.resourceSplitContainer.ResumeLayout(false);
            this.resourceGroupBox.ResumeLayout(false);
            this.resourceDataGroupBox.ResumeLayout(false);
            this.resourceDataGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resourceDataPictureBox)).EndInit();
            this.conflictTabPage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.losingGroupBox.ResumeLayout(false);
            this.winningGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage conflictTabPage;
        private SplitContainer splitContainer1;
        private ListView losingListView;
        private ListView winningListView;
        private ColumnHeader losingPackageHeader1;
        private ColumnHeader winningPackageHeader1;
        private ColumnHeader losingBlankHeader;
        private ColumnHeader losingModHeader;
        private ColumnHeader losingPackageHeader2;
        private ColumnHeader winningBlankHeader;
        private ColumnHeader winningModHeader;
        private ColumnHeader winningPackageHeader2;
        private ColumnHeader winningResourceHeader;
        private ColumnHeader winningTagHeader;
        private ColumnHeader losingResourceHeader;
        private ColumnHeader losingTagHeader;
        private GroupBox losingGroupBox;
        private GroupBox winningGroupBox;
        private TabPage contentTabPage;
        private ListView resourceListView;
        private ColumnHeader resourceInstanceHeader;
        private ColumnHeader resourceTagHeader;
        private ColumnHeader resourceTypeHeader;
        private ColumnHeader resourceGroupHeader;
        private ColumnHeader itemHeader;
        private GroupBox resourceDataGroupBox;
        private GroupBox resourceGroupBox;
        private System.ComponentModel.BackgroundWorker resourceDataBackgroundWorker;
        private TextBox resourceDataTextBox;
        private PictureBox resourceDataPictureBox;
        private ListView packageListView;
        private ColumnHeader packageHeader;
        private SplitContainer resourceSplitContainer;
        private ColumnHeader packageFlagHeader;
        private SplitContainer packageSplitContainer;
        private GroupBox packageGroupBox;
        private Label resourceProgressLabel;
        private ProgressBar resourceProgressBar;
        private ColumnHeader resourceNameHeader;
        private TabPage informationTabPage;
        private TextBox informationNoteTextBox;
        private TextBox informationURLTextBox;
        private Label informationURLLabel;
        private Label informationNoteLabel;
    }
}