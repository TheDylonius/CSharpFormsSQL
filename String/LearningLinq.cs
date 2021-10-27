using System;
using System.Linq;
using System.Windows.Forms;

namespace CSharpFormsSQL
{
    public partial class LearningLinq : Form
    {
        public LearningLinq()
        {
            InitializeComponent();
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            // Declare input and output as the two textboxes.
            var input = inputBox.Text;
            var output = outputBox.Text = "";

            // Build an array of words from the textbox split by space, comma, or period.
            var words = input.Split(new char[] { ' ', ',', '.', '!' });

            // Count all words typed into the textbox with five or more characters.
            var count = words.Count(word => word.Length >= 5);

            // Take all words with five or more characters, convert the result into a list, order by word length, then convert again into a list.
            var longWords = words.Where(word => word.Length >= 5).ToList().OrderBy(word => word.Length).ToList();

            // Display the number of words with five or more characters.
            outputBox.Text = $"Number of words with five or more characters: {count}";

            // Display each word with five or more characters.
            outputBox.Text += "\nWords with five or more characters, sorted: ";
            longWords.ForEach(word => outputBox.Text += $"\n{word}");
        }
    }
}