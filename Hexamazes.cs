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
        private Node[,] maze;
        Hexamazes(Bomb bomb, StreamWriter logFileWriter) : base(bomb, logFileWriter, "Hexamazes")
        {

        }

        private void CreateMaze()
        {
            maze = new Node[45, 23];

            for (int i = 0; i < 23; i++)
            {
                if (i == 11)
                { 
                    maze[0, i] = new Node(0, i, Symbol.None, )
                }
            }







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

            NorthEastandSouthEast,
            NorthEastandSouth,
            NorthEastandSouthWest,
            NorthEastandNorthWest,

            SouthEastandSouth,
            SouthEastandSouthWest,
            SouthEastandNorthWest,

            SouthandSouthWest,
            SouthandNorthWest,

            SouthWestandNorthWest,

            //3 walls
            NorthandNorthEastandSouthEast,
            NorthandNorthEastandSouth,
            NorthandNorthEastandSouthWest,
            NorthandNorthEastandNorthWest,

            NorthandSouthEastandSouth,
            NorthandSouthEastandSouthWest,
            NorthandSouthEastandNorthWest,

            NorthandSouthandSouthWest,
            NorthandSouthandNorthWest,

            NorthandSouthWestandNorthWest,

            NorthEastandSouthEastandSouth,
            NorthEastandSouthEastandSouthWest,
            NorthEastandSouthEastandNorthWest,

            NorthEastandSouthandSouthWest,
            NorthEastandSouthandNorthWest,

            NorthEastandSouthWestandNorthWest,

            SouthEastandSouthandSouthWest,
            SouthEastandSouthandNorthWest,

            SouthEastandSouthWestandNorthWest,

            SouthandSouthWestandNorthWest,

            //4 walls

            NorthandNorthEastOpen,
            NorthandSouthEastOpen,
            NorthandSouthOpen,
            NorthandSouthWestOpen,
            NorthandNorthWestOpen,

            NorthEastandSouthEastOpen,
            NorthEastandSouthOpen,
            NorthEastandSouthWestOpen,
            NorthEastandNorthWestOpen,

            SouthEastandSouthOpen,
            SouthEastandSouthWestOpen,
            SouthEastandNorthWestOpen,

            SouthandSouthWestOpen,
            SouthandNorthWestOpen,

            SouthWestandNorthWestOpen,

            //5 walls
            NorthOpen,
            NorthEastOpen,
            SouthEastOpen,
            SouthOpen,
            SouthWestOpen,
            NorthWestOpen
        }

        public enum ExitColor
        { 
            Red,
            Yellow,
            Green,
            Cyan,
            Blue,
            Pink
        }

        public enum ExitColorDirection
        { 
            North,
            NorthEast,
            SouthEast,
            South,
            SouthWest,
            NorthWest,
            None
        }

        public enum Symbol
        { 
            NorthTriangle,
            NorthEastTriangle,
            EastTriangle,
            SouthEastTriangle,
            SouthTriangle,
            SouthWestTriangle,
            NorthWestTriangle,
            WestTriangle,
            HorizontalHexagon,
            VerticalHexagon,
            Circle,
            None
        }

        public class Node
        {
            public int Row { get; }
            public int Colunm { get; }
            public Symbol Symbol  { get; }
            public Node North { get;  }
            public Node NorthEast { get; }
            public Node SouthEast { get; }
            public Node South { get; }
            public Node SouthWest { get; }
            public Node NorthWest { get; }

            public Walls Walls { get; set; }

            public Node(int row, int column, Symbol symbol, Walls walls)
            {
                Row = row;
                Colunm = column;
                Symbol = symbol;
                Walls = walls;
            }
        }
    }
}
