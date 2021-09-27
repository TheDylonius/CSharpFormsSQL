
namespace CSharpWinFormsSQLCourse
{
    partial class SquareCalculator
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
            this.label3 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.area = new System.Windows.Forms.TextBox();
            this.perimeter = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Single Side:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(16, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Area:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(16, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Perimeter:";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(135, 10);
            this.input.Margin = new System.Windows.Forms.Padding(4);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(132, 23);
            this.input.TabIndex = 3;
            // 
            // area
            // 
            this.area.Location = new System.Drawing.Point(135, 81);
            this.area.Margin = new System.Windows.Forms.Padding(4);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(132, 23);
            this.area.TabIndex = 4;
            // 
            // perimeter
            // 
            this.perimeter.Location = new System.Drawing.Point(135, 50);
            this.perimeter.Margin = new System.Windows.Forms.Padding(4);
            this.perimeter.Name = "perimeter";
            this.perimeter.Size = new System.Drawing.Size(132, 23);
            this.perimeter.TabIndex = 5;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(106, 125);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 6;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // SquareCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 160);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.perimeter);
            this.Controls.Add(this.area);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SquareCalculator";
            this.Text = "Square Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox area;
        private System.Windows.Forms.TextBox perimeter;
        private System.Windows.Forms.Button calculate;
    }
}