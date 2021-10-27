using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpFormsSQL
{
    public partial class SquareCalculator : Form
    {
        public SquareCalculator()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            if (double.TryParse(input.Text, out double result))
            {
                area.Text = (result * result).ToString();
                perimeter.Text = (result * 4).ToString();
            }
            else
            {
                MessageBox.Show("You have entered a non-numerical value, please try again.");
            }
        }
    }
}