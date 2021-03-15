using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTANE_Solver
{
    //Author: Nya Bentley
    //Date: 3/1/21
    //Purpose: Shows the edgework the user inputted
    //         and asks for confirmation
    public partial class EdgeworkConfirmationForm : Form
    {
        //FIELDS
        
        //the form the user will go to if they press backButton
        private EdgeworkInputForm inputForm;

        //where the edgework will be read from
        private Bomb bomb;

        private ModuleSelectionForm moduleSelectionForm;

        /// <summary>
        /// Tells the user what the edgework is
        /// </summary>
        /// <param name="bomb">the bomb that was created</param>
        public EdgeworkConfirmationForm(Bomb bomb)
        {
            InitializeComponent();
            inputForm = new EdgeworkInputForm();
            UpdateForm(bomb);

        }

        /// <summary>
        /// Tells the user what the edgework is
        /// </summary>
        /// <param name="bomb">the bomb that was created</param>
        /// <param name="inputForm">the form used to get to this form</param>
        public EdgeworkConfirmationForm(Bomb bomb, EdgeworkInputForm inputForm)
        {
            InitializeComponent();
            UpdateForm(bomb, inputForm);
        }

        /// <summary>
        /// Used to set the form so it looks good as new
        /// </summary>
        /// <param name="bomb">the bomb needed to show the edgework</param>
        public void UpdateForm(Bomb bomb)
        {
            this.bomb = bomb;
            SetUpLabels();
        }

        /// <summary>
        /// Used to set the form so it looks good as new
        /// </summary>
        /// <param name="bomb">the bomb needed to show the edgework</param>
        /// <param name="inputForm">the form used to get to this form</param>
        public void UpdateForm(Bomb bomb, EdgeworkInputForm inputForm)
        {
            this.inputForm = inputForm;
            this.bomb = bomb;
            SetUpLabels();
        }

        /// <summary>
        /// Sets up that labels so they are evenly spaced on the form
        /// </summary>
        public void SetUpLabels()
        {
            SetLabel(dayOfWeekLabel, "Day of the week: " +  bomb.Day, 1);
            SetLabel(serialNumberLabel, "Serial Number: " + bomb.SerialNumber, 2);
            SetLabel(batteryLabel, "# of batteries: " + bomb.Battery, 3);
            SetLabel(batteryHolderLabel, "# battery holders:" + bomb.BatteryHolder, 4);
           
            SetLabel(indicatorLabel, "Indicator", 5);

            SetIndicatorLabel(bobLabel, bomb.Bob, 6);
            SetIndicatorLabel(carLabel, bomb.Car, 7);
            SetIndicatorLabel(clrLabel, bomb.Clr, 8);
            SetIndicatorLabel(frkLabel, bomb.Frk, 9);
            SetIndicatorLabel(frqLabel, bomb.Frq, 10);
            SetIndicatorLabel(indLabel, bomb.Ind, 11);
            SetIndicatorLabel(msaLabel, bomb.Msa, 12);
            SetIndicatorLabel(nsaLabel, bomb.Nsa, 13);
            SetIndicatorLabel(sigLabel, bomb.Sig, 14);
            SetIndicatorLabel(sndLabel, bomb.Snd, 15);
            SetIndicatorLabel(trnLabel, bomb.Trn, 16);

            SetLabel(portLabel, "Port", 17);


            if (bomb.EmptyPortPlate)
            {
                SetLabel(emptyPortPlateLabel, "There is an empty port plate", 18);
            }

            else
            { 
                SetLabel(emptyPortPlateLabel, "There isn't an empty port plate", 18);
            }

            SetPortLabel(dvidLabel, bomb.Dvid, 19);
            SetPortLabel(parallelLabel, bomb.Parallel, 20);
            SetPortLabel(psLabel, bomb.Ps, 21);
            SetPortLabel(rjLabel, bomb.Rj, 22);
            SetPortLabel(serialLabel, bomb.Serial, 23);
            SetPortLabel(stereoLabel, bomb.Stereo, 24);
        }

        /// <summary>
        /// Sets up the label for a port
        /// </summary>
        /// <param name="label">the label itself</param>
        /// <param name="port">the port for the label</param>
        /// <param name="index">where the label in terms of the rest of the labels</param>
        public void SetPortLabel(Label label, Port port, int index)
        {
            SetLabel(label, $"# of {port.Name} ports: {port.Num}", index);
        }

        /// <summary>
        /// Sets up the label for a indicator
        /// </summary>
        /// <param name="label">the label itself</param>
        /// <param name="indicator">the indicator for the label</param>
        /// <param name="index">where the label in temrs of the res of the labels</param>
        public void SetIndicatorLabel(Label label, Indicator indicator, int index)
        {
            String text;

            if (!indicator.Visible)
            {
                text = indicator.Name + " is invisible";
            }

            else if (indicator.Visible && indicator.Lit)
            {
                text = indicator.Name + " is visible and lit";
            }

            else
            {
                text = indicator.Name + " is visible and unlit";
            }

            SetLabel(label, text, index);
        }

        /// <summary>
        /// Sets up the labels
        /// </summary>
        /// <param name="label">the label itself</param>
        /// <param name="text">what the label will say</param>
        /// <param name="index">where the label in temrs of the res of the labels</param>
        public void SetLabel(Label label, String text, int index)
        {
            label.Text = text;

            //sets the label in the middle hoirzontally
            int positionX = (this.Width - label.Width) / 2;

            //sets where the label is going to be vertically
            int positionY = index * 23;


            label.Location = new Point(positionX, positionY);
        }

        /// <summary>
        /// Asks if the player is sure they want to program. If they say yes, the entire program will be closed
        /// </summary>
        private void EdgeworkConfirmationForm_FormClosing(object sender, FormClosingEventArgs e)
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
        /// Sends the user to the edgeworkInput form
        /// </summary>
        private void backButton_Click(object sender, EventArgs e)
        {
            if (inputForm == null)
            {
                inputForm = new EdgeworkInputForm(this);
            }

            this.Hide();
            inputForm.UpdateForm();
            inputForm.Show();
        }

        /// <summary>
        /// Sends the user to the module selction form
        /// </summary>
        private void submitButton_Click(object sender, EventArgs e)
        {
            if (moduleSelectionForm == null)
            {
                moduleSelectionForm = new ModuleSelectionForm(bomb, this, inputForm);
            }

            else
            {
                moduleSelectionForm.UpdateForm(bomb);
            }

            this.Hide();

            moduleSelectionForm.Show();
        }
    }
}
