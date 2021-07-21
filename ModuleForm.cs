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
    //Author: Nya Bentley
    //Date: 4/9/21
    //Purpose: Keeps all the information that
    //          all module forms have here
    public partial class ModuleForm : Form
    {
        protected Bomb Bomb { get; set; }

        protected StreamWriter LogFileWriter { get; set; }

        protected ModuleSelectionForm ModuleSelectionForm;

        //this should never be used
        public ModuleForm()
        {
            InitializeComponent();

            Text = "KTANE Bot by Hawker";

            FormClosing += CloseProgram;
            Shown += ChangeTitle;

        }

        public ModuleForm(Bomb bomb, StreamWriter logFileWriter,
               ModuleSelectionForm moduleSelectionForm)
        {
            InitializeComponent();

            FormClosing += CloseProgram;
            Shown += ChangeTitle;

            UpdateEdgeWork(bomb, logFileWriter, moduleSelectionForm);
        }

        /// <summary>
        /// Updates infomration needed to solve most modules
        /// and reset the form
        /// </summary>
        /// <param name="bomb"></param>
        /// <param name="logFileWriter"></param>
        /// <param name="moduleSelectionForm"></param>
        public void UpdateEdgeWork(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm)
        {
            Bomb = bomb;
            LogFileWriter = logFileWriter;
            ModuleSelectionForm = moduleSelectionForm;
        }

        /// <summary>
        /// Adds one strike to the bomb
        /// </summary>
        public void IncrementStrike()
        {
            Bomb.Strike++;
            MessageBox.Show($"A stike has been added. Currently at {Bomb.Strike} strike(s)", "Strike Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Asks the user if they want to close the program
        /// </summary>
        /// <param name="e"></param>
        public void CloseProgram(object sender, FormClosingEventArgs e)
        {
            if (this.Visible)
            {
                String message = "Are you sure you want to quit the program?";
                String caption = "Quit Program";

                DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //if the user clicks no, don't close the program
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }

                else
                {
                    LogFileWriter.Close();
                    this.Visible = false;
                    Application.Exit();
                }
            }
        }

        public void ShowErrorMessage(String message, String captions)
        {
            MessageBox.Show(message, captions, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowAnswer(String message, String captions)
        {
            MessageBox.Show(message, captions, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void GoToMoudleSelectionForm()
        {
            this.Hide();
            ModuleSelectionForm.UpdateForm();
            ModuleSelectionForm.Show();
        }

        private void ChangeTitle(object sender, EventArgs e)
        {
            Text = "KTANE Bot by Hawker";
        }
    }
}
