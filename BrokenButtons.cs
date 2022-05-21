using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace KTANE_Solver
{
    public class BrokenButtons : Module
    {
        public string firstButtonPressed;
        public string secondButtonPressed; 
        public string thirdButtonPressed; 
        public string fourthButtonPressed; 
        public string fifthButtonPressed; 
        
        private bool leftSubmitButton;

        private bool submitAndBuutonRule;
        private bool noAnswerFound;

        public string tempAnswer;
        

        
        public BrokenButtons(Bomb bomb, StreamWriter logFileWriter) : base(bomb, logFileWriter, "Broken Buttons")
        {
            leftSubmitButton = false;

            firstButtonPressed = "";
            secondButtonPressed = "";
            thirdButtonPressed = "";
            fourthButtonPressed = "";
            fifthButtonPressed = "";
            submitAndBuutonRule = false;
            noAnswerFound = false;
        }

        public void Solve()
        {
            firstButtonPressed = FindButtonToPress();

            if (!submitAndBuutonRule && !noAnswerFound)
            {
                secondButtonPressed = FindButtonToPress();

                if (!submitAndBuutonRule && !noAnswerFound)
                {
                    if (!submitAndBuutonRule && !noAnswerFound)
                    {
                        fourthButtonPressed = FindButtonToPress();

                        if (!submitAndBuutonRule && !noAnswerFound)
                        {
                            fifthButtonPressed = FindButtonToPress();
                        }
                    }
                }
            }
            


            string answer;

            if (leftSubmitButton)
            {
                answer = "left";
            }

            else
            {
                answer = "right";
            }

            ShowAnswer($"Press the {answer} submit button");
        }


        private string FindButtonToPress()
        {
            string answer = "";

            if (AskWordAppearQuestion("SEA"))
            {
                answer = "SEA";
            }

            else if (AskQuestion("Is there a button on the third or first row starts with the letter T?"))
            {
                BrokenButtonsWordSelectionForm wordSelectionForm = new BrokenButtonsWordSelectionForm("T", this);
                wordSelectionForm.ShowDialog();
                answer = tempAnswer;
            }

            else if (AskMutipleWordAppearQuestion("ONE", "SUBMIT"))
            {
                answer = "ONE";
                leftSubmitButton = true;
            }

            else if (AskQuestion("Is there a button that is literally blank?"))
            {
                answer = "LITERALLY BLANK";
            }

            else if (AskWordAppearQuestion("OTHER"))
            {
                answer = "OTHER";
                leftSubmitButton = !leftSubmitButton;
            }

            else if (AskQuestion("Is there a duplicate word?"))
            {
                BrokenButtonsWordSelectionForm wordSelectionForm = new BrokenButtonsWordSelectionForm("All", this);
                wordSelectionForm.ShowDialog();
                answer = tempAnswer;
            }

            else if (AskWordAppearQuestion("MODULE"))
            {
                BrokenButtonsWordSelectionForm wordSelectionForm = new BrokenButtonsWordSelectionForm("Port", this);
                wordSelectionForm.ShowDialog();
                answer = tempAnswer;
            }

            else if (AskQuestion("Is there a button that has a port name on it?"))
            {
                BrokenButtonsWordSelectionForm wordSelectionForm = new BrokenButtonsWordSelectionForm("Port", this);
                wordSelectionForm.ShowDialog();
                answer = tempAnswer;
            }

            else if (AskQuestion("Is there a button that has less than 3 characters on it?"))
            {
                BrokenButtonsWordSelectionForm wordSelectionForm = new BrokenButtonsWordSelectionForm("threeLess", this);
                wordSelectionForm.ShowDialog();
                answer = tempAnswer;
            }

            else if (AskMutipleWordAppearQuestion("SUBMIT", "BUTTON"))
            {
                submitAndBuutonRule = true;
                answer = "DON'T PRESS";
            }

            else if (AskMutipleWordAppearQuestion("COLUMN", "SEVEN"))
            {
                //may be wrong (may be an other button in the same row as column)
                answer = "COLUMN";
            }

            else if (AskMutipleWordAppearQuestion("COLUMN", "TWO"))
            {
                //may be wrong (may be an other button in the same row as column)
                answer = "COLUMN";
            }

            else if (firstButtonPressed == "" &&
                    secondButtonPressed == "" &&
                    thirdButtonPressed == "" &&
                    fourthButtonPressed == "" &&
                    fifthButtonPressed == "")
            {
                ShowAnswer("Find the word that is in the 2nd row and 3rd column");
                BrokenButtonsWordSelectionForm wordSelectionForm = new BrokenButtonsWordSelectionForm("All", this);
                wordSelectionForm.ShowDialog();
                answer = tempAnswer;
            }

            else if (firstButtonPressed.Contains('E'))
            {
                answer = "NO ANSWER";
                noAnswerFound = true;
                leftSubmitButton = false;
            }

            if (answer == "LITERALLY BLANK")
            {
                ShowAnswer("Press the literally blank button");
            }

            else if (answer != "DON'T PRESS" && answer != "NO ANSWER")
            {
                ShowAnswer($"Press \"{answer}\"");
            }

            return answer;
        }

        private bool AskWordAppearQuestion(string word)
        { 
            return AskQuestion($"Is there a button labled \"{word}\"?");
        }

        private bool AskMutipleWordAppearQuestion(string word1, string word2)
        {
            return AskQuestion($"Are there buttons labled \"{word1}\" and labled \"{word2}\"?");
        }

        private bool AskQuestion(string question)
        {
            return MessageBox.Show(question, "The Bulb", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }
    }
}
