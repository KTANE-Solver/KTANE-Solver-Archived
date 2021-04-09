using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KTANE_Solver
{
    //Author: Nya Bentley
    //Date: 4/8/21
    //Purpose: Keeps all the information that
    //          all modules have here
    public class Module
    {
        //where the information of the bomb is stored
        protected Bomb Bomb { get; }

        //used to write to the log file
        protected StreamWriter LogFileWriter { get; }

        /// <summary>
        /// Base of a module
        /// </summary>
        /// <param name="bomb">used for edgework</param>
        /// <param name="logFileWriter">used to write to the log file</param>
        public Module(Bomb bomb, StreamWriter logFileWriter)
        {
            Bomb = bomb;
            LogFileWriter = logFileWriter;
        }
    }
}
