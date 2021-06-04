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
    //Date: 5/1/21
    //Purpose: Gets information needed to solve the Chess module
    public partial class ChessForm : ModuleForm
    {
        public ChessForm(ModuleSelectionForm moduleSelectionForm, Bomb bomb, StreamWriter logFileWriter) : base(bomb, logFileWriter, moduleSelectionForm)
        { 
            InitializeComponent();
            UpdateForm(moduleSelectionForm, bomb, LogFileWriter);
        }

        public void UpdateForm(ModuleSelectionForm moduleSelectionForm, Bomb bomb, StreamWriter logFileWriter)
        {
            ModuleSelectionForm = moduleSelectionForm;
            Bomb = bomb;
            LogFileWriter = logFileWriter;

            UpdateTextBox(piece1TextBox);
            UpdateTextBox(piece2TextBox);
            UpdateTextBox(piece3TextBox);
            UpdateTextBox(piece4TextBox);
            UpdateTextBox(piece5TextBox);
            UpdateTextBox(piece6TextBox);
        }

        private void UpdateTextBox(TextBox textBox)
        {
            textBox.Text = "";
        }

        /// <summary>
        /// Asks the user if they want to close the program
        /// </summary>
        private void ChessForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseProgram(e);
        }

        /// <summary>
        /// Goes back to the module selection form
        /// </summary>
        private void backButton_Click(object sender, EventArgs e)
        {
            GoToMoudleSelectionForm();
        }

        /// <summary>
        /// increment strikes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void strikeButton_Click(object sender, EventArgs e)
        {
            IncrementStrike();
        }

        /// <summary>
        /// Solves the chess module
        /// </summary>
        private void submitButton_Click(object sender, EventArgs e)
        {
            String piece1 = piece1TextBox.Text.ToLower();
            String piece2 = piece2TextBox.Text.ToLower();
            String piece3 = piece3TextBox.Text.ToLower();
            String piece4 = piece4TextBox.Text.ToLower();
            String piece5 = piece5TextBox.Text.ToLower();
            String piece6 = piece6TextBox.Text.ToLower();

            if (!ValidLocation(piece1) || !ValidLocation(piece2) || !ValidLocation(piece3) ||
                !ValidLocation(piece4) || !ValidLocation(piece5) || !ValidLocation(piece6))
            {
                return;
            }

            LogFileWriter.WriteLine("======================CHESS======================\n");

            Chess module = new Chess(piece1, piece2, piece3, piece4, piece5, piece6, Bomb, LogFileWriter);

            module.Solve();
            UpdateForm(ModuleSelectionForm, Bomb, LogFileWriter);
        }

        private bool ValidLocation(String str)
        {
            //str has to be only two charcters
            if (str.Length != 2)
            {
                MessageBox.Show("There can only be two characters", "Chess Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //first character has to be a-f
            if ((int)str[0] < 97 || (int)str[1] > 102)
            {
                MessageBox.Show("First charcter has to be \"a-f\"", "Chess Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //second character has to be 1-6
            if ((int)str[1] < 49 || (int)str[1] > 57)
            {
                MessageBox.Show("Second charcter has to be \"1-6\"", "Chess Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}