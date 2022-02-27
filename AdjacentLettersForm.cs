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
    public partial class AdjacentLettersForm : ModuleForm
    {
        public AdjacentLettersForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm)
        {
            InitializeComponent();
            UpdateForm(bomb, logFileWriter, moduleSelectionForm);
        }

        public void UpdateForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm)
        {
            UpdateEdgeWork(bomb, logFileWriter, moduleSelectionForm);

            row1TextBox.Text = "";
            row2TextBox.Text = "";
            row3TextBox.Text = "";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            GoToMoudleSelectionForm();
        }

        private void strikeButton_Click(object sender, EventArgs e)
        {
            IncrementStrike("Adjacent Letters");
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (row1TextBox.Text.Length != 4 || row2TextBox.Text.Length != 4 || row3TextBox.Text.Length != 4)
            {
                ShowErrorMessage("Text boxes must conatain 4 letters", "Adjacent Letters Error");
                return;
            }

            if (!ContainsOnlyLetters(row1TextBox.Text) || !ContainsOnlyLetters(row2TextBox.Text) || !ContainsOnlyLetters(row3TextBox.Text))
            {
                ShowErrorMessage("Text boxes can only contain letters", "Adjacent Letters Error");
                return;
            }
            char[,] grid = new char[3, 4];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == 0)
                    {
                        grid[0, j] = row1TextBox.Text.ToUpper()[j];
                    }

                    if (i == 1)
                    {
                        grid[1, j] = row2TextBox.Text.ToUpper()[j];
                    }

                    else
                    {
                        grid[2, j] = row3TextBox.Text.ToUpper()[j];
                    }
                }
            }

            PrintHeader("Adjacent Letters");

            AdjacentLetters module = new AdjacentLetters(grid, Bomb, LogFileWriter);
            module.Solve();
            UpdateForm(Bomb, LogFileWriter, ModuleSelectionForm);
        }

        private bool ContainsOnlyLetters(String str)
        {
            str = str.ToUpper();

            foreach (char c in str)
            {
                if (c < 65 || c > 90)
                    return false;
            }

            return true;
        }
    }
}
