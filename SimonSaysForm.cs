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
    public partial class SimonSaysForm : ModuleForm
    {
        public SimonSaysForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm)
        {
            InitializeComponent();
            UpdateForm(bomb, logFileWriter, moduleSelectionForm);
        }

        public void UpdateForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm)
        {
            UpdateEdgeWork(bomb, logFileWriter, moduleSelectionForm);

            instructionLabel.Text = "B - Blue\nG - Green\nR - Red\nY - Yellow";
            textBox1.Text = "";

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            GoToMoudleSelectionForm();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //textbox can only contain the character b, r, g, and y

            String input = textBox1.Text.ToUpper();

            foreach (char character in input)
            {
                switch (character)
                {
                    case 'B':
                    case 'G':
                    case 'R':
                    case 'Y':
                        break;

                    default:
                        ShowErrorMessage("Textbox can only contain the character b, r, g, and y", "Simon Says Error");
                        return;

                }
            }

            SimonSays module = new SimonSays(input, Bomb, LogFileWriter);
            module.Solve();
            UpdateForm(Bomb, LogFileWriter, ModuleSelectionForm);
        }

        private void strikeButton_Click(object sender, EventArgs e)
        {
            IncrementStrike("Simon Says");
        }
    }
}
