
namespace CSharpWinFormsSQLCourse.integration
{
    partial class SpotifyDataGrabber
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SongColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtistColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlbumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DanceabilityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SongColumn,
            this.ArtistColumn,
            this.AlbumColumn,
            this.DanceabilityColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // SongColumn
            // 
            this.SongColumn.HeaderText = "Song Name";
            this.SongColumn.Name = "SongColumn";
            this.SongColumn.ReadOnly = true;
            // 
            // ArtistColumn
            // 
            this.ArtistColumn.HeaderText = "Artist";
            this.ArtistColumn.Name = "ArtistColumn";
            this.ArtistColumn.ReadOnly = true;
            // 
            // AlbumColumn
            // 
            this.AlbumColumn.HeaderText = "Album";
            this.AlbumColumn.Name = "AlbumColumn";
            this.AlbumColumn.ReadOnly = true;
            // 
            // DanceabilityColumn
            // 
            this.DanceabilityColumn.HeaderText = "Danceability";
            this.DanceabilityColumn.Name = "DanceabilityColumn";
            this.DanceabilityColumn.ReadOnly = true;
            // 
            // SpotifyDataGrabber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SpotifyDataGrabber";
            this.Text = "SpotifyDataGrabber";
            this.Load += new System.EventHandler(this.SpotifyDataGrabber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtistColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlbumColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DanceabilityColumn;
    }
}