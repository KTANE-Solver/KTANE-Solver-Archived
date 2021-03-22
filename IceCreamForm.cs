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
    //AUTHOR: Nya Bentley
    //DATE: 3/14/21
    //PURPOSE: Gets the informtion needed to solve the ice cream module
    public partial class IceCreamForm : Form
    {
        //used for the edgework
        private Bomb bomb;

        //the form used to get to this form
        private ModuleSelectionForm moduleSelectionForm;

        //used to write to the log file
        StreamWriter logFileWriter;

        //used to solve the ice cream do
        private IceCream iceCream;

        /// <summary>
        /// Creates a form used to get information to solve the ice cream
        /// module
        /// </summary>
        /// <param name="moduleSelectionForm">the form used to get to this form</param>
        /// <param name="bomb">used for the edgework</param>
        public IceCreamForm(ModuleSelectionForm moduleSelectionForm, Bomb bomb, StreamWriter logFileWriter)
        {
            InitializeComponent();
            UpdateForm(moduleSelectionForm, bomb, 1);
            this.logFileWriter = logFileWriter;
        }

        /// <summary>
        /// Updates the form so it looks new
        /// </summary>
        /// <param name="bomb">used to get the edgework</param>
        /// <param name="stage">what stage the user is on</param>
        public void UpdateForm(ModuleSelectionForm moduleSelectionForm, Bomb bomb,  int stage)
        {
            this.bomb = bomb;
            this.moduleSelectionForm = moduleSelectionForm;

            stageLabel.Text = "Stage " + stage;

            //set up the customer combo box
            SetUpCustomerComboBox(customerComboBox);

            //set up the flavors combo box
            SetUpIceCreamComboBox(flavor1ComboBox);
            SetUpIceCreamComboBox(flavor2ComboBox);
            SetUpIceCreamComboBox(flavor3ComboBox);
            SetUpIceCreamComboBox(flavor4ComboBox);
        }

        /// <summary>
        /// Set up combo box for customer
        /// </summary>
        /// <param name="comboBox">the comboBox that will have the customer's name</param>
        private void SetUpCustomerComboBox(ComboBox comboBox)
        {
            String [] names = new String[] {"Adam", "Ashley", "Bob", "Cheryl", "Dave", "Gary",
                                            "George", "Jacob", "Jade", "Jessica", "Mike", "Pat",
                                            "Sally", "Sam", "Sean", "Simon", "Taylor", "Tim", 
                                            "Tom", "Victor"};

            comboBox.Items.Clear();
            comboBox.Items.AddRange(names);
            comboBox.Text = "Adam";
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// Sets up a combo box for ice cream flavors
        /// </summary>
        /// <param name="comboBox">hte combobox that will be given the flavors</param>
        private void SetUpIceCreamComboBox(ComboBox comboBox)
        {
            String[] flavors = new String [] { "Cookies and Cream", "Double Chocolate",
                                               "Double Strawberry", "Mint Chocolate Chip", 
                                               "Neapolitan", "Raspberry Ripple", "Rocky Road", 
                                               "The Classic", "Tutti Frutti" }; 
            comboBox.Items.Clear();
            comboBox.Items.AddRange(flavors);
            comboBox.Text = "Cookies and Cream";
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// Asks the user if they're sure if they want to close the program
        /// </summary>
        private void IceCreamForm_FormClosing(object sender, FormClosingEventArgs e)
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
        /// sends the player back to the module selection stage
        /// </summary>
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            moduleSelectionForm.UpdateForm();
            moduleSelectionForm.Show();
        }

        /// <summary>
        /// Shows the user the answer assuming edgeowork is correct
        /// </summary>
        private void submitButton_Click(object sender, EventArgs e)
        {

            String flavor1 = flavor1ComboBox.Text;
            String flavor2 = flavor2ComboBox.Text;
            String flavor3 = flavor3ComboBox.Text;
            String flavor4 = flavor4ComboBox.Text;

            //check to see if there are duplicate flavors
            if (flavor1 == flavor2 || flavor1 == flavor3 || flavor1  == flavor4 ||
                flavor2 == flavor3 || flavor2 == flavor4 ||
                flavor3 == flavor4)
            {
                MessageBox.Show("Can't have duplicate flavors", "Invalid Ice Cream", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            iceCream = new IceCream(customerComboBox.Text, flavor1, flavor2, flavor3, flavor4, bomb, logFileWriter);
            logFileWriter.WriteLine("======================ICE CREAM======================");
            logFileWriter.WriteLine($"{stageLabel.Text}\n");

            iceCream.Solve();

            if (stageLabel.Text == "Stage 1")
            {
                UpdateForm(moduleSelectionForm, bomb, 2);
            }

            else if (stageLabel.Text == "Stage 2")
            {
                UpdateForm(moduleSelectionForm, bomb, 3);
            }

            else
            { 
                UpdateForm(moduleSelectionForm, bomb, 1);
            }

        }
    }
}
