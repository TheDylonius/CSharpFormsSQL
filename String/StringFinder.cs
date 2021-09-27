using System;
using System.Drawing;
using System.Windows.Forms;

namespace CSharpWinFormsSQLCourse
{
    public partial class StringFinder : Form
    {
        public StringFinder()
        {
            InitializeComponent();
        }

        private void find_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(searchIn.Text) && !string.IsNullOrEmpty(searchFor.Text))
            {
                if (searchIn.Text.Contains(searchFor.Text))
                {
                    searchIn.BackColor = Color.Green;
                }
                else
                {
                    searchIn.BackColor = Color.Red;
                }
            }
        }
    }
}