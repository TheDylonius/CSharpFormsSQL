using System;
using System.IO;
using System.Windows.Forms;

namespace CSharpWinFormsSQLCourse
{
    public partial class FileCopier : Form
    {
        OpenFileDialog fileDialog = new OpenFileDialog()
        {
            Filter = "All Files|*.*"
        };

        FolderBrowserDialog folderDialog = new FolderBrowserDialog();

        public FileCopier()
        {
            InitializeComponent();
        }

        private void fileChooserButton_Click(object sender, EventArgs e)
        {
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < fileDialog.FileNames.Length; i++)
                {
                    checkedListBox1.Items.Add(fileDialog.FileNames[i]);
                }

                allChecker.Enabled = true;
            }
        }

        private void fileCopierButton_Click(object sender, EventArgs e)
        {
            // Reset the Progress Bar.
            progressBar.Value = 0;
            progressBar.Maximum = checkedListBox1.CheckedItems.Count;

            foreach (var item in checkedListBox1.CheckedItems)
            {
                progressBar.PerformStep();
                File.Copy(item.ToString(), Path.Combine(folderDialog.SelectedPath, Path.GetFileName(item.ToString())));
            }
        }

        private void folderChooserButton_Click(object sender, EventArgs e)
        {
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                chosenPath.Text = folderDialog.SelectedPath;
                fileCopierButton.Enabled = true;
            }
        }

        private void allChecker_CheckedChanged(object sender, EventArgs e)
        {
            if (allChecker.Checked)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
            }
        }
    }
}