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
    //Purpose: Prompts the user to give edgework
    public partial class EdgeworkInputForm : Form
    {
        //FIELDS

        //the form the user will go to when they press submit
        EdgeworkConfirmationForm confirmationForm;

        //the bomb that will be careated
        Bomb bomb;

        //PROPERTIES

        //CONSTRUCTOR
        public EdgeworkInputForm()
        {
            InitializeComponent();
            UpdateForm();
        }

        public void UpdateForm()
        {
            SetUpDayOfWeekComboBox();

            //setting promppt text for battery and port textboxes
            SetPromptText(batteryTextBox, "# of batteries");
            SetPromptText(batteryHolderTextBox, "# of battery holders");
            SetPromptText(dvidTextBox, "# of DVI-D ports");
            SetPromptText(parallelTextBox, "# of parallel ports");
            SetPromptText(psTextBox, "# of PS/2 ports");
            SetPromptText(rjTextBox, "# of RJ-45 ports");
            SetPromptText(serialTextBox, "# of serial ports");
            SetPromptText(stereoTextBox, "# of stereo RCA ports");
        }

        //METHODS
        /// <summary>
        /// Sets up the combo box
        /// </summary>
        private void SetUpDayOfWeekComboBox()
        {
            String[] days = new String[] {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            dayOfWeekComboBox.Items.AddRange(days);
            dayOfWeekComboBox.Text = "Sunday";

            this.dayOfWeekComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
 
        private void bobVisibleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!bobVisibleCheckBox.Checked)
            {
                bobLitCheckBox.Checked = false;
            }
        }

        private void bobLitCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (bobLitCheckBox.Checked)
            {
                bobVisibleCheckBox.Checked = true;
            }
        }

        private void carVisibleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!carVisibleCheckBox.Checked)
            {
                carLitCheckBox.Checked = false;
            }
        }

        private void carLitCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (carLitCheckBox.Checked)
            {
                carVisibleCheckBox.Checked = true;
            }
        }

        private void clrVisibleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!clrVisibleCheckBox.Checked)
            {
                clrLitCheckBox.Checked = false;
            }
        }

        private void clrLitCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (clrLitCheckBox.Checked)
            {
                clrVisibleCheckBox.Checked = true;
            }
        }

        private void frkVisibleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!frkVisibleCheckBox.Checked)
            {
                frkLitCheckBox.Checked = false;
            }
        }

        private void frkLitCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (frkLitCheckBox.Checked)
            {
                frkVisibleCheckBox.Checked = true;
            }
        }

        private void frqVisibleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!frqVisibleCheckBox.Checked)
            {
                frqLitCheckBox.Checked = false;
            }
        }

        private void frqLitCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (frqLitCheckBox.Checked)
            {
                frqVisibleCheckBox.Checked = true;
            }
        }

        private void indVisibleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!indVisibleCheckBox.Checked)
            {
                indLitCheckBox.Checked = false;
            }
        }

        private void indLitCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (indLitCheckBox.Checked)
            {
                indVisibleCheckBox.Checked = true;
            }
        }

        private void msaVisibleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!msaVisibleCheckBox.Checked)
            {
                msaLitCheckBox.Checked = false;
            }
        }

        private void msaLitCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (msaLitCheckBox.Checked)
            {
                msaVisibleCheckBox.Checked = true;
            }
        }

        private void nsaVisibleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!nsaVisibleCheckBox.Checked)
            {
                nsaLitCheckBox.Checked = false;
            }
        }

        private void nsaLitCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (nsaLitCheckBox.Checked)
            {
                nsaVisibleCheckBox.Checked = true;
            }
        }

        private void sigVisibleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!sigVisibleCheckBox.Checked)
            {
                sigLitCheckBox.Checked = false;
            }
        }

        private void sigLitCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sigLitCheckBox.Checked)
            {
                sigVisibleCheckBox.Checked = true;
            }
        }

        private void sndVisibleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!sndVisibleCheckBox.Checked)
            {
                sndLitCheckBox.Checked = false;
            }
        }

        private void sndLitCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sndLitCheckBox.Checked)
            {
                sndVisibleCheckBox.Checked = true;
            }
        }

        private void trnVisibleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!trnVisibleCheckBox.Checked)
            {
                trnLitCheckBox.Checked = false;
            }
        }

        private void trnLitCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (trnLitCheckBox.Checked)
            {
                trnVisibleCheckBox.Checked = true;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Bomb.Days day;
            Enum.TryParse(dayOfWeekComboBox.Text, out day);


            String serialNumber = serialNumberTextBox.Text.ToUpper();
            bool oneLetter = false;

            //make sure the serial number is valid
            //-textbox can't be blank
            //-at least one letter
            //-the last character is a letter

            if (serialNumberTextBox.Text.Length == 0)
            {
                ShowErrorMessageBox("Invalid serial number", "Serial number can't be blank");
                return;
            }

            for (int i = 0; i < serialNumber.Length; i++)
            { 
                if(serialNumber[i] >= 65 && serialNumber[i] <= 90)
                {
                    oneLetter = true;
                    break;
                }
            }

            if (!oneLetter) 
            {            
                Console.WriteLine("There isn't a letter in the serial number");

                String text = "You entered an invalid serial number. There has to be at least 1 letter in the serial number";

                String caption = "Invalid Serial Number";

                ShowErrorMessageBox(caption, text);

                return;
            }

            bool lastCharIsDigit = serialNumber[serialNumber.Length - 1] >= 48 && serialNumber[serialNumber.Length - 1] <= 57;

            if (!lastCharIsDigit)
            {
                Console.WriteLine("The last character of the serial number isn't a number");

                String text = "You entered an invalid serial number. A valid serial number must have the last character be a number";

                String caption = "Invalid Serial Number";

                ShowErrorMessageBox(caption, text);

                return;
            }

            //make sure the batteries can be parsed into an int
            int battery;

            try
            {
                battery = Int32.Parse(batteryTextBox.Text);
            }
            catch
            {
                String text = "You entered an invalid battery number.";

                String caption = "Invalid Battery";

                ShowErrorMessageBox(caption, text);

                return;
            }

            //make sure the battery holder can be parsed into an int
            int batteryHolder;

            try
            {
                batteryHolder = Int32.Parse(batteryHolderTextBox.Text);
            }
            catch
            {
                String text = "You entered an invalid battery holder number.";

                String caption = "Invalid Battery Holder";

                ShowErrorMessageBox(caption, text);

                return;
            }


            //make sure the number of batteries and battery holders isn't invalid
            if (battery < batteryHolder)
            {
                String text = "The number of batteries can't be less than the number of battery holders";


                String caption = "Invalid Battery Holder and Battery";

                ShowErrorMessageBox(caption, text);

                return;
            }

            if (battery * 2 > batteryHolder)
            {
                String text = "The number of batteries can't be greater than twice the number of battery holders";


                String caption = "Invalid Battery Holder and Battery";

                ShowErrorMessageBox(caption, text);

                return;
            }

            //setting the indicators
            Indicator bob = new Indicator("BOB", bobVisibleCheckBox.Checked, bobLitCheckBox.Checked);
            Indicator car = new Indicator("CAR", carVisibleCheckBox.Checked, carLitCheckBox.Checked);
            Indicator clr = new Indicator("CLR", clrVisibleCheckBox.Checked, clrLitCheckBox.Checked);
            Indicator frk = new Indicator("FRK", frkVisibleCheckBox.Checked, frkLitCheckBox.Checked);
            Indicator frq = new Indicator("FRQ", frqVisibleCheckBox.Checked, frqLitCheckBox.Checked);
            Indicator ind = new Indicator("IND", indVisibleCheckBox.Checked, indLitCheckBox.Checked);
            Indicator msa = new Indicator("MSA", msaVisibleCheckBox.Checked, msaLitCheckBox.Checked);
            Indicator nsa = new Indicator("NSA", nsaVisibleCheckBox.Checked, nsaLitCheckBox.Checked);
            Indicator snd = new Indicator("SND", sndVisibleCheckBox.Checked, sndLitCheckBox.Checked);
            Indicator sig = new Indicator("SIG", sigVisibleCheckBox.Checked, sigLitCheckBox.Checked);
            Indicator trn = new Indicator("TRN", trnVisibleCheckBox.Checked, trnLitCheckBox.Checked);

            //seeing if there is an empty port plate
            bool emptyPortPlate = emptyPortPlateCheckBox.Checked;

            //make sure dvid text box is valid
            int dvidNum;

            try
            {
                dvidNum = Int32.Parse(dvidTextBox.Text); 
            }
            catch
            {
                String text = "You entered an invalid DVI-D port number";

                String caption = "Invalid DVI-D Number";

                ShowErrorMessageBox(caption, text);

                return;
            }

            Port dvid = new Port("DVI-D", dvidNum);

            //make sure parallel text box is valid
            int parallelNum;

            try
            {
                parallelNum = Int32.Parse(parallelTextBox.Text);
            }
            catch
            {
                String text = "You entered an invalid parallel port number";

                String caption = "Invalid Parallel Number";

                ShowErrorMessageBox(caption, text);

                return;
            }

            Port parallel = new Port("parallel", parallelNum);


            //make sure rj text box is valid
            int rjNum;

            try
            {
                rjNum = Int32.Parse(rjTextBox.Text);
            }
            catch
            {
                String text = "You entered an invalid RJ-45 port number";

                String caption = "Invalid RJ-45 Number";

                ShowErrorMessageBox(caption, text);

                return;
            }

            Port rj = new Port("RJ-45", rjNum);

            //make sure ps text box is valid
            int psNum;

            try
            {
                psNum = Int32.Parse(serialTextBox.Text);
            }
            catch
            {
                String text = "You entered an invalid serial port number";

                String caption = "Invalid Serial Number";

                ShowErrorMessageBox(caption, text);

                return;
            }

            Port ps = new Port("PS/2", psNum);

            //make sure serial text box is valid
            int serialNum;

            try
            {
                serialNum = Int32.Parse(serialTextBox.Text);
            }
            catch
            {
                String text = "You entered an invalid serial port number";

                String caption = "Invalid Serial Number";

                ShowErrorMessageBox(caption, text);

                return;
            }

            Port serial = new Port("serial", serialNum);


            //make sure stereo text box is valid
            int stereoNum;

            //make sure parallel text box is valid
            try
            {
                stereoNum = Int32.Parse(serialTextBox.Text);
            }
            catch
            {
                String text = "You entered an invalid stereo port number";

                String caption = "Invalid Stereo Number";

                ShowErrorMessageBox(caption, text);

                return;
            }

            Port stereo = new Port("stereo RCA", stereoNum);


            //if this statement is reached, the bomb is valid.
            bomb = new Bomb(day, serialNumber, battery, batteryHolder, bob, car, clr, frk, frq, ind, msa, nsa, sig, snd, trn, emptyPortPlate, dvid, parallel, ps, rj, serial, stereo);

            //going onto the confirmation page
            confirmationForm = new EdgeworkConfirmationForm(bomb, this);
            this.Hide();
            confirmationForm.Show();

        }

        /// <summary>
        /// Shows a message box that will indicate an error
        /// </summary>
        /// <param name="caption">the caption of the message box</param>
        /// <param name="text">the text the message box with show</param>
        private void ShowErrorMessageBox(String caption, String text)
        {
            MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Makes sure the user is sure they want to close
        /// </summary>
        private void EdgeworkInputForm_FormClosing(object sender, FormClosingEventArgs e)
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
        /// Changes textbox color to gray
        /// so it looks like prompt text
        /// </summary>
        /// <param name="textBox">the text box getting the prompt text</param>
        /// <param name="text">what the prompt text will say</param>
        private void SetPromptText(TextBox textBox, String text)
        {
            textBox.Text = text;
            textBox.ForeColor = Color.Gray;

        }

        /// <summary>
        /// Deletes the text in the prompt text
        /// so the user can type in whatever
        /// </summary>
        /// <param name="textBox">the textbox that will be left blank</param>
        /// <param name="propmtText">the prompt text in the textbox</param>
        private void DeletePromptText(TextBox textBox, String propmtText)
        {
            if (textBox.Text == propmtText)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        private void batteryTextBox_Enter(object sender, EventArgs e)
        {
            DeletePromptText(batteryTextBox, "# of batteries");

        }

        private void batteryHolderTextBox_Enter(object sender, EventArgs e)
        {
            DeletePromptText(batteryHolderTextBox, "# of battery holders");
        }

        private void dvidTextBox_Enter(object sender, EventArgs e)
        {
            DeletePromptText(dvidTextBox, "# of DVI-D ports");
        }

        
        private void parallelTextBox_Enter(object sender, EventArgs e)
        {
            DeletePromptText(parallelTextBox, "# of parallel ports");
        }

        private void psTextBox_Enter(object sender, EventArgs e)
        {
            DeletePromptText(psTextBox, "# of PS/2 ports");
        }

        private void rjTextBox_Enter(object sender, EventArgs e)
        {
            DeletePromptText(rjTextBox, "# of RJ-45 ports");
        }

        private void serialTextBox_Enter(object sender, EventArgs e)
        {
            DeletePromptText(serialTextBox, "# of serial ports");
        }

        private void stereoTextBox_Enter(object sender, EventArgs e)
        {
            DeletePromptText(stereoTextBox, "# of stereo RCA ports");
        }

        private void batteryTextBox_Leave(object sender, EventArgs e)
        {
            if (batteryTextBox.Text == "")
            { 
                SetPromptText(batteryTextBox, "# of batteries");
            }

        }

        private void batteryHolderTextBox_Leave(object sender, EventArgs e)
        {
            if (batteryHolderTextBox.Text == "")
            {
                SetPromptText(batteryHolderTextBox, "# of battery holders");
            }
        }

        private void dvidTextBox_Leave(object sender, EventArgs e)
        {
            if (dvidTextBox.Text == "")
            {
                SetPromptText(dvidTextBox, "# of DVI-D ports");
            }
        }

        private void parallelTextBox_Leave(object sender, EventArgs e)
        {
            if (parallelTextBox.Text == "")
            {
                SetPromptText(parallelTextBox, "# of parallel ports");
            }
        }

        private void psTextBox_Leave(object sender, EventArgs e)
        {
            if (psTextBox.Text == "")
            {
                SetPromptText(psTextBox, "# of PS/2 ports");
            }
        }

        private void rjTextBox_Leave(object sender, EventArgs e)
        {
            if (rjTextBox.Text == "")
            {
                SetPromptText(rjTextBox, "# of RJ-45 ports");
            }
        }

        private void serialTextBox_Leave(object sender, EventArgs e)
        {
            if (serialTextBox.Text == "")
            {
                SetPromptText(serialTextBox, "# of serial ports");
            }
        }

        private void stereoTextBox_Leave(object sender, EventArgs e)
        {
            if (stereoTextBox.Text == "")
            {
                SetPromptText(stereoTextBox, "# of stereo RCA ports");
            }
        }
    }  
}
