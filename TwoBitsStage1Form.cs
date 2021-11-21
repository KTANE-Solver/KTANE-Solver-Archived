﻿using System;
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

        int initalCode;
        String firstAnswer;

        public TwoBitsStage1Form(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm) : base(bomb, logFileWriter, moduleSelectionForm)
        {
            InitializeComponent();
            
            UpdateForm(bomb, logFileWriter, moduleSelectionForm);
        }

        public void UpdateForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm)
        {
            module = new TwoBits(bomb, logFileWriter);

            initalCode = module.GetInitalCode();


            firstAnswer = module.ConvertCode(initalCode, 1);

            answerLabel.Text = $"Insert {firstAnswer} and press query";



            UpdateEdgeWork(bomb, logFileWriter, moduleSelectionForm);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            GoToMoudleSelectionForm();
        }

        private void strikeButton_Click(object sender, EventArgs e)
        {
            IncrementStrike("Two Bits");
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            PrintDebugLine($"Stage 1:\n");
            PrintDebugLine($"Initial Code is {initalCode}\n");
            PrintDebugLine($"User must query {firstAnswer}\n");

            this.Hide();

            TwoBitsOtherStageForm secondStage = new TwoBitsOtherStageForm(module, this, 2, Bomb, LogFileWriter, ModuleSelectionForm);
            secondStage.Show();
        }
    }
}
