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
    //Purpose: Get information needed to solve Stage 1 of
    // "Who's on First"
    public partial class WhosOnFirstFirstStageForm : ModuleForm
    {
        //the form used for stage 2 and 3
        WhosOnFirstOtherStageForm whosOnFirstOtherStage;


        /// <summary>
        /// Creates the form that will Get information 
        /// needed to solve Stage 1 of "Who's on First"
        /// </summary>
        /// <param name="moduleSelectionForm"></param>
        /// <param name="bomb"></param>
        /// <param name="logFileWriter"></param>
        public WhosOnFirstFirstStageForm(ModuleSelectionForm moduleSelectionForm, Bomb bomb, StreamWriter logFileWriter) : base(bomb, logFileWriter, moduleSelectionForm)
        {
            InitializeComponent();
            UpdateForm(moduleSelectionForm, bomb, logFileWriter);
            whosOnFirstOtherStage = new WhosOnFirstOtherStageForm(moduleSelectionForm, bomb, logFileWriter);

        }


        /// <summary>
        /// Restarts the form
        /// </summary>
        /// <param name="moduleSelectionForm"></param>
        /// <param name="bomb"></param>
        /// <param name="logFileWriter"></param>
        public void UpdateForm(ModuleSelectionForm moduleSelectionForm, Bomb bomb, StreamWriter logFileWriter)
        {
            ModuleSelectionForm = moduleSelectionForm;
            Bomb = bomb;
            LogFileWriter = logFileWriter;


            UpdateDisplay();
            
            UpdateButtonComboBox(topLeftComboBox);
            UpdateButtonComboBox(topRightComboBox);
            UpdateButtonComboBox(midLeftComboBox);
            UpdateButtonComboBox(midRightComboBox);
            UpdateButtonComboBox(bottomLeftComboBox);
            UpdateButtonComboBox(bottomRightComboBox);

        }

        /// <summary>
        /// Restarts the display comboBox
        /// </summary>
        private void UpdateDisplay()
        {
            String[] display = new string[] { "*BLANK*", "BLANK", "C", "CEE", "DISPLAY", "FIRST", "HOLD ON", "LEAD", "LED", "LEED", "NO", "NOTHING", "OKAY", "READ", 
                                              "RED", "REED", "SAYS", "SEE", "THEIR", "THERE", "THEY ARE", "THEY'RE", "UR", "YES", "YOU", "YOU ARE", "YOU'RE", "YOUR" };


            displayComboBox.Items.Clear();

            displayComboBox.Items.AddRange(display);

            displayComboBox.Text = "*BLANK*";

            displayComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void UpdateButtonComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();

            String[] items = new string[] { "BLANK", "FIRST", "LEFT", "MIDDLE", "NO", "NOTHING", "OKAY", "PRESS", "READY", "RIGHT", "UHHH", "WAIT", "WHAT", "YES" };

            comboBox.Text = "BLANK";

            comboBox.Items.AddRange(items);

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

        private void WhosOnFirstFirstStageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseProgram(e);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //make sure there are no duplicates words

            String topLeft = topLeftComboBox.Text;
            String midLeft = topLeftComboBox.Text;
            String bottomLeft = topLeftComboBox.Text;
            String topRight = topRightComboBox.Text;
            String midRight = midRightComboBox.Text;
            String bottomRight = bottomRightComboBox.Text;

            if (topLeft == midLeft || topLeft == bottomLeft || topLeft == topRight || topLeft == midRight || topLeft == bottomRight ||
               midLeft == bottomLeft || midLeft == topRight || midLeft == midRight || midLeft == bottomRight || bottomLeft == topRight ||
               bottomLeft == midRight || bottomLeft == bottomRight || topRight == midRight || bottomLeft == bottomRight || midRight == bottomRight)
            {
                MessageBox.Show("Can't have duplicate words", "Who's on First Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            WhosOnFirst module = new WhosOnFirst(1, displayComboBox.Text, topLeft, topRight, midLeft, midRight, bottomLeft, bottomRight, Bomb, LogFileWriter);
            module.Solve();

            this.Hide();

            whosOnFirstOtherStage.Show();

        }
    }
}
