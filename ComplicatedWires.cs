using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace KTANE_Solver
{
    //Date: 4/27/21
    //Purpose: Solves the "Complicated Wires" module
    class ComplicatedWires : Module
    {
        //the list of wires on the module
        private List<ComplicatedWire> wires;

        //tells the user which wires to cut
        private List<string> directions;

        /// <summary>
        /// Creates the class that will solve the "Complicated Wires" module
        /// </summary>
        /// <param name="wires">the list of wires</param>
        /// <param name="bomb">used for edgework</param>
        /// <param name="logFileWriter">used to write to the log file</param>
        public ComplicatedWires(List<ComplicatedWire> wires, Bomb bomb, StreamWriter logFileWriter) : base(bomb, logFileWriter)
        {
            this.wires = wires;

            directions = new List<string>();

            for (int i = 0; i < wires.Count; i++)
            {
                PrintWire(i + 1, wires[i]);
            }
        }

        public void Solve()
        {
            //find which wire needs to be cut
            foreach (ComplicatedWire wire in wires)
            {
                switch (wire.ColorPropety)
                {
                    //if the wire is blue,
                    case ComplicatedWire.Color.BLUE:

                        //if the wire is lit, cut if parllel port is there
                        if (wire.Lit)
                        {
                            AddParallelCondition();
                        }

                        //if the wire is unlit and has star, don't cut
                        else if (wire.Star)
                            directions.Add("Don't Cut");

                        //if the wire doesn't have a star, cut if last digit is even
                        else
                        {
                            AddEvenNumberCondition();
                        }
                        break;

                    //if the wire is red,
                    case ComplicatedWire.Color.RED:

                        //if the light is lit, cut if there's two or more batteries
                        if (wire.Lit)
                        {
                            AddBatteryCondition();
                        }

                        //if the light is unlit and has no star, cut if last digit is even
                        else if (!wire.Lit && !wire.Star)
                        {
                            AddEvenNumberCondition();
                        }

                        //if the light is unlit and there's a star, cut the wire
                        else
                            directions.Add("Cut");
                        break;

                        
                        

                    //if the wire is purple,
                    case ComplicatedWire.Color.PURPLE:

                        //if the light is lit, and there's a star, don't cut the wire
                        if (wire.Lit && wire.Star)
                            directions.Add("Don't Cut");


                        //if the light is unlit, and star, cut if parallel port is there
                        else if (!wire.Lit && wire.Star)
                        {
                            AddParallelCondition();
                        }

                        //if the light is unlit and no star, cut if last digit is even

                        //if the light is lit, and no star, cut if last digit is even

                        else
                            AddEvenNumberCondition();
                            break;

                    //if the wire is white,
                    case ComplicatedWire.Color.WHITE:
                        //if light is unlit, cut the wire
                        if (!wire.Lit)
                            directions.Add("Cut");

                        //if light is lit, and star, cut if more than 2 batteires
                        else if (wire.Lit && wire.Star)
                        {
                            AddBatteryCondition();
                        }

                        //if light is lit, and no star, don't cut
                        else
                            directions.Add("Don't Cut");
                        break;
                }
            }

            string answer = "";

            for (int i = 0; i < directions.Count; i++)
            {
                answer += $"{i + 1}. {directions[i]}\n";
            }

            MessageBox.Show(answer, "Complicated Wires", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        /// <summary>
        /// Tells the user to cut the wire if there are two or more batteries
        /// </summary>
        private void AddBatteryCondition()
        {
            if (Bomb.Battery >= 2)
                directions.Add("Cut");

            else
                directions.Add("Don't Cut");
        }

        private void AddParallelCondition()
        {
            if (Bomb.Parallel.Visible)
                directions.Add("Cut");

            else
                directions.Add("Don't Cut");
        }

        private void AddEvenNumberCondition()
        {
            if (Bomb.LastDigit % 2 == 0)
                directions.Add("Cut");

            else
                directions.Add("Don't Cut");
        }

        /// <summary>
        /// Prints the wire information
        /// </summary>
        /// <param name="num">the index of the wire</param>
        /// <param name="wire">the wire itself</param>
        private void PrintWire(int num, ComplicatedWire wire)
        {
            Console.WriteLine($"Wire {num} Color: {wire.ColorPropety} Light: {wire.Lit} Star: {wire.Star}");
        }
    }
}
