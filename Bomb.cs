using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTANE_Solver
{
    //Author: Nya Bentley
    //Date: 2/27/21
    //Purpose: Represnts the bomb, will hold all of the edgework
    public class Bomb
    {
        //===============ENUM===============

        //an enum that represents the days of the week
        public enum Days
        { 
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        //===============FIELDS===============

        //the day of the week
        private Days day;

        //the seraial number
        private String serialNumber;

        //the number of batteries
        private int battery;

        //the number of battery holders
        private int batteryHolder;

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

        //indicator sig
        private Indicator sig;

        //indicator snd
        private Indicator snd;

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
        public Days Day
        {
            get
            { 
                return day;
            }
        }

        public String SeiralNumber
        {
            get
            {
                return serialNumber;
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
                //keep subtracting two batteries for every
                //holder on the bomb

                return battery - (2 * batteryHolder);
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

        public int Strike
        {
            get
            {
                return strike;
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
        public Bomb(Days day, String serialNumber, int battery, int batteryHolder, Indicator bob, Indicator car, 
                    Indicator clr, Indicator frk, Indicator frq, Indicator ind, Indicator msa, Indicator nsa, 
                    Indicator sig, Indicator snd, Indicator trn, bool emptyPortPlate, Port dvid, Port parallel, 
                    Port ps, Port rj, Port serial, Port stereo)
        {
            this.day = day;
            this.serialNumber = serialNumber;
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
    }
}
