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
    public partial class _3DMazeStage2Form : MultiStageModuleForm
    {
        _3DMaze module;
        _3DMazeForm firstStageForm;

        public _3DMazeStage2Form()
        {
            InitializeComponent();
        }

        public _3DMazeStage2Form(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm, _3DMazeForm firstStageForm, _3DMaze module)
        : base(bomb, logFileWriter, moduleSelectionForm, firstStageForm, "3D Maze", false)
        {
            InitializeComponent();

            this.module = module;
            this.firstStageForm = firstStageForm;
            UpdateForm();
        }

        public void UpdateForm()
        {
            string[] cardinals = new string[] { "North", "East", "South", "West"};

            cardinalComboBox.Items.Clear();
            cardinalComboBox.Items.AddRange(cardinals);
            cardinalComboBox.Text = cardinals[0];
            cardinalComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void moduleSelectionButton_Click(object sender, EventArgs e)
        {
            GoToMoudleSelectionForm();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            firstStageForm.UpdateForm(Bomb, LogFileWriter, ModuleSelectionForm);
            firstStageForm.Show();
        }

        private void strikeButton_Click(object sender, EventArgs e)
        {
            IncrementStrike();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //find the goal cardinal
            string goalCardinal = cardinalComboBox.Text.ToUpper();

            module.CardinalGoal = goalCardinal;

            PrintDebugLine($"Cardinal Direction: {goalCardinal}\n");

            //find the goal node
            int row = module.FindRow();

            int column = module.FindColumn();

            module.Goal = module.Maze[row, column];

            PrintDebugLine($"Goal: [{row},{column}]");

            module.UpdateGoal();

            PrintDebugLine($"Updated Goal: [{module.Goal.Row},{module.Goal.Colunm}]\n");

            module.Solve();

            this.Hide();
            firstStageForm.UpdateForm(Bomb,LogFileWriter, ModuleSelectionForm);
            firstStageForm.Show();
        }
    }
}
