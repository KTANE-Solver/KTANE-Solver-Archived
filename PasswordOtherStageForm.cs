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
    public partial class PasswordOtherStageForm : ModuleForm
    {
        private int stage;
        private PasswordFirstStageForm firstStage;
        private List<char> previousLetters;
        private Password module;

        public PasswordOtherStageForm(int stage, List<char> previousLetters, PasswordFirstStageForm firstStage, Password module, Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm)
        {
            InitializeComponent();
            UpdateForm(stage, previousLetters, firstStage, module, bomb, logFileWriter, moduleSelectionForm);
        }

        public void UpdateForm(int stage, List<char> previousLetters, PasswordFirstStageForm firstStage, Password module, Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm)
        {
            this.stage = stage;
            this.firstStage = firstStage;
            this.previousLetters = previousLetters;
            this.module = module;

            stageLabel.Text = "Stage " + stage;

            if (stage == 2)
            {
                rowLabel.Text = "Fourth Row";
            }

            else
            {
                rowLabel.Text = "Fifth Row";
            }

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

            UpdateEdgeWork(bomb, logFileWriter, moduleSelectionForm);
        }

        private void moduleSelectionButton_Click(object sender, EventArgs e)
        {
            GoToMoudleSelectionForm();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (stage == 2)
            {
                this.Hide();
                firstStage.Show();
            }

            else
            {

                for (int i = previousLetters.Count; i > previousLetters.Count - 6; i--)
                {
                    previousLetters.RemoveAt(previousLetters[i]);
                }

                UpdateForm(stage - 1, previousLetters, firstStage, module, Bomb, LogFileWriter, ModuleSelectionForm);
            }
        }

        private void strikeButton_Click(object sender, EventArgs e)
        {
            IncrementStrike();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            String letter1 = textBox1.Text.ToUpper();
            String letter2 = textBox2.Text.ToUpper();
            String letter3 = textBox3.Text.ToUpper();
            String letter4 = textBox4.Text.ToUpper();
            String letter5 = textBox5.Text.ToUpper();
            String letter6 = textBox6.Text.ToUpper();


            //check to make sure each input is valid
            if (!(ContainsOneLetter(letter1) || ContainsOneLetter(letter2) || ContainsOneLetter(letter3) ||
                  ContainsOneLetter(letter4) || ContainsOneLetter(letter5) || ContainsOneLetter(letter6)))
            {
                ShowErrorMessage("Each text box must contain only 1 letter", "Password Error");
                return;
            }

            if (stage == 3)
            {
                module.FillRow(letter1[0], letter2[0], letter3[0], letter4[0], letter5[0], letter6[0], 5);

                if (!module.Solve(5))
                {
                    ShowErrorMessage("Unable to find answer", "Password Error");
                }

                this.Hide();
                firstStage.UpdateForm(Bomb, LogFileWriter, ModuleSelectionForm);
                firstStage.Show();
            }

            else
            {
                module.FillRow(letter1[0], letter2[0], letter3[0], letter4[0], letter5[0], letter6[0], 4);


                if (!module.Solve(4))
                {
                    previousLetters.Add(textBox1.Text[0]);
                    previousLetters.Add(textBox2.Text[0]);
                    previousLetters.Add(textBox3.Text[0]);
                    previousLetters.Add(textBox4.Text[0]);
                    previousLetters.Add(textBox5.Text[0]);
                    previousLetters.Add(textBox6.Text[0]);

                    UpdateForm(stage + 1, previousLetters, firstStage, module, Bomb, LogFileWriter, ModuleSelectionForm);
                }

                else
                {
                    this.Hide();
                    firstStage.UpdateForm(Bomb, LogFileWriter, ModuleSelectionForm);
                    firstStage.Show();
                }
            }
        }

        /// <summary>
        /// Tells if the string is only 1 length
        /// </summary>
        private bool ContainsOneLetter(String str)
        {
            return str.Length == 1 && str[0] >= 65 && str[0] <= 90;
        }
    }
}
