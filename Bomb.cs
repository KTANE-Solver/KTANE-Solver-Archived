using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTANE_Solver
{
    /// <summary>
    /// Author: Nya Bentley
    /// Date: 2/27/21
    /// Purpose: Represnts the bomb, will hold all of the edgework
    /// </summary>
    public class Bomb
    {
        //===============ENUM===============

        //an enum that represents the days of the week

        //===============FIELDS===============

        //the day of the week
        private Day day;

        //the seraial number
        private String serialNumber;

        //the number of batteries
        private int battery;

        //the number of battery holders
        private int batteryHolder;

        //list of lit indicators
        public List<Indicator> LitIndicatorsList { get; }

        //list of unlit indicators
        public List<Indicator> UnlitIndicatorsList { get; }

        //indicator bob
        private Indicator bob;

        //indicator car
        private Indicator car;

        //indicator clr
        private Indicator clr;

        //indicator frk
        private Indicator frk;

        //indicator frq
        private Indicator frq;

        //indicator ind
        private Indicator ind;

        //indicator msa
        private Indicator msa;

        //indicator nsa
        private Indicator nsa;

        //indicator snd
        private Indicator snd;

        //indicator sig
        private Indicator sig;

        //indicator trn
        private Indicator trn;

        //if there is an empty port plate
        private bool emptyPortPlate;

        //dvid port
        private Port dvid;

        //parallel port
        private Port parallel;

        //ps2 port
        private Port ps;

        //rj45 port
        private Port rj;

        //serial port
        private Port serial;

        //stereo port
        private Port stereo;

        //the number of strikes
        private int strike;

        //===============PROPERTIES===============
        public Day Day
        {
            get
            { 
                return day;
            }
        }

        public String SerialNumber
        {
            get
            {
                return serialNumber;
            }
        }

        //tells if this serial number
        public bool ValidSerialNumber
        {
            //the serial number must have at least one number
            //the serial number must have at least on letter
            //the serial number's last character must be a number

            get
            {
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

                return lastCharIsNum && hasLetter;
            }
        }

        //tells the first digit in the serial number
        public int FirstDigit
        {
            get
            {
                for (int i = 0; i < serialNumber.Length; i++)
                {
                    if (serialNumber[i] >= 48 && serialNumber[i] <= 57)
                    {
                        return Int32.Parse("" + serialNumber[i]);
                    }
                }

                //should never happen
                return -1;
            }
        }

        //tells the last digit in the serial number
        public int LastDigit
        {
            get
            {
                return Int32.Parse("" + serialNumber[serialNumber.Length - 1]);
            }
        }

        public char FirstLetter
        {
            get
            {
                for (int i = 0; i > serialNumber.Length; i++)
                {
                    if (serialNumber[i] >= 65 && serialNumber[i] <= 90)
                    {
                        return serialNumber[i];
                    }
                }

                //this should never happen
                return serialNumber[0];
            }
        }

        //tells the last letter in the serialNumber
        public char LastLetter
        {
            get
            { 
                for(int i = serialNumber.Length - 1; i > -1; i--)
                {
                    if (serialNumber[i] >= 65 && serialNumber[i] <= 90)
                    {
                        return serialNumber[i];
                    }
                }

                //this should never happen
                return serialNumber[0];
            }
        }

        //Tells if the last letter is a vowel
        public bool LastLetterIsVowel
        {
            get
            {
                return LastLetter == 'A' || LastLetter == 'E' || LastLetter == 'O' || LastLetter == 'I' || LastLetter == 'U';
            }
        }

        //tells how many digits are in the serial number
        public int DigitNum
        {
            get
            {
                int num = 0;

                for (int i = 0; i < serialNumber.Length; i++)
                {
                    if (serialNumber[i] >= 48 && serialNumber[i] <= 57)
                    {
                        num++;
                    }
                }

                return num;
            }
        }

        //tells how many digits are in the serial number
        public int LetterNum
        {
            get
            {
                int num = 0;

                for (int i = 0; i < serialNumber.Length; i++)
                {
                    if (serialNumber[i] >= 65 && serialNumber[i] <= 90)
                    {
                        num++;
                    }
                }

                return num;
            }
        }

        //tells how the sum of digits in the serial number
        public int DigitSum
        {
            get
            {
                int sum = 0;

                for (int i = 0; i < serialNumber.Length; i++)
                {
                    if (serialNumber[i] >= 48 && serialNumber[i] <= 57)
                    {
                        sum += Int32.Parse("" + serialNumber[i]);
                    }
                }

                return sum;
            }
        }

        //the number of vowles in the serial number
        public int VowelNum
        {
            get
            {
                int num = 0;
                for (int i = 0; i < serialNumber.Length; i++)
                {
                    switch (serialNumber[i])
                    {
                        case 'A':
                        case 'E':
                        case 'I':
                        case 'O':
                        case 'U':
                            num++;
                            break;

                    }
                }

                return num;
            }
        }

        //tells if the serial number has a vowel
        public bool HasVowel
        {
            get
            {
                for (int i = 0; i < serialNumber.Length; i++)
                {
                    switch (serialNumber[i])
                    {
                        case 'A':
                        case 'E':
                        case 'I':
                        case 'O':
                        case 'U':
                            return true;

                    }
                }

                return false;
            }
        }

        public int Battery
        {
            get
            {
                return battery;
            }
        }

        public int BatteryHolder
        {
            get
            {
                return batteryHolder;
            }
        }

        //the number AA batteries on the bomb
        public int AABattery
        {
            get
            {
                //subtract the number of D batteries from the total
                //amount of batteries
                return battery - DBattery;
            }
        }

        //the number of D batteries on the bomb
        public int DBattery
        {
            get
            {
                //keep subtracting the number of holders by a factor of 1,
                //and keep subtracting the number of batteries by a factor of 2,
                //until the number of batteries and number of holders are the same.
                //That will be the number of d batteries

                int batteryNum = battery;
                int batteryHolderNum = batteryHolder;

                while (batteryHolderNum != batteryNum)
                {
                    batteryNum -= 2;
                    batteryHolderNum -= 1;
                }

                return batteryNum;
            }
        }

        public Indicator Bob
        {
            get
            {
                return bob;
            }
        }

        public Indicator Car
        {
            get
            {
                return car;
            }
        }

        public Indicator Clr
        {
            get
            {
                return clr;
            }
        }

        public Indicator Frk
        {
            get
            {
                return frk;
            }
        }

        public Indicator Frq
        {
            get
            {
                return frq;
            }
        }

        public Indicator Ind
        {
            get
            {
                return ind;
            }
        }

        public Indicator Msa
        {
            get
            {
                return msa;
            }
        }

        public Indicator Nsa
        {
            get
            {
                return nsa;
            }
        }

        public Indicator Sig
        {
            get
            {
                return sig;
            }
        }

        public Indicator Snd
        {
            get
            {
                return snd;
            }
        }

        public Indicator Trn
        {
            get
            {
                return trn;
            }
        }

        //tells how many lit inidcators are on the bomb
        public int IndicatorLitNum
        {
            get
            {
                return LitIndicatorsList.Count;
            }
        }

        //tells how many unlit inidcators are on the bomb
        public int IndicatorUnlitNum
        {
            get
            {
                return UnlitIndicatorsList.Count;
            }
        }

        //the number of indicaotrs on the bomb
        public int IndicatorNum
        {
            get
            { 
                return IndicatorUnlitNum + IndicatorLitNum;
            }
        }

        public bool EmptyPortPlate
        {
            get
            {
                return emptyPortPlate;
            }
        }

        public Port Dvid
        {
            get
            {
                return dvid;
            }
        }

        public Port Parallel
        {
            get
            {
                return parallel;
            }
        }

        public Port Ps
        {
            get
            {
                return ps;
            }
        }

        public Port Rj
        {
            get
            {
                return rj;
            }
        }

        public Port Serial
        {
            get
            {
                return serial;
            }
        }

        public Port Stereo
        {
            get
            {
                return stereo;
            }
        }

        //the number of unique ports on the bomb
        public int UniquePortNum
        {
            get
            {
                int num = 0;

                if (dvid.Num > 0)
                    num++;

                if (parallel.Num > 0)
                    num++;

                if (ps.Num > 0)
                    num++;

                if (rj.Num > 0)
                    num++;

                if (serial.Num > 0)
                    num++;

                if (stereo.Num > 0)
                    num++;

                return num;
            }
        }

        //tells the total amount of ports on the bomb
        public int PortNum
        {
            get
            {
                int num = dvid.Num;

                num += parallel.Num;

                num += ps.Num;

                num += rj.Num;

                num += serial.Num;

                num += stereo.Num;

                return num;
            }
        }

        public int Strike
        {
            get
            {
                return strike;
            }

            set
            {
                strike = value;
            }
        }
        //===============CONSTRUCTORS===============
        /// <summary>
        /// Create a bomb
        /// </summary>
        /// <param name="day">the day of the week</param>
        /// <param name="serialNumber">the serial number found on the bomb</param>
        /// <param name="battery">the number of batteries on the bomb</param>
        /// <param name="batteryHolder">the number of battery holders on the bomb</param>
        /// <param name="bob">the bob indicator</param>
        /// <param name="car">the car indicator</param>
        /// <param name="clr">the clr indicator</param>
        /// <param name="frk">the frk indicator</param>
        /// <param name="frq">the frq indicator</param>
        /// <param name="ind">the ind indicator</param>
        /// <param name="msa">the msa indicator</param>
        /// <param name="nsa">the nsa indicator</param>
        /// <param name="sig">the sig indicator</param>
        /// <param name="snd">the snd indicator</param>
        /// <param name="trn">the trn indicator</param>
        /// <param name="emptyPortPlate">if there is an empty port plate</param>
        /// <param name="dvid">the dvid port</param>
        /// <param name="parallel">the parallel port</param>
        /// <param name="ps">the ps/2 port</param>
        /// <param name="rj">the rj-45 port</param>
        /// <param name="serial">the serial port</param>
        /// <param name="stereo">the stereo port</param>
        public Bomb(Day day, String serialNumber, int battery, int batteryHolder, Indicator bob, Indicator car, 
                    Indicator clr, Indicator frk, Indicator frq, Indicator ind, Indicator msa, Indicator nsa, 
                    Indicator sig, Indicator snd, Indicator trn, bool emptyPortPlate, Port dvid, Port parallel, 
                    Port ps, Port rj, Port serial, Port stereo)
        {
            LitIndicatorsList = new List<Indicator>();
            UnlitIndicatorsList = new List<Indicator>();

            this.day = day;
            this.serialNumber = serialNumber.ToUpper();
            this.battery = battery;
            this.batteryHolder = batteryHolder;
            this.bob = bob;
            this.car = car;
            this.clr = clr;
            this.frk = frk;
            this.frq = frq;
            this.ind = ind;
            this.msa = msa;
            this.nsa = nsa;
            this.sig = sig;
            this.snd = snd;
            this.trn = trn;
            this.emptyPortPlate = emptyPortPlate;
            this.dvid = dvid;
            this.parallel = parallel;
            this.ps = ps;
            this.rj = rj;
            this.serial = serial;
            this.stereo = stereo;


            if (bob.VisibleAndLit)
            {
                LitIndicatorsList.Add(bob);
            }

            else if (bob.VisibleNotLit)
            {
                UnlitIndicatorsList.Add(bob);
            }

            if (car.VisibleAndLit)
            {
                LitIndicatorsList.Add(car);
            }

            else if (car.VisibleNotLit)
            {
                UnlitIndicatorsList.Add(car);
            }


            if (clr.VisibleAndLit)
            {
                LitIndicatorsList.Add(clr);
            }

            else if (clr.VisibleNotLit)
            {
                UnlitIndicatorsList.Add(clr);
            }


            if (frk.VisibleAndLit)
            {
                LitIndicatorsList.Add(frk);
            }

            else if (frk.VisibleNotLit)
            {
                UnlitIndicatorsList.Add(frk);
            }

            if (frq.VisibleAndLit)
            {
                LitIndicatorsList.Add(frq);
            }

            else if (frq.VisibleNotLit)
            {
                UnlitIndicatorsList.Add(frq);
            }

            if (ind.VisibleAndLit)
            {
                LitIndicatorsList.Add(ind);
            }

            else if (ind.VisibleNotLit)
            {
                UnlitIndicatorsList.Add(ind);
            }

            if (msa.VisibleAndLit)
            {
                LitIndicatorsList.Add(msa);
            }

            else if (msa.VisibleNotLit)
            {
                UnlitIndicatorsList.Add(msa);
            }

            if (nsa.VisibleAndLit)
            {
                LitIndicatorsList.Add(nsa);
            }

            else if (nsa.VisibleNotLit)
            {
                UnlitIndicatorsList.Add(nsa);
            }

            if (sig.VisibleAndLit)
            {
                LitIndicatorsList.Add(sig);
            }

            else if (sig.VisibleNotLit)
            {
                UnlitIndicatorsList.Add(sig);
            }

            if (snd.VisibleAndLit)
            {
                LitIndicatorsList.Add(snd);
            }

            else if (snd.VisibleNotLit)
            {
                UnlitIndicatorsList.Add(snd);
            }

            if (trn.VisibleAndLit)
            {
                LitIndicatorsList.Add(trn);
            }

            else if (trn.VisibleNotLit)
            {
                UnlitIndicatorsList.Add(trn);
            }

        }

        //===============METHODS===============
        /// <summary>
        /// increases the amount of strikes by 1
        /// </summary>
        public void IncrementStrike()
        {
            strike++;
        }

        /// <summary>
        /// resets the amount of strikes to 0
        /// </summary>
        public void ResetStrike()
        {
            strike = 0;
        }

        /// <summary>
        /// Tells how many times a desired character 
        /// is found in the serial number
        /// </summary>
        /// <param name="character">the character that wants to be found</param>
        /// <returns>the number of times the character was found</returns>
        public int CharacterCount(char character)
        {
            int num = 0;

            for (int i = 0; i < serialNumber.Length; i++)
            {
                if (serialNumber[i] == character)
                {
                    num++;
                }
            }

            return num;
        }
    }
}
