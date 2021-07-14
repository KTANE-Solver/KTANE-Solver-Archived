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
    public partial class PasswordFirstStageForm : ModuleForm
    {
        public PasswordFirstStageForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm)
        {
            InitializeComponent();
            UpdateForm(bomb, logFileWriter, moduleSelectionForm);
        }

        public void UpdateForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm)
        {
            UpdateEdgeWork(bomb, logFileWriter, moduleSelectionForm);

            firstRow1TextBox.Text = "";
            firstRow2TextBox.Text = "";
            firstRow3TextBox.Text = "";
            firstRow4TextBox.Text = "";
            firstRow5TextBox.Text = "";
            firstRow6TextBox.Text = "";


            secondRow1TextBox.Text = "";
            secondRow2TextBox.Text = "";
            secondRow3TextBox.Text = "";
            secondRow4TextBox.Text = "";
            secondRow5TextBox.Text = "";
            secondRow6TextBox.Text = "";


            thirdRow1TextBox.Text = "";
            thirdRow2TextBox.Text = "";
            thirdRow3TextBox.Text = "";
            thirdRow4TextBox.Text = "";
            thirdRow5TextBox.Text = "";
            thirdRow6TextBox.Text = "";
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

            

            String firstRow1 = firstRow1TextBox.Text.ToUpper();
            String firstRow2 = firstRow2TextBox.Text.ToUpper();
            String firstRow3 = firstRow3TextBox.Text.ToUpper();
            String firstRow4 = firstRow4TextBox.Text.ToUpper();
            String firstRow5 = firstRow5TextBox.Text.ToUpper();
            String firstRow6 = firstRow6TextBox.Text.ToUpper();

            String secondRow1 = secondRow1TextBox.Text.ToUpper();
            String secondRow2 = secondRow2TextBox.Text.ToUpper();
            String secondRow3 = secondRow3TextBox.Text.ToUpper();
            String secondRow4 = secondRow4TextBox.Text.ToUpper();
            String secondRow5 = secondRow5TextBox.Text.ToUpper();
            String secondRow6 = secondRow6TextBox.Text.ToUpper();

            String thirdRow1 = thirdRow1TextBox.Text.ToUpper();
            String thirdRow2 = thirdRow2TextBox.Text.ToUpper();
            String thirdRow3 = thirdRow3TextBox.Text.ToUpper();
            String thirdRow4 = thirdRow4TextBox.Text.ToUpper();
            String thirdRow5 = thirdRow5TextBox.Text.ToUpper();
            String thirdRow6 = thirdRow6TextBox.Text.ToUpper();

            //make sure each text box only has 1 character and each text box only contains a captialized letter
            if (!(ContainsOneLetter(firstRow1) || ContainsOneLetter(firstRow2) || ContainsOneLetter(firstRow3) || ContainsOneLetter(firstRow4) || ContainsOneLetter(firstRow5) || ContainsOneLetter(firstRow6) ||
                  ContainsOneLetter(secondRow1) || ContainsOneLetter(secondRow2) || ContainsOneLetter(secondRow3) || ContainsOneLetter(secondRow4) || ContainsOneLetter(secondRow5) || ContainsOneLetter(secondRow6) ||
                  ContainsOneLetter(thirdRow1) || ContainsOneLetter(thirdRow2) || ContainsOneLetter(thirdRow3) || ContainsOneLetter(thirdRow4) || ContainsOneLetter(thirdRow5) || ContainsOneLetter(thirdRow6)))
            {
                MessageBox.Show("Each text box must contain only 1 letter", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Password module = new Password(Bomb, LogFileWriter);

            module.FillRow(firstRow1[0], firstRow2[0], firstRow3[0], firstRow4[0], firstRow5[0], firstRow6[0], module.firstRow);
            module.FillRow(secondRow1[0], secondRow2[0], secondRow3[0], secondRow4[0], secondRow5[0], secondRow6[0], module.secondRow);
            module.FillRow(thirdRow1[0], thirdRow2[0], thirdRow3[0], thirdRow4[0], thirdRow5[0], thirdRow6[0], module.thirdRow);

            if (module.Solve(3))
            {
                UpdateForm(Bomb, LogFileWriter, ModuleSelectionForm);
            }


        }

        /// <summary>
        /// Tells if the string is only 1 length
        /// </summary>
        private bool ContainsOneLetter(String str)
        {
            return str.Length == 1 && str[0] >= 65 && str[0] <= 90;
        }

        private void PasswordFirstStageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseProgram(e);
        }
    }
}
