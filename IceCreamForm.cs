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
    //AUTHOR: Nya Bentley
    //DATE: 3/14/21
    //PURPOSE: Gets the informtion needed to solve the ice cream module
    public partial class IceCreamForm : ModuleForm
    {
        //used to solve the ice cream do
        private IceCream iceCream;

        /// <summary>
        /// Creates a form used to get information to solve the ice cream
        /// module
        /// </summary>
        /// <param name="moduleSelectionForm">the form used to get to this form</param>
        /// <param name="bomb">used for the edgework</param>
        public IceCreamForm(ModuleSelectionForm moduleSelectionForm, Bomb bomb, StreamWriter logFileWriter) : base(bomb, logFileWriter, moduleSelectionForm)
        {
            InitializeComponent();
            UpdateForm(moduleSelectionForm, bomb, 1);
            LogFileWriter = logFileWriter;
        }

        /// <summary>
        /// Updates the form so it looks new
        /// </summary>
        /// <param name="bomb">used to get the edgework</param>
        /// <param name="stage">what stage the user is on</param>
        public void UpdateForm(ModuleSelectionForm moduleSelectionForm, Bomb bomb,  int stage)
        {
            Bomb = bomb;
            ModuleSelectionForm = moduleSelectionForm;

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
            CloseProgram(e);
        }
        
        /// <summary>
        /// sends the player back to the module selection stage
        /// </summary>
        private void backButton_Click(object sender, EventArgs e)
        {
            GoToMoudleSelectionForm();
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

            iceCream = new IceCream(customerComboBox.Text, flavor1, flavor2, flavor3, flavor4, Bomb, LogFileWriter);
            LogFileWriter.WriteLine("======================ICE CREAM======================");
            LogFileWriter.WriteLine($"{stageLabel.Text}\n");

            iceCream.Solve();

            if (stageLabel.Text == "Stage 1")
            {
                UpdateForm(ModuleSelectionForm, Bomb, 2);
            }

            else if (stageLabel.Text == "Stage 2")
            {
                UpdateForm(ModuleSelectionForm, Bomb, 3);
            }

            else
            { 
                UpdateForm(ModuleSelectionForm, Bomb, 1);
            }

        }

        private void strikeButton_Click(object sender, EventArgs e)
        {
            IncrementStrike();
        }
    }
}
