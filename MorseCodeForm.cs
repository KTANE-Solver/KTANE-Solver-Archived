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
    public partial class MorseCodeForm : ModuleForm
    {
        public MorseCodeForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm)
        {
            InitializeComponent();
            UpdateForm(bomb, logFileWriter, moduleSelectionForm);
        }

        public void UpdateForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm)
        {
            wordComboBox.Items.Clear();

            String[] words = new string[] { "beats", "bistro", "bombs", "boxes", "break", "brick", "flick", "halls", "leaks", "shell", "slick", "steak", "sting", "strobe", "trick", "vector" };

            wordComboBox.Items.AddRange(words);

            wordComboBox.Text = "beats";

            wordComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            
            UpdateEdgeWork(bomb, logFileWriter, moduleSelectionForm);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            GoToMoudleSelectionForm();
        }

        private void strikeButton_Click(object sender, EventArgs e)
        {
            IncrementStrike("Morse Code");
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            MorseCode.Solve(wordComboBox.Text);
            UpdateForm(Bomb, LogFileWriter, ModuleSelectionForm);
        }
    }
}
