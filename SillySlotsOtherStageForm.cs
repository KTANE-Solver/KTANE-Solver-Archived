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
    //Date: 3/25/21
    //Purpose: Used to get the information needed to solve stage 2-4
    public partial class SillySlotsOtherStageForm : Form
    {

        //=========FEILDS=========
        //the form used to get here
        private ModuleSelectionForm moduleSelectionForm;

        //slot information
        private String stage1Slot1Color;
        private String stage1Slot2Color;
        private String stage1Slot3Color;

        private String stage1Slot1Object;
        private String stage1Slot2Object;
        private String stage1Slot3Object;

        private String stage2Slot1Color;
        private String stage2Slot2Color;
        private String stage2Slot3Color;

        private String stage2Slot1Object;
        private String stage2Slot2Object;
        private String stage2Slot3Object;

        private String stage3Slot1Color;
        private String stage3Slot2Color;
        private String stage3Slot3Color;

        private String stage3Slot1Object;
        private String stage3Slot2Object;
        private String stage3Slot3Object;

        //the stage the user is on
        private int stage;

        //used to write to the log file
        private StreamWriter logFileWriter;

        //used to increase the amount of srikes
        private Bomb bomb;

        //the form the user will see next if they press the back button
        //while on stage 2
        private SillySlotsStage1Form sillySlotsStage1Form;

        //used to solve the module
        private SillySlots sillySlotsModule;

        //=========PROPERTIES=========


        //=========CONSTRUCTOR=========

        /// <summary>
        /// Used to get the information
        /// </summary>
        /// <param name="sillySlotsStage1Form">the form used to get here</param>
        /// <param name="moduleSelectionForm">the form used if the user wants to select another module</param>
        /// <param name="bomb">used to increment edgework</param>
        /// <param name="logFileWriter">used to write to the log file</param>
        /// <param name="sillySlotsModule">used to solve the module</param>
        /// <param name="stage">which stage the user is on</param>
        /// <param name="stage1Slot1Color"></param>
        /// <param name="stage1Slot1Object"></param>
        /// <param name="stage1Slot2Color"></param>
        /// <param name="stage1Slot2Object"></param>
        /// <param name="stage1Slot3Color"></param>
        /// <param name="stage1Slot3Object"></param>
        /// <param name="stage2Slot1Color"></param>
        /// <param name="stage2Slot1Object"></param>
        /// <param name="stage2Slot2Color"></param>
        /// <param name="stage2Slot2Object"></param>
        /// <param name="stage2Slot3Color"></param>
        /// <param name="stage2Slot3Object"></param>
        /// <param name="stage3Slot1Color"></param>
        /// <param name="stage3Slot1Object"></param>
        /// <param name="stage3Slot2Color"></param>
        /// <param name="stage3Slot2Object"></param>
        /// <param name="stage3Slot3Color"></param>
        /// <param name="stage3Slot3Object"></param>
        public SillySlotsOtherStageForm(SillySlotsStage1Form sillySlotsStage1Form,
                                        ModuleSelectionForm moduleSelectionForm,
                                        Bomb bomb, StreamWriter logFileWriter,
                                        SillySlots sillySlotsModule, int stage,
                                        String stage1Slot1Color, String stage1Slot1Object,
                                        String stage1Slot2Color, String stage1Slot2Object,
                                        String stage1Slot3Color, String stage1Slot3Object,
                                        String stage2Slot1Color, String stage2Slot1Object,
                                        String stage2Slot2Color, String stage2Slot2Object,
                                        String stage2Slot3Color, String stage2Slot3Object,
                                        String stage3Slot1Color, String stage3Slot1Object,
                                        String stage3Slot2Color, String stage3Slot2Object,
                                        String stage3Slot3Color, String stage3Slot3Object)
        {
            InitializeComponent();
            UpdateForm(sillySlotsStage1Form,
                       moduleSelectionForm,
                       bomb, logFileWriter,
                       sillySlotsModule, stage,
                       stage1Slot1Color, stage1Slot1Object,
                       stage1Slot2Color, stage1Slot2Object,
                       stage1Slot3Color, stage1Slot3Object,
                       stage2Slot1Color, stage2Slot1Object,
                       stage2Slot2Color, stage2Slot2Object,
                       stage2Slot3Color, stage2Slot3Object,
                       stage3Slot1Color, stage3Slot1Object,
                       stage3Slot2Color, stage3Slot2Object,
                       stage3Slot3Color, stage3Slot3Object);
        }

        


        //=========METHODS=========
        /// <summary>
        /// Used to update the form so it's good as new
        /// </summary>
        public void UpdateForm(SillySlotsStage1Form sillySlotsStage1Form,
                                        ModuleSelectionForm moduleSelectionForm,
                                        Bomb bomb, StreamWriter logFileWriter,
                                        SillySlots sillySlotsModule, int stage,
                                        String stage1Slot1Color, String stage1Slot1Object,
                                        String stage1Slot2Color, String stage1Slot2Object,
                                        String stage1Slot3Color, String stage1Slot3Object,
                                        String stage2Slot1Color, String stage2Slot1Object,
                                        String stage2Slot2Color, String stage2Slot2Object,
                                        String stage2Slot3Color, String stage2Slot3Object,
                                        String stage3Slot1Color, String stage3Slot1Object,
                                        String stage3Slot2Color, String stage3Slot2Object,
                                        String stage3Slot3Color, String stage3Slot3Object)
        {

            //setting up all the vairables
            this.moduleSelectionForm = moduleSelectionForm;
            this.bomb = bomb;
            this.sillySlotsStage1Form = sillySlotsStage1Form;
            this.stage = stage;
            this.logFileWriter = logFileWriter;
            this.sillySlotsModule = sillySlotsModule;

            this.stage1Slot1Color = stage1Slot1Color;
            this.stage1Slot2Color = stage1Slot2Color;
            this.stage1Slot3Color = stage1Slot3Color;

            this.stage1Slot1Object = stage1Slot1Object;
            this.stage1Slot2Object = stage1Slot2Object;
            this.stage1Slot3Object = stage1Slot3Object;

            this.stage2Slot1Color = stage2Slot1Color;
            this.stage2Slot2Color = stage2Slot2Color;
            this.stage2Slot3Color = stage2Slot3Color;

            this.stage2Slot1Object = stage2Slot1Object;
            this.stage2Slot2Object = stage2Slot2Object;
            this.stage2Slot3Object = stage2Slot3Object;

            this.stage3Slot1Color = stage3Slot1Color;
            this.stage3Slot2Color = stage3Slot2Color;
            this.stage3Slot3Color = stage3Slot3Color;

            this.stage3Slot1Object = stage3Slot1Object;
            this.stage3Slot2Object = stage3Slot2Object;
            this.stage3Slot3Object = stage3Slot3Object;

            /**updating the form itself**/

            //the label will show what stage the user is on
            stageLabel.Text = "Stage " + stage;

            //set up keyword comboBox
            keywordComboBox.Items.Clear();

            String[] keywordList = new String[] { "Sassy", "Silly", "Soggy", "Sally", "Simon", "Sausage", "Steven" };

            keywordComboBox.Items.AddRange(keywordList);
            keywordComboBox.Text = "Sassy";
            keywordComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            //set up each color combobox
            SetColorComboBox(slot1ColorComboBox);
            SetColorComboBox(slot2ColorComboBox);
            SetColorComboBox(slot3ColorComboBox);

            //set up each object combobox
            SetObjectComboBox(slot1ObjectComboBox);
            SetObjectComboBox(slot2ObjectComboBox);
            SetObjectComboBox(slot3ObjectComboBox);
        }

        /// <summary>
        /// Sets up a combo box so it has
        /// all the colors
        /// </summary>
        /// <param name="comboBox">the combo box that will have all the colors</param>
        private void SetColorComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();

            String[] colorList = new string[] { "Blue", "Green", "Red" };

            comboBox.Items.AddRange(colorList);
            comboBox.Text = "Blue";
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// Sets up a combo box so it has
        /// all the objects
        /// </summary>
        /// <param name="comboBox">the combo box that will have all the objects</param>
        private void SetObjectComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();

            String[] objectList = new string[] { "Bomb", "Cherry", "Coin", "Grape" };

            comboBox.Items.AddRange(objectList);
            comboBox.Text = "Bomb";
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// Gives the player a strike
        /// </summary>
        private void strikeButton_Click(object sender, EventArgs e)
        {
            this.bomb.Strike++;
            MessageBox.Show($"A stike has been added. Currently at {bomb.Strike} strike(s)", "Strike Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        /// <summary>
        /// Asks if the user is sure they wnt to close the program
        /// </summary>
        private void SillySlotsOtherStageForm_FormClosing(object sender, FormClosingEventArgs e)
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
                    logFileWriter.Close();
                    this.Visible = false;
                    Application.Exit();
                }
            }
        }

        /// <summary>
        /// Sends the player to the module selection from
        /// </summary>
        private void moduleSelectionButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            moduleSelectionForm.UpdateForm();
            moduleSelectionForm.Show();
        }

        /// <summary>
        /// Goes back to the previous stage
        /// </summary>
        private void backButton_Click(object sender, EventArgs e)
        {
            if (stage == 2)
            {
                this.Hide();
                sillySlotsStage1Form.UpdateForm(moduleSelectionForm, bomb);
                sillySlotsStage1Form.Show();
            }

            else
            {
                UpdateForm(sillySlotsStage1Form, moduleSelectionForm, bomb, logFileWriter, sillySlotsModule, stage - 1,
                           stage1Slot1Color, stage1Slot1Object,
                           stage1Slot2Color, stage1Slot2Object,
                           stage1Slot3Color, stage1Slot3Object,
                           stage2Slot1Color, stage2Slot1Object,
                           stage2Slot2Color, stage2Slot2Object,
                           stage2Slot3Color, stage2Slot3Object,
                           stage3Slot1Color, stage3Slot1Object,
                           stage3Slot2Color, stage3Slot2Object,
                           stage3Slot3Color, stage3Slot3Object);
            }
        }

        /// <summary>
        /// Tells the player what to do to solve the stage
        /// <summary>
        private void submitButton_Click(object sender, EventArgs e)
        {
            //if the stage is 4, tell the user the answer and go to stage 1
            if (stage == 4)
            {
                bool pressKeep = sillySlotsModule.Solve(4);
                this.Hide();
                sillySlotsStage1Form.UpdateForm(moduleSelectionForm, bomb);
                sillySlotsStage1Form.Show();
            }

            //otherwise, go to stage 1 if the answer is keep
            //or go to the next stage if the user has to pull the lever
            else
            {
               bool pressKeep = sillySlotsModule.Solve(stage);

                if (pressKeep)
                {
                    MessageBox.Show("Press Keep", "Silly Slot Stage 4 Answer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    sillySlotsStage1Form.UpdateForm(moduleSelectionForm, bomb);
                    sillySlotsStage1Form.Show();
                }

                else
                {
                    MessageBox.Show("Pull the lever", $"Silly Slot Stage {stage} Answer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (stage == 2)
                    {
                        stage2Slot1Color = slot1ColorComboBox.Text;
                        stage2Slot2Color = slot2ColorComboBox.Text;
                        stage2Slot3Color = slot3ColorComboBox.Text;

                        stage2Slot1Object = slot1ObjectComboBox.Text;
                        stage2Slot2Object = slot2ObjectComboBox.Text;
                        stage2Slot3Object = slot3ObjectComboBox.Text;
                    }

                    else if (stage == 3)
                    {
                        stage3Slot1Color = slot1ColorComboBox.Text;
                        stage3Slot2Color = slot2ColorComboBox.Text;
                        stage3Slot3Color = slot3ColorComboBox.Text;
                     
                        stage3Slot1Object = slot1ObjectComboBox.Text;
                        stage3Slot2Object = slot2ObjectComboBox.Text;
                        stage3Slot3Object = slot3ObjectComboBox.Text;
                    }

                    UpdateForm(sillySlotsStage1Form, moduleSelectionForm, bomb, logFileWriter, sillySlotsModule, stage + 1,
                           stage1Slot1Color, stage1Slot1Object,
                           stage1Slot2Color, stage1Slot2Object,
                           stage1Slot3Color, stage1Slot3Object,
                           stage2Slot1Color, stage2Slot1Object,
                           stage2Slot2Color, stage2Slot2Object,
                           stage2Slot3Color, stage2Slot3Object,
                           stage3Slot1Color, stage3Slot1Object,
                           stage3Slot2Color, stage3Slot2Object,
                           stage3Slot3Color, stage3Slot3Object);
                }
            }

                    
        }
    }
}
