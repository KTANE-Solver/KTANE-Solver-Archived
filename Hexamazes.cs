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

        /// <summary>
        /// Initializes all appropriate cells with data
        /// </summary>
        private void CreateBigMaze()
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
                else if (column == 2)
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
                else if (column == 4)
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
                else if (column == 6)
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
                                maze[row, column] = new Node(row, column, Symbol.LeftTriangle, Walls.SouthEastandSouthWestandNorthWest);
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
                else if (column == 8)
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
                else if (column == 10)
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
                else if (column == 12)
                {
                    for (int row = 0; row < 45; row++)
                    {
                        switch (row)
                        {
                            case 5:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandNorthWest);
                                break;

                            case 7:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEast);
                                break;

                            case 9:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthOpen);
                                break;

                            case 11:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouth);
                                break;

                            case 13:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthOpen);
                                break;

                            case 15:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouth);
                                break;

                            case 17:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthWest);
                                break;

                            case 19:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 21:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 23:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthandNorthWest);
                                break;

                            case 25:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEast);
                                break;

                            case 27:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthandNorthWest);
                                break;

                            case 29:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthandNorthWest);
                                break;

                            case 31:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEast);
                                break;

                            case 33:
                                maze[row, column] = new Node(row, column, Symbol.Hexagon, Walls.NorthandSouthOpen);
                                break;

                            case 35:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 37:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastOpen);
                                break;

                            case 39:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandNorthWestOpen);
                                break;

                            default:
                                maze[row, column] = null;
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
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandSouth);
                                break;

                            case 6:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastOpen);
                                break;

                            case 8:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 10:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthWest);
                                break;

                            case 12:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 14:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 16:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthandNorthWest);
                                break;

                            case 18:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandSouthWest);
                                break;

                            case 20:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestandNorthWest);
                                break;

                            case 22:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastandNorthWest);
                                break;

                            case 24:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthandNorthWest);
                                break;

                            case 26:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWest);
                                break;

                            case 28:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandSouth);
                                break;

                            case 30:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandSouthWest);
                                break;

                            case 32:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastandSouthWest);
                                break;

                            case 34:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastOpen);
                                break;

                            case 36:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandNorthWest);
                                break;

                            case 38:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastandNorthWest);
                                break;

                            case 40:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthOpen);
                                break;

                            default:
                                maze[row, column] = null;
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
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 6:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 8:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandSouthWest);
                                break;

                            case 10:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastandSouthWest);
                                break;

                            case 12:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouth);
                                break;

                            case 14:
                                maze[row, column] = new Node(row, column, Symbol.DownTriangle, Walls.NorthandNorthEastandNorthWest);
                                break;

                            case 16:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthandNorthWest);
                                break;

                            case 18:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 20:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 22:
                                maze[row, column] = new Node(row, column, Symbol.UpTriangle, Walls.SouthEastandNorthWest);
                                break;

                            case 24:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWest);
                                break;

                            case 26:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 28:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 30:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthWest);
                                break;

                            case 32:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 34:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandNorthWest);
                                break;

                            case 36:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandNorthWest);
                                break;

                            case 38:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthOpen);
                                break;

                            case 40:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthOpen);
                                break;

                            case 42:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthandNorthWest);
                                break;

                            default:
                                maze[row, column] = null;
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
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthOpen);
                                break;

                            case 4:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthandNorthWest);
                                break;

                            case 6:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWest);
                                break;

                            case 8:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthOpen);
                                break;

                            case 10:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandNorthWest);
                                break;

                            case 12:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 14:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthandSouthWest);
                                break;

                            case 16:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 18:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 20:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 22:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandSouth);
                                break;

                            case 24:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 26:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthandNorthWest);
                                break;

                            case 28:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 30:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthandSouthWest);
                                break;

                            case 32:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 34:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEast);
                                break;

                            case 36:
                                maze[row, column] = new Node(row, column, Symbol.Circle, Walls.SouthWestandNorthWest);
                                break;

                            case 38:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthWestOpen);
                                break;

                            case 40:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastOpen);
                                break;

                            case 42:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthWestOpen);
                                break;

                            default:
                                maze[row, column] = null;
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
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthOpen);
                                break;

                            case 3:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthandNorthWest);
                                break;

                            case 5:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 7:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthOpen);
                                break;

                            case 9:
                                maze[row, column] = new Node(row, column, Symbol.RightTriangle, Walls.SouthandSouthWest);
                                break;

                            case 11:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandSouthWest);
                                break;

                            case 13:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 15:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastandSouthWest);
                                break;

                            case 17:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastandSouthWest);
                                break;

                            case 19:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthWest);
                                break;

                            case 21:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastandSouthWest);
                                break;

                            case 23:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEast);
                                break;

                            case 25:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthandNorthWest);
                                break;

                            case 27:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandSouth);
                                break;

                            case 29:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 31:
                                maze[row, column] = new Node(row, column, Symbol.RightTriangle, Walls.NorthandNorthEastandSouth);
                                break;

                            case 33:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEast);
                                break;

                            case 35:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthOpen);
                                break;

                            case 37:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandSouthWest);
                                break;

                            case 39:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastandNorthWest);
                                break;

                            case 41:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 43:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastOpen);
                                break;

                            default:
                                maze[row, column] = null;
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
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthWestandNorthWestOpen);
                                break;

                            case 2:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthWestandNorthWestOpen);
                                break;

                            case 4:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthandSouthWest);
                                break;

                            case 6:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthandNorthWest);
                                break;

                            case 8:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthWest);
                                break;

                            case 10:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 12:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 14:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthWest);
                                break;

                            case 16:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 18:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 20:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthandNorthWest);
                                break;

                            case 22:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandSouthWest);
                                break;

                            case 24:
                                maze[row, column] = new Node(row, column, Symbol.Hexagon, Walls.NorthandSouthOpen);
                                break;

                            case 26:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthWestandNorthWest);
                                break;

                            case 28:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastandSouthWest);
                                break;

                            case 30:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 32:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthandSouthWest);
                                break;

                            case 34:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandSouthWest);
                                break;

                            case 36:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastandNorthWest);
                                break;

                            case 38:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 40:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthWestandNorthWest);
                                break;

                            case 42:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthOpen);
                                break;

                            case 44:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthWestOpen);
                                break;

                            default:
                                maze[row, column] = null;
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
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthOpen);
                                break;

                            case 3:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 5:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthandSouthWest);
                                break;

                            case 7:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandSouth);
                                break;

                            case 9:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthOpen);
                                break;

                            case 11:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthandSouthWest);
                                break;

                            case 13:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandSouthWest);
                                break;

                            case 15:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestandNorthWest);
                                break;

                            case 17:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthandNorthWest);
                                break;

                            case 19:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandNorthWest);
                                break;

                            case 21:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestandNorthWest);
                                break;

                            case 23:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthandNorthWest);
                                break;

                            case 25:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandSouthWest);
                                break;

                            case 27:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestandNorthWest);
                                break;

                            case 29:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 31:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 33:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthWest);
                                break;

                            case 35:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthWestOpen);
                                break;

                            case 37:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthOpen);
                                break;

                            case 39:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthandNorthWest);
                                break;

                            case 41:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastOpen);
                                break;

                            case 43:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastOpen);
                                break;

                            default:
                                maze[row, column] = null;
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
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthOpen);
                                break;

                            case 4:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthWestOpen);
                                break;

                            case 6:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandSouthEast);
                                break;

                            case 8:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthandNorthWest);
                                break;

                            case 10:
                                maze[row, column] = new Node(row, column, Symbol.UpTriangle, Walls.NorthandSouthandNorthWest);
                                break;

                            case 12:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthandNorthWestOpen);
                                break;

                            case 14:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthandSouthWest);
                                break;

                            case 16:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 18:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEast);
                                break;

                            case 20:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 22:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthandSouthWest);
                                break;

                            case 24:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthandSouthWest);
                                break;

                            case 26:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 28:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandSouthWest);
                                break;

                            case 30:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthWestandNorthWest);
                                break;

                            case 32:
                                maze[row, column] = new Node(row, column, Symbol.Circle, Walls.NorthandSouthWestOpen);
                                break;

                            case 34:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthWest);
                                break;

                            case 36:
                                maze[row, column] = new Node(row, column, Symbol.Circle, Walls.NorthandSouthOpen);
                                break;

                            case 38:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthWestOpen);
                                break;

                            case 40:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEast);
                                break;

                            case 42:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthandSouthWest);
                                break;

                            default:
                                maze[row, column] = null;
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
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthandSouthWest);
                                break;

                            case 4:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthOpen);
                                break;

                            case 6:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthandNorthWest);
                                break;

                            case 8:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWest);
                                break;

                            case 10:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandSouthWest);
                                break;

                            case 12:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthWestandNorthWest);
                                break;

                            case 14:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthandSouthWest);
                                break;

                            case 16:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 18:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandSouthWest);
                                break;

                            case 20:
                                maze[row, column] = new Node(row, column, Symbol.Hexagon, Walls.NorthEastandSouthandNorthWest);

                                break;
                            case 22:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandSouth);
                                break;

                            case 24:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 26:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 28:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEast);
                                break;

                            case 30:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandNorthWest);
                                break;

                            case 32:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 34:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthandNorthWest);
                                break;

                            case 36:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandSouthWest);
                                break;

                            case 38:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestandNorthWest);
                                break;

                            case 40:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthOpen);
                                break;

                            case 42:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthWestOpen);
                                break;

                            default:
                                maze[row, column] = null;
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
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 6:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthandSouthWestOpen);
                                break;

                            case 8:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthandNorthWest);
                                break;

                            case 10:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthWestOpen);
                                break;

                            case 12:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthWestOpen);
                                break;

                            case 14:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthandSouthWestOpen);
                                break;

                            case 16:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthWest);
                                break;

                            case 18:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthWest);
                                break;

                            case 20:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastandSouthWest);
                                break;

                            case 22:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthandSouthWest);
                                break;

                            case 24:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 26:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthOpen);
                                break;

                            case 28:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWest);
                                break;

                            case 30:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthWestOpen);
                                break;

                            case 32:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthWest);
                                break;

                            case 34:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestandNorthWest);
                                break;

                            case 36:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthWestOpen);
                                break;

                            case 38:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandSouthWest);
                                break;

                            case 40:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthOpen);
                                break;

                            default:
                                maze[row, column] = null;
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
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 7:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthandNorthWest);
                                break;

                            case 9:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthOpen);
                                break;

                            case 11:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthandSouthWest);
                                break;

                            case 13:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthandNorthWestOpen);
                                break;

                            case 15:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthandNorthWest);
                                break;

                            case 17:
                                maze[row, column] = new Node(row, column, Symbol.Circle, Walls.NorthandSouthEastandNorthWest);
                                break;

                            case 19:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthWestandNorthWest);
                                break;

                            case 21:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthandNorthWest);
                                break;

                            case 23:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthWest);
                                break;

                            case 25:
                                maze[row, column] = new Node(row, column, Symbol.DownTriangle, Walls.NorthEastandSouthandSouthWest);
                                break;

                            case 27:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthWest);
                                break;

                            case 29:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthWestOpen);
                                break;

                            case 31:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 33:
                                maze[row, column] = new Node(row, column, Symbol.RightTriangle, Walls.NorthEastandNorthWestOpen);
                                break;

                            case 35:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthWestOpen);
                                break;

                            case 37:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandSouthWest);
                                break;

                            case 39:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthOpen);
                                break;

                            default:
                                maze[row, column] = null;
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
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthWestandNorthWestOpen);
                                break;

                            case 8:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandSouth);
                                break;

                            case 10:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthOpen);
                                break;

                            case 12:
                                maze[row, column] = new Node(row, column, Symbol.LeftTriangle, Walls.NorthEastandSouthWest);
                                break;

                            case 14:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastandNorthWest);
                                break;

                            case 16:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthWestOpen);
                                break;

                            case 18:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 20:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 22:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthandNorthWest);
                                break;

                            case 24:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 26:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthWestandNorthWestOpen);
                                break;

                            case 28:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandNorthWestOpen);
                                break;

                            case 30:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 32:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandNorthWest);
                                break;

                            case 34:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 36:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastOpen);
                                break;

                            case 38:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            default:
                                maze[row, column] = null;
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
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthWestOpen);
                                break;

                            case 9:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthWestOpen);
                                break;

                            case 11:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthOpen);
                                break;

                            case 13:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastandSouthWest);
                                break;

                            case 15:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthWestandNorthWest);
                                break;

                            case 17:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthandNorthWest);
                                break;

                            case 19:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 21:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthandNorthWest);
                                break;

                            case 23:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 25:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastandSouthWest);
                                break;

                            case 27:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthEastandNorthWest);
                                break;

                            case 29:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandNorthWest);
                                break;

                            case 31:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandNorthWest);
                                break;

                            case 33:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestandNorthWest);
                                break;

                            case 35:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthOpen);
                                break;

                            case 37:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthWestandNorthWestOpen);
                                break;

                            default:
                                maze[row, column] = null;
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
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthOpen);
                                break;

                            case 10:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthandSouthWest);
                                break;

                            case 12:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 14:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthWestOpen);
                                break;

                            case 16:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthandNorthWest);
                                break;

                            case 18:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthWest);
                                break;

                            case 20:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthWestOpen);
                                break;

                            case 22:
                                maze[row, column] = new Node(row, column, Symbol.Hexagon, Walls.NorthandSouthEastandSouthWest);
                                break;

                            case 24:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthandSouthWest);
                                break;

                            case 26:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandSouthWest);
                                break;

                            case 28:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthWestandNorthWest);
                                break;

                            case 30:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthWestOpen);
                                break;

                            case 32:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 34:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthandNorthWestOpen);
                                break;

                            case 36:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastOpen);
                                break;

                            default:
                                maze[row, column] = null;
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
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthOpen);
                                break;

                            case 11:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthandSouthWest);
                                break;

                            case 13:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 15:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthandNorthWest);
                                break;

                            case 17:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthWestandNorthWestOpen);
                                break;

                            case 19:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandNorthWestOpen);
                                break;

                            case 21:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 23:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthandNorthWest);
                                break;

                            case 25:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthWestandNorthWestOpen);
                                break;

                            case 27:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthWest);
                                break;

                            case 29:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 31:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthOpen);
                                break;

                            case 33:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthandSouthWest);
                                break;

                            case 35:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthWestOpen);
                                break;

                            default:
                                maze[row, column] = null;
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
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 12:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandNorthWestOpen);
                                break;

                            case 14:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandSouth);
                                break;

                            case 16:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthandSouthWest);
                                break;

                            case 18:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthWestOpen);
                                break;

                            case 20:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 22:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 24:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandNorthWestOpen);
                                break;

                            case 26:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 28:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandSouthWest);
                                break;

                            case 30:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastOpen);
                                break;

                            case 32:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandNorthWest);
                                break;

                            case 34:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthEastOpen);
                                break;

                            default:
                                maze[row, column] = null;
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
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandNorthWestOpen);
                                break;

                            case 13:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthWestandNorthWestOpen);
                                break;

                            case 15:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthWestOpen);
                                break;

                            case 17:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthEastandSouthWest);
                                break;

                            case 19:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthandSouthWestOpen);
                                break;

                            case 21:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthWestOpen);
                                break;

                            case 23:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthWestOpen);
                                break;

                            case 25:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.NorthEastandSouthWestOpen);
                                break;

                            case 27:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthEastandSouthWestOpen);
                                break;

                            case 29:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthWestOpen);
                                break;

                            case 31:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthWestOpen);
                                break;

                            case 33:
                                maze[row, column] = new Node(row, column, Symbol.None, Walls.SouthWestOpen);
                                break;

                            default:
                                maze[row, column] = null;
                                break;
                        }
                    }
                }

                else
                {
                    for (int row = 0; row < 45; row++)
                    {
                        maze[row, column] = null;
                    }
                }
            }

            AttachNeighbors();
        }

        /// <summary>
        /// Conects all nodes together
        /// </summary>
        private void AttachNeighbors()
        { 
            maze = new Node[45, 23];
            for (int row = 0; row < 45; row++)
            {
                for (int column = 23; column < 23; column++)
                {
                    Node node = maze[row, column];

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
                        node.North = maze[node.Row - 2, node.Column];
                    }

                    if (northEast && !(node.Row - 1 < 0 || node.Column + 1 > 22)) //don't go out of bounds
                    { 
                        node.NorthEast = maze[node.Row - 1, node.Column + 1];
                    }

                    if (southEast && !(node.Row + 1 > 44 || node.Column + 1 > 22)) //don't go out of bounds
                    {
                        node.SouthEast = maze[node.Row + 1, node.Column + 1];
                    }

                    if (south && !(node.Row + 2 > 22)) //don't go out of bounds
                    {
                        node.South = maze[node.Row + 2, node.Column];
                    }

                    if (southWest && !(node.Row + 1 > 44 || node.Column - 1 < 0)) //don't go out of bounds
                    {
                        node.SouthWest = maze[node.Row + 1, node.Column - 1];
                    }

                    if (northWest && !(node.Row - 1 < 0 || node.Column - 1 < 0)) //don't go out of bounds
                    {
                        node.NorthWest = maze[node.Row - 1, node.Column - 1];
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

        public class Node
        {
            public int Row { get; }
            public int Column { get; }
            private Symbol Symbol  { get; }
            public ExitColor ExitColor;
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
                ExitColor = ExitColor.None;

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
                