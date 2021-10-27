
namespace CSharpFormsSQL
{
    partial class FileDownloader
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
            this.downloadFreeze = new System.Windows.Forms.Button();
            this.downloadNoFreeze = new System.Windows.Forms.Button();
            this.openWinExplore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // downloadFreeze
            // 
            this.downloadFreeze.Location = new System.Drawing.Point(35, 12);
            this.downloadFreeze.Name = "downloadFreeze";
            this.downloadFreeze.Size = new System.Drawing.Size(371, 66);
            this.downloadFreeze.TabIndex = 0;
            this.downloadFreeze.Text = "Download (Freeze)";
            this.downloadFreeze.UseVisualStyleBackColor = true;
            this.downloadFreeze.Click += new System.EventHandler(this.downloadFreeze_Click);
            // 
            // downloadNoFreeze
            // 
            this.downloadNoFreeze.Location = new System.Drawing.Point(35, 84);
            this.downloadNoFreeze.Name = "downloadNoFreeze";
            this.downloadNoFreeze.Size = new System.Drawing.Size(371, 66);
            this.downloadNoFreeze.TabIndex = 1;
            this.downloadNoFreeze.Text = "Download (No Freeze)";
            this.downloadNoFreeze.UseVisualStyleBackColor = true;
            this.downloadNoFreeze.Click += new System.EventHandler(this.downloadNoFreeze_Click);
            // 
            // openWinExplore
            // 
            this.openWinExplore.Location = new System.Drawing.Point(35, 156);
            this.openWinExplore.Name = "openWinExplore";
            this.openWinExplore.Size = new System.Drawing.Size(371, 66);
            this.openWinExplore.TabIndex = 2;
            this.openWinExplore.Text = "Open in Windows Explorer";
            this.openWinExplore.UseVisualStyleBackColor = true;
            this.openWinExplore.Click += new System.EventHandler(this.openWinExplore_Click);
            // 
            // FileDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 308);
            this.Controls.Add(this.openWinExplore);
            this.Controls.Add(this.downloadNoFreeze);
            this.Controls.Add(this.downloadFreeze);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FileDownloader";
            this.Text = "FileDownloader";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button downloadFreeze;
        private System.Windows.Forms.Button downloadNoFreeze;
        private System.Windows.Forms.Button openWinExplore;
    }
}