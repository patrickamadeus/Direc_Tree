namespace Dashboard
{
    partial class MainForm
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
            this.StartDirectoryInput = new System.Windows.Forms.Button();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.DirectoryText = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchMethods = new System.Windows.Forms.Panel();
            this.DFS = new System.Windows.Forms.RadioButton();
            this.BFS = new System.Windows.Forms.RadioButton();
            this.SearchMethodLabel = new System.Windows.Forms.Label();
            this.AllOccurence = new System.Windows.Forms.CheckBox();
            this.FileInput = new System.Windows.Forms.TextBox();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.StartingDirText = new System.Windows.Forms.Label();
            this.AppName1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GraphPanel = new System.Windows.Forms.Panel();
            this.OutputText = new System.Windows.Forms.Label();
            this.FoundDirText = new System.Windows.Forms.Label();
            this.TimeSpentText = new System.Windows.Forms.Label();
            this.InfoPanel.SuspendLayout();
            this.SearchMethods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StartDirectoryInput
            // 
            this.StartDirectoryInput.Location = new System.Drawing.Point(33, 212);
            this.StartDirectoryInput.Name = "StartDirectoryInput";
            this.StartDirectoryInput.Size = new System.Drawing.Size(92, 28);
            this.StartDirectoryInput.TabIndex = 0;
            this.StartDirectoryInput.Text = "Choose..";
            this.StartDirectoryInput.UseVisualStyleBackColor = true;
            this.StartDirectoryInput.Click += new System.EventHandler(this.StartDirectory_Click);
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.InfoPanel.Controls.Add(this.WarningLabel);
            this.InfoPanel.Controls.Add(this.DirectoryText);
            this.InfoPanel.Controls.Add(this.SearchButton);
            this.InfoPanel.Controls.Add(this.SearchMethods);
            this.InfoPanel.Controls.Add(this.SearchMethodLabel);
            this.InfoPanel.Controls.Add(this.AllOccurence);
            this.InfoPanel.Controls.Add(this.FileInput);
            this.InfoPanel.Controls.Add(this.FileNameLabel);
            this.InfoPanel.Controls.Add(this.StartingDirText);
            this.InfoPanel.Controls.Add(this.AppName1);
            this.InfoPanel.Controls.Add(this.pictureBox1);
            this.InfoPanel.Controls.Add(this.StartDirectoryInput);
            this.InfoPanel.Location = new System.Drawing.Point(0, 0);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(371, 714);
            this.InfoPanel.TabIndex = 1;
            // 
            // WarningLabel
            // 
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.ForeColor = System.Drawing.Color.Red;
            this.WarningLabel.Location = new System.Drawing.Point(130, 539);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(0, 16);
            this.WarningLabel.TabIndex = 14;
            // 
            // DirectoryText
            // 
            this.DirectoryText.AutoSize = true;
            this.DirectoryText.Location = new System.Drawing.Point(24, 248);
            this.DirectoryText.Name = "DirectoryText";
            this.DirectoryText.Size = new System.Drawing.Size(0, 16);
            this.DirectoryText.TabIndex = 13;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchButton.Location = new System.Drawing.Point(29, 533);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(92, 28);
            this.SearchButton.TabIndex = 12;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchMethods
            // 
            this.SearchMethods.Controls.Add(this.DFS);
            this.SearchMethods.Controls.Add(this.BFS);
            this.SearchMethods.Location = new System.Drawing.Point(27, 435);
            this.SearchMethods.Name = "SearchMethods";
            this.SearchMethods.Size = new System.Drawing.Size(225, 71);
            this.SearchMethods.TabIndex = 11;
            // 
            // DFS
            // 
            this.DFS.AutoSize = true;
            this.DFS.Location = new System.Drawing.Point(7, 35);
            this.DFS.Name = "DFS";
            this.DFS.Size = new System.Drawing.Size(55, 20);
            this.DFS.TabIndex = 1;
            this.DFS.TabStop = true;
            this.DFS.Text = "DFS";
            this.DFS.UseVisualStyleBackColor = true;
            // 
            // BFS
            // 
            this.BFS.AutoSize = true;
            this.BFS.Location = new System.Drawing.Point(8, 7);
            this.BFS.Name = "BFS";
            this.BFS.Size = new System.Drawing.Size(54, 20);
            this.BFS.TabIndex = 0;
            this.BFS.TabStop = true;
            this.BFS.Text = "BFS";
            this.BFS.UseVisualStyleBackColor = true;
            // 
            // SearchMethodLabel
            // 
            this.SearchMethodLabel.AutoSize = true;
            this.SearchMethodLabel.Location = new System.Drawing.Point(30, 416);
            this.SearchMethodLabel.Name = "SearchMethodLabel";
            this.SearchMethodLabel.Size = new System.Drawing.Size(166, 16);
            this.SearchMethodLabel.TabIndex = 10;
            this.SearchMethodLabel.Text = "Choose Searching Method";
            // 
            // AllOccurence
            // 
            this.AllOccurence.AutoSize = true;
            this.AllOccurence.Location = new System.Drawing.Point(33, 343);
            this.AllOccurence.Name = "AllOccurence";
            this.AllOccurence.Size = new System.Drawing.Size(141, 20);
            this.AllOccurence.TabIndex = 9;
            this.AllOccurence.Text = "Find All Occurence";
            this.AllOccurence.UseVisualStyleBackColor = true;
            // 
            // FileInput
            // 
            this.FileInput.Location = new System.Drawing.Point(29, 307);
            this.FileInput.Name = "FileInput";
            this.FileInput.Size = new System.Drawing.Size(254, 22);
            this.FileInput.TabIndex = 8;
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(30, 283);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(100, 16);
            this.FileNameLabel.TabIndex = 7;
            this.FileNameLabel.Text = "Input File Name";
            // 
            // StartingDirText
            // 
            this.StartingDirText.AutoSize = true;
            this.StartingDirText.Location = new System.Drawing.Point(30, 186);
            this.StartingDirText.Name = "StartingDirText";
            this.StartingDirText.Size = new System.Drawing.Size(159, 16);
            this.StartingDirText.TabIndex = 6;
            this.StartingDirText.Text = "Choose Starting Directory";
            // 
            // AppName1
            // 
            this.AppName1.AutoSize = true;
            this.AppName1.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppName1.Location = new System.Drawing.Point(149, 41);
            this.AppName1.Margin = new System.Windows.Forms.Padding(0);
            this.AppName1.Name = "AppName1";
            this.AppName1.Size = new System.Drawing.Size(194, 45);
            this.AppName1.TabIndex = 4;
            this.AppName1.Text = "DirecTree";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dashboard.Properties.Resources.folder_tree;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // GraphPanel
            // 
            this.GraphPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GraphPanel.Location = new System.Drawing.Point(391, 56);
            this.GraphPanel.Name = "GraphPanel";
            this.GraphPanel.Size = new System.Drawing.Size(756, 528);
            this.GraphPanel.TabIndex = 2;
            // 
            // OutputText
            // 
            this.OutputText.AutoSize = true;
            this.OutputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputText.Location = new System.Drawing.Point(737, 12);
            this.OutputText.Name = "OutputText";
            this.OutputText.Size = new System.Drawing.Size(106, 32);
            this.OutputText.TabIndex = 3;
            this.OutputText.Text = "Output";
            // 
            // FoundDirText
            // 
            this.FoundDirText.AutoSize = true;
            this.FoundDirText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoundDirText.Location = new System.Drawing.Point(405, 605);
            this.FoundDirText.Name = "FoundDirText";
            this.FoundDirText.Size = new System.Drawing.Size(0, 20);
            this.FoundDirText.TabIndex = 5;
            // 
            // TimeSpentText
            // 
            this.TimeSpentText.AutoSize = true;
            this.TimeSpentText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeSpentText.Location = new System.Drawing.Point(405, 640);
            this.TimeSpentText.Name = "TimeSpentText";
            this.TimeSpentText.Size = new System.Drawing.Size(0, 20);
            this.TimeSpentText.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 713);
            this.Controls.Add(this.TimeSpentText);
            this.Controls.Add(this.FoundDirText);
            this.Controls.Add(this.OutputText);
            this.Controls.Add(this.GraphPanel);
            this.Controls.Add(this.InfoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.SearchMethods.ResumeLayout(false);
            this.SearchMethods.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartDirectoryInput;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Label AppName1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label StartingDirText;
        private System.Windows.Forms.TextBox FileInput;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Panel SearchMethods;
        private System.Windows.Forms.Label SearchMethodLabel;
        private System.Windows.Forms.CheckBox AllOccurence;
        private System.Windows.Forms.RadioButton DFS;
        private System.Windows.Forms.RadioButton BFS;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label DirectoryText;
        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.Panel GraphPanel;
        private System.Windows.Forms.Label OutputText;
        private System.Windows.Forms.Label FoundDirText;
        private System.Windows.Forms.Label TimeSpentText;
    }
}

