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
    public partial class _3DMazePart2Form : ModuleForm
    {
        private _3DMazeForm firstStage;
        private _3DMaze module;

        private String currentDirection;

        public _3DMazePart2Form(_3DMazeForm firstStage, _3DMaze module, String currentDirection, Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm)
        {
            this.currentDirection = currentDirection;
            this.firstStage = firstStage;
            this.module = module;

            InitializeComponent();
            UpdateForm(bomb, logFileWriter, moduleSelectionForm);
        }

        public void UpdateForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm)
        {
            letterTextBox.Text = "";
            UpdateEdgeWork(bomb, logFileWriter, moduleSelectionForm);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            firstStage.UpdateForm(Bomb, LogFileWriter, ModuleSelectionForm);
        }

        private void moduleSelectionButton_Click(object sender, EventArgs e)
        {
            GoToMoudleSelectionForm();
        }

        private void strikeButton_Click(object sender, EventArgs e)
        {
            IncrementStrike();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //can only have the letters N E S or W

            String direction = letterTextBox.Text.ToUpper();

            if (direction.Length != 1)
            {
                ShowErrorMessage("Text box must only have 1 letter", "3D Maze Error");
                return;
            }

            if (!(direction[0] == 'N' || direction[0] == 'E' || direction[0] == 'S' || direction[0] == 'W'))
            {
                ShowErrorMessage("Letters can only be 'N', 'S', 'E', or 'W' ", "3D Maze Error");
                return;
            }

            String endDirection;

            if (direction[0] == 'N')
            {
                endDirection = "NORTH";
            }

            else if (direction[0] == 'E')
            {
                endDirection = "EAST";
            }

            else if (direction[0] == 'S')
            {
                endDirection = "SOUTH";
            }

            else
            {
                endDirection = "WEST";
            }

            System.Diagnostics.Debug.WriteLine($"Aiming {endDirection} at {module.endRow} {module.endColumn}");

            module.FindExit(currentDirection, endDirection);

            this.Hide();
            firstStage.UpdateForm(Bomb, LogFileWriter, ModuleSelectionForm);
            firstStage.Show();
        }
    }
}
