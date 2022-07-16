using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace KTANE_Solver
{
    class Hexamazes : Module
    {
        private Node[,] bigMaze;
        private Node[,] littleMaze;
        private Cardinal littleMazeDirection;
        private int rowLineUp;
        private int colLineUp;

        public Hexamazes(Bomb bomb, StreamWriter logFileWriter, Node[,] littleMaze) : base(bomb, logFileWriter, "Hexamazes")
        {
            CreateBigMaze();
            VerifMaze(bigMaze);
            this.littleMaze = littleMaze;

            littleMazeDirection = Cardinal.North;
        }

        private enum Cardinal
        {
            North,
            NorthEast,
            SouthEast,
            South,
            SouthWest,
            NorthWest
        }

        public void Solve()
        {
            CreateBigMaze();
            FindLittleMaze();
        }
        /// <summary>
        /// Initializes all appropriate cells with data
        /// </summary>
        private void CreateBigMaze()
        {
            bigMaze = new Node[45, 23];

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
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandNorthWest);
                                break;

                            case 13:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastOpen);
                                break;

                            case 15:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthOpen);
                                break;

                            case 17:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEast);
                                break;

                            case 19:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 21:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthOpen);
                                break;

                            case 23:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 25:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthandNorthWestOpen);
                                break;

                            case 26:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandSouth);
                                break;

                            case 27:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandSouth);
                                break;

                            case 29:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 31:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthWestOpen);
                                break;

                            case 33:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastOpen);
                                break;

                            default:
                                bigMaze[row, column] = null;
                                break;

                        }
                    }
                }

                //2nd column
                else if (column == 2)
                {
                    for (int row = 0; row < 45; row++)
                    {
                        switch (row)
                        {
                            case 10:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthandSouthWestOpen);
                                break;

                            case 12:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 14:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 16:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthandNorthWest);
                                break;

                            case 18:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandSouth);
                                break;

                            case 20:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandNorthWest);
                                break;

                            case 22:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;


                            case 24:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastOpen);
                                break;


                            case 26:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 28:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastOpen);
                                break;

                            case 30:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastOpen);
                                break;

                            case 32:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastOpen);
                                break;

                            case 34:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastOpen);
                                break;

                            default:
                                bigMaze[row, column] = null;
                                break;
                        }
                    }
                }

                //3rd column
                else if (column == 4)
                {
                    for (int row = 0; row < 45; row++)
                    {
                        switch (row)
                        {
                            case 9:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastOpen);
                                break;

                            case 11:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthOpen);
                                break;

                            case 13:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastOpen);
                                break;

                            case 15:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandNorthWest);
                                break;

                            case 17:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastandNorthWest);
                                break;

                            case 19:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthandNorthWest);
                                break;

                            case 21:
                                bigMaze[row, column] = new Node(row, column, Symbol.Hexagon, Walls.SouthEastOpen);
                                break;

                            case 23:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthWestOpen);
                                break;

                            case 25:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthWestOpen);
                                break;

                            case 27:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastOpen);
                                break;

                            case 29:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastOpen);
                                break;

                            case 31:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandSouthWest);
                                break;

                            case 33:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthWestOpen);
                                break;

                            case 35:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastOpen);
                                break;

                            default:
                                bigMaze[row, column] = null;
                                break;
                        }
                    }
                }

                //4th column
                else if (column == 6)
                {
                    for (int row = 0; row < 45; row++)
                    {
                        switch (row)
                        {
                            case 8:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthandNorthWest);
                                break;

                            case 10:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastOpen);
                                break;

                            case 12:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 14:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEast);
                                break;

                            case 16:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 18:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastOpen);
                                break;

                            case 20:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandSouthWest);
                                break;

                            case 22:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastandSouthWest);
                                break;

                            case 24:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthandSouthWest);
                                break;

                            case 26:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEast);
                                break;

                            case 28:
                                bigMaze[row, column] = new Node(row, column, Symbol.LeftTriangle, Walls.SouthEastandSouthWestandNorthWest);
                                break;

                            case 30:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastandSouthWest);
                                break;

                            case 32:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthandSouthWest);
                                break;

                            case 34:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthOpen);
                                break;

                            case 36:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWest);
                                break;

                            default:
                                bigMaze[row, column] = null;
                                break;
                        }
                    }
                }

                //5th column
                else if (column == 8)
                {
                    for (int row = 0; row < 45; row++)
                    {
                        switch (row)
                        {
                            case 7:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEast);
                                break;

                            case 9:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWest);
                                break;

                            case 11:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWest);
                                break;

                            case 13:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWest);
                                break;

                            case 15:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWest);
                                break;

                            case 17:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastOpen);
                                break;


                            case 19:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 21:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 23:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastOpen);
                                break;

                            case 25:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandSouth);
                                break;

                            case 27:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 29:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthOpen);
                                break;

                            case 31:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastOpen);
                                break;

                            case 33:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandSouth);
                                break;

                            case 35:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastOpen);
                                break;

                            case 37:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            default:
                                bigMaze[row, column] = null;
                                break;
                        }
                    }
                }

                //6th column
                else if (column == 10)
                {
                    for (int row = 0; row < 45; row++)
                    {
                        switch (row)
                        {
                            case 6:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWest);
                                break;

                            case 8:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWest);
                                break;

                            case 10:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWest);
                                break;

                            case 12:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandSouthWest);
                                break;

                            case 14:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthandSouthWest);
                                break;

                            case 16:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandSouth);
                                break;

                            case 18:
                                bigMaze[row, column] = new Node(row, column, Symbol.Circle, Walls.NorthandSouthEastandSouthWest);
                                break;

                            case 20:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastandSouthWest);
                                break;

                            case 22:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEast);
                                break;

                            case 24:
                                bigMaze[row, column] = new Node(row, column, Symbol.Circle, Walls.SouthEastandSouth);
                                break;

                            case 26:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 28:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 30:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthandNorthWest);
                                break;

                            case 32:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandNorthWest);
                                break;

                            case 34:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastandNorthWest);
                                break;

                            case 36:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthOpen);
                                break;

                            case 38:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandSouthWest);
                                break;

                            default:
                                bigMaze[row, column] = null;
                                break;
                        }
                    }
                }

                //7th column
                else if (column == 12)
                {
                    for (int row = 0; row < 45; row++)
                    {
                        switch (row)
                        {
                            case 5:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandNorthWest);
                                break;

                            case 7:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEast);
                                break;

                            case 9:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthOpen);
                                break;

                            case 11:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouth);
                                break;

                            case 13:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthOpen);
                                break;

                            case 15:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouth);
                                break;

                            case 17:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthWest);
                                break;

                            case 19:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 21:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 23:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthandNorthWest);
                                break;

                            case 25:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEast);
                                break;

                            case 27:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthandNorthWest);
                                break;

                            case 29:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthandNorthWest);
                                break;

                            case 31:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEast);
                                break;

                            case 33:
                                bigMaze[row, column] = new Node(row, column, Symbol.Hexagon, Walls.NorthandSouthOpen);
                                break;

                            case 35:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 37:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastOpen);
                                break;

                            case 39:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandNorthWestOpen);
                                break;

                            default:
                                bigMaze[row, column] = null;
                                break;
                        }
                    }
                }

                //8th column
                else if (column == 14)
                {
                    for (int row = 0; row < 45; row++)
                    {
                        switch (row)
                        {
                            case 4:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandSouth);
                                break;

                            case 6:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastOpen);
                                break;

                            case 8:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 10:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthWest);
                                break;

                            case 12:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 14:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 16:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthandNorthWest);
                                break;

                            case 18:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandSouthWest);
                                break;

                            case 20:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestandNorthWest);
                                break;

                            case 22:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastandNorthWest);
                                break;

                            case 24:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthandNorthWest);
                                break;

                            case 26:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWest);
                                break;

                            case 28:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandSouth);
                                break;

                            case 30:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandSouthWest);
                                break;

                            case 32:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastandSouthWest);
                                break;

                            case 34:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastOpen);
                                break;

                            case 36:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandNorthWest);
                                break;

                            case 38:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastandNorthWest);
                                break;

                            case 40:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthOpen);
                                break;

                            default:
                                bigMaze[row, column] = null;
                                break;
                        }
                    }
                }

                //9th column
                else if (column == 16)
                {
                    for (int row = 0; row < 45; row++)
                    {
                        switch (row)
                        {
                            case 4:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 6:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 8:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandSouthWest);
                                break;

                            case 10:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastandSouthWest);
                                break;

                            case 12:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouth);
                                break;

                            case 14:
                                bigMaze[row, column] = new Node(row, column, Symbol.DownTriangle, Walls.NorthandNorthEastandNorthWest);
                                break;

                            case 16:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthandNorthWest);
                                break;

                            case 18:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 20:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 22:
                                bigMaze[row, column] = new Node(row, column, Symbol.UpTriangle, Walls.SouthEastandNorthWest);
                                break;

                            case 24:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWest);
                                break;

                            case 26:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 28:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 30:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthWest);
                                break;

                            case 32:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 34:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandNorthWest);
                                break;

                            case 36:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandNorthWest);
                                break;

                            case 38:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthOpen);
                                break;

                            case 40:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthOpen);
                                break;

                            case 42:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthandNorthWest);
                                break;

                            default:
                                bigMaze[row, column] = null;
                                break;
                        }
                    }
                }

                //10th column
                else if (column == 18)
                {
                    for (int row = 0; row < 45; row++)
                    {
                        switch (row)
                        {
                            case 2:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthOpen);
                                break;

                            case 4:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthandNorthWest);
                                break;

                            case 6:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWest);
                                break;

                            case 8:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthOpen);
                                break;

                            case 10:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandNorthWest);
                                break;

                            case 12:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 14:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthandSouthWest);
                                break;

                            case 16:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 18:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 20:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 22:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandSouth);
                                break;

                            case 24:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 26:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthandNorthWest);
                                break;

                            case 28:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 30:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthandSouthWest);
                                break;

                            case 32:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 34:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEast);
                                break;

                            case 36:
                                bigMaze[row, column] = new Node(row, column, Symbol.Circle, Walls.SouthWestandNorthWest);
                                break;

                            case 38:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthWestOpen);
                                break;

                            case 40:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastOpen);
                                break;

                            case 42:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthWestOpen);
                                break;

                            default:
                                bigMaze[row, column] = null;
                                break;
                        }
                    }
                }

                //11th column
                else if (column == 20)
                {
                    for (int row = 0; row < 45; row++)
                    {
                        switch (row)
                        {
                            case 1:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthOpen);
                                break;

                            case 3:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthandNorthWest);
                                break;

                            case 5:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 7:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthOpen);
                                break;

                            case 9:
                                bigMaze[row, column] = new Node(row, column, Symbol.RightTriangle, Walls.SouthandSouthWest);
                                break;

                            case 11:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandSouthWest);
                                break;

                            case 13:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 15:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastandSouthWest);
                                break;

                            case 17:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastandSouthWest);
                                break;

                            case 19:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthWest);
                                break;

                            case 21:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastandSouthWest);
                                break;

                            case 23:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEast);
                                break;

                            case 25:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthandNorthWest);
                                break;

                            case 27:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandSouth);
                                break;

                            case 29:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 31:
                                bigMaze[row, column] = new Node(row, column, Symbol.RightTriangle, Walls.NorthandNorthEastandSouth);
                                break;

                            case 33:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEast);
                                break;

                            case 35:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthOpen);
                                break;

                            case 37:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandSouthWest);
                                break;

                            case 39:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastandNorthWest);
                                break;

                            case 41:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 43:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastOpen);
                                break;

                            default:
                                bigMaze[row, column] = null;
                                break;
                        }
                    }
                }

                //12th column
                else if (column == 22)
                {
                    for (int row = 0; row < 45; row++)
                    {
                        switch (row)
                        {
                            case 0:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthWestandNorthWestOpen);
                                break;

                            case 2:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthWestandNorthWestOpen);
                                break;

                            case 4:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthandSouthWest);
                                break;

                            case 6:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthandNorthWest);
                                break;

                            case 8:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthWest);
                                break;

                            case 10:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 12:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 14:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthWest);
                                break;

                            case 16:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 18:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 20:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthandNorthWest);
                                break;

                            case 22:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandSouthWest);
                                break;

                            case 24:
                                bigMaze[row, column] = new Node(row, column, Symbol.Hexagon, Walls.NorthandSouthOpen);
                                break;

                            case 26:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthWestandNorthWest);
                                break;

                            case 28:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastandSouthWest);
                                break;

                            case 30:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 32:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthandSouthWest);
                                break;

                            case 34:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandSouthWest);
                                break;

                            case 36:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastandNorthWest);
                                break;

                            case 38:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 40:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthWestandNorthWest);
                                break;

                            case 42:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthOpen);
                                break;

                            case 44:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthWestOpen);
                                break;

                            default:
                                bigMaze[row, column] = null;
                                break;
                        }
                    }
                }

                //13th column
                else if (column == 24)
                {
                    for (int row = 0; row < 45; row++)
                    {
                        switch (row)
                        {
                            case 1:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthOpen);
                                break;

                            case 3:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 5:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthandSouthWest);
                                break;

                            case 7:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandSouth);
                                break;

                            case 9:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthOpen);
                                break;

                            case 11:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthandSouthWest);
                                break;

                            case 13:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandSouthWest);
                                break;

                            case 15:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestandNorthWest);
                                break;

                            case 17:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthandNorthWest);
                                break;

                            case 19:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandNorthWest);
                                break;

                            case 21:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestandNorthWest);
                                break;

                            case 23:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthandNorthWest);
                                break;

                            case 25:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandSouthWest);
                                break;

                            case 27:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestandNorthWest);
                                break;

                            case 29:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 31:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 33:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthWest);
                                break;

                            case 35:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthWestOpen);
                                break;

                            case 37:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthOpen);
                                break;

                            case 39:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthandNorthWest);
                                break;

                            case 41:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastOpen);
                                break;

                            case 43:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastOpen);
                                break;

                            default:
                                bigMaze[row, column] = null;
                                break;
                        }
                    }
                }

                //14th column
                else if (column == 26)
                {
                    for (int row = 0; row < 45; row++)
                    {
                        switch (row)
                        {
                            case 2:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthOpen);
                                break;

                            case 4:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthWestOpen);
                                break;

                            case 6:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandSouthEast);
                                break;

                            case 8:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthandNorthWest);
                                break;

                            case 10:
                                bigMaze[row, column] = new Node(row, column, Symbol.UpTriangle, Walls.NorthandSouthandNorthWest);
                                break;

                            case 12:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthandNorthWestOpen);
                                break;

                            case 14:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthandSouthWest);
                                break;

                            case 16:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 18:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEast);
                                break;

                            case 20:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 22:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthandSouthWest);
                                break;

                            case 24:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthandSouthWest);
                                break;

                            case 26:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 28:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandSouthWest);
                                break;

                            case 30:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthWestandNorthWest);
                                break;

                            case 32:
                                bigMaze[row, column] = new Node(row, column, Symbol.Circle, Walls.NorthandSouthWestOpen);
                                break;

                            case 34:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthWest);
                                break;

                            case 36:
                                bigMaze[row, column] = new Node(row, column, Symbol.Circle, Walls.NorthandSouthOpen);
                                break;

                            case 38:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthWestOpen);
                                break;

                            case 40:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEast);
                                break;

                            case 42:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthandSouthWest);
                                break;

                            default:
                                bigMaze[row, column] = null;
                                break;
                        }
                    }
                }

                //15th column
                else if (column == 28)
                {
                    for (int row = 0; row < 45; row++)
                    {
                        switch (row)
                        {
                            case 2:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthandSouthWest);
                                break;

                            case 4:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthOpen);
                                break;

                            case 6:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthandNorthWest);
                                break;

                            case 8:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWest);
                                break;

                            case 10:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandSouthWest);
                                break;

                            case 12:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthWestandNorthWest);
                                break;

                            case 14:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthandSouthWest);
                                break;

                            case 16:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 18:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandSouthWest);
                                break;

                            case 20:
                                bigMaze[row, column] = new Node(row, column, Symbol.Hexagon, Walls.NorthEastandSouthandNorthWest);

                                break;
                            case 22:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandSouth);
                                break;

                            case 24:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 26:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 28:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEast);
                                break;

                            case 30:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandNorthWest);
                                break;

                            case 32:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 34:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthandNorthWest);
                                break;

                            case 36:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandSouthWest);
                                break;

                            case 38:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestandNorthWest);
                                break;

                            case 40:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthOpen);
                                break;

                            case 42:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthWestOpen);
                                break;

                            default:
                                bigMaze[row, column] = null;
                                break;
                        }
                    }
                }

                //16th column
                else if (column == 30)
                {
                    for (int row = 0; row < 45; row++)
                    {
                        switch (row)
                        {
                            case 4:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 6:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthandSouthWestOpen);
                                break;

                            case 8:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthandNorthWest);
                                break;

                            case 10:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthWestOpen);
                                break;

                            case 12:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthWestOpen);
                                break;

                            case 14:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthandSouthWestOpen);
                                break;

                            case 16:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthWest);
                                break;

                            case 18:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthWest);
                                break;

                            case 20:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastandSouthWest);
                                break;

                            case 22:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthandSouthWest);
                                break;

                            case 24:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 26:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthOpen);
                                break;

                            case 28:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWest);
                                break;

                            case 30:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthWestOpen);
                                break;

                            case 32:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthWest);
                                break;

                            case 34:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestandNorthWest);
                                break;

                            case 36:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthWestOpen);
                                break;

                            case 38:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandSouthWest);
                                break;

                            case 40:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthOpen);
                                break;

                            default:
                                bigMaze[row, column] = null;
                                break;
                        }
                    }
                }

                //17th column
                else if (column == 32)
                {
                    for (int row = 0; row < 45; row++)
                    {
                        switch (row)
                        {
                            case 5:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 7:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthandNorthWest);
                                break;

                            case 9:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthOpen);
                                break;

                            case 11:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthandSouthWest);
                                break;

                            case 13:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthandNorthWestOpen);
                                break;

                            case 15:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthandNorthWest);
                                break;

                            case 17:
                                bigMaze[row, column] = new Node(row, column, Symbol.Circle, Walls.NorthandSouthEastandNorthWest);
                                break;

                            case 19:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthWestandNorthWest);
                                break;

                            case 21:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthandNorthWest);
                                break;

                            case 23:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthWest);
                                break;

                            case 25:
                                bigMaze[row, column] = new Node(row, column, Symbol.DownTriangle, Walls.NorthEastandSouthandSouthWest);
                                break;

                            case 27:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthWest);
                                break;

                            case 29:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthWestOpen);
                                break;

                            case 31:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 33:
                                bigMaze[row, column] = new Node(row, column, Symbol.RightTriangle, Walls.NorthEastandNorthWestOpen);
                                break;

                            case 35:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthWestOpen);
                                break;

                            case 37:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandSouthWest);
                                break;

                            case 39:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthOpen);
                                break;

                            default:
                                bigMaze[row, column] = null;
                                break;
                        }
                    }
                }

                //18th column
                else if (column == 34)
                {
                    for (int row = 0; row < 45; row++)
                    {
                        switch (row)
                        {
                            case 6:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthWestandNorthWestOpen);
                                break;

                            case 8:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandSouth);
                                break;

                            case 10:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthOpen);
                                break;

                            case 12:
                                bigMaze[row, column] = new Node(row, column, Symbol.LeftTriangle, Walls.NorthEastandSouthWest);
                                break;

                            case 14:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastandNorthWest);
                                break;

                            case 16:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthWestOpen);
                                break;

                            case 18:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 20:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 22:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthandNorthWest);
                                break;

                            case 24:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 26:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthWestandNorthWestOpen);
                                break;

                            case 28:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandNorthWestOpen);
                                break;

                            case 30:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 32:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandNorthWest);
                                break;

                            case 34:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 36:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastOpen);
                                break;

                            case 38:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            default:
                                bigMaze[row, column] = null;
                                break;
                        }
                    }
                }

                //19th column
                else if (column == 36)
                {
                    for (int row = 0; row < 45; row++)
                    {
                        switch (row)
                        {
                            case 7:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthWestOpen);
                                break;

                            case 9:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthWestOpen);
                                break;

                            case 11:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthOpen);
                                break;

                            case 13:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastandSouthWest);
                                break;

                            case 15:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthWestandNorthWest);
                                break;

                            case 17:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthandNorthWest);
                                break;

                            case 19:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 21:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthandNorthWest);
                                break;

                            case 23:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 25:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandSouthWest);
                                break;

                            case 27:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastandNorthWest);
                                break;

                            case 29:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandNorthWest);
                                break;

                            case 31:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandNorthWest);
                                break;

                            case 33:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestandNorthWest);
                                break;

                            case 35:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthOpen);
                                break;

                            case 37:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthWestandNorthWestOpen);
                                break;

                            default:
                                bigMaze[row, column] = null;
                                break;
                        }
                    }
                }

                //20th column
                else if (column == 38)
                {
                    for (int row = 0; row < 45; row++)
                    {
                        switch (row)
                        {
                            case 8:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthOpen);
                                break;

                            case 10:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthandSouthWest);
                                break;

                            case 12:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 14:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthWestOpen);
                                break;

                            case 16:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthandNorthWest);
                                break;

                            case 18:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthWest);
                                break;

                            case 20:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthWestOpen);
                                break;

                            case 22:
                                bigMaze[row, column] = new Node(row, column, Symbol.Hexagon, Walls.NorthandSouthEastandSouthWest);
                                break;

                            case 24:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthandSouthWest);
                                break;

                            case 26:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandSouthWest);
                                break;

                            case 28:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthWestandNorthWest);
                                break;

                            case 30:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthWestOpen);
                                break;

                            case 32:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 34:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthandNorthWestOpen);
                                break;

                            case 36:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastOpen);
                                break;

                            default:
                                bigMaze[row, column] = null;
                                break;
                        }
                    }
                }

                //21th column
                else if (column == 40)
                {
                    for (int row = 0; row < 45; row++)
                    {
                        switch (row)
                        {
                            case 9:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthOpen);
                                break;

                            case 11:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthandSouthWest);
                                break;

                            case 13:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 15:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthandNorthWest);
                                break;

                            case 17:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthWestandNorthWestOpen);
                                break;

                            case 19:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandNorthWestOpen);
                                break;

                            case 21:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 23:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthandNorthWest);
                                break;

                            case 25:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthWestandNorthWestOpen);
                                break;

                            case 27:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthWest);
                                break;

                            case 29:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 31:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 33:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthandSouthWest);
                                break;

                            case 35:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthWestOpen);
                                break;

                            default:
                                bigMaze[row, column] = null;
                                break;
                        }
                    }
                }

                //22nd column
                else if (column == 42)
                {
                    for (int row = 0; row < 45; row++)
                    {
                        switch (row)
                        {
                            case 10:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 12:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 14:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandSouth);
                                break;

                            case 16:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthandSouthWest);
                                break;

                            case 18:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthWestOpen);
                                break;

                            case 20:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 22:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 24:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandNorthWestOpen);
                                break;

                            case 26:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 28:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandSouthWest);
                                break;

                            case 30:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastOpen);
                                break;

                            case 32:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandNorthWest);
                                break;

                            case 34:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastOpen);
                                break;

                            default:
                                bigMaze[row, column] = null;
                                break;
                        }
                    }
                }

                //23rd column
                else if (column == 44)
                {
                    for (int row = 0; row < 45; row++)
                    {
                        switch (row)
                        {
                            case 11:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthWestOpen);
                                break;

                            case 13:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthWestandNorthWestOpen);
                                break;

                            case 15:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthWestOpen);
                                break;

                            case 17:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandSouthWest);
                                break;

                            case 19:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthWestOpen);
                                break;

                            case 21:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthWestOpen);
                                break;

                            case 23:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthWestOpen);
                                break;

                            case 25:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 27:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthWestOpen);
                                break;

                            case 29:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthWestOpen);
                                break;

                            case 31:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthWestOpen);
                                break;

                            case 33:
                                bigMaze[row, column] = new Node(row, column, Symbol.None, Walls.SouthWestOpen);
                                break;

                            default:
                                bigMaze[row, column] = null;
                                break;
                        }
                    }
                }

                else
                {
                    for (int row = 0; row < 45; row++)
                    {
                        bigMaze[row, column] = null;
                    }
                }
            }

            AttachNeighbors();
        }

        private void FindLittleMaze()
        {
            Node[,] littleMaze;
            bool validMaze = false;

            while (!validMaze)
            {
                for (int row = 0; row < 31; row++)
                {
                    for (int col = 0; col < 16; col++)
                    {
                        littleMaze = CopyBigMazePart(row, col);

                        validMaze = ValidMazeProjection(littleMaze);

                        if (validMaze)
                        {
                            rowLineUp = row;
                            colLineUp = col;
                            this.littleMaze = littleMaze;
                            break;
                        }
                    }

                    if (validMaze)
                    {
                        break;
                    }
                }

                if (!validMaze)
                {
                    littleMazeDirection = UpdateCardinalClockWise(littleMazeDirection);
                    this.littleMaze = Rotate45Clocwise(this.littleMaze);

                    foreach (Node node in this.littleMaze)
                    {
                        node.Symbol = UpdateSymbol(node.Symbol);
                    }
                }
            }



        }

        private Cardinal UpdateCardinalClockWise(Cardinal cardinal)
        {
            int num = (int)cardinal + 1;

            if (num >= 6)
            {
                num %= 0;
            }

            return (Cardinal)num;
        }

        private Node[,] RotateBigMaze(Node[,] oldMaze)
        {
            Node[,] newMaze = new Node[45, 23];

            for (int row = 0; row < 45; row++)
            {
                for (int col = 0; col < 45; col++)
                {
                    switch (row)
                    {
                        case 0:

                            if (col != 11)
                            {
                                newMaze[row, col] = null;
                            }

                            else
                            {
                                newMaze[row, col] = oldMaze[11, 0];
                            }

                            break;

                        case 1:
                            if (col == 10)
                            {
                                newMaze[row, col] = oldMaze[13, 0];
                            }

                            else if (col == 12)
                            {
                                newMaze[row, col] = oldMaze[10, 1];
                            }

                            else
                            {

                            }
                            break;

                        case 2:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 3:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 4:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 5:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 6:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 7:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 8:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 9:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 10:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 11:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 12:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 13:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 14:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 15:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 16:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 17:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 18:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 19:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 20:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 21:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 22:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 23:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 24:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 25:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 26:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 27:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 28:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 29:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 30:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 31:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 32:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 33:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 34:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 35:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 36:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 37:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 38:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 39:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 40:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 41:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 42:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 43:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;

                        case 44:
                            if (col == 0)
                            {

                            }

                            else if (col == 1)
                            {

                            }

                            else if (col == 2)
                            {

                            }

                            else if (col == 3)
                            {

                            }

                            else if (col == 4)
                            {

                            }

                            else if (col == 5)
                            {

                            }

                            else if (col == 6)
                            {

                            }

                            else if (col == 7)
                            {

                            }

                            else if (col == 8)
                            {

                            }

                            else if (col == 9)
                            {

                            }

                            else if (col == 10)
                            {

                            }

                            else if (col == 11)
                            {

                            }

                            else if (col == 12)
                            {

                            }

                            else if (col == 13)
                            {

                            }

                            else if (col == 14)
                            {

                            }

                            else if (col == 15)
                            {

                            }

                            else if (col == 16)
                            {

                            }

                            else if (col == 17)
                            {

                            }

                            else if (col == 18)
                            {

                            }

                            else if (col == 19)
                            {

                            }

                            else if (col == 20)
                            {

                            }

                            else if (col == 21)
                            {

                            }

                            else if (col == 22)
                            {

                            }

                            else
                            {

                            }
                            break;
                    }
                }

            }
        }
        private void UpdateRowAndColumn(Node node)
        { 
            
        }

        private Symbol UpdateSymbol(Symbol symbol)
        {
            switch (symbol)
            {
                case Symbol.UpTriangle:
                    return Symbol.DownTriangle;

                case Symbol.RightTriangle:
                    return Symbol.LeftTriangle;

                case Symbol.DownTriangle:
                    return Symbol.UpTriangle;

                case Symbol.LeftTriangle:
                    return Symbol.RightTriangle;

                default:
                    return symbol;
            }
        }

        private Walls UpdateWall(Walls wall)
        {
            switch (wall)
            {
                case Walls.None:
                    return Walls.None;

                case Walls.North:
                    return Walls.NorthEast;

                case Walls.NorthEast:
                    return Walls.SouthEast;

                case Walls.SouthEast:
                    return Walls.South;

                case Walls.South:
                    return Walls.SouthWest;

                case Walls.SouthWest:
                    return Walls.NorthWest;

                case Walls.NorthWest:
                    return Walls.North;

                case Walls.NorthandNorthEast:
                    return Walls.NorthEastandSouthEast;

                case Walls.NorthandSouthEast:
                    return 
                case Walls.NorthandSouth:
                    break;
                case Walls.NorthandSouthWest:
                    break;
                case Walls.NorthandNorthWest:
                    break;
                case Walls.NorthEastandSouthEast:
                    break;
                case Walls.NorthEastandSouth:
                    break;
                case Walls.NorthEastandSouthWest:
                    break;
                case Walls.NorthEastandNorthWest:
                    break;
                case Walls.SouthEastandSouth:
                    break;
                case Walls.SouthEastandSouthWest:
                    break;
                case Walls.SouthEastandNorthWest:
                    break;
                case Walls.SouthandSouthWest:
                    break;
                case Walls.SouthandNorthWest:
                    break;
                case Walls.SouthWestandNorthWest:
                    break;
                case Walls.NorthandNorthEastandSouthEast:
                    break;
                case Walls.NorthandNorthEastandSouth:
                    break;
                case Walls.NorthandNorthEastandSouthWest:
                    break;
                case Walls.NorthandNorthEastandNorthWest:
                    break;
                case Walls.NorthandSouthEastandSouth:
                    break;
                case Walls.NorthandSouthEastandSouthWest:
                    break;
                case Walls.NorthandSouthEastandNorthWest:
                    break;
                case Walls.NorthandSouthandSouthWest:
                    break;
                case Walls.NorthandSouthandNorthWest:
                    break;
                case Walls.NorthandSouthWestandNorthWest:
                    break;
                case Walls.NorthEastandSouthEastandSouth:
                    break;
                case Walls.NorthEastandSouthEastandSouthWest:
                    break;
                case Walls.NorthEastandSouthEastandNorthWest:
                    break;
                case Walls.NorthEastandSouthandSouthWest:
                    break;
                case Walls.NorthEastandSouthandNorthWest:
                    break;
                case Walls.NorthEastandSouthWestandNorthWest:
                    break;
                case Walls.SouthEastandSouthandSouthWest:
                    break;
                case Walls.SouthEastandSouthandNorthWest:
                    break;
                case Walls.SouthEastandSouthWestandNorthWest:
                    break;
                case Walls.SouthandSouthWestandNorthWest:
                    break;
                case Walls.NorthandNorthEastOpen:
                    break;
                case Walls.NorthandSouthEastOpen:
                    break;
                case Walls.NorthandSouthOpen:
                    break;
                case Walls.NorthandSouthWestOpen:
                    break;
                case Walls.NorthandNorthWestOpen:
                    break;
                case Walls.NorthEastandSouthEastOpen:
                    break;
                case Walls.NorthEastandSouthOpen:
                    break;
                case Walls.NorthEastandSouthWestOpen:
                    break;
                case Walls.NorthEastandNorthWestOpen:
                    break;
                case Walls.SouthEastandSouthOpen:
                    break;
                case Walls.SouthEastandSouthWestOpen:
                    break;
                case Walls.SouthEastandNorthWestOpen:
                    break;
                case Walls.SouthandSouthWestOpen:
                    break;
                case Walls.SouthandNorthWestOpen:
                    break;
                case Walls.SouthWestandNorthWestOpen:
                    break;
                case Walls.NorthOpen:
                    break;
                case Walls.NorthEastOpen:
                    break;
                case Walls.SouthEastOpen:
                    break;
                case Walls.SouthOpen:
                    break;
                case Walls.SouthWestOpen:
                    break;
                case Walls.NorthWestOpen:
                    break;
            }
        }

    
        private bool ValidMazeProjection(Node[,] littleMaze)
            {
                bool validMaze = true;

                for (int row = 0; row < 7; row++)
                {
                    for (int col = 0; col < 7; col++)
                    {
                        validMaze = SameNode(littleMaze[row, col], this.littleMaze[row, col]);

                        if (!validMaze)
                        {
                            break;
                        }
                    }

                    if (!validMaze)
                    {
                        break;
                    }
                }

                return validMaze;
            }

        private bool SameNode(Node node1, Node node2)
        {
            if (node1 == null && node2 != null)
            {
                return false;
            }

            if (node1 != null && node2 == null)
            {
                return false;
            }

            if (node1 == null && node2 == null)
            {
                return true;
            }

            if (node1.Symbol != node2.Symbol)
            {
                return false;
            }

            return true;
        }

        private Node[,] CopyBigMazePart(int topLeftRow, int topLeftCol)
        {
            Node[,] littleMaze = new Node[7, 7];

            for (int row = 0; row < 7; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    littleMaze[row, col] = bigMaze[topLeftRow + row, topLeftCol + col];
                }
            }

            return littleMaze;
        }

        /// <summary>
        /// Conects all nodes together
        /// </summary>
        private void AttachNeighbors()
        { 
            bigMaze = new Node[45, 23];
            for (int row = 0; row < 45; row++)
            {
                for (int column = 23; column < 23; column++)
                {
                    Node node = bigMaze[row, column];

                    //dont try to connect null nodes
                    if (node == null)
                    {
                        continue;
                    }

                    //find where nodes have openings
                    bool north = false;
                    bool northEast = false;
                    bool southEast = false;
                    bool south = false;
                    bool southWest = false;
                    bool northWest = false;

                    switch (node.Walls)
                    {
                        case Walls.None:
                            north = true;
                            northEast = true;
                            southEast = true;
                            south = true;
                            southWest = true;
                            northWest = true;
                            break;

                        case Walls.North:
                            northEast = true;
                            southEast = true;
                            south = true;
                            southWest = true;
                            northWest = true;
                            break;

                        case Walls.NorthEast:
                            north = true;
                            southEast = true;
                            south = true;
                            southWest = true;
                            northWest = true;
                            break;

                        case Walls.SouthEast:
                            north = true;
                            southEast = true;
                            south = true;
                            southWest = true;
                            northWest = true;
                            break;

                        case Walls.South:
                            north = true;
                            northEast = true;
                            southEast = true;
                            southWest = true;
                            northWest = true;
                            break;

                        case Walls.SouthWest:
                            north = true;
                            northEast = true;
                            southEast = true;
                            south = true;
                            northWest = true;
                            break;

                        case Walls.NorthWest:
                            north = true;
                            northEast = true;
                            southEast = true;
                            south = true;
                            southWest = true;
                            break;

                        case Walls.NorthandNorthEast:
                            north = true;
                            northEast = true;
                            break;

                        case Walls.NorthandSouthEast:
                            north = true;
                            southEast = true;
                            break;

                        case Walls.NorthandSouth:
                            north = true;
                            south = true;
                            break;

                        case Walls.NorthandSouthWest:
                            north = true;
                            southWest = true;
                            break;

                        case Walls.NorthandNorthWest:
                            north = true;
                            northWest = true;
                            break;

                        case Walls.NorthEastandSouthEast:
                            northEast = true;
                            southEast = true;
                            break;

                        case Walls.NorthEastandSouth:
                            northEast = true;
                            south = true;
                            break;

                        case Walls.NorthEastandSouthWest:
                            northEast = true;
                            southWest = true;
                            break;

                        case Walls.NorthEastandNorthWest:
                            northEast = true;
                            northWest = true;
                            break;

                        case Walls.SouthEastandSouth:
                            southEast = true;
                            south = true;
                            break;

                        case Walls.SouthEastandSouthWest:
                            southEast = true;
                            southWest = true;
                            break;

                        case Walls.SouthEastandNorthWest:
                            southEast = true;
                            northWest = true;
                            break;

                        case Walls.SouthandSouthWest:
                            south = true;
                            southWest = true;
                            break;

                        case Walls.SouthandNorthWest:
                            south = true;
                            northWest = true;
                            break;

                        case Walls.SouthWestandNorthWest:
                            southWest = true;
                            northWest = true;
                            break;

                        case Walls.NorthandNorthEastandSouthEast:
                            north = true;
                            northEast = true;
                            southEast = true;
                            break;

                        case Walls.NorthandNorthEastandSouth:
                            north = true;
                            northEast = true;
                            south = true;
                            break;

                        case Walls.NorthandNorthEastandSouthWest:
                            north = true;
                            northEast = true;
                            southWest = true;
                            break;

                        case Walls.NorthandNorthEastandNorthWest:
                            north = true;
                            northEast = true;
                            northWest = true;
                            break;

                        case Walls.NorthandSouthEastandSouth:
                            north = true;
                            southEast = true;
                            south = true;
                            break;

                        case Walls.NorthandSouthEastandSouthWest:
                            north = true;
                            southEast = true;
                            southWest = true;
                            break;

                        case Walls.NorthandSouthEastandNorthWest:
                            north = true;
                            southEast = true;
                            northWest = true;
                            break;

                        case Walls.NorthandSouthandSouthWest:
                            north = true;
                            south = true;
                            southWest = true;
                            break;

                        case Walls.NorthandSouthandNorthWest:
                            north = true;
                            south = true;
                            northWest = true;
                            break;

                        case Walls.NorthandSouthWestandNorthWest:
                            north = true;
                            southWest = true;
                            northWest = true;
                            break;

                        case Walls.NorthEastandSouthEastandSouth:
                            northEast = true;
                            southEast = true;
                            south = true;
                            break;

                        case Walls.NorthEastandSouthEastandSouthWest:
                            northEast = true;
                            southEast = true;
                            southWest = true;
                            break;

                        case Walls.NorthEastandSouthEastandNorthWest:
                            northEast = true;
                            southEast = true;
                            northWest = true;
                            break;

                        case Walls.NorthEastandSouthandSouthWest:
                            northEast = true;
                            south = true;
                            southWest = true;
                            break;

                        case Walls.NorthEastandSouthandNorthWest:
                            northEast = true;
                            south = true;
                            northWest = true;
                            break;

                        case Walls.NorthEastandSouthWestandNorthWest:
                            northEast = true;
                            southWest = true;
                            northWest = true;
                            break;

                        case Walls.SouthEastandSouthandSouthWest:
                            southEast = true;
                            south = true;
                            southWest = true;
                            break;

                        case Walls.SouthEastandSouthandNorthWest:
                            southEast = true;
                            south = true;
                            northWest = true;
                            break;

                        case Walls.SouthEastandSouthWestandNorthWest:
                            southEast = true;
                            southWest = true;
                            northWest = true;
                            break;

                        case Walls.SouthandSouthWestandNorthWest:
                            south = true;
                            southWest = true;
                            northWest = true;
                            break;

                        case Walls.NorthandNorthEastOpen:
                            north = true;
                            northEast = true;
                            break;

                        case Walls.NorthandSouthEastOpen:
                            north = true;
                            southEast = true;
                            break;

                        case Walls.NorthandSouthOpen:
                            north = true;
                            south = true;
                            break;

                        case Walls.NorthandSouthWestOpen:
                            north = true;
                            southWest = true;
                            break;

                        case Walls.NorthandNorthWestOpen:
                            north = true;
                            northWest = true;
                            break;

                        case Walls.NorthEastandSouthEastOpen:
                            northEast = true;
                            southEast = true;
                            break;

                        case Walls.NorthEastandSouthOpen:
                            northEast = true;
                            south = true;
                            break;

                        case Walls.NorthEastandSouthWestOpen:
                            northEast = true;
                            southWest = true;
                            break;

                        case Walls.NorthEastandNorthWestOpen:
                            northEast = true;
                            northWest = true;
                            break;

                        case Walls.SouthEastandSouthOpen:
                            southEast = true;
                            south = true;
                            break;

                        case Walls.SouthEastandSouthWestOpen:
                            southEast = true;
                            southWest = true;
                            break;

                        case Walls.SouthEastandNorthWestOpen:
                            southEast = true;
                            northWest = true;
                            break;

                        case Walls.SouthandSouthWestOpen:
                            south = true;
                            southWest = true;
                            break;

                        case Walls.SouthandNorthWestOpen:
                            south = true;
                            northWest = true;
                            break;

                        case Walls.SouthWestandNorthWestOpen:
                            southWest = true;
                            northWest = true;
                            break;

                        case Walls.NorthOpen:
                            north = true;
                            break;

                        case Walls.NorthEastOpen:
                            northEast = true;
                            break;

                        case Walls.SouthEastOpen:
                            southEast = true;
                            break;

                        case Walls.SouthOpen:
                            south = true;
                            break;

                        case Walls.SouthWestOpen:
                            southWest = true;
                            break;

                        case Walls.NorthWestOpen:
                            northWest = true;
                            break;
                    }

                    //add neighbors to each node


                    if (north && !(node.Row - 2 < 0)) //don't go out of bounds
                    {
                        node.North = bigMaze[node.Row - 2, node.Column];
                    }

                    if (northEast && !(node.Row - 1 < 0 || node.Column + 1 > 22)) //don't go out of bounds
                    { 
                        node.NorthEast = bigMaze[node.Row - 1, node.Column + 1];
                    }

                    if (southEast && !(node.Row + 1 > 44 || node.Column + 1 > 22)) //don't go out of bounds
                    {
                        node.SouthEast = bigMaze[node.Row + 1, node.Column + 1];
                    }

                    if (south && !(node.Row + 2 > 22)) //don't go out of bounds
                    {
                        node.South = bigMaze[node.Row + 2, node.Column];
                    }

                    if (southWest && !(node.Row + 1 > 44 || node.Column - 1 < 0)) //don't go out of bounds
                    {
                        node.SouthWest = bigMaze[node.Row + 1, node.Column - 1];
                    }

                    if (northWest && !(node.Row - 1 < 0 || node.Column - 1 < 0)) //don't go out of bounds
                    {
                        node.NorthWest = bigMaze[node.Row - 1, node.Column - 1];
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
            UpTriangle,
            RightTriangle,
            DownTriangle,
            LeftTriangle,
            Hexagon,
            Circle,
            None
        }

        private void VerifMaze(Node[,] maze)
        {
            int counter = 0;

            foreach (Node start in maze)
            {
                if (start != null)
                {
                    //verify that start's north has south set to start
                    if (start.North != null && start.North.South != start)
                    {
                        PrintDebugLine($"Inconsistencies at {start.Row},{start.Column} and {start.North.Row},{start.North.Column}\n");
                        counter++;
                    }

                    //verify that start's northeast has southwest set to start
                    if (start.NorthEast != null && start.NorthEast.SouthWest != start)
                    {
                        PrintDebugLine($"Inconsistencies at {start.Row},{start.Column} and {start.South.Row},{start.South.Column}\n");
                        counter++;
                    }

                    //verify that start's southeast has northwest set to start
                    if (start.SouthEast != null && start.SouthEast.NorthWest != start)
                    {
                        PrintDebugLine($"Inconsistencies at {start.Row},{start.Column} and {start.South.Row},{start.South.Column}\n");
                        counter++;
                    }

                    //verify that start's south has north set to start
                    if (start.South != null && start.South.North != start)
                    {
                        PrintDebugLine($"Inconsistencies at {start.Row},{start.Column} and {start.South.Row},{start.South.Column}\n");
                        counter++;
                    }

                    //verify that start's southwest has northwest set to start
                    if (start.SouthWest != null && start.SouthWest.NorthEast != start)
                    {
                        PrintDebugLine($"Inconsistencies at {start.Row},{start.Column} and {start.South.Row},{start.South.Column}\n");
                        counter++;
                    }

                    //verify that start's northwest has southeast set to start
                    if (start.NorthWest != null && start.NorthWest.SouthEast != start)
                    {
                        PrintDebugLine($"Inconsistencies at {start.Row},{start.Column} and {start.South.Row},{start.South.Column}\n");
                        counter++;
                    }
                }

            }

            if (counter == 0)
            {
                PrintDebugLine("No inconsistencies found\n");
            }

        }

        public class Node
        {
            public int Row;
            public int Column;
            public Symbol Symbol;
            public ExitColor NorthExitColor;
            public ExitColor NorthEastExitColor;
            public ExitColor SouthEastExitColor;
            public ExitColor SouthExitColor;
            public ExitColor SouthWestExitColor;
            public ExitColor NorthWestExitColor;

            public Node North;
            public Node NorthEast;
            public Node SouthEast;
            public Node South;
            public Node SouthWest;
            public Node NorthWest;

            public Walls Walls { get; set; }

            public Node(int row, int column, Symbol symbol, Walls walls)
            {
                Row = row;
                Column = column;
                Symbol = symbol;
                Walls = walls;

                NorthExitColor = ExitColor.None;
                NorthEastExitColor = ExitColor.None;
                SouthEastExitColor = ExitColor.None;
                SouthExitColor = ExitColor.None;
                SouthWestExitColor = ExitColor.None;
                NorthWestExitColor = ExitColor.None;

                North = null;
                NorthEast = null;
                SouthEast = null;
                South = null;
                SouthWest = null;
                NorthWest = null;
            }   
        }
    }
}               
                