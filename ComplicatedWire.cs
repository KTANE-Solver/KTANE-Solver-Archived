using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTANE_Solver
{
    //Date: 4/27/21
    //Purpose: Repreents wires that appear in "Complicated Wires"
    class ComplicatedWire
    {
        //PROPERTIES

        //the colors the wire could be
        public enum Color
        { 
            BLUE,
            RED,
            PURPLE,
            WHITE
        }

        //the color of the wire
        public Color ColorPropety { get; set; }

        //if there's a star
        public bool Star { get; set; }

        //if the light is lit
        public bool Lit { get; set; }

        //CONSTURCTOR

        /// <summary>
        /// Creates a complicated wire
        /// </summary>
        /// <param name="color">the color of the wire</param>
        /// <param name="star">If thee's a star on the wire</param>
        /// <param name="lit">If the light is lit</param>
        public ComplicatedWire(Color color, bool star, bool lit)
        {
            ColorPropety = color;
            Star = star;
            Lit = lit;
        }

        //METHOD
    }
}
