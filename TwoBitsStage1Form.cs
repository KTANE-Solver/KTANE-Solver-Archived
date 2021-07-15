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
    public partial class TwoBitsStage1Form : ModuleForm
    {
        TwoBits module;

        public TwoBitsStage1Form(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm) : base(bomb, logFileWriter, moduleSelectionForm)
        {
            InitializeComponent();
            
            UpdateForm(bomb, logFileWriter, moduleSelectionForm);
        }

        public void UpdateForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm)
        {
            module = new TwoBits(bomb, logFileWriter);

            String firstAnswer = module.GetInitalCode();

            answerLabel.Text = $"Insert {firstAnswer} and press query";

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
            this.Hide();
            TwoBitsOtherStageForm secondStage = new TwoBitsOtherStageForm(module, this, 2, Bomb, LogFileWriter, ModuleSelectionForm);
            secondStage.Show();
        }
    }
}
