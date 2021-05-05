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
    //Purpose: Get information needed to solve Stage 2 and 3 of
    // "Who's on First"
    public partial class WhosOnFirstOtherStageForm : ModuleForm
    {
        //the form that handles the first stage of "Who's on First"
        WhosOnFirstFirstStageForm whosOnFirstFirstStageForm;

        /// <summary>
        /// Creates the form that will Get information 
        /// needed to solve Stage 1 of "Who's on First"
        /// </summary>
        /// <param name="moduleSelectionForm"></param>
        /// <param name="bomb"></param>
        /// <param name="logFileWriter"></param>
        public WhosOnFirstOtherStageForm(ModuleSelectionForm moduleSelectionForm, Bomb bomb, StreamWriter logFileWriter, WhosOnFirstFirstStageForm whosOnFirstFirstStageForm) 
        : base(bomb, logFileWriter, moduleSelectionForm)
        {
            this.whosOnFirstFirstStageForm = whosOnFirstFirstStageForm;
            InitializeComponent();
            UpdateForm(2, moduleSelectionForm, bomb, logFileWriter);
        }


        /// <summary>
        /// Restarts the form
        /// </summary>
        /// <param name="moduleSelectionForm"></param>
        /// <param name="bomb"></param>
        /// <param name="logFileWriter"></param>
        public void UpdateForm(int stage, ModuleSelectionForm moduleSelectionForm, Bomb bomb, StreamWriter logFileWriter)
        {
            stageLabel.Text = "Stage " + stage;

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

        /// <summary>
        /// Restarts a button comboBox
        /// </summary>
        /// <param name="comboBox"></param>
        private void UpdateButtonComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();

            String[] items = new string[] { "BLANK", "FIRST", "LEFT", "MIDDLE", "NO", "NOTHING", "OKAY", "PRESS", "READY", "RIGHT", "UHHH", "WAIT", "WHAT", "YES" };

            comboBox.Text = "BLANK";

            comboBox.Items.AddRange(items);

            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void WhosOnFirstOtherStageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseProgram(e);
        }

        /// <summary>
        /// Goes back to the previous stage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            if (stageLabel.Text == "Stage 2")
            {
                this.Hide();

                whosOnFirstFirstStageForm.UpdateForm(ModuleSelectionForm, Bomb, LogFileWriter);
                whosOnFirstFirstStageForm.Show();
            }

            else
            { 
                UpdateForm(3, ModuleSelectionForm, Bomb, LogFileWriter);
            }
        }

        private void strikeButton_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {

        }

        private void moduleSelectionButton_Click(object sender, EventArgs e)
        {
            GoToMoudleSelectionForm();
        }
    }
}
