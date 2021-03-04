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

        public EdgeworkConfirmationForm(Bomb bomb, EdgeworkInputForm inputForm)
        {
            InitializeComponent();
            UpdateForm(bomb, inputForm);
        }

        public void UpdateForm(Bomb bomb)
        {
            this.bomb = bomb;
            SetUpLabels();
        }

        public void UpdateForm(Bomb bomb, EdgeworkInputForm inputForm)
        {
            this.inputForm = inputForm;
            this.bomb = bomb;
            SetUpLabels();
        }

        public void SetUpLabels()
        {
            SetLabel(dayOfWeekLabel, "Day of the week: " +  bomb.Day, 1);
            SetLabel(serialNumberLabel, "Serial Number: " + bomb.SeiralNumber, 2);
            SetLabel(batteryLabel, "# of batteries: " + bomb.Battery, 3);
            SetLabel(batteryHolderLabel, "# battery holders:" + bomb.BatteryHolder, 4);
           
            SetLabel(indicatorLabel, "Indicator", 5);

            SetIndicatorLabel(bobLabel, bomb.Bob, 5);
            SetIndicatorLabel(carLabel, bomb.Car, 6);
            SetIndicatorLabel(clrLabel, bomb.Clr, 7);
            SetIndicatorLabel(frkLabel, bomb.Frk, 8);
            SetIndicatorLabel(frqLabel, bomb.Frq, 9);
            SetIndicatorLabel(indLabel, bomb.Ind, 10);
            SetIndicatorLabel(msaLabel, bomb.Msa, 11);
            SetIndicatorLabel(nsaLabel, bomb.Nsa, 12);
            SetIndicatorLabel(sigLabel, bomb.Sig, 13);
            SetIndicatorLabel(sndLabel, bomb.Snd, 14);
            SetIndicatorLabel(trnLabel, bomb.Trn, 15);

            SetLabel(portLabel, "Port", 16);


            if (bomb.EmptyPortPlate)
            {
                SetLabel(emptyPortPlateLabel, "There is an empty port plate", 17);
            }

            else
            { 
                SetLabel(emptyPortPlateLabel, "There isn't an empty port plate", 17);
            }

            SetPortLabel(dvidLabel, bomb.Dvid, 18);
            SetPortLabel(parallelLabel, bomb.Parallel, 19);
            SetPortLabel(psLabel, bomb.Ps, 20);
            SetPortLabel(rjLabel, bomb.Rj, 21);
            SetPortLabel(serialLabel, bomb.Serial, 22);
            SetPortLabel(stereoLabel, bomb.Stereo, 23);
        }

        public void SetPortLabel(Label label, Port port, int index)
        {
            SetLabel(label, $"# of {port.Name} ports: {port.Num}", index);
        }

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
                text = indicator.Name + "is visible and unlit";
            }

            SetLabel(label, text, index);
        }

        public void SetLabel(Label label, String text, int index)
        {
            label.Text = text;

            int positionX = (this.Width - label.Width) / 2;
            int positionY = index * 23;

            label.Location = new Point(positionX, positionY);
        }

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

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (moduleSelectionForm == null)
            {
                moduleSelectionForm = new ModuleSelectionForm(bomb, this, inputForm);
            }

            this.Hide();

            moduleSelectionForm.Show();
        }
    }
}
