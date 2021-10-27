using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpWinFormsSQLCourse
{
    public partial class ImageViewer : Form
    {
        private int currentIndex = 0;

        // Create the image list.
        ImageList imageList = new ImageList();

        // Create the file opener to allow the user to choose files.
        OpenFileDialog fileOpener = new OpenFileDialog()
        {
            Filter = "JPG Files|*.jpg",
            Multiselect = true
        };

        public ImageViewer()
        {
            InitializeComponent();
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // Clear the image list of any existing images.
            imageList.Images.Clear();

            // Display the file opener so the user can choose their files.
            if (fileOpener.ShowDialog() == DialogResult.OK)
            {
                // Loop through and all selected files to the image list.
                for (int i = 0; i < fileOpener.FileNames.Length; i++)
                {
                    imageList.Images.Add(Image.FromFile(fileOpener.FileNames[i]));
                }

                // Set the currently displayed image as the one matching the current index.
                pictureBox.Image = imageList.Images[currentIndex];
            }
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            if (currentIndex != imageList.Images.Count - 1 && imageList.Images.Count > 0)
            {
                pictureBox.Image = imageList.Images[++currentIndex];
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (currentIndex != 0 && imageList.Images.Count > 0)
            {
                pictureBox.Image = imageList.Images[--currentIndex];
            }
        }
    }
}