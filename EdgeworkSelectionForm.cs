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
    //Author: Nya Bentley
    //Date: 2/27/21
    //Purpose: Used to prompt the user if they want to get 
    //         the edgework from the Edgework.txt or type 
    //         it in manually
            
    public partial class EdgeworkSelectionForm : Form
    {
        EdgeworkConfirmationForm confirmationForm;
        EdgeworkInputForm inputForm;
        public EdgeworkSelectionForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates a bomb object and sends the user to the EdgeworkConfirmation Form
        /// </summary>
        private void automaticButton_Click(object sender, EventArgs e)
        {
            Bomb.Days day = 0;

            String serialNumber = "0";

            int battery = 0;
            int batteryHolder = 0;

            Indicator bob = null;
            Indicator car = null;
            Indicator clr = null;
            Indicator frk = null;
            Indicator frq = null;
            Indicator ind = null;
            Indicator msa = null;
            Indicator nsa = null;
            Indicator sig = null;
            Indicator snd = null;
            Indicator trn = null;

            bool emptyPortPlate = false;

            Port dvid = null;
            Port parallel = null;
            Port ps = null;
            Port rj = null;
            Port serial = null;
            Port stereo = null;

            //if there is a problem reading Edgework.txt
            bool errorReached = false;

            StreamReader reader = new StreamReader("../../Edgework.txt");

            //the line the reader is reading

            for (int lineReaing = 1; lineReaing <= 22; lineReaing++)
            {
                String currentLine = reader.ReadLine();

                switch (lineReaing)
                {
                    //day of the week
                    case 1:
                        errorReached = !Enum.TryParse(currentLine, out day);

                        if (errorReached)
                        {
                            Console.WriteLine("Can't read day. Read " + currentLine);
                        }
                        break;

                    //serial number
                    case 2:
                        serialNumber = currentLine.ToUpper();
                        break;

                    //batteries
                    case 3:
                        errorReached = !Int32.TryParse(currentLine, out battery);

                        if (errorReached)
                        {
                            Console.WriteLine("Can't read battery. Read " + currentLine);
                        }

                        break;

                    //battery holder
                    case 4:
                        errorReached = !Int32.TryParse(currentLine, out batteryHolder);

                        if (errorReached)
                        {
                            Console.WriteLine("Can't read batteryHolder");
                        }

                        break;

                    //indicator bob
                    case 5:
                        String[] indicatorInfo = currentLine.Split('|');

                        bool visible;
                        bool lit;

                        try
                        {
                            visible = bool.Parse(indicatorInfo[0]);
                            lit = bool.Parse(indicatorInfo[1]);

                            bob = new Indicator("BOB", visible, lit);
                        }

                        catch
                        {
                            errorReached = true;


                            Console.WriteLine("Can't read bob");

                        }

                        break;

                    //indicator car
                    case 6:
                        indicatorInfo = currentLine.Split('|');

                        try
                        {
                            visible = bool.Parse(indicatorInfo[0]);
                            lit = bool.Parse(indicatorInfo[1]);

                            car = new Indicator("CAR", visible, lit);
                        }

                        catch
                        {
                            errorReached = true;
                            Console.WriteLine("Can't read car");

                        }
                        break;

                    //indicator clr
                    case 7:

                        indicatorInfo = currentLine.Split('|');

                        try
                        {
                            visible = bool.Parse(indicatorInfo[0]);
                            lit = bool.Parse(indicatorInfo[1]);

                            clr = new Indicator("CLR", visible, lit);
                        }

                        catch
                        {
                            errorReached = true;
                            Console.WriteLine("Can't read clr");
                        }

                        break;

                    //indicator frk
                    case 8:

                        indicatorInfo = currentLine.Split('|');

                        try
                        {
                            visible = bool.Parse(indicatorInfo[0]);
                            lit = bool.Parse(indicatorInfo[1]);

                            frk = new Indicator("FRK", visible, lit);
                        }

                        catch
                        {
                            errorReached = true;
                            Console.WriteLine("Can't read frk");
                        }

                        break;

                    //indicator frq
                    case 9:
                        indicatorInfo = currentLine.Split('|');

                        try
                        {
                            visible = bool.Parse(indicatorInfo[0]);
                            lit = bool.Parse(indicatorInfo[1]);

                            frq = new Indicator("FRQ", visible, lit);
                        }

                        catch
                        {
                            errorReached = true;
                            Console.WriteLine("Can't read frq");
                        }

                        break;

                    //indicator ind
                    case 10:

                        indicatorInfo = currentLine.Split('|');

                        try
                        {
                            visible = bool.Parse(indicatorInfo[0]);
                            lit = bool.Parse(indicatorInfo[1]);

                            ind = new Indicator("IND", visible, lit);
                        }

                        catch
                        {
                            errorReached = true;
                            Console.WriteLine("Can't read ind");
                        }

                        break;

                    //indicator msa
                    case 11:

                        indicatorInfo = currentLine.Split('|');

                        try
                        {
                            visible = bool.Parse(indicatorInfo[0]);
                            lit = bool.Parse(indicatorInfo[1]);

                            msa = new Indicator("MSA", visible, lit);
                        }

                        catch
                        {
                            errorReached = true;
                            Console.WriteLine("Can't read msa");
                        }

                        break;

                    //indicator nsa
                    case 12:

                        indicatorInfo = currentLine.Split('|');

                        try
                        {
                            visible = bool.Parse(indicatorInfo[0]);
                            lit = bool.Parse(indicatorInfo[1]);

                            nsa = new Indicator("NSA", visible, lit);
                        }

                        catch
                        {
                            errorReached = true;
                            Console.WriteLine("Can't read nsa");
                        }

                        break;

                    //indicator sig
                    case 13:

                        indicatorInfo = currentLine.Split('|');

                        try
                        {
                            visible = bool.Parse(indicatorInfo[0]);
                            lit = bool.Parse(indicatorInfo[1]);

                            sig = new Indicator("SIG", visible, lit);
                        }

                        catch
                        {
                            errorReached = true;
                            Console.WriteLine("Can't read sig");
                        }

                        break;

                    //indicator snd
                    case 14:

                        indicatorInfo = currentLine.Split('|');

                        try
                        {
                            visible = bool.Parse(indicatorInfo[0]);
                            lit = bool.Parse(indicatorInfo[1]);

                            snd = new Indicator("SND", visible, lit);
                        }

                        catch
                        {
                            errorReached = true;
                            Console.WriteLine("Can't read snd");
                        }


                        break;

                    //indicator trn
                    case 15:

                        indicatorInfo = currentLine.Split('|');

                        try
                        {
                            visible = bool.Parse(indicatorInfo[0]);
                            lit = bool.Parse(indicatorInfo[1]);

                            trn = new Indicator("TRN", visible, lit);
                        }

                        catch
                        {
                            errorReached = true;
                            Console.WriteLine("Can't read trn");
                        }


                        break;

                    //empty port plate
                    case 16:
                        try
                        {
                            emptyPortPlate = bool.Parse(currentLine);
                        }

                        catch
                        {
                            errorReached = true;
                            Console.WriteLine("Can't read empty port plate");
                        }

                        break;

                    //Port dvid
                    case 17:
                        int portNum;

                        errorReached = !Int32.TryParse(currentLine, out portNum);

                        dvid = new Port("DVI-D", portNum);

                        break;

                    //Port parallel
                    case 18:
                        errorReached = !Int32.TryParse(currentLine, out portNum);

                        parallel = new Port("Parallel", portNum);

                        if (errorReached)
                        { 
                            Console.WriteLine("Can't read parallel port");
                        }

                        break;

                    //Port ps/2
                    case 19:
                        errorReached = !Int32.TryParse(currentLine, out portNum);

                        ps = new Port("PS/2", portNum);

                        if (errorReached)
                        {
                            Console.WriteLine("Can't read ps/2 port");
                        }

                        break;
                        
                    //Port rj-45
                    case 20:
                        errorReached = !Int32.TryParse(currentLine, out portNum);

                        rj = new Port("RJ-45", portNum);

                        if (errorReached)
                        {
                            Console.WriteLine("Can't read rj-45 port. Read " + currentLine);
                        }

                        break;

                    //Port serial
                    case 21:
                        errorReached = !Int32.TryParse(currentLine, out portNum);

                        serial = new Port("Serial", portNum);

                        if (errorReached)
                        {
                            Console.WriteLine("Can't read serial port");
                        }

                        break;

                    //Port stereo
                    case 22:
                        errorReached = !Int32.TryParse(currentLine, out portNum);

                        stereo = new Port("Stero RCA", portNum);

                        if (errorReached)
                        {
                            Console.WriteLine("Can't read stereo port");
                        }

                        break;

                }

                if (errorReached)
                {
                    break;
                }
            }

            reader.Close();

            //no point in seeing if there is an error if there already is an error
            if (!errorReached)
            {

                //make sure the serial number is valid

                //the serial number must have at least one number
                //the serial number must have at least on letter
                //the serial number's last character must be a number
                bool lastCharIsNum = false;
                bool hasLetter = false;

                for (int i = 0; i < serialNumber.Length; i++)
                {
                    if (!hasLetter && serialNumber[i] >= 65 && serialNumber[i] <= 90)
                    {
                        hasLetter = true;
                    }

                    if (i == serialNumber.Length - 1 && serialNumber[i] >= 48 && serialNumber[i] <= 57)
                    {
                        lastCharIsNum = true;
                    }
                }

                if (!(lastCharIsNum && hasLetter))
                {
                    errorReached = true;
                    Console.WriteLine("Not a valid serial number");

                }

                //make sure the number of batteries is at least the same number of holders or at most twice
                if (!errorReached && battery < batteryHolder || battery > batteryHolder * 2)
                {
                    errorReached = true;
                    Console.WriteLine($"Invalid batteries and battery holders. Battery Count: {battery}. Battery Holder Count: {batteryHolder}");
                }

                //make sure each indicator is valid
                if (!errorReached && !bob.ValidIndicator)
                {
                    errorReached = true;
                    Console.WriteLine("Invalid bob");
                }

                if (!errorReached && !car.ValidIndicator)
                {
                    errorReached = true;
                    Console.WriteLine("Invalid car");
                }

                if (!errorReached && !clr.ValidIndicator)
                {
                    errorReached = true;
                    Console.WriteLine("Invalid clr");
                }

                if (!errorReached && !frk.ValidIndicator)
                {
                    errorReached = true;
                    Console.WriteLine("Invalid frk");
                }

                if (!errorReached && !frq.ValidIndicator)
                {
                    errorReached = true;
                    Console.WriteLine("Invalid frq");
                }

                if (!errorReached && !ind.ValidIndicator)
                {
                    errorReached = true;
                    Console.WriteLine("Invalid ind");
                }

                if (!errorReached && !msa.ValidIndicator)
                {
                    errorReached = true;
                    Console.WriteLine("Invalid msa");
                }

                if (!errorReached && !nsa.ValidIndicator)
                {
                    errorReached = true;
                    Console.WriteLine("Invalid nsa");
                }

                if (!errorReached && !sig.ValidIndicator)
                {
                    errorReached = true;
                    Console.WriteLine("Invalid sig");
                }

                if (!errorReached && !snd.ValidIndicator)
                {
                    errorReached = true;
                    Console.WriteLine("Invalid snd");
                }

                if (!errorReached && !trn.ValidIndicator)
                {
                    errorReached = true;
                    Console.WriteLine("Invalid trn");
                }
            }
            
            

            //if there is an error tell the user that and send them to the manually
            if (errorReached)
            {
                MessageBox.Show("There was an error reading Egdework.txt. Try manually inputting the edgework",
                                "Error Reading Edgework.txt",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                inputForm = new EdgeworkInputForm();
                this.Hide();
                inputForm.Show();
            }

            //otherwise go to the edgework confirmation form
            else
            {
                Bomb bomb = new Bomb(day, serialNumber, battery, batteryHolder, 
                                    bob, car, clr, frk, frq, ind, msa, nsa, sig, snd, trn, 
                                    emptyPortPlate, dvid, parallel, ps, rj, serial, stereo);

                confirmationForm = new EdgeworkConfirmationForm(bomb);
                this.Hide();
                confirmationForm.Show();
            }
        }

        /// <summary>
        /// Brings the user to the EdgeworkInput form
        /// </summary>
        private void manualButton_Click(object sender, EventArgs e)
        {
            inputForm = new EdgeworkInputForm();
            this.Hide();
            inputForm.Show();
        }

        /// <summary>
        /// Asks the user if the user is sure they want to close the program
        /// </summary>
        private void EdgeworkSelectionForm_FormClosing(object sender, FormClosingEventArgs e)
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
            }

            //If this form is already hidden, just close it



        }
    }
}
