using System;
using System.Windows.Forms;

namespace CSharpWinFormsSQLCourse
{
    public partial class LandingForm : Form
    {
        public LandingForm()
        {
            InitializeComponent();
        }

        public void OpenForm(Form NewForm)
        {
            NewForm.ShowDialog();
        }

        private void lesson1_Click(object sender, EventArgs e)
        {
            OpenForm(new AverageCalculator());
        }

        private void lesson2_Click(object sender, EventArgs e)
        {
            OpenForm(new SquareCalculator());
        }

        private void lesson3_Click(object sender, EventArgs e)
        {
            OpenForm(new StringFinder());
        }

        private void lesson4_Click(object sender, EventArgs e)
        {
            OpenForm(new TextEditor());
        }

        private void lesson5_Click(object sender, EventArgs e)
        {
            OpenForm(new TextEditor());
        }

        private void lesson6_Click(object sender, EventArgs e)
        {
            OpenForm(new TextEditor());
        }

        private void lesson7_Click(object sender, EventArgs e)
        {
            OpenForm(new NumberFormatter());
        }

        private void lesson8_Click(object sender, EventArgs e)
        {
            OpenForm(new TextEditor());
        }

        private void lesson9_Click(object sender, EventArgs e)
        {
            OpenForm(new TextEditor());
        }

        private void lesson10_Click(object sender, EventArgs e)
        {
            OpenForm(new TextEditor());
        }

        private void lesson11_Click(object sender, EventArgs e)
        {
            OpenForm(new TextEditor());
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dylan Davis, author of this program, has been developing C# applications on and off over several years.", "About the Author");
        }

        private void programToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dylan Davis, author of this program, created it to demonstrate the capabilities of WinForms for aspiring C# developers.", "About the Program");
        }

        private void spotifyTester_Click(object sender, EventArgs e)
        {
            //Program.SpotifyTest();
        }
    }
}