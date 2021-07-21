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
    //Purpose: Gets the information needed to solve the
    //"Complicated Wires" module
    public partial class ComplicatedWiresForm : ModuleForm
    {

        public ComplicatedWiresForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm)
        {
            InitializeComponent();
            UpdateForm(bomb, logFileWriter, moduleSelectionForm);
        }

        /// <summary>
        /// Updates the form
        /// </summary>
        public void UpdateForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm)
        {
            UpdateEdgeWork(bomb, logFileWriter, moduleSelectionForm);

            ResetComboBox(wireComboBox1);
            ResetComboBox(wireComboBox2);
            ResetComboBox(wireComboBox3);
            ResetComboBox(wireComboBox4);

            ResetLateComboBox(wireComboBox5);
            ResetLateComboBox(wireComboBox6);

            wireLitCheckBox1.Checked = false;
            wireLitCheckBox2.Checked = false;
            wireLitCheckBox3.Checked = false;
            wireLitCheckBox4.Checked = false;
            wireLitCheckBox5.Checked = false;
            wireLitCheckBox6.Checked = false;


            wireStarCheckBox1.Checked = false;
            wireStarCheckBox2.Checked = false;
            wireStarCheckBox3.Checked = false;
            wireStarCheckBox4.Checked = false;
            wireStarCheckBox5.Checked = false;
            wireStarCheckBox6.Checked = false;
        }

        /// <summary>
        /// Resets the first 4 combo boxes
        /// </summary>
        /// <param name="comboBox"></param>
        private void ResetComboBox(ComboBox comboBox)
        {
            string[] items = new string[] { "Blue", "Purple", "Red", "White", };

            comboBox.Items.Clear();
            comboBox.Items.AddRange(items);

            comboBox.Text = "Blue";

            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// Resets the last 2 combo boxes
        /// </summary>
        /// <param name="comboBox"></param>
        private void ResetLateComboBox(ComboBox comboBox)
        {
            string[] items = new string[] {"*Blank*", "Blue", "Purple", "Red", "White", };

            comboBox.Items.Clear();
            comboBox.Items.AddRange(items);

            comboBox.Text = "*Blank*";

            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// Goes back to the module selection form
        /// </summary>
        private void backButton_Click(object sender, EventArgs e)
        {
            GoToMoudleSelectionForm();
        }

        /// <summary>
        /// Increments the number of stirkes
        /// </summary>
        private void Strike_Click(object sender, EventArgs e)
        {
            IncrementStrike();
        }

        /// <summary>
        /// Tells the user what the answer is
        /// </summary>
        private void submitButton_Click(object sender, EventArgs e)
        {

            //wire 6 can't not be blank when 5 isn't
            if (wireComboBox6.Text != "*Blank*" && wireComboBox5.Text == "*Blank*")
            {
                ShowErrorMessage("Wire 6 can't not be blank when 5 is", "Complicated Wires Error");
                return;
            }

            ComplicatedWire wire1 = CreateWire(wireComboBox1, wireLitCheckBox1, wireStarCheckBox1);
            ComplicatedWire wire2 = CreateWire(wireComboBox2, wireLitCheckBox2, wireStarCheckBox2);
            ComplicatedWire wire3 = CreateWire(wireComboBox3, wireLitCheckBox3, wireStarCheckBox3);
            ComplicatedWire wire4 = CreateWire(wireComboBox4, wireLitCheckBox4, wireStarCheckBox4);
            ComplicatedWire wire5 = CreateWire(wireComboBox5, wireLitCheckBox5, wireStarCheckBox5);
            ComplicatedWire wire6 = CreateWire(wireComboBox6, wireLitCheckBox6, wireStarCheckBox6);

            //only add wire if not null
            List<ComplicatedWire> wireList = new List<ComplicatedWire> { wire1, wire2, wire3, wire4};

            if (wire5 != null)
            { 
                wireList.Add(wire5);

                if(wire6 != null)
                    wireList.Add(wire6);
            }

            ComplicatedWires module = new ComplicatedWires(wireList, Bomb, LogFileWriter);

            module.Solve();
            UpdateForm(Bomb, LogFileWriter, ModuleSelectionForm);
        }

        /// <summary>
        /// Creates a wire
        /// </summary>
        /// <param name="color"></param>
        /// <param name="lit"></param>
        /// <param name="star"></param>
        /// <returns>a wire if the word isn't blank</returns>
        private ComplicatedWire CreateWire(ComboBox color, CheckBox lit, CheckBox star)
        {
            String colorString = color.Text.ToUpper();

            if (colorString == "*BLANK*")
                return null;

            ComplicatedWire.Color colorEnum = (ComplicatedWire.Color)Enum.Parse(typeof(ComplicatedWire.Color), colorString);


            ComplicatedWire wire = new ComplicatedWire(colorEnum, star.Checked, lit.Checked);

            return wire;
        }
    }
}
