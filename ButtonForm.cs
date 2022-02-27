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
    public partial class ButtonForm : ModuleForm
    {
        public ButtonForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionFrom)
        {
            InitializeComponent();
            UpdateForm(bomb, logFileWriter, moduleSelectionFrom);

        }

        public void UpdateForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionFrom)
        {
            String[] colors = { "Blue", "Red", "White", "Yellow" };
            String[] words = { "Abort", "Detonate", "Hold", "Press" };

            colorComboBox.Items.Clear();
            colorComboBox.Items.AddRange(colors);
            colorComboBox.Text = colors[0];
            colorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            wordComboBox.Items.Clear();
            wordComboBox.Items.AddRange(words);
            wordComboBox.Text = words[0];
            wordComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            UpdateEdgeWork(bomb, logFileWriter, moduleSelectionFrom);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            GoToMoudleSelectionForm();
        }

        private void strikeButton_Click(object sender, EventArgs e)
        {
            IncrementStrike("Button");
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            PrintHeader("Button");

            Button module = new Button(Bomb, LogFileWriter);

            Button.Color color = (Button.Color)Enum.Parse(typeof(Button.Color), colorComboBox.Text);

            module.Solve(color, wordComboBox.Text);
        }
    }
}
