using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KTANE_Solver
{
    public partial class FizzBuzzForm : ModuleForm
    {
        public FizzBuzzForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm)
        {
            InitializeComponent();
            UpdateForm(bomb, logFileWriter, moduleSelectionForm);
        }

        public void UpdateForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm)
        {
            UpdateEdgeWork(bomb, logFileWriter, moduleSelectionForm);
            ColorComboBox(colorComboBox1);
            ColorComboBox(colorComboBox2);
            ColorComboBox(colorComboBox3);

            numberTextBox1.Text = "";
            numberTextBox2.Text = "";
            numberTextBox3.Text = "";
        }

        private void ColorComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();

            String[] colors = { "Blue", "Green", "Red", "White", "Yellow" };

            comboBox.Items.AddRange(colors);

            comboBox.Text = colors[0];

            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            GoToMoudleSelectionForm();
        }

        private void strikeButton_Click(object sender, EventArgs e)
        {
            IncrementStrike("FizzBuzz");
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

            if (numberTextBox1.Text.Length != 7 || numberTextBox2.Text.Length != 7 || numberTextBox3.Text.Length != 7)
            {
                ShowErrorMessage("Numbers have to be 7 digits long", "Fizz Buzz Error");
                return;
            }

            try
            {
                int.Parse(numberTextBox1.Text);
                int.Parse(numberTextBox2.Text);
                int.Parse(numberTextBox3.Text);
            }

            catch
            {
                ShowErrorMessage("Numbers text box can only contain numbers", "Fizz Buzz Error");
                return;
            }

            new FizzBuzz(colorComboBox1.Text, numberTextBox1.Text, colorComboBox2.Text, numberTextBox2.Text, colorComboBox3.Text, numberTextBox3.Text, Bomb, LogFileWriter);
            UpdateForm(Bomb, LogFileWriter, ModuleSelectionForm);
        }
    }
}
