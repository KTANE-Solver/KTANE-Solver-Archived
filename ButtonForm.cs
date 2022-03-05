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
    /// <summary>
    /// Author: Nya Bentley
    /// Purpose: Gets information needed to solve the button module
    /// </summary>

    public partial class ButtonForm : ModuleForm
    {
        public ButtonForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm)
        : base (bomb, logFileWriter, moduleSelectionForm, "Button", false)
        {
            InitializeComponent();
            UpdateForm(bomb, logFileWriter, moduleSelectionForm);

        }

        public void UpdateForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm)
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

            UpdateEdgeWork(bomb, logFileWriter, moduleSelectionForm);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            GoToMoudleSelectionForm();
        }

        private void strikeButton_Click(object sender, EventArgs e)
        {
            IncrementStrike();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            PrintHeader();

            Button module = new Button(Bomb, LogFileWriter);

            Button.Color color = (Button.Color)Enum.Parse(typeof(Button.Color), colorComboBox.Text);

            module.Solve(color, wordComboBox.Text);
        }
    }
}
