namespace s3mo
{
    partial class StartupForm
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
            this.documentsPathLabel = new System.Windows.Forms.Label();
            this.gamePathTextBox = new System.Windows.Forms.TextBox();
            this.documentsButton = new System.Windows.Forms.Button();
            this.gamePathButton = new System.Windows.Forms.Button();
            this.gamePathLabel = new System.Windows.Forms.Label();
            this.documentsTextBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // documentsPathLabel
            // 
            this.documentsPathLabel.AutoSize = true;
            this.documentsPathLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.documentsPathLabel.Location = new System.Drawing.Point(24, 87);
            this.documentsPathLabel.Name = "documentsPathLabel";
            this.documentsPathLabel.Size = new System.Drawing.Size(69, 15);
            this.documentsPathLabel.TabIndex = 9;
            this.documentsPathLabel.Text = "Documents";
            // 
            // gamePathTextBox
            // 
            this.gamePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gamePathTextBox.Location = new System.Drawing.Point(99, 43);
            this.gamePathTextBox.Name = "gamePathTextBox";
            this.gamePathTextBox.Size = new System.Drawing.Size(339, 23);
            this.gamePathTextBox.TabIndex = 7;
            // 
            // documentsButton
            // 
            this.documentsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.documentsButton.Location = new System.Drawing.Point(444, 83);
            this.documentsButton.Name = "documentsButton";
            this.documentsButton.Size = new System.Drawing.Size(41, 23);
            this.documentsButton.TabIndex = 11;
            this.documentsButton.Text = "...";
            this.documentsButton.UseVisualStyleBackColor = true;
            this.documentsButton.Click += new System.EventHandler(this.documentsButton_Click);
            // 
            // gamePathButton
            // 
            this.gamePathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gamePathButton.Location = new System.Drawing.Point(444, 43);
            this.gamePathButton.Name = "gamePathButton";
            this.gamePathButton.Size = new System.Drawing.Size(41, 23);
            this.gamePathButton.TabIndex = 8;
            this.gamePathButton.Text = "...";
            this.gamePathButton.UseVisualStyleBackColor = true;
            this.gamePathButton.Click += new System.EventHandler(this.gamePathButton_Click);
            // 
            // gamePathLabel
            // 
            this.gamePathLabel.AutoSize = true;
            this.gamePathLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gamePathLabel.Location = new System.Drawing.Point(29, 46);
            this.gamePathLabel.Name = "gamePathLabel";
            this.gamePathLabel.Size = new System.Drawing.Size(64, 15);
            this.gamePathLabel.TabIndex = 6;
            this.gamePathLabel.Text = "Executable";
            // 
            // documentsTextBox
            // 
            this.documentsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.documentsTextBox.Location = new System.Drawing.Point(99, 83);
            this.documentsTextBox.Name = "documentsTextBox";
            this.documentsTextBox.Size = new System.Drawing.Size(339, 23);
            this.documentsTextBox.TabIndex = 10;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(371, 15);
            this.label.TabIndex = 12;
            this.label.Text = "Enter the path for the Sims 3 executable and Sims 3 document folder:";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(349, 131);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 13;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(430, 131);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 166);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label);
            this.Controls.Add(this.documentsPathLabel);
            this.Controls.Add(this.gamePathTextBox);
            this.Controls.Add(this.documentsButton);
            this.Controls.Add(this.gamePathButton);
            this.Controls.Add(this.gamePathLabel);
            this.Controls.Add(this.documentsTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Startup";
            this.Load += new System.EventHandler(this.StartupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label documentsPathLabel;
        private TextBox gamePathTextBox;
        private Button documentsButton;
        private Button gamePathButton;
        private Label gamePathLabel;
        private TextBox documentsTextBox;
        private Label label;
        private Button okButton;
        private Button cancelButton;
    }
}