namespace s3mo
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.gamePathLabel = new System.Windows.Forms.Label();
            this.gamePathTextBox = new System.Windows.Forms.TextBox();
            this.gamePathButton = new System.Windows.Forms.Button();
            this.documentsButton = new System.Windows.Forms.Button();
            this.documentsTextBox = new System.Windows.Forms.TextBox();
            this.documentsPathLabel = new System.Windows.Forms.Label();
            this.buildSizeLimitLabel = new System.Windows.Forms.Label();
            this.buildSizeLimitNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.buildPrioirtyNumbericUpDown = new System.Windows.Forms.NumericUpDown();
            this.buildPriorityLabel = new System.Windows.Forms.Label();
            this.pathGroupBox = new System.Windows.Forms.GroupBox();
            this.buildGroupBox = new System.Windows.Forms.GroupBox();
            this.resourcecfgTextBox = new System.Windows.Forms.TextBox();
            this.resourcecfgLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.defaultBuildSizeLimitLabel = new System.Windows.Forms.Label();
            this.cacheGroupBox = new System.Windows.Forms.GroupBox();
            this.nraasScriptErrorCheckBox = new System.Windows.Forms.CheckBox();
            this.savedSimsDownloadedsimsCheckBox = new System.Windows.Forms.CheckBox();
            this.sigsCacheBinCheckBox = new System.Windows.Forms.CheckBox();
            this.downloadsBinCheckBox = new System.Windows.Forms.CheckBox();
            this.igaCacheCheckBox = new System.Windows.Forms.CheckBox();
            this.dcCacheDccCheckBox = new System.Windows.Forms.CheckBox();
            this.dcCacheMissingdepsCheckBox = new System.Windows.Forms.CheckBox();
            this.featuredItemCheckbox = new System.Windows.Forms.CheckBox();
            this.thumbnailCheckBox = new System.Windows.Forms.CheckBox();
            this.worldCacheCheckBox = new System.Windows.Forms.CheckBox();
            this.socialCacheCheckBox = new System.Windows.Forms.CheckBox();
            this.simCompositorCacheCheckBox = new System.Windows.Forms.CheckBox();
            this.scriptCacheCheckBox = new System.Windows.Forms.CheckBox();
            this.compositorCacheCheckBox = new System.Windows.Forms.CheckBox();
            this.casPartCacheCheckBox = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.buildSizeLimitNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildPrioirtyNumbericUpDown)).BeginInit();
            this.pathGroupBox.SuspendLayout();
            this.buildGroupBox.SuspendLayout();
            this.cacheGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamePathLabel
            // 
            this.gamePathLabel.AutoSize = true;
            this.gamePathLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gamePathLabel.Location = new System.Drawing.Point(17, 33);
            this.gamePathLabel.Name = "gamePathLabel";
            this.gamePathLabel.Size = new System.Drawing.Size(64, 15);
            this.gamePathLabel.TabIndex = 0;
            this.gamePathLabel.Text = "Executable";
            this.toolTip1.SetToolTip(this.gamePathLabel, "The executable that will run when play button is hit.");
            // 
            // gamePathTextBox
            // 
            this.gamePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gamePathTextBox.Location = new System.Drawing.Point(87, 30);
            this.gamePathTextBox.Name = "gamePathTextBox";
            this.gamePathTextBox.Size = new System.Drawing.Size(325, 23);
            this.gamePathTextBox.TabIndex = 1;
            // 
            // gamePathButton
            // 
            this.gamePathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gamePathButton.Location = new System.Drawing.Point(417, 30);
            this.gamePathButton.Name = "gamePathButton";
            this.gamePathButton.Size = new System.Drawing.Size(41, 23);
            this.gamePathButton.TabIndex = 2;
            this.gamePathButton.Text = "...";
            this.gamePathButton.UseVisualStyleBackColor = true;
            this.gamePathButton.Click += new System.EventHandler(this.gamePathButton_Click);
            // 
            // documentsButton
            // 
            this.documentsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.documentsButton.Location = new System.Drawing.Point(417, 67);
            this.documentsButton.Name = "documentsButton";
            this.documentsButton.Size = new System.Drawing.Size(41, 23);
            this.documentsButton.TabIndex = 5;
            this.documentsButton.Text = "...";
            this.documentsButton.UseVisualStyleBackColor = true;
            this.documentsButton.Click += new System.EventHandler(this.documentsButton_Click);
            // 
            // documentsTextBox
            // 
            this.documentsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.documentsTextBox.Location = new System.Drawing.Point(87, 67);
            this.documentsTextBox.Name = "documentsTextBox";
            this.documentsTextBox.Size = new System.Drawing.Size(325, 23);
            this.documentsTextBox.TabIndex = 4;
            // 
            // documentsPathLabel
            // 
            this.documentsPathLabel.AutoSize = true;
            this.documentsPathLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.documentsPathLabel.Location = new System.Drawing.Point(12, 71);
            this.documentsPathLabel.Name = "documentsPathLabel";
            this.documentsPathLabel.Size = new System.Drawing.Size(69, 15);
            this.documentsPathLabel.TabIndex = 3;
            this.documentsPathLabel.Text = "Documents";
            this.toolTip1.SetToolTip(this.documentsPathLabel, "The Sims 3 documents folder");
            // 
            // buildSizeLimitLabel
            // 
            this.buildSizeLimitLabel.AutoSize = true;
            this.buildSizeLimitLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buildSizeLimitLabel.Location = new System.Drawing.Point(36, 27);
            this.buildSizeLimitLabel.Name = "buildSizeLimitLabel";
            this.buildSizeLimitLabel.Size = new System.Drawing.Size(88, 15);
            this.buildSizeLimitLabel.TabIndex = 0;
            this.buildSizeLimitLabel.Text = "Size Limit (MB)";
            this.toolTip1.SetToolTip(this.buildSizeLimitLabel, "Size limit of every individual merged packages in megabytes. Setting it too high " +
        "may cause issues.");
            // 
            // buildSizeLimitNumericUpDown
            // 
            this.buildSizeLimitNumericUpDown.Location = new System.Drawing.Point(130, 24);
            this.buildSizeLimitNumericUpDown.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.buildSizeLimitNumericUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.buildSizeLimitNumericUpDown.Name = "buildSizeLimitNumericUpDown";
            this.buildSizeLimitNumericUpDown.Size = new System.Drawing.Size(100, 23);
            this.buildSizeLimitNumericUpDown.TabIndex = 2;
            this.buildSizeLimitNumericUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // buildPrioirtyNumbericUpDown
            // 
            this.buildPrioirtyNumbericUpDown.Location = new System.Drawing.Point(130, 56);
            this.buildPrioirtyNumbericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.buildPrioirtyNumbericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.buildPrioirtyNumbericUpDown.Name = "buildPrioirtyNumbericUpDown";
            this.buildPrioirtyNumbericUpDown.Size = new System.Drawing.Size(100, 23);
            this.buildPrioirtyNumbericUpDown.TabIndex = 4;
            this.buildPrioirtyNumbericUpDown.Value = new decimal(new int[] {
            495,
            0,
            0,
            0});
            // 
            // buildPriorityLabel
            // 
            this.buildPriorityLabel.AutoSize = true;
            this.buildPriorityLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buildPriorityLabel.Location = new System.Drawing.Point(79, 59);
            this.buildPriorityLabel.Name = "buildPriorityLabel";
            this.buildPriorityLabel.Size = new System.Drawing.Size(45, 15);
            this.buildPriorityLabel.TabIndex = 3;
            this.buildPriorityLabel.Text = "Priority";
            this.toolTip1.SetToolTip(this.buildPriorityLabel, "Priority of the merged package within the game mods folder");
            // 
            // pathGroupBox
            // 
            this.pathGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathGroupBox.Controls.Add(this.documentsPathLabel);
            this.pathGroupBox.Controls.Add(this.gamePathTextBox);
            this.pathGroupBox.Controls.Add(this.documentsButton);
            this.pathGroupBox.Controls.Add(this.gamePathButton);
            this.pathGroupBox.Controls.Add(this.gamePathLabel);
            this.pathGroupBox.Controls.Add(this.documentsTextBox);
            this.pathGroupBox.Location = new System.Drawing.Point(13, 12);
            this.pathGroupBox.Name = "pathGroupBox";
            this.pathGroupBox.Size = new System.Drawing.Size(478, 117);
            this.pathGroupBox.TabIndex = 6;
            this.pathGroupBox.TabStop = false;
            this.pathGroupBox.Text = "Game Path";
            // 
            // buildGroupBox
            // 
            this.buildGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buildGroupBox.Controls.Add(this.resourcecfgTextBox);
            this.buildGroupBox.Controls.Add(this.resourcecfgLabel);
            this.buildGroupBox.Controls.Add(this.label1);
            this.buildGroupBox.Controls.Add(this.defaultBuildSizeLimitLabel);
            this.buildGroupBox.Controls.Add(this.buildSizeLimitNumericUpDown);
            this.buildGroupBox.Controls.Add(this.buildSizeLimitLabel);
            this.buildGroupBox.Controls.Add(this.buildPrioirtyNumbericUpDown);
            this.buildGroupBox.Controls.Add(this.buildPriorityLabel);
            this.buildGroupBox.Location = new System.Drawing.Point(13, 135);
            this.buildGroupBox.Name = "buildGroupBox";
            this.buildGroupBox.Size = new System.Drawing.Size(478, 200);
            this.buildGroupBox.TabIndex = 7;
            this.buildGroupBox.TabStop = false;
            this.buildGroupBox.Text = "Build";
            // 
            // resourcecfgTextBox
            // 
            this.resourcecfgTextBox.Location = new System.Drawing.Point(130, 89);
            this.resourcecfgTextBox.Multiline = true;
            this.resourcecfgTextBox.Name = "resourcecfgTextBox";
            this.resourcecfgTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resourcecfgTextBox.Size = new System.Drawing.Size(282, 97);
            this.resourcecfgTextBox.TabIndex = 8;
            this.resourcecfgTextBox.Text = resources.GetString("resourcecfgTextBox.Text");
            // 
            // resourcecfgLabel
            // 
            this.resourcecfgLabel.AutoSize = true;
            this.resourcecfgLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resourcecfgLabel.Location = new System.Drawing.Point(49, 88);
            this.resourcecfgLabel.Name = "resourcecfgLabel";
            this.resourcecfgLabel.Size = new System.Drawing.Size(75, 15);
            this.resourcecfgLabel.TabIndex = 7;
            this.resourcecfgLabel.Text = "Resource.cfg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "(Default : 495)";
            // 
            // defaultBuildSizeLimitLabel
            // 
            this.defaultBuildSizeLimitLabel.AutoSize = true;
            this.defaultBuildSizeLimitLabel.Location = new System.Drawing.Point(236, 27);
            this.defaultBuildSizeLimitLabel.Name = "defaultBuildSizeLimitLabel";
            this.defaultBuildSizeLimitLabel.Size = new System.Drawing.Size(86, 15);
            this.defaultBuildSizeLimitLabel.TabIndex = 5;
            this.defaultBuildSizeLimitLabel.Text = "(Default : 1000)";
            // 
            // cacheGroupBox
            // 
            this.cacheGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cacheGroupBox.Controls.Add(this.nraasScriptErrorCheckBox);
            this.cacheGroupBox.Controls.Add(this.savedSimsDownloadedsimsCheckBox);
            this.cacheGroupBox.Controls.Add(this.sigsCacheBinCheckBox);
            this.cacheGroupBox.Controls.Add(this.downloadsBinCheckBox);
            this.cacheGroupBox.Controls.Add(this.igaCacheCheckBox);
            this.cacheGroupBox.Controls.Add(this.dcCacheDccCheckBox);
            this.cacheGroupBox.Controls.Add(this.dcCacheMissingdepsCheckBox);
            this.cacheGroupBox.Controls.Add(this.featuredItemCheckbox);
            this.cacheGroupBox.Controls.Add(this.thumbnailCheckBox);
            this.cacheGroupBox.Controls.Add(this.worldCacheCheckBox);
            this.cacheGroupBox.Controls.Add(this.socialCacheCheckBox);
            this.cacheGroupBox.Controls.Add(this.simCompositorCacheCheckBox);
            this.cacheGroupBox.Controls.Add(this.scriptCacheCheckBox);
            this.cacheGroupBox.Controls.Add(this.compositorCacheCheckBox);
            this.cacheGroupBox.Controls.Add(this.casPartCacheCheckBox);
            this.cacheGroupBox.Location = new System.Drawing.Point(13, 341);
            this.cacheGroupBox.Name = "cacheGroupBox";
            this.cacheGroupBox.Size = new System.Drawing.Size(478, 258);
            this.cacheGroupBox.TabIndex = 8;
            this.cacheGroupBox.TabStop = false;
            this.cacheGroupBox.Text = "Clear Caches";
            // 
            // nraasScriptErrorCheckBox
            // 
            this.nraasScriptErrorCheckBox.AutoSize = true;
            this.nraasScriptErrorCheckBox.Location = new System.Drawing.Point(30, 229);
            this.nraasScriptErrorCheckBox.Name = "nraasScriptErrorCheckBox";
            this.nraasScriptErrorCheckBox.Size = new System.Drawing.Size(142, 19);
            this.nraasScriptErrorCheckBox.TabIndex = 14;
            this.nraasScriptErrorCheckBox.Text = "NRaas ScriptError logs";
            this.nraasScriptErrorCheckBox.UseVisualStyleBackColor = true;
            // 
            // savedSimsDownloadedsimsCheckBox
            // 
            this.savedSimsDownloadedsimsCheckBox.AutoSize = true;
            this.savedSimsDownloadedsimsCheckBox.Location = new System.Drawing.Point(247, 154);
            this.savedSimsDownloadedsimsCheckBox.Name = "savedSimsDownloadedsimsCheckBox";
            this.savedSimsDownloadedsimsCheckBox.Size = new System.Drawing.Size(209, 19);
            this.savedSimsDownloadedsimsCheckBox.TabIndex = 13;
            this.savedSimsDownloadedsimsCheckBox.Text = "SavedSims\\downloadedsims.index";
            this.savedSimsDownloadedsimsCheckBox.UseVisualStyleBackColor = true;
            // 
            // sigsCacheBinCheckBox
            // 
            this.sigsCacheBinCheckBox.AutoSize = true;
            this.sigsCacheBinCheckBox.Location = new System.Drawing.Point(247, 179);
            this.sigsCacheBinCheckBox.Name = "sigsCacheBinCheckBox";
            this.sigsCacheBinCheckBox.Size = new System.Drawing.Size(110, 19);
            this.sigsCacheBinCheckBox.TabIndex = 12;
            this.sigsCacheBinCheckBox.Text = "SigsCache\\*.bin";
            this.sigsCacheBinCheckBox.UseVisualStyleBackColor = true;
            // 
            // downloadsBinCheckBox
            // 
            this.downloadsBinCheckBox.AutoSize = true;
            this.downloadsBinCheckBox.Location = new System.Drawing.Point(247, 79);
            this.downloadsBinCheckBox.Name = "downloadsBinCheckBox";
            this.downloadsBinCheckBox.Size = new System.Drawing.Size(115, 19);
            this.downloadsBinCheckBox.TabIndex = 11;
            this.downloadsBinCheckBox.Text = "Downloads\\*.bin";
            this.downloadsBinCheckBox.UseVisualStyleBackColor = true;
            // 
            // igaCacheCheckBox
            // 
            this.igaCacheCheckBox.AutoSize = true;
            this.igaCacheCheckBox.Location = new System.Drawing.Point(247, 129);
            this.igaCacheCheckBox.Name = "igaCacheCheckBox";
            this.igaCacheCheckBox.Size = new System.Drawing.Size(114, 19);
            this.igaCacheCheckBox.TabIndex = 10;
            this.igaCacheCheckBox.Text = "IGACache Folder";
            this.igaCacheCheckBox.UseVisualStyleBackColor = true;
            // 
            // dcCacheDccCheckBox
            // 
            this.dcCacheDccCheckBox.AutoSize = true;
            this.dcCacheDccCheckBox.Location = new System.Drawing.Point(247, 29);
            this.dcCacheDccCheckBox.Name = "dcCacheDccCheckBox";
            this.dcCacheDccCheckBox.Size = new System.Drawing.Size(119, 19);
            this.dcCacheDccCheckBox.TabIndex = 9;
            this.dcCacheDccCheckBox.Text = "DCCache\\dcc.ent";
            this.dcCacheDccCheckBox.UseVisualStyleBackColor = true;
            // 
            // dcCacheMissingdepsCheckBox
            // 
            this.dcCacheMissingdepsCheckBox.AutoSize = true;
            this.dcCacheMissingdepsCheckBox.Location = new System.Drawing.Point(247, 54);
            this.dcCacheMissingdepsCheckBox.Name = "dcCacheMissingdepsCheckBox";
            this.dcCacheMissingdepsCheckBox.Size = new System.Drawing.Size(165, 19);
            this.dcCacheMissingdepsCheckBox.TabIndex = 8;
            this.dcCacheMissingdepsCheckBox.Text = "DCCache\\missingdeps.idx";
            this.dcCacheMissingdepsCheckBox.UseVisualStyleBackColor = true;
            // 
            // featuredItemCheckbox
            // 
            this.featuredItemCheckbox.AutoSize = true;
            this.featuredItemCheckbox.Location = new System.Drawing.Point(247, 104);
            this.featuredItemCheckbox.Name = "featuredItemCheckbox";
            this.featuredItemCheckbox.Size = new System.Drawing.Size(137, 19);
            this.featuredItemCheckbox.TabIndex = 7;
            this.featuredItemCheckbox.Text = "FeaturedItems Folder";
            this.featuredItemCheckbox.UseVisualStyleBackColor = true;
            // 
            // thumbnailCheckBox
            // 
            this.thumbnailCheckBox.AutoSize = true;
            this.thumbnailCheckBox.Location = new System.Drawing.Point(247, 204);
            this.thumbnailCheckBox.Name = "thumbnailCheckBox";
            this.thumbnailCheckBox.Size = new System.Drawing.Size(124, 19);
            this.thumbnailCheckBox.TabIndex = 6;
            this.thumbnailCheckBox.Text = "Thumbnails Folder";
            this.thumbnailCheckBox.UseVisualStyleBackColor = true;
            // 
            // worldCacheCheckBox
            // 
            this.worldCacheCheckBox.AutoSize = true;
            this.worldCacheCheckBox.Location = new System.Drawing.Point(247, 229);
            this.worldCacheCheckBox.Name = "worldCacheCheckBox";
            this.worldCacheCheckBox.Size = new System.Drawing.Size(132, 19);
            this.worldCacheCheckBox.TabIndex = 5;
            this.worldCacheCheckBox.Text = "WorldCaches Folder";
            this.worldCacheCheckBox.UseVisualStyleBackColor = true;
            // 
            // socialCacheCheckBox
            // 
            this.socialCacheCheckBox.AutoSize = true;
            this.socialCacheCheckBox.Checked = true;
            this.socialCacheCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.socialCacheCheckBox.Location = new System.Drawing.Point(30, 129);
            this.socialCacheCheckBox.Name = "socialCacheCheckBox";
            this.socialCacheCheckBox.Size = new System.Drawing.Size(89, 19);
            this.socialCacheCheckBox.TabIndex = 4;
            this.socialCacheCheckBox.Text = "socialCache";
            this.socialCacheCheckBox.UseVisualStyleBackColor = true;
            // 
            // simCompositorCacheCheckBox
            // 
            this.simCompositorCacheCheckBox.AutoSize = true;
            this.simCompositorCacheCheckBox.Checked = true;
            this.simCompositorCacheCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.simCompositorCacheCheckBox.Location = new System.Drawing.Point(30, 104);
            this.simCompositorCacheCheckBox.Name = "simCompositorCacheCheckBox";
            this.simCompositorCacheCheckBox.Size = new System.Drawing.Size(141, 19);
            this.simCompositorCacheCheckBox.TabIndex = 3;
            this.simCompositorCacheCheckBox.Text = "simCompositorCache";
            this.simCompositorCacheCheckBox.UseVisualStyleBackColor = true;
            // 
            // scriptCacheCheckBox
            // 
            this.scriptCacheCheckBox.AutoSize = true;
            this.scriptCacheCheckBox.Checked = true;
            this.scriptCacheCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.scriptCacheCheckBox.Location = new System.Drawing.Point(30, 79);
            this.scriptCacheCheckBox.Name = "scriptCacheCheckBox";
            this.scriptCacheCheckBox.Size = new System.Drawing.Size(88, 19);
            this.scriptCacheCheckBox.TabIndex = 2;
            this.scriptCacheCheckBox.Text = "scriptCache";
            this.scriptCacheCheckBox.UseVisualStyleBackColor = true;
            // 
            // compositorCacheCheckBox
            // 
            this.compositorCacheCheckBox.AutoSize = true;
            this.compositorCacheCheckBox.Checked = true;
            this.compositorCacheCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.compositorCacheCheckBox.Location = new System.Drawing.Point(30, 54);
            this.compositorCacheCheckBox.Name = "compositorCacheCheckBox";
            this.compositorCacheCheckBox.Size = new System.Drawing.Size(120, 19);
            this.compositorCacheCheckBox.TabIndex = 1;
            this.compositorCacheCheckBox.Text = "compositorCache";
            this.compositorCacheCheckBox.UseVisualStyleBackColor = true;
            // 
            // casPartCacheCheckBox
            // 
            this.casPartCacheCheckBox.AutoSize = true;
            this.casPartCacheCheckBox.Checked = true;
            this.casPartCacheCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.casPartCacheCheckBox.Location = new System.Drawing.Point(30, 29);
            this.casPartCacheCheckBox.Name = "casPartCacheCheckBox";
            this.casPartCacheCheckBox.Size = new System.Drawing.Size(102, 19);
            this.casPartCacheCheckBox.TabIndex = 0;
            this.casPartCacheCheckBox.Text = "CASPartCache";
            this.casPartCacheCheckBox.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 611);
            this.Controls.Add(this.cacheGroupBox);
            this.Controls.Add(this.buildGroupBox);
            this.Controls.Add(this.pathGroupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buildSizeLimitNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildPrioirtyNumbericUpDown)).EndInit();
            this.pathGroupBox.ResumeLayout(false);
            this.pathGroupBox.PerformLayout();
            this.buildGroupBox.ResumeLayout(false);
            this.buildGroupBox.PerformLayout();
            this.cacheGroupBox.ResumeLayout(false);
            this.cacheGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label gamePathLabel;
        private TextBox gamePathTextBox;
        private Button gamePathButton;
        private Button documentsButton;
        private TextBox documentsTextBox;
        private Label documentsPathLabel;
        private Label buildSizeLimitLabel;
        private NumericUpDown buildSizeLimitNumericUpDown;
        private NumericUpDown buildPrioirtyNumbericUpDown;
        private Label buildPriorityLabel;
        private GroupBox pathGroupBox;
        private GroupBox buildGroupBox;
        private GroupBox cacheGroupBox;
        private CheckBox igaCacheCheckBox;
        private CheckBox dcCacheDccCheckBox;
        private CheckBox dcCacheMissingdepsCheckBox;
        private CheckBox featuredItemCheckbox;
        private CheckBox thumbnailCheckBox;
        private CheckBox worldCacheCheckBox;
        private CheckBox socialCacheCheckBox;
        private CheckBox simCompositorCacheCheckBox;
        private CheckBox scriptCacheCheckBox;
        private CheckBox compositorCacheCheckBox;
        private CheckBox casPartCacheCheckBox;
        private CheckBox sigsCacheBinCheckBox;
        private CheckBox downloadsBinCheckBox;
        private CheckBox savedSimsDownloadedsimsCheckBox;
        private CheckBox nraasScriptErrorCheckBox;
        private ToolTip toolTip1;
        private Label defaultBuildSizeLimitLabel;
        private Label label1;
        private TextBox resourcecfgTextBox;
        private Label resourcecfgLabel;
    }
}