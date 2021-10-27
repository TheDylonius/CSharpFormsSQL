
namespace CSharpFormsSQL
{
    partial class LandingForm
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
            this.averageCalculator = new System.Windows.Forms.Button();
            this.squareCalculator = new System.Windows.Forms.Button();
            this.stringFinder = new System.Windows.Forms.Button();
            this.letterNumberFinder = new System.Windows.Forms.Button();
            this.discountCalculator = new System.Windows.Forms.Button();
            this.vowelFinder = new System.Windows.Forms.Button();
            this.fileDisplayer = new System.Windows.Forms.Button();
            this.textEditor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spotifyTester = new System.Windows.Forms.Button();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // averageCalculator
            // 
            this.averageCalculator.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.averageCalculator.Location = new System.Drawing.Point(13, 72);
            this.averageCalculator.Margin = new System.Windows.Forms.Padding(5);
            this.averageCalculator.Name = "averageCalculator";
            this.averageCalculator.Size = new System.Drawing.Size(193, 46);
            this.averageCalculator.TabIndex = 0;
            this.averageCalculator.Text = "Average Calculator";
            this.averageCalculator.UseVisualStyleBackColor = true;
            this.averageCalculator.Click += new System.EventHandler(this.lesson1_Click);
            // 
            // squareCalculator
            // 
            this.squareCalculator.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.squareCalculator.Location = new System.Drawing.Point(13, 125);
            this.squareCalculator.Margin = new System.Windows.Forms.Padding(5);
            this.squareCalculator.Name = "squareCalculator";
            this.squareCalculator.Size = new System.Drawing.Size(193, 46);
            this.squareCalculator.TabIndex = 1;
            this.squareCalculator.Text = "Square Calculator";
            this.squareCalculator.UseVisualStyleBackColor = true;
            this.squareCalculator.Click += new System.EventHandler(this.lesson2_Click);
            // 
            // stringFinder
            // 
            this.stringFinder.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.stringFinder.Location = new System.Drawing.Point(213, 72);
            this.stringFinder.Margin = new System.Windows.Forms.Padding(5);
            this.stringFinder.Name = "stringFinder";
            this.stringFinder.Size = new System.Drawing.Size(193, 46);
            this.stringFinder.TabIndex = 2;
            this.stringFinder.Text = "String Finder";
            this.stringFinder.UseVisualStyleBackColor = true;
            this.stringFinder.Click += new System.EventHandler(this.lesson3_Click);
            // 
            // letterNumberFinder
            // 
            this.letterNumberFinder.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.letterNumberFinder.Location = new System.Drawing.Point(213, 125);
            this.letterNumberFinder.Margin = new System.Windows.Forms.Padding(5);
            this.letterNumberFinder.Name = "letterNumberFinder";
            this.letterNumberFinder.Size = new System.Drawing.Size(193, 46);
            this.letterNumberFinder.TabIndex = 5;
            this.letterNumberFinder.Text = "Letter / Number Finder";
            this.letterNumberFinder.UseVisualStyleBackColor = true;
            this.letterNumberFinder.Click += new System.EventHandler(this.lesson6_Click);
            // 
            // discountCalculator
            // 
            this.discountCalculator.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.discountCalculator.Location = new System.Drawing.Point(13, 180);
            this.discountCalculator.Margin = new System.Windows.Forms.Padding(5);
            this.discountCalculator.Name = "discountCalculator";
            this.discountCalculator.Size = new System.Drawing.Size(193, 46);
            this.discountCalculator.TabIndex = 8;
            this.discountCalculator.Text = "Discount Calculator";
            this.discountCalculator.UseVisualStyleBackColor = true;
            this.discountCalculator.Click += new System.EventHandler(this.lesson8_Click);
            // 
            // vowelFinder
            // 
            this.vowelFinder.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.vowelFinder.Location = new System.Drawing.Point(213, 180);
            this.vowelFinder.Margin = new System.Windows.Forms.Padding(5);
            this.vowelFinder.Name = "vowelFinder";
            this.vowelFinder.Size = new System.Drawing.Size(193, 46);
            this.vowelFinder.TabIndex = 10;
            this.vowelFinder.Text = "Vowel Finder";
            this.vowelFinder.UseVisualStyleBackColor = true;
            this.vowelFinder.Click += new System.EventHandler(this.lesson9_Click);
            // 
            // fileDisplayer
            // 
            this.fileDisplayer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.fileDisplayer.Location = new System.Drawing.Point(413, 125);
            this.fileDisplayer.Margin = new System.Windows.Forms.Padding(5);
            this.fileDisplayer.Name = "fileDisplayer";
            this.fileDisplayer.Size = new System.Drawing.Size(193, 46);
            this.fileDisplayer.TabIndex = 12;
            this.fileDisplayer.Text = "File Displayer";
            this.fileDisplayer.UseVisualStyleBackColor = true;
            this.fileDisplayer.Click += new System.EventHandler(this.lesson10_Click);
            // 
            // textEditor
            // 
            this.textEditor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.textEditor.Location = new System.Drawing.Point(413, 72);
            this.textEditor.Margin = new System.Windows.Forms.Padding(5);
            this.textEditor.Name = "textEditor";
            this.textEditor.Size = new System.Drawing.Size(193, 46);
            this.textEditor.TabIndex = 13;
            this.textEditor.Text = "Text Editor";
            this.textEditor.UseVisualStyleBackColor = true;
            this.textEditor.Click += new System.EventHandler(this.lesson11_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Numerical Functions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "String Manipulation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "IO Operations";
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuBar.Size = new System.Drawing.Size(618, 25);
            this.menuBar.TabIndex = 18;
            this.menuBar.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(61, 19);
            this.fileToolStripMenuItem.Text = "Options";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorToolStripMenuItem,
            this.programToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.authorToolStripMenuItem.Text = "Author";
            this.authorToolStripMenuItem.Click += new System.EventHandler(this.authorToolStripMenuItem_Click);
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.programToolStripMenuItem.Text = "Program";
            this.programToolStripMenuItem.Click += new System.EventHandler(this.programToolStripMenuItem_Click);
            // 
            // spotifyTester
            // 
            this.spotifyTester.Location = new System.Drawing.Point(213, 390);
            this.spotifyTester.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spotifyTester.Name = "spotifyTester";
            this.spotifyTester.Size = new System.Drawing.Size(193, 46);
            this.spotifyTester.TabIndex = 19;
            this.spotifyTester.Text = "Spotify Test";
            this.spotifyTester.UseVisualStyleBackColor = true;
            this.spotifyTester.Click += new System.EventHandler(this.spotifyTester_Click);
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(618, 827);
            this.Controls.Add(this.spotifyTester);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textEditor);
            this.Controls.Add(this.fileDisplayer);
            this.Controls.Add(this.vowelFinder);
            this.Controls.Add(this.discountCalculator);
            this.Controls.Add(this.letterNumberFinder);
            this.Controls.Add(this.stringFinder);
            this.Controls.Add(this.squareCalculator);
            this.Controls.Add(this.averageCalculator);
            this.Controls.Add(this.menuBar);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuBar;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "LandingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dylan\'s C# and SQL Course";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button averageCalculator;
        private System.Windows.Forms.Button squareCalculator;
        private System.Windows.Forms.Button stringFinder;
        private System.Windows.Forms.Button letterNumberFinder;
        private System.Windows.Forms.Button discountCalculator;
        private System.Windows.Forms.Button vowelFinder;
        private System.Windows.Forms.Button fileDisplayer;
        private System.Windows.Forms.Button textEditor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.Button spotifyTester;
    }
}