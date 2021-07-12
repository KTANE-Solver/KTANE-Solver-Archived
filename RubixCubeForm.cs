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
    public partial class RubixCubeForm : ModuleForm
    {
        public RubixCubeForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm)
        {
            InitializeComponent();
            UpdateForm(bomb, logFileWriter, moduleSelectionForm);
        }


        public void UpdateForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm)
        {
            UpdateEdgeWork(bomb, logFileWriter, moduleSelectionForm);

            UpdateComboBox(topComboBox);
            UpdateComboBox(leftComboBox);
            UpdateComboBox(frontComboBox);
            UpdateComboBox(rightComboBox);
            UpdateComboBox(bottomComboBox);

        }
        private void UpdateComboBox(ComboBox comboBox)
        {
            String[] items = new String[] { "Blue", "Green", "Orange", "Red", "White", "Yellow" };
            comboBox.Items.Clear();
            comboBox.Items.AddRange(items);
            comboBox.Text = items[0];
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
            //make sure no duplicate items
            String top = topComboBox.Text.ToUpper();
            String left = leftComboBox.Text.ToUpper();
            String right = rightComboBox.Text.ToUpper();
            String front = frontComboBox.Text.ToUpper();
            String bottom = bottomComboBox.Text.ToUpper();

            if (top == left || top == right || top == front || top == bottom ||
               left == right || left == front || left == bottom ||
               right == front || right == bottom ||
               front == bottom)
            {
                MessageBox.Show("Can't have duplicate colors", "Rubik Cube Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RubikCube.Face topFace = (RubikCube.Face)Enum.Parse(typeof(RubikCube.Face), top);
            RubikCube.Face leftFace = (RubikCube.Face)Enum.Parse(typeof(RubikCube.Face), left);
            RubikCube.Face rightFace = (RubikCube.Face)Enum.Parse(typeof(RubikCube.Face), right);
            RubikCube.Face frontFace = (RubikCube.Face)Enum.Parse(typeof(RubikCube.Face), front);
            RubikCube.Face bottomFace = (RubikCube.Face)Enum.Parse(typeof(RubikCube.Face), bottom);

            RubikCube module = new RubikCube(topFace, leftFace, frontFace, rightFace, bottomFace, Bomb, LogFileWriter);
            module.Solve();
            UpdateForm(Bomb, LogFileWriter, ModuleSelectionForm);
            

        }

        private void RubixCubeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseProgram(e);
        }
    }
}
