using System;
using System.Drawing;
using System.Windows.Forms;

namespace CSharpFormsSQL
{
    public partial class TextEditor : Form
    {
        public TextEditor()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Saves all text within the input textbox into a file.
                inputBox.SaveFile(saveFileDialog1.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clears the 'File Name' field in the Open File dialog box.
            openFileDialog1.FileName = "";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Opens the selected file and loads the text into the editor.
                    inputBox.LoadFile(openFileDialog1.FileName);
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message, "Error!");
                }
            }
        }

        private void oldText_DoubleClick(object sender, EventArgs e)
        {
            if (oldText.Text.Trim().Length > 0)
            {
                // Search for the specified text in the input box, then select it.
                inputBox.Select(inputBox.Find(oldText.Text), oldText.Text.Length);

                // Change the background colour of the selection to yellow.
                inputBox.SelectionBackColor = Color.Yellow;
            }
        }

        private void newText_DoubleClick(object sender, EventArgs e)
        {
            // If the newText textbox contains some actual text.
            if (newText.Text.Trim().Length > 0)
            {
                // Replace the old text with the new text.
                inputBox.Text = inputBox.Text.Replace(oldText.Text, newText.Text);
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the font selection dialog.
            fontDialog1.ShowDialog();

            // Change the input box font to the selected font.
            inputBox.Font = fontDialog1.Font;
        }

        private void printPreviewPrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Choose the document which will be displayed in the preview panel.
            printPreviewDialog1.Document = printDocument1;

            // Show the print preview dialog window.
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Draw the page for printing.
            e.Graphics.DrawString(inputBox.Text, inputBox.Font, Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the print dialog, and check whether the user presses 'OK'.
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}