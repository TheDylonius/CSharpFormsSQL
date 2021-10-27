
namespace CSharpFormsSQL
{
    partial class StringFinder
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchFor = new System.Windows.Forms.TextBox();
            this.searchIn = new System.Windows.Forms.TextBox();
            this.find = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "I would like to find this string:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "in this other string:";
            // 
            // searchFor
            // 
            this.searchFor.Location = new System.Drawing.Point(16, 29);
            this.searchFor.Name = "searchFor";
            this.searchFor.Size = new System.Drawing.Size(185, 23);
            this.searchFor.TabIndex = 2;
            // 
            // searchIn
            // 
            this.searchIn.Location = new System.Drawing.Point(16, 84);
            this.searchIn.Name = "searchIn";
            this.searchIn.Size = new System.Drawing.Size(458, 23);
            this.searchIn.TabIndex = 3;
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(302, 29);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(75, 23);
            this.find.TabIndex = 4;
            this.find.Text = "Find!";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // StringFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 121);
            this.Controls.Add(this.find);
            this.Controls.Add(this.searchIn);
            this.Controls.Add(this.searchFor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StringFinder";
            this.Text = "String Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchFor;
        private System.Windows.Forms.TextBox searchIn;
        private System.Windows.Forms.Button find;
    }
}