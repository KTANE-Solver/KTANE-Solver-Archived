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
    public partial class GamepadForm : ModuleForm
    {
        public GamepadForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm)
        {
            InitializeComponent();
            UpdateForm(bomb, logFileWriter, moduleSelectionForm);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            GoToMoudleSelectionForm();
        }

        public void UpdateForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm)
        {
            xTextBox.Text = "";
            yTextBox.Text = "";

            UpdateEdgeWork(bomb, logFileWriter, moduleSelectionForm);
        }

        private void StrikeButton_Click(object sender, EventArgs e)
        {
            IncrementStrike();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int x, y;

            try
            {
                x = int.Parse(xTextBox.Text);
                y = int.Parse(yTextBox.Text);
            }

            catch
            {
                ShowErrorMessage("X and Y text boxes must only contain numbers", "Gamepad Error");
                return;
            }

            if (x < 0 || x > 99 || y < 0 || y > 99)
            {
                ShowErrorMessage("X and Y can only be between 0 and 99", "Gamepad Error");
                return;
            }

            new Gamepad(x, y, Bomb, LogFileWriter);
            UpdateForm(Bomb, LogFileWriter, ModuleSelectionForm);
        }
    }
}
