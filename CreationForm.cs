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
    public partial class CreationForm : ModuleForm
    {
        private Creation module;
        public CreationForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm) : base(bomb, logFileWriter, moduleSelectionForm, "Creation", false)
        {
            InitializeComponent();
            UpdateElementComboBox(upperLeftComboBox);
            UpdateElementComboBox(upperRightComboBox);
            UpdateElementComboBox(bottomLeftComboBox);
            UpdateElementComboBox(bottomRightComboBox);

            String[] weather = new string[] { "Air", "Earth", "Fire", "Water", };

            weatherComboBox.Items.Clear();
            weatherComboBox.Items.AddRange(weather);
            weatherComboBox.Text = weather[0];
            weatherComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void UpdateElementComboBox(ComboBox comboBox)
        {
           
            String[] elements = new string[] { "Air", "Earth", "Fire", "Water", };

            comboBox.Items.Clear();
            comboBox.Items.AddRange(elements);
            comboBox.Text = elements[0];
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            
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
            //make sure comboBoxes don't share element

            string upperLeft = upperLeftComboBox.Text;
            string upperRight = upperLeftComboBox.Text;
            string lowerLeft = upperLeftComboBox.Text;
            string lowerRight = upperLeftComboBox.Text;

            if (upperLeft == upperRight ||
                upperLeft == lowerLeft ||
                upperLeft == lowerRight ||
                upperRight == lowerLeft ||
                upperRight == lowerRight ||
                lowerLeft == lowerRight)
            {
                ShowErrorMessage("Can't have duplicate elements");
                return;
            }

            Creation.Weather startingWeather = (Creation.Weather)Enum.Parse(typeof(Creation.Weather), weatherComboBox.Text);

            module = new Creation(Bomb, LogFileWriter, startingWeather, "", "", "", "");
        }
    }
}
