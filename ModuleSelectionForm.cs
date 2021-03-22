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
    //Date: 3/4/21
    //Purpose: Allows the player to choose which module
    //         they want to be solved
    public partial class ModuleSelectionForm : Form
    {

        //===========FIELDS===========

        //the current bomb
        private Bomb bomb;

        //the confirmation form used get here
        private EdgeworkConfirmationForm confirmationForm;

        //the input form used if the user wants
        //to change the edgework
        private EdgeworkInputForm inputForm;

        //used to write to the log file
        StreamWriter logFileWriter;

        //module forms
        private IceCreamForm iceCreamForm;
        private LogicForm logicForm;
        private MazeForm mazeForm;
        private MurderForm murderForm;
        private SillySlotsForm sillySlotsForm;


        //===========CONSTRUCTORS===========

        /// <summary>
        /// Creates an form that allows the user to
        /// pick which module wants to be solved
        /// </summary>
        /// <param name="bomb">the current bomb</param>
        /// <param name="confirmationForm">the form used if the player wants to check the edgework</param>
        /// <param name="inputForm">the form used if the player want to change the edgework</param>
        public ModuleSelectionForm(Bomb bomb, EdgeworkConfirmationForm confirmationForm, EdgeworkInputForm inputForm, StreamWriter logFileWriter)
        {
            InitializeComponent();
            this.logFileWriter = logFileWriter;
            this.bomb = bomb;
            this.confirmationForm = confirmationForm;
            this.inputForm = inputForm;
            UpdateForm();
        }


        //===========METHODS===========

        /// <summary>
        /// Sets up the form, so it looks
        /// good as new
        /// </summary>
        public void UpdateForm()
        {
            logFileWriter.WriteLine("======================MODULE SELECTION======================");
            SetUpModuleComboBox();
        }

        /// <summary>
        /// Sets up the form, so it looks
        /// good as new
        /// </summary>
        /// <param name="bomb">the new bomb</param>
        public void UpdateForm(Bomb bomb)
        {
            logFileWriter.WriteLine("======================MODULE SELECTION======================");
            SetUpModuleComboBox();
            this.bomb = bomb;
        }

        /// <summary>
        /// Sets up the combo box so it has all the modules 
        /// </summary>
        private void SetUpModuleComboBox()
        {
            moduleComboBox.Items.Clear();

            String[] modules = new String[] {"Ice Cream", "Logic", "Maze", "Murder", "Silly Slots"};
            moduleComboBox.Items.AddRange(modules);
            moduleComboBox.Text = "Ice Cream";
            moduleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// Sends the user to the edgework input form
        /// </summary>
        private void changeEdgeworkButton_Click(object sender, EventArgs e)
        {
            logFileWriter.WriteLine("User is changing edgework...\n");
            this.Hide();
            inputForm.UpdateForm();
            inputForm.Show();
        }

        /// <summary>
        /// sends the user to the edgework confirmation form
        /// </summary>
        private void checkEdgeworkButton_Click(object sender, EventArgs e)
        {
            logFileWriter.WriteLine("User is checking edgework...\n");
            this.Hide();
            confirmationForm.UpdateForm(bomb, inputForm);
            confirmationForm.Show();
        }

        /// <summary>
        /// Confirms that the user want to close the program
        /// </summary>
        private void ModuleSelectionForm_FormClosing(object sender, FormClosingEventArgs e)
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
                    this.Visible = false;
                    Application.Exit();
                }
            }
        }

        /// <summary>
        /// Saves the current bomb to Edgework.txt
        /// </summary>
        private void saveEdgeworkButton_Click(object sender, EventArgs e)
        {
            logFileWriter.WriteLine("User is trying to save edgework...\n");

            StreamWriter writer = new StreamWriter("../../Edgework.txt");

            try
            {
                writer.WriteLine(bomb.Day);
                writer.WriteLine(bomb.SerialNumber);
                writer.WriteLine(bomb.Battery);
                writer.WriteLine(bomb.BatteryHolder);

                SaveIndicator(writer, bomb.Bob);
                SaveIndicator(writer, bomb.Car);
                SaveIndicator(writer, bomb.Clr);
                SaveIndicator(writer, bomb.Frk);
                SaveIndicator(writer, bomb.Frq);
                SaveIndicator(writer, bomb.Ind);
                SaveIndicator(writer, bomb.Msa);
                SaveIndicator(writer, bomb.Nsa);
                SaveIndicator(writer, bomb.Sig);
                SaveIndicator(writer, bomb.Snd);
                SaveIndicator(writer, bomb.Trn);

                writer.WriteLine(bomb.EmptyPortPlate);
                writer.WriteLine(bomb.Dvid.Num);
                writer.WriteLine(bomb.Parallel.Num);
                writer.WriteLine(bomb.Ps.Num);
                writer.WriteLine(bomb.Rj.Num);
                writer.WriteLine(bomb.Serial.Num);
                writer.WriteLine(bomb.Stereo.Num);

                writer.Close();

                MessageBox.Show("Edgework saved successfully", "Edgework Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                logFileWriter.WriteLine("User has successfully saved edgeork\n");
            }

            catch
            {
                MessageBox.Show("There was an error saving this edgework to Edgework.txt", "Saving Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                logFileWriter.WriteLine("User has unsuccessfully saved edgeork\n");
            }
        }

        /// <summary>
        /// Saves the indicators to Edgework.txt
        /// </summary>
        /// <param name="writer">used to save the data<param>
        /// <param name="indicator">the indicator that will be saved</param>
        private void SaveIndicator(StreamWriter writer, Indicator indicator)
        {
            writer.WriteLine($"{indicator.Visible}|{indicator.Lit}");
        }

        /// <summary>
        /// Sends the player to the module form
        /// they selected in the combo box
        /// </summary>
        private void submitButton_Click(object sender, EventArgs e)
        {

            switch(moduleComboBox.Text)
            {
                case "Ice Cream":
                    this.Hide();

                    if (iceCreamForm == null)
                    {
                        iceCreamForm = new IceCreamForm(this, bomb, logFileWriter);
                    }

                    else
                    {
                        iceCreamForm.UpdateForm(this, bomb, 1);
                    }

                    iceCreamForm.Show();
                    break;

                case "Logic":
                    this.Hide();

                    if (logicForm == null)
                    {
                        logicForm = new LogicForm(this, bomb, logFileWriter);
                    }

                    else
                    {
                        logicForm.UpdateForm(this, bomb);
                    }

                    logicForm.Show();
                    break;

                case "Maze":
                    this.Hide();

                    if (mazeForm == null)
                    {
                        mazeForm = new MazeForm(this, bomb, logFileWriter);
                    }

                    else
                    {
                        mazeForm.UpdateForm(this, bomb);
                    }

                    mazeForm.Show();
                    break;
                
                case "Murder":
                case "Silly Slots":
                    MessageBox.Show("Sorry. This module has not been implemented yet.", "Module Not Implemented", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
