using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KTANE_Solver
{
    class Hexamazes : Module
    {
        Hexamazes(Bomb bomb, StreamWriter logFileWriter) : base(bomb, logFileWriter, "Hexamazes")
        {

        }

        public enum Walls
        {

            //0 walls
            None,

            //1 walls
            North,
            NorthEast,
            SouthEast,
            South,
            SouthWest,
            NorthWest,

            //2 walls
            NorthandNorthEast,
            NorthandSouthEast,
            NorthandSouth,
            NorthandSouthWest,
            NorthandNorthWest,

            //3 walls
            NorthandNorthEastandSouthEast,
            NorthandNorthEastandSouth,
            NorthandNorthEastandSouthWest,
            NorthandNorthEastandNorthWest,
            
            
            NorthEastandSouthEastandSouth,
            NorthEastandSouthEastandSouthWest,
            NorthEastandSouthEastandNorthWest,
            NorthEastandSouthEastandNorth,


            SouthEastandSouthandSouthWest,
            SouthEastandSouthandNorthWest,
            SouthEastandSouthandNorth,
            SouthEastandSouthandNorthEast,
            
            SouthandSouthWestandNorthWest,
            SouthandSouthWestandNorth,
            SouthandSouthWestandNorthEast,
            SouthandSouthWestandSouthEast,
            
            SouthWestandNorthWestandNorth,
            SouthWestandNorthWestandNorthEast,
            SouthWestandNorthWestandSouthEast,
            SouthWestandNorthWestandSouth,


            //4 walls
            NorthandNorthEastandSouthEastandSouth,
            NorthandNorthEastandSouthEastandSouthWest,
            NorthandNorthEastandSouthEastandNorthWest,
            
            NorthEastandSouthEastandSouthandSouthWest,
            NorthEastandSouthEastandSouthandNorthWest,
            NorthEastandSouthEastandSouthandNorth,
            
            SouthEastandSouthandSouthWestandNorthWest,
            SouthEastandSouthandSouthWestandNorth,
            SouthEastandSouthandSouthWestandNorthEast,
            
            SouthandSouthWestandNorthWestandNorth,
            SouthandSouthWestandNorthWestandNorthEast,
            SouthandSouthWestandNorthWestandSouthEast,
            
            SouthWestandNorthWestandNorthandNorthEast,
            SouthWestandNorthWestandNorthandSouthEast,
            SouthWestandNorthWestandNorthandSouth,

            //5 walls
            NorthFree,
            NorthEastFree,
            SouthEastFree,
            SouthFree,
            SouthWestFree,
            NorthWestFree
        }


        public class Node
        {
            public int Row { get; }
            public int Colunm { get; }
            public char Character { get; }
            public Node North { get; set; }
            public Node NorthEast { get; set; }
            public Node SouthEast { get; set; }
            public Node South { get; set; }
            public Node SouthWest { get; set; }
            public Node NorthWest { get; set; }

            public Walls Wall { get; set; }
        }
    }
}
