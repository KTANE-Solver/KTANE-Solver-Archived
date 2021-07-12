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
    public partial class TwoBitsOtherStageForm : ModuleForm
    {
        int stage;
        TwoBits module;
        TwoBitsStage1Form stage1Form;
        public TwoBitsOtherStageForm(TwoBits module, TwoBitsStage1Form stage1Form, int stage, Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm) : base(bomb, logFileWriter, moduleSelectionForm)
        {
            InitializeComponent();
            UpdateForm(stage1Form, stage, bomb, logFileWriter, moduleSelectionForm);

            this.module = module;
        }

        public void UpdateForm(TwoBitsStage1Form stage1Form, int stage, Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm)
        {
            UpdateEdgeWork(bomb, logFileWriter, moduleSelectionForm);

            this.stage1Form = stage1Form;

            this.stage = stage;

            stageLabel.Text = "Stage " + stage;

            resultTextBox.Text = "";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (stage == 2)
            {
                this.Hide();
                stage1Form.Show();
            }

            else
            {
                UpdateForm(stage1Form, stage - 1, Bomb, LogFileWriter, ModuleSelectionForm);
            }
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
            int code;

            try
            {
                code = Int32.Parse(resultTextBox.Text);
            }

            catch
            {
                MessageBox.Show("Text box can only hold numbers", "Two Bits Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (code < 0 && code > 99)
            {
                MessageBox.Show("Text box can only hold numbers that are between 0 and 99", "Two Bits Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            module.Solve(stage, code);

            module = new TwoBits(Bomb, LogFileWriter);

            if (stage == 4)
            {
                this.Hide();
                stage1Form.UpdateForm(Bomb, LogFileWriter, ModuleSelectionForm);
                stage1Form.Show();
            }

            else
            {
                UpdateForm(stage1Form, stage + 1, Bomb, LogFileWriter, ModuleSelectionForm);
            }
        }

        private void TwoBitsOtherStageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseProgram(e);
        }
    }
}