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
    public partial class AverageCalculator : Form
    {
        public AverageCalculator()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            var values = input.Text.Split(new char[] { ',', ' '});
            var numbers = new List<double>();

            for (var i = 0; i < values.Length; i++)
            {
                if (!double.TryParse(values[i], out double result))
                {
                    MessageBox.Show("You have entered a non-decimal value. Please try again.");
                    break;
                }
                else
                {
                    numbers.Add(result);
                }
            }

            output.Text = $"{numbers.Sum() / numbers.Count()}";
        }
    }
}