
namespace CSharpWinFormsSQLCourse
{
    partial class FileCopier
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
            this.fileChooserButton = new System.Windows.Forms.Button();
            this.allChecker = new System.Windows.Forms.CheckBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.fileCopierButton = new System.Windows.Forms.Button();
            this.folderChooserButton = new System.Windows.Forms.Button();
            this.chosenPath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fileChooserButton
            // 
            this.fileChooserButton.Location = new System.Drawing.Point(12, 12);
            this.fileChooserButton.Name = "fileChooserButton";
            this.fileChooserButton.Size = new System.Drawing.Size(75, 23);
            this.fileChooserButton.TabIndex = 0;
            this.fileChooserButton.Text = "Choose Files";
            this.fileChooserButton.UseVisualStyleBackColor = true;
            this.fileChooserButton.Click += new System.EventHandler(this.fileChooserButton_Click);
            // 
            // allChecker
            // 
            this.allChecker.AutoSize = true;
            this.allChecker.Enabled = false;
            this.allChecker.Location = new System.Drawing.Point(94, 17);
            this.allChecker.Name = "allChecker";
            this.allChecker.Size = new System.Drawing.Size(71, 17);
            this.allChecker.TabIndex = 1;
            this.allChecker.Text = "Check All";
            this.allChecker.UseVisualStyleBackColor = true;
            this.allChecker.CheckedChanged += new System.EventHandler(this.allChecker_CheckedChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 41);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(321, 349);
            this.checkedListBox1.TabIndex = 2;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 404);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(321, 34);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 3;
            // 
            // fileCopierButton
            // 
            this.fileCopierButton.Enabled = false;
            this.fileCopierButton.Location = new System.Drawing.Point(450, 12);
            this.fileCopierButton.Name = "fileCopierButton";
            this.fileCopierButton.Size = new System.Drawing.Size(75, 23);
            this.fileCopierButton.TabIndex = 4;
            this.fileCopierButton.Text = "Copy Files";
            this.fileCopierButton.UseVisualStyleBackColor = true;
            this.fileCopierButton.Click += new System.EventHandler(this.fileCopierButton_Click);
            // 
            // folderChooserButton
            // 
            this.folderChooserButton.Location = new System.Drawing.Point(531, 12);
            this.folderChooserButton.Name = "folderChooserButton";
            this.folderChooserButton.Size = new System.Drawing.Size(75, 23);
            this.folderChooserButton.TabIndex = 5;
            this.folderChooserButton.Text = "Choose Folder";
            this.folderChooserButton.UseVisualStyleBackColor = true;
            this.folderChooserButton.Click += new System.EventHandler(this.folderChooserButton_Click);
            // 
            // chosenPath
            // 
            this.chosenPath.AutoSize = true;
            this.chosenPath.Location = new System.Drawing.Point(528, 41);
            this.chosenPath.Name = "chosenPath";
            this.chosenPath.Size = new System.Drawing.Size(0, 13);
            this.chosenPath.TabIndex = 6;
            // 
            // FileCopier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chosenPath);
            this.Controls.Add(this.folderChooserButton);
            this.Controls.Add(this.fileCopierButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.allChecker);
            this.Controls.Add(this.fileChooserButton);
            this.Name = "FileCopier";
            this.Text = "FileCopier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fileChooserButton;
        private System.Windows.Forms.CheckBox allChecker;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button fileCopierButton;
        private System.Windows.Forms.Button folderChooserButton;
        private System.Windows.Forms.Label chosenPath;
    }
}