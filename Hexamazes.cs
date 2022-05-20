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

            for (int column = 0; column < 23; column++)
            {
                //1st column
                if (column == 0)
                {
                    for (int row = 0; row < 45; row++)
                    {
                        switch (row)
                        {
                            case 11:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandNorthWest);
                                break;

                            case 13:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastOpen);
                                break;

                            case 15:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthOpen);
                                break;

                            case 17:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEast);
                                break;

                            case 19:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 21:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthOpen);
                                break;

                            case 23:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 25:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthandNorthWestOpen);
                                break;

                            case 26:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandSouth);
                                break;

                            case 27:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandSouth);
                                break;

                            case 29:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 31:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthWestOpen);
                                break;

                            case 33:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastOpen);
                                break;

                            default:
                                maze[row, column] = null;
                                break;

                        }
                    }
                }

                //2nd column
                else if (column == 1)
                {
                    for (int row = 0; row < 45; row++)
                    {
                        switch (row)
                        {
                            case 10:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthandSouthWestOpen);
                                break;

                            case 12:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 14:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 16:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthandNorthWest);
                                break;

                            case 18:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandSouth);
                                break;

                            case 20:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandNorthWest);
                                break;

                            case 22:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;


                            case 24:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastOpen);
                                break;


                            case 26:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 28:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastOpen);
                                break;

                            case 30:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastOpen);
                                break;

                            case 32:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastOpen);
                                break;

                            case 34:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastOpen);
                                break;

                            default:
                                maze[row, column] = null;
                                break;
                        }
                    }
                }

                //3rd column
                else if (column == 2)
                {
                    for (int row = 0; row < 45; row++)
                    {
                        switch (row)
                        {
                            case 9:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastOpen);
                                break;

                            case 11:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthOpen);
                                break;

                            case 13:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastOpen);
                                break;

                            case 15:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandNorthWest);
                                break;

                            case 17:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastandNorthWest);
                                break;

                            case 19:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthandNorthWest);
                                break;

                            case 21:
                                maze[row, column] = new Node(row, column, Symbol.Hexagon, Walls.SouthEastOpen);
                                break;

                            case 23:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthWestOpen);
                                break;

                            case 25:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthWestOpen);
                                break;

                            case 27:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastOpen);
                                break;

                            case 29:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastOpen);
                                break;

                            case 31:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandSouthWest);
                                break;

                            case 33:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthWestOpen);
                                break;

                            case 35:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastOpen);
                                break;

                            default:
                                maze[row, column] = null;
                                break;
                        }
                    }
                }

                //4th column
                else if (column == 3)
                {
                    for (int row = 0; row < 45; row++)
                    {
                        switch (row)
                        {
                            case 8:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthandNorthWest);
                                break;

                            case 10:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastOpen);
                                break;

                            case 12:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 14:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEast);
                                break;

                            case 16:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 18:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastOpen);
                                break;

                            case 20:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandSouthWest);
                                break;

                            case 22:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastandSouthWest);
                                break;

                            case 24:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthandSouthWest);
                                break;

                            case 26:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEast);
                                break;

                            case 28:
                                maze[row, column] = new Node(row, column, Symbol.NorthEastTriangle, Walls.SouthEastandSouthWestandNorthWest);
                                break;

                            case 30:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastandSouthWest);
                                break;

                            case 32:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthandSouthWest);
                                break;

                            case 34:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthOpen);
                                break;

                            case 36:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWest);
                                break;

                            default:
                                maze[row, column] = null;
                                break;
                        }
                    }
                }

                //5th column
                else if (column == 4)
                {
                    for (int row = 0; row < 45; row++)
                    {
                        switch (row)
                        {
                            case 7:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEast);
                                break;

                            case 9:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWest);
                                break;

                            case 11:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWest);
                                break;

                            case 13:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWest);
                                break;

                            case 15:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWest);
                                break;

                            case 17:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastOpen);
                                break;


                            case 19:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 21:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 23:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastOpen);
                                break;

                            case 25:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandSouth);
                                break;

                            case 27:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 29:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthOpen);
                                break;

                            case 31:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastOpen);
                                break;

                            case 33:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandSouth);
                                break;

                            case 35:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastOpen);
                                break;

                            case 37:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            default:
                                maze[row, column] = null;
                                break;
                        }
                    }
                }

                //6th column
                else if (column == 5)
                {
                    for (int row = 0; row < 45; row++)
                    {
                        switch (row)
                        {
                            case 6:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWest);
                                break;

                            case 8:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWest);
                                break;

                            case 10:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWest);
                                break;

                            case 12:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandSouthWest);
                                break;

                            case 14:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthandSouthWest);
                                break;

                            case 16:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandSouth);
                                break;

                            case 18:
                                maze[row, column] = new Node(row, column, Symbol.Circle, Walls.NorthandSouthEastandSouthWest);
                                break;

                            case 20:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastandSouthWest);
                                break;

                            case 22:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEast);
                                break;

                            case 24:
                                maze[row, column] = new Node(row, column, Symbol.Circle, Walls.SouthEastandSouth);
                                break;

                            case 26:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 28:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 30:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthandNorthWest);
                                break;

                            case 32:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandNorthWest);
                                break;

                            case 34:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastandNorthWest);
                                break;

                            case 36:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthOpen);
                                break;

                            case 38:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandSouthWest);
                                break;

                            default:
                                maze[row, column] = null;
                                break;
                        }
                    }
                }

                //7th column
                else if (column == 6)
                {
                    for (int row = 0; row < 45; row++)
                    {
                        
                    }
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
            Pink,
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
            Hexagon,
            Circle,
            None
        }

        public class Node
        {
            private int Row { get; }
            private int Colunm { get; }
            private Symbol Symbol  { get; }
            public ExitColor ExitColor;
            private Node North { get;  }
            private Node NorthEast { get; }
            private Node SouthEast { get; }
            private Node South { get; }
            private Node SouthWest { get; }
            private Node NorthWest { get; }

            public Walls Walls { get; set; }

            public Node(int row, int column, Symbol symbol, Walls walls)
            {
                Row = row;
                Colunm = column;
                Symbol = symbol;
                Walls = walls;
                ExitColor = ExitColor.None;
            }
        }
    }
}
