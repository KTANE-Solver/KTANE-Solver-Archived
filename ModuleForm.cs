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

        public ModuleForm(Bomb bomb, StreamWriter logFileWriter, 
               ModuleSelectionForm moduleSelectionForm)
        {
            InitializeComponent();

            Bomb = bomb;
            LogFileWriter = logFileWriter;
            ModuleSelectionForm = moduleSelectionForm;
        }


        public void IncrementStrike()
        {
            Bomb.Strike++;
            MessageBox.Show( $"A stike has been added. Currently at {Bomb.Strike} strike(s)", "Strike Added", MessageBoxButtons.OK ,MessageBoxIcon.Information);
        }

        public void CloseProgram(FormClosingEventArgs e)
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

        public void GoToMoudleSelectionForm()
        {
            this.Hide();
            ModuleSelectionForm.UpdateForm();
            ModuleSelectionForm.Show();
        }
    }
}
