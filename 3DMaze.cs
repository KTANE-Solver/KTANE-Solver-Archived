using System;
using System.Collections.Generic;
using System.IO;

namespace KTANE_Solver
{
    public class _3DMaze : Module
    {
        char[,] grid;

        Vertex[,] VertexGrid;

        //where the user needs to be
        public int endRow;
        public int endColumn;

        public int cardinalRow;
        public int cardinalColumn;

        public _3DMaze(Bomb bomb, StreamWriter logFileWriter) : base(bomb, logFileWriter)
        {
            VertexGrid = new Vertex[8, 8];

            FindEndSpace();
        }

        /// <summary>
        /// Initializes the grid depending on the three letters found
        /// </summary>
        public void CreateGrid(List<char> characters)
        {
            if (characters.Contains('A') && characters.Contains('B') && characters.Contains('C'))
            {
                grid = new char[,]
                {
                    {'!', '!', '!', '!', '!', '.', '!', '.', '!', '.', '!', '!', '!', '!', '!', '.'},
                    {'!', '?', '.', '?', '!', '?', '.', '?', '!', '?', '.', 'A', '.', '?', '!', '?'},
                    {'!', '.', '!', '.', '!', '.', '!', '.', '!', '!', '!', '.', '!', '.', '!', '.'},
                    {'!', '?', '.', '*', '!', 'A', '.', '?', '.', '?', '!', '?', '.', '?', '.', 'B'},
                    {'!', '.', '!', '!', '!', '.', '!', '!', '!', '!', '!', '!', '!', '.', '!', '.'},
                    {'.', 'A', '.', '?', '.', '?', '!', 'B', '.', '?', '.', 'C', '.', '?', '!', '?'},
                    {'!', '.', '!', '.', '!', '!', '!', '.', '!', '.', '!', '.', '!', '!', '!', '!'},
                    {'.', '?', '!', 'C', '.', '?', '!', '?', '.', '*', '!', '?', '!', '?', '.', 'B'},
                    {'!', '!', '!', '.', '!', '.', '!', '!', '!', '!', '!', '.', '!', '.', '!', '!'},
                    {'.', '?', '!', '?', '.', '?', '!', '?', '.', 'A', '.', '?', '.', '?', '!', '?'},
                    {'!', '.', '!', '.', '!', '.',  '!', '.', '!', '.', '!', '!' ,'!', '.', '!','.'},
                    {'.', '?', '!', 'B', '!', '?', '.', 'C', '.', '?', '!', '?', '.', 'B', '.', '?'},
                    {'!', '.', '!', '.', '!', '!', '!', '!', '!', '.', '!', '.', '!', '!', '!', '.'},
                    {'.', '*', '!', '?', '.', 'C', '.', '?', '!', '?', '!', '?', '.', '?', '!', '?'},
                    {'!', '!', '!', '!', '!', '.', '!', '.', '!', '!', '!', '.', '!', '.', '!', '!'},
                    {'.', '?', '.', '?', '!', '?', '.', '?', '!', 'A', '!', '?', '.', 'C',  '.','?'}
                };
            }

            else if (characters.Contains('A') && characters.Contains('B') && characters.Contains('D'))
            {
                grid = new char[,]
                {
                    {'!','!','!','.','!','!','!','.','!','.','!','.','!','!','!','!'},
                    {'!','A','.','?','.','?','.','B','.','?','.','?','!','A','.','*'},
                    {'!','.','!','!','!','!','!','.','!','.','!','!','!','.','!','.'},
                    {'!','?','!','?','.','D','.','?','.','?','!','?','.','?','.','?'},
                    {'!','.','!','.','!','.','!','!','!','!','!','.','!','!','!','.'},
                    {'.','?','.','?','.','?','!','?','.','?','.','D','.','?','!','B'},
                    {'!','.','!','.','!','!','!','.','!','.','!','.','!','.','!','.'},
                    {'!','?','!','A','.','?','.','B','.','?','!','?','.','?','.','?'},
                    {'!','!','!','!','!','!','!','.','!','.','!','!','!','!','!','.'},
                    {'!','?','.','?','.','*','!','?','.','?','.','?','.','A','!','?'},
                    {'!','.','!','.','!','.','!','!','!','.','!','!','!','.','!','.'},
                    {'!','D','.','?','.','?','!','?','.','A','!','?','.','?','.','?'},
                    {'!','!','!','.','!','.','!','.','!','.','!','.','!','.','!','!'},
                    {'.','?','!','?','.','B','.','?','.','?','!','D','.','?','!','?'},
                    {'!','.','!','.','!','.','!','!','!','!','!','.','!','.','!','.'},
                    {'.','?','.','D','.','?','!','?','.','*','!','?','!','?','!','B'}
                };
            }

            else if (characters.Contains('A') && characters.Contains('B') && characters.Contains('H'))
            {
                grid = new char[,]
                {
                    {'!','!','!','!','!','!','!','.','!','!','!','.','!','!','!','!'},
                    {'!','B','.','?','.','?','!','?','.','?','.','A','.','?','.','H'},
                    {'!','.','!','!','!','!','!','!','!','!','!','.','!','.','!','.'},
                    {'.','*','!','?','.','H','.','?','.','?','.','?','.','?','!','?'},
                    {'!','!','!','.','!','.','!','.','!','!','!','!','!','.','!','!'},
                    {'.','B','.','?','!','?','!','?','.','B','.','?','!','?','!','?'},
                    {'!','.','!','!','!','.','!','!','!','.','!','.','!','.','!','.'},
                    {'!','?','!','?','.','?','!','?','.','*','!','?','.','H','!','A'},
                    {'!','.','!','.','!','.','!','.','!','!','!','.','!','.','!','.'},
                    {'!','?','!','A','.','?','!','H','.','?','.','?','!','?','.','?'},
                    {'!','.','!','.','!','!','!','!','!','.','!','!','!','.','!','.'},
                    {'!','?','!','?','!','?','.','?','.','A','.','?','.','B','.','?'},
                    {'!','.','!','.','!','!','!','.','!','!','!','.','!','!','!','.'},
                    {'.','?','.','B','.','?','!','?','.','?','!','*','.','?','!','?'},
                    {'.','?','.','B','.','?','!','?','.','?','!','*','.','?','!','?'},
                    {'!','.','!','!','!','!','!','.','!','.','!','.','!','.','!','.'},
                    {'.','A','.','?','.','?','.','H','.','?','.','?','.','?','!','?'}
                };
            }

            else if (characters.Contains('A') && characters.Contains('C') && characters.Contains('D'))
            {
                grid = new char[,]
                {
                    {'!',   '!',    '!',    '.',    '!',    '!',    '!',    '!',    '!',    '!',    '!',    '.',    '!',    '!',    '!',    '!' },
                    {'.',   'D',    '.',    '?',    '.',    '?',    '.',    '?',    '!',    '?',    '.',    '?',    '.',    '?',    '.',    '?' },
                    {'!',   '.',    '!',    '!',    '!',    '!',    '!',    '.',    '!',    '.',    '!',    '!',    '!',    '!',    '!',    '.' },
                    {'!',   '?',    '!',    '?',    '.',    'C',    '.',    '?',    '!',    'D',    '!',    '*',    '.',    '?',    '.',    'C' },
                    {'!',   '.',    '!',    '.',    '!',    '.',    '!',    '.',    '!',    '.',    '!',    '!',    '!',    '!',    '!',    '!' },
                    {'.',   '?',    '!',    '*',    '!',    '?',    '!',    '?',    '.',    '?',    '.',    'C',    '!',    '?',    '.',    '?' },
                    {'!',   '.',    '!',    '!',    '!',    '.',    '!',    '.',    '!',    '.',    '!',    '.',    '!',    '.',    '!',    '.' },
                    {'!',   '?',    '.',    'A',    '.',    '?',    '!',    '?',    '!',    '?',    '.',    '?',    '.',    '?',    '!',    '?' },
                    {'!',   '!',    '!',    '!',    '!',    '!',    '!',    '.',    '!',    '!',    '!',    '!',    '!',    '!',    '!',    '.' },
                    {'!',   'D',    '.',    '?',    '.',    '?',    '.',    'C',    '!',    '?',    '.',    'D',    '.',    '?',    '!',    '?' },
                    {'!',   '.',    '!',    '!',    '!',    '!',    '!',    '.',    '!',    '.',    '!',    '!',    '!',    '.',    '!',    '.' },
                    {'.',   '?',    '!',    '?',    '!',    'A',    '.',    '?',    '.',    '?',    '!',    '*',    '.',    '?',    '!',    '?' },
                    {'!',   '.',    '!',    '.',    '!',    '.',    '!',    '!',    '!',    '.',    '!',    '!',    '!',    '!',    '!',    '.' },
                    {'.',   '?',    '!',    '?',    '.',    '?',    '!',    'A',    '.',    '?',    '.',    '?',    '.',    'D',    '.',    '?' },
                    {'!',   '.',    '!',    '!',    '!',    '!',    '!',    '.',    '!',    '.',    '!',    '!',    '!',    '.',    '!',    '.' },
                    {'!',   'A',    '.',    '?',    '.',    '?',    '.',    '?',    '.',    '?',    '.',    'C',    '!',    '?',    '.',    '?' }

                };
            }

            else if (characters.Contains('A') && characters.Contains('C') && characters.Contains('H'))
            {
                grid = new char[,]
                {
                    {'!','.','!','.','!','!','!','!','!','!','!','!','!','.','!','.'},
                    {'!','H','.','?','.','C','.','?','.','?','!','?','!','A','.','?' },
                    {'!','!','!','!','!','.','!','!','!','.','!','.','!','.','!','.' },
                    {'!','*','.','?','.','?','!','?','.','H','.','?','.','?','!','?' },
                    {'!','.','!','!','!','!','!','.','!','.','!','!','!','!','!','.' },
                    {'.','?','!','?','.','?','!','?','.','?','!','?','.','*','!','C' },
                    {'!','.','!','.','!','.','!','.','!','.','!','.','!','.','!','.' },
                    {'!','?','.','A','.','?','.','?','.','?','.','H','.','?','!','?' },
                    {'!','.','!','!','!','.','!','.','!','.','!','!','!','.','!','.' },
                    {'!','C','!','?','.','H','.','?','.','C','.','?','.','A','.','?' },
                    {'!','.','!','.','!','.','!','.','!','.','!','.','!','.','!','!' },
                    {'.','?','!','*','.','?','!','?','.','?','!','?','.','?','!','A' },
                    {'!','!','!','!','!','!','!','.','!','.','!','.','!','!','!','.' },
                    {'!','?','.','?','.','?','!','C','.','?','!','H','.','?','.','?' },
                    {'!','.','!','!','!','.','!','!','!','!','!','.','!','!','!','!' },
                    {'.','?','!','?','.','A','.','?','.','?','.','?','!','?','.','?' }

                };
            }

            else if (characters.Contains('A') && characters.Contains('D') && characters.Contains('H'))
            {
                grid = new char[,]
                {
                    {'!','.','!','!','!','!','!','!','!','.','!','!','!','.','!','!' },
                    {'!','D','.','?','!','D','.','?','.','?','!','*','.','?','.','?' },
                    {'!','.','!','.','!','.','!','.','!','!','!','!','!','!','!','.' },
                    {'!','?','!','?','!','?','!','?','.','H','.','?','.','?','.','A' },
                    {'!','.','!','.','!','.','!','.','!','.','!','!','!','!','!','!' },
                    {'!','?','!','*','.','H','!','?','!','?','.','?','.','A','.','?' },
                    {'!','.','!','!','!','.','!','.','!','!','!','!','!','.','!','.' },
                    {'!','A','!','?','!','?','!','D','.','?','.','?','.','?','.','?' },
                    {'!','.','!','.','!','!','!','!','!','.','!','!','!','.','!','!' },
                    {'.','?','.','?','.','?','.','?','.','H','!','D','.','?','!','?' },
                    {'!','!','!','!','!','!','!','.','!','.','!','.','!','.','!','.' },
                    {'!','*','.','?','.','H','.','?','!','?','!','?','!','?','.','A' },
                    {'!','.','!','!','!','!','!','.','!','.','!','.','!','.','!','.' },
                    {'.','D','.','?','.','?','!','?','!','?','!','?','!','?','!','?' },
                    {'!','!','!','!','!','.','!','.','!','!','!','.','!','.','!','.' },
                    {'!','?','.','?','.','?','.','A','.','?','!','H','.','?','!','?' }

                };
            }

            else if (characters.Contains('B') && characters.Contains('C') && characters.Contains('D'))
            {
                grid = new char[,]
                {
                    {'!','.','!','!','!','.','!','!','!','!','!','!','!','!','!','.'},
                    {'!','?','.','?','!','?','!','?','.','?','.','B','.','?','.','?'},
                    {'!','.','!','!','!','!','!','.','!','!','!','.','!','!','!','!'},
                    {'.','C','.','?','.','D','.','?','!','?','.','?','!','*','.','?'},
                    {'!','.','!','!','!','!','!','.','!','.','!','!','!','.','!','.'},
                    {'!','?','!','*','!','?','.','B','!','?','.','?','.','C','.','?'},
                    {'!','!','!','.','!','.','!','.','!','.','!','!','!','!','!','!'},
                    {'.','?','.','C','.','?','.','?','!','?','.','?','.','B','.','?'},
                    {'!','!','!','.','!','!','!','!','!','.','!','.','!','!','!','!'},
                    {'.','?','.','?','!','?','.','?','.','C','.','?','!','?','.','D'},
                    {'!','!','!','.','!','.','!','!','!','!','!','.','!','.','!','!'},
                    {'.','B','.','?','.','?','!','?','.','?','.','D','.','?','!','.'},
                    {'!','.','!','!','!','!','!','.','!','.','!','.','!','!','!','.'},
                    {'.','?','.','C','.','?','.','?','.','*','!','?','!','D','.','?'},
                    {'!','!','!','.','!','!','!','!','!','!','!','.','!','.','!','!'},
                    {'.','D','.','?','!','?','.','B','.','?','.','?','.','?','!','?'}

                };
            }

            else if (characters.Contains('B') && characters.Contains('C') && characters.Contains('D'))
            {
                grid = new char[,]
                {
                    {'!','!','!','.','!','!','!','!','!','.','!','.','!','!','!','!' },
                    {'!','C','.','?','.','?','.','?','.','H','!','?','.','?','.','?' },
                    {'!','.','!','!','!','.','!','!','!','.','!','!','!','.','!','!' },
                    {'.','?','!','?','.','C','.','?','!','?','.','?','.','?','.','H' },
                    {'!','!','!','.','!','!','!','.','!','!','!','!','!','.','!','.' },
                    {'.','?','!','?','!','*','!','?','!','B','.','?','.','?','!','?' },
                    {'!','.','!','.','!','.','!','.','!','.','!','!','!','!','!','.' },
                    {'!','B','.','?','.','?','.','H','!','*','.','?','.','?','.','?' },
                    {'!','.','!','!','!','!','!','!','!','!','!','!','!','!','!','.' },
                    {'!','?','.','H','.','?','.','?','!','?','.','B','.','?','.','C' },
                    {'!','.','!','.','!','!','!','.','!','.','!','.','!','!','!','.' },
                    {'.','?','!','?','!','?','.','*','!','?','!','?','.','?','!','?' },
                    {'!','!','!','.','!','.','!','!','!','.','!','!','!','.','!','.' },
                    {'.','?','!','?','!','B','.','?','!','C','.','?','.','?','!','?' },
                    {'!','.','!','.','!','.','!','.','!','.','!','!','!','!','!','.' },
                    {'.','?','.','C','.','?','!','?','.','?','.','H','!','?','.','B' }
                };
            }

            else if (characters.Contains('B') && characters.Contains('D') && characters.Contains('H'))
            {
                grid = new char[,]
                {
                    {'!','.','!','!','!','!','!','.','!','.','!','.','!','.','!','!'},
                    {'.','?','!','?','!','D','.','?','!','B','.','?','.','?','.','H'},
                    {'!','.','!','.','!','.','!','!','!','.','!','.','!','.','!','!'},
                    {'!','?','!','?','.','?','!','*','.','?','!','?','!','D','!','?'},
                    {'!','!','!','!','!','.','!','!','!','!','!','.','!','.','!','.'},
                    {'.','?','.','?','.','H','.','?','.','*','!','?','!','?','.','B'},
                    {'!','!','!','!','!','.','!','!','!','!','!','.','!','!','!','!'},
                    {'.','D','.','?','!','?','.','?','.','?','.','B','.','?','.','?'},
                    {'!','.','!','.','!','.','!','!','!','.','!','.','!','!','!','!'},
                    {'.','?','.','?','!','?','!','?','.','D','!','?','.','?','.','H'},
                    {'!','!','!','.','!','.','!','.','!','.','!','.','!','.','!','.'},
                    {'!','?','.','?','.','B','.','?','!','?','!','?','!','?','.','?'},
                    {'!','.','!','!','!','!','!','.','!','!','!','!','!','.','!','.'},
                    {'!','?','!','?','.','?','.','H','.','?','.','?','.','H','.','*'},
                    {'!','.','!','!','!','.','!','.','!','!','!','!','!','!','!','!'},
                    {'.','D','.','?','.','?','!','?','!','?','.','B','!','?','.','?'}
                };
            }

            else
            {
                grid = new char[,]
                {
                    {'!','.','!','!','!','.','!','!','!','!','!','.','!','!','!','.'},
                    {'!','?','!','?','.','H','.','?','!','?','.','D','.','?','!','?'},
                    {'!','.','!','.','!','!','!','.','!','.','!','!','!','.','!','.'},
                    {'!','?','!','?','!','?','!','?','.','C',' ','*','!','?','!','?'},
                    {'!','.','!','.','!','.','!','.','!','.','!','.','!','.','!','.'},
                    {'.','?','.','?','!','?','.','H','.','?','.','?','!','?','.','D'},
                    {'!','.','!','.','!','.','!','.','!','.','!','.','!','!','!','.'},
                    {'.','H','.','?','!','?','!','?','!','?',' ','D','.','?','.','?'},
                    {'!','.','!','!','!','.','!','.','!','.','!','.','!','!','!','.'},
                    {'!','?','.','?','.','C','!','?','!','?',' ','?','.','?','.','?'},
                    {'!','.','!','!','!','!','!','.','!','.','!','!','!','!','!','.'},
                    {'!','C','.','?','.','?','.','D','!','?','.','C','.','?','.','H'},
                    {'!','.','!','!','!','.','!','!','!','!','!','.','!','!','!','.'},
                    {'!','*','!','D','.','?','.','?','.','H','.','?','.','*','!','?'},
                    {'!','!','!','.','!','!','!','.','!','.','!','!','!','.','!','!'},
                    {'.','?','.','?','!','?','.','?','!','?',' ','?','.','?','.','C'}
                };
            }

            int gridRow;
            int gridColumn;

            for (int row = 0; row < 8; row++)
            {
                for (int column = 0; column < 8; column++)
                {
                    gridRow = (row * 2) + 1;
                    gridColumn = (column * 2) + 1;

                    VertexGrid[row, column] = new Vertex(grid[gridRow, gridColumn], row, column);
                }
            }

            for (int row = 0; row < 8; row++)
            {
                for (int column = 0; column < 8; column++)
                {
                    gridRow = (row * 2) + 1;
                    gridColumn = (column * 2) + 1;

                    Vertex vertex = VertexGrid[row, column];
                    //north
                    if (grid[gridRow - 1, gridColumn] != '!')
                    {
                        if (row == 0)
                        {
                            vertex.SetNorthVertex(VertexGrid[7, column]);
                        }

                        else
                        {
                            vertex.SetNorthVertex(VertexGrid[row - 1, column]);
                        }
                    }

                    //east
                    if (column == 7 && grid[gridRow, 0] != '!')
                    {
                        vertex.SetEastVertex(VertexGrid[row, 0]);
                    }

                    else if (column != 7 && grid[gridRow, gridColumn + 1] != '!')
                    {
                        vertex.SetEastVertex(VertexGrid[row, column + 1]);
                    }

                    //south
                    if (row == 7 && grid[0, gridColumn] != '!')
                    {
                        vertex.SetSouthVertex(VertexGrid[0, column]);
                    }

                    else if (row != 7 && grid[gridRow + 1, gridColumn] != '!')
                    {
                        vertex.SetSouthVertex(VertexGrid[row + 1, column]);
                    }

                    //west
                    if (grid[gridRow, gridColumn - 1] != '!')
                    {
                        if (column == 0)
                        {
                            vertex.SetWestVertex(VertexGrid[row, 0]);
                        }

                        else
                        {
                            vertex.SetWestVertex(VertexGrid[row, column - 1]);
                        }
                    }
                }
            }


        }

        /// <summary>
        /// Finds the user location given at least two letter spots with ? meaning blank
        ///
        /// </summary>
        /// <param name="spots">where the user has gone</param>
        /// <returns>the coordinates of where the user currently is.
        ///          Last data is the direction the user is facing
        ///          0 is north
        ///          1 is east
        ///          2 is south
        ///          3 is west.
        ///If there happens to be a -1, then the spots were invalid</returns>
        public List<int[]> FindLocation(List<char> spots)
        {
            List<int[]> coordinates = new List<int[]>();

            //have two seperate spots list. one with the cardinals and one without


            List<char> cardinalSpots = new List<char>();

            //If any of the spots contain N,E,S, or W convert them to *
            for (int i = 0; i < spots.Count; i++)
            {
                if (spots[i] == 'N' || spots[i] == 'E' || spots[i] == 'S' || spots[i] == 'W')
                {
                    cardinalSpots.Add('*');
                    spots[i] = '?';
                }

                else
                {
                    cardinalSpots.Add(spots[i]);
                }
            }

            //find a location that starts with the first spot

            //if the spot can't be found, return -1
            for (int row = 0; row < 16; row++)
            {
                for (int column = 0; column < 16; column++)
                {
                    if (row == 11 && column == 11)
                    {
                        Console.WriteLine();
                    }
                    if (FoundPathNorth(spots, row, column) || FoundPathNorth(cardinalSpots, row, column))
                    {
                        coordinates.Add(new int[] { row, column, 0 });
                    }

                    if (FoundPathEast(spots, row, column) || FoundPathEast(cardinalSpots, row, column))
                    {
                        coordinates.Add(new int[] { row, column, 1 });
                    }

                    if (row == 5 && column == 15)
                    {
                        Console.WriteLine();
                    }

                    if (FoundPathSouth(spots, row, column) || FoundPathSouth(cardinalSpots, row, column))
                    {
                        coordinates.Add(new int[] { row, column, 2 });
                    }

                    if (FoundPathWest(spots, row, column) || FoundPathWest(cardinalSpots, row, column))
                    {
                        coordinates.Add(new int[] { row, column, 3 });
                    }

                }
            }

            //check if there have been any possible locations found

            //if yes, return them
            if (coordinates.Count != 0)
            {
                return coordinates;
            }

            //if not return null, representing an invalid path was given
            return null;
        }

        /// <summary>
        /// Tells if a path is found going north
        /// </summary>
        /// <param name="spots"></param>
        /// <returns></returns>
        private bool FoundPathNorth(List<char> spots, int startRow, int startColumn)
        {
            if (grid[startRow, startColumn] == spots[0])
            {

                //if row becomes negative, add 16 til postive

                int tempRow = startRow - ((spots.Count - 1) * 2);

                if (tempRow < 0)
                {
                    tempRow += 16;
                }

                if (grid[tempRow, startColumn] == spots[spots.Count - 1])
                {
                    //if the end is correct, the make sure there are no
                    //walls in between the start and end

                    tempRow = startRow - 1;

                    if (tempRow < 0)
                    {
                        tempRow += 16;
                    }

                    int endRow = startRow - ((spots.Count - 1) * 2) - 1;

                    if (endRow < 0)
                    {
                        endRow += 16;
                    }

                    do
                    {
                        if (grid[tempRow, startColumn] == '!')
                        {
                            return false;
                        }

                        tempRow -= 2;

                        if (tempRow < 0)
                        {
                            tempRow += 16;
                        }
                    }
                    while (tempRow != endRow);

                    //if no walls have been found, then make sure each spot is correct

                    for (int i = 0; i < spots.Count; i++)
                    {
                        tempRow = startRow - (2 * i);

                        if (tempRow < 0)
                        {
                            tempRow += 16;
                        }

                        if (grid[tempRow, startColumn] != spots[i])
                        {
                            return false;
                        }
                    }


                    //if this point is reached, then this path is valid
                    return true;

                }

            }

            return false;
        }

        /// <summary>
        /// Tells if a path is found going east
        /// </summary>
        /// <param name="spots"></param>
        /// <returns></returns>
        private bool FoundPathEast(List<char> spots, int startRow, int startColumn)
        {
            if (grid[startRow, startColumn] == spots[0])
            {
                //if row becomes negative, add 16 til postive

                int tempColumn = startColumn + ((spots.Count - 1) * 2);

                if (tempColumn > 15)
                {
                    tempColumn -= 16;
                }

                if (grid[startRow, tempColumn] == spots[spots.Count - 1])
                {
                    //if the end is correct, the make sure there are no
                    //walls in between the start and end

                    tempColumn = startColumn + 1;

                    if (tempColumn > 15)
                    {
                        tempColumn -= 16;
                    }

                    int endColumn = startColumn + ((spots.Count - 1) * 2) - 1;

                    if (endColumn > 15)
                    {
                        endColumn -= 16;
                    }

                    do
                    {
                        if (grid[startRow, tempColumn] == '!')
                        {
                            return false;
                        }

                        tempColumn += 2;

                        if (tempColumn > 15)
                        {
                            tempColumn -= 16;
                        }
                    }
                    while (tempColumn != endColumn);

                    //checking the last tile just in case
                    if (grid[startRow, tempColumn] == '!')
                    {
                        return false;
                    }


                    //if no walls have been found, then make sure each spot is correct
                    for (int i = 0; i < spots.Count; i++)
                    {
                        tempColumn = startColumn + (2 * i);

                        if (tempColumn > 15)
                        {
                            tempColumn -= 16;
                        }

                        if (grid[startRow, tempColumn] != spots[i])
                        {
                            return false;
                        }
                    }

                    //if this point is reached, then this path is valid
                    return true;

                }

            }

            return false;
        }

        /// <summary>
        /// Tells if a path is found going south
        /// </summary>
        /// <param name="spots"></param>
        /// <returns></returns>
        private bool FoundPathSouth(List<char> spots, int startRow, int startColumn)
        {
            if (grid[startRow, startColumn] == spots[0])
            {

                //if row becomes negative, add 16 til postive

                int tempRow = startRow + ((spots.Count - 1) * 2);

                if (tempRow > 15)
                {
                    tempRow -= 16;
                }

                if (grid[tempRow, startColumn] == spots[spots.Count - 1])
                {
                    //if the end is correct, the make sure there are no
                    //walls in between the start and end

                    tempRow = startRow + 1;

                    if (tempRow > 15)
                    {
                        tempRow -= 16;
                    }

                    int endRow = startRow + ((spots.Count - 1) * 2) - 1;

                    if (endRow > 15)
                    {
                        endRow -= 16;
                    }

                    do
                    {
                        if (grid[tempRow, startColumn] == '!')
                        {
                            return false;
                        }

                        tempRow += 2;

                        if (tempRow > 15)
                        {
                            tempRow -= 16;
                        }
                    }
                    while (tempRow != endRow);

                    //checking just in case
                    if (grid[tempRow, startColumn] == '!')
                    {
                        return false;
                    }

                    //if no walls have been found, then make sure each spot is correct
                    for (int i = 0; i < spots.Count; i++)
                    {
                        tempRow = startRow + (2 * i);

                        if (tempRow > 15)
                        {
                            tempRow -= 16;
                        }

                        if (grid[tempRow, startColumn] != spots[i])
                        {
                            return false;
                        }
                    }


                    //if this point is reached, then this path is valid
                    return true;

                }

            }

            return false;
        }

        /// <summary>
        /// Tells if a path is found going west
        /// </summary>
        /// <param name="spots"></param>
        /// <returns></returns>
        private bool FoundPathWest(List<char> spots, int startRow, int startColumn)
        {
            if (grid[startRow, startColumn] == spots[0])
            {
                //if row becomes negative, add 16 til postive

                int tempColumn = startColumn - ((spots.Count - 1) * 2);

                if (tempColumn < 0)
                {
                    tempColumn += 16;
                }

                if (grid[startRow, tempColumn] == spots[spots.Count - 1])
                {
                    //if the end is correct, the make sure there are no
                    //walls in between the start and end

                    tempColumn = startColumn - 1;

                    if (tempColumn < 0)
                    {
                        tempColumn += 16;
                    }

                    int endColumn = startColumn - ((spots.Count - 1) * 2) + 1;

                    if (endColumn > 0)
                    {
                        endColumn += 16;
                    }

                    do
                    {
                        if (grid[startRow, tempColumn] == '!')
                        {
                            return false;
                        }

                        tempColumn -= 2;

                        if (tempColumn < 0)
                        {
                            tempColumn += 16;
                        }
                    }
                    while (tempColumn != endColumn);

                    //if no walls have been found, then make sure each spot is correct
                    for (int i = 0; i < spots.Count; i++)
                    {
                        tempColumn = startColumn - (2 * i);

                        if (tempColumn > 15)
                        {
                            tempColumn -= 16;
                        }

                        if (grid[tempColumn, tempColumn] != spots[i])
                        {
                            return false;
                        }
                    }


                    //if this point is reached, then this path is valid
                    return true;

                }

            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="startRow"></param>
        /// <param name="startColumn"></param>
        /// <param name="startingDirection"></param>
        /// <returns>the direction the user is currently facing</returns>
        public String FindClosestCardinal(int startRow, int startColumn, String startingDirection)
        {
            DijkstraAlgorithm(startRow, startColumn);

            Vertex startVertex = VertexGrid[startRow, startColumn];

            Dictionary<Vertex, List<Vertex>> cardinals = new Dictionary<Vertex, List<Vertex>>();

            foreach (Vertex vertex in VertexGrid)
            {
                if (vertex.Data == '*')
                {
                    cardinals.Add(vertex, new List<Vertex>());
                }
            }

            List<Vertex> shortestPath = null;

            List<Vertex> keys = new List<Vertex>(cardinals.Keys);

            foreach (Vertex endVertex in keys)
            {
                cardinals[endVertex] = FindShortestPath(startVertex, endVertex);
                
                if (shortestPath == null)
                {
                    shortestPath = cardinals[endVertex];
                }

                else if(shortestPath.Count > cardinals[endVertex].Count)
                {
                    shortestPath = cardinals[endVertex];
                }
            }

            cardinalRow = shortestPath[shortestPath.Count - 1].Row;
            cardinalColumn = shortestPath[shortestPath.Count - 1].Column;


            return PrintDirections(shortestPath, startingDirection, null);
        }

        public void FindExit(String startingDirection, String endingDirection)
        {
            DijkstraAlgorithm(cardinalRow, cardinalColumn);

            Vertex startVertex = VertexGrid[cardinalRow, cardinalColumn];

            Vertex endVertex = VertexGrid[endRow, endColumn];

            List<Vertex> shortestPath = FindShortestPath(startVertex, endVertex);

            foreach (Vertex vertex in shortestPath)
            {
                System.Diagnostics.Debug.WriteLine($"{vertex.Row} {vertex.Column}");
            }

            PrintDirections(shortestPath, startingDirection, endingDirection);

            ShowAnswer("Continue pressing forward until module is solved", "3D Maze Answer");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="startingDirection"></param>
        /// <param name="designatedDirection">the direction the user wants to end up facing</param>
        /// <returns></returns>
        public String PrintDirections(List<Vertex> path, String startingDirection, String designatedDirection)
        {
            Vertex currentVertex = path[0];

            Vertex nextVertex = path[1];

            String currentDirectionFacing = startingDirection;

            List<String> directions = new List<string>();

            do
            {
                switch (currentDirectionFacing)
                {
                    case "NORTH":
                        if (currentVertex.EastVertex == nextVertex)
                        {
                            directions.Add("Right");
                            currentDirectionFacing = "EAST";
                        }

                        else if (currentVertex.SouthVertex == nextVertex)
                        {
                            directions.Add("Right");
                            directions.Add("Right");

                            currentDirectionFacing = "SOUTH";

                        }

                        else if (currentVertex.WestVertex == nextVertex)
                        {
                            directions.Add("Left");

                            currentDirectionFacing = "WEST";
                        }

                        else
                        { 
                            currentDirectionFacing = "NORTH";
                        }
                        break;

                    case "EAST":
                        if (currentVertex.NorthVertex == nextVertex)
                        {
                            directions.Add("Left");
                            currentDirectionFacing = "NORTH";
                        }

                        else if (currentVertex.SouthVertex == nextVertex)
                        {
                            directions.Add("Right");
                            currentDirectionFacing = "SOUTH";
                        }

                        else if (currentVertex.WestVertex == nextVertex)
                        {
                            directions.Add("Right");
                            directions.Add("Right");
                            currentDirectionFacing = "WEST";
                        }

                        else
                        { 
                            currentDirectionFacing = "EAST";
                        }
                        break;

                    case "SOUTH":
                        if (currentVertex.NorthVertex == nextVertex)
                        {
                            directions.Add("Right");
                            directions.Add("Right");
                            currentDirectionFacing = "NORTH";
                        }

                        else if (currentVertex.EastVertex == nextVertex)
                        {
                            directions.Add("Left");
                            currentDirectionFacing = "EAST";
                        }

                        else if (currentVertex.WestVertex == nextVertex)
                        {
                            directions.Add("Right");
                            currentDirectionFacing = "WEST";
                        }

                        else
                        { 
                            currentDirectionFacing = "SOUTH";
                        }
                        break;

                    //west
                    default:
                        if (currentVertex.NorthVertex == nextVertex)
                        {
                            directions.Add("Right");
                            currentDirectionFacing = "NORTH";
                        }

                        else if (currentVertex.EastVertex == nextVertex)
                        {
                            directions.Add("Right");
                            directions.Add("Right");
                            currentDirectionFacing = "EAST";
                        }

                        else if (currentVertex.SouthVertex == nextVertex)
                        {
                            directions.Add("Left");
                            currentDirectionFacing = "SOUTH";
                        }

                        else
                        { 
                            currentDirectionFacing = "WEST";
                        }
                        break;
                }

                directions.Add("Forward");

                if (nextVertex == path[path.Count - 1])
                {
                    nextVertex = null;

                    if (designatedDirection != null)
                    {
                        switch (currentDirectionFacing)
                        {
                            case "NORTH":
                                if (designatedDirection == "EAST")
                                {
                                    directions.Add("Right");
                                    currentDirectionFacing = "EAST";
                                }

                                else if (designatedDirection == "SOUTH")
                                {
                                    directions.Add("Right");
                                    directions.Add("Right");

                                    currentDirectionFacing = "SOUTH";

                                }

                                else if (designatedDirection == "WEST")
                                {
                                    directions.Add("Left");

                                    currentDirectionFacing = "WEST";
                                }
                                break;

                            case "EAST":
                                if (designatedDirection == "NORTH")
                                {
                                    directions.Add("Left");
                                    currentDirectionFacing = "NORTH";
                                }

                                else if (designatedDirection == "SOUTH")
                                {
                                    directions.Add("Right");
                                    currentDirectionFacing = "SOUTH";
                                }

                                else if (designatedDirection == "WEST")
                                {
                                    directions.Add("Right");
                                    directions.Add("Right");
                                    currentDirectionFacing = "WEST";
                                }
                                break;

                            case "SOUTH":
                                if (designatedDirection == "NORTH")
                                {
                                    directions.Add("Right");
                                    directions.Add("Right");
                                    currentDirectionFacing = "NORTH";
                                }

                                else if (designatedDirection == "EAST")
                                {
                                    directions.Add("Left");
                                    currentDirectionFacing = "EAST";
                                }

                                else if (designatedDirection == "WEST")
                                {
                                    directions.Add("Right");
                                    currentDirectionFacing = "WEST";
                                }
                                break;

                            default:
                                if (designatedDirection == "NORTH")
                                {
                                    directions.Add("Right");
                                    currentDirectionFacing = "NORTH";
                                }

                                else if (designatedDirection == "EAST")
                                {
                                    directions.Add("Right");
                                    directions.Add("Right");
                                    currentDirectionFacing = "EAST";
                                }

                                else if (designatedDirection == "SOUTH")
                                {
                                    directions.Add("Left");
                                    currentDirectionFacing = "SOUTH";
                                }
                                break;

                        }
                    }
                    
                }

                else
                {
                    currentVertex = nextVertex;
                    nextVertex = path[path.IndexOf(nextVertex) + 1];
                }

            } while (nextVertex != null);

            List<String> finalDirections = new List<String>();

            while (directions.Count != 0)
            {
                int counter = 0;
                String word = directions[0];

                while (directions.Count != 0 && word == directions[0])
                {
                    counter++;
                    directions.RemoveAt(0);
                }
                finalDirections.Add(word + " x" + counter);
            }

            String answer = "";

            foreach (String direction in finalDirections)
            {
                answer += direction + ", ";
            }

            answer = answer.Substring(0, answer.Length - 2);

            ShowAnswer(answer, "3D Maze Answer Part 1");

            return currentDirectionFacing;
        }

        /// <summary>
        /// Finding the goal space
        /// </summary>
        private void FindEndSpace()
        {
            //Start with the first numeric digit in the serial number.
            //Add 1 for every unlit indicator with a letter in “MAZE GAMER”.
            //If the row number is greater than 7, subtract 8.

            int startingRow = Bomb.FirstDigit;

            if (Bomb.Car.VisibleNotLit)
                startingRow++;

            if (Bomb.Clr.VisibleNotLit)
                startingRow++;

            if (Bomb.Frk.VisibleNotLit)
                startingRow++;

            if (Bomb.Frq.VisibleNotLit)
                startingRow++;

            if (Bomb.Msa.VisibleNotLit)
                startingRow++;

            if (Bomb.Nsa.VisibleNotLit)
                startingRow++;

            if (Bomb.Sig.VisibleNotLit)
                startingRow++;

            if (Bomb.Trn.VisibleNotLit)
                startingRow++;

            endRow = startingRow % 8;

            //Start with the last numeric digit in the serial number.
            //Add 1 for every lit indicator with a letter in “HELP IM LOST”.
            //If the column number is greater than 7, subtract 8.

            int startingColumn = Bomb.LastDigit;


            if (Bomb.Bob.Lit)
                startingColumn++;

            if (Bomb.Clr.Lit)
                startingColumn++;

            if (Bomb.Ind.Lit)
                startingColumn++;

            if (Bomb.Msa.Lit)
                startingColumn++;

            if (Bomb.Sig.Lit)
                startingColumn++;

            endColumn = startingColumn % 8;
        }

        public void PrintGrid()
        {
            for (int row = 0; row < 16; row++)
            {
                for (int column = 0; column < 16; column++)
                {
                    System.Diagnostics.Debug.Write(grid[row, column] + " ");
                }

                System.Diagnostics.Debug.WriteLine("");
            }
        }

        public void DijkstraAlgorithm(int startRow, int startColumn)
        {
            ResetVertecies();

            Vertex currentVertex = VertexGrid[startRow, startColumn];

            currentVertex.TotalCost = 0;

            currentVertex.Permanent = true;

            List<Vertex> nonPermanentList = FindNonPermanentVerticies();

            while (nonPermanentList.Count != 0)
            {
                foreach (Vertex neighbor in FindNonPermanentNeighbors(currentVertex))
                {
                    //unweighted
                    int potentialCost = currentVertex.TotalCost + 1;

                    if (potentialCost < neighbor.TotalCost)
                    {
                        neighbor.TotalCost = potentialCost;
                        neighbor.PreviousVertex = currentVertex;
                    }
                }

                //Find the smallest non-permanent vertex, make it permanent,
                //and set it the the current node
                Vertex smallestCost = nonPermanentList[0];

                for (int i = 1; i < nonPermanentList.Count; i++)
                {
                    if (nonPermanentList[i].TotalCost < smallestCost.TotalCost)
                    {
                        smallestCost = nonPermanentList[i];
                    }
                }

                smallestCost.Permanent = true;

                currentVertex = smallestCost;

                //udpate the non-permanent list
                nonPermanentList.Remove(smallestCost);
            }
        }

        public List<Vertex> FindShortestPath(Vertex start, Vertex end)
        {
            List<Vertex> path = new List<Vertex>();

            path.Add(end);

            while (!path.Contains(start))
            {
                Vertex current = path[path.Count - 1];
                path.Add(current.PreviousVertex);
            }

            path.Reverse();

            return path;
        }

        private List<Vertex> FindNonPermanentNeighbors(Vertex vertex)
        {
            List<Vertex> nonPermanentNeighbors = new List<Vertex>();

            //start by find all the non-permanent rooms, and return the ones that
            //are connected to the starting rooms

            foreach (Vertex possibleNeighbor in FindNonPermanentVerticies())
            {
                if (vertex.Edges.Contains(possibleNeighbor))
                {
                    nonPermanentNeighbors.Add(possibleNeighbor);
                }
            }

            return nonPermanentNeighbors;
        }

        private List<Vertex> FindNonPermanentVerticies()
        {
            List<Vertex> nonPermanentList = new List<Vertex>();

            foreach (Vertex v in VertexGrid)
            {
                if (!v.Permanent)
                {
                    nonPermanentList.Add(v);
                }
            }

            return nonPermanentList;
        }


        /// <summary>
        /// Sets all vertices visited to false
        /// </summary>
        public void ResetVertecies()
        {
            foreach (Vertex vertex in VertexGrid)
            {
                vertex.Permanent = false;
                vertex.TotalCost = int.MaxValue;
                vertex.PreviousVertex = null;
            }
        }

        public class Vertex
        {
            public char Data { get; }

            public bool Permanent { get; set; }

            public int TotalCost { get; set; }

            public Vertex PreviousVertex { get; set; }

            public Vertex NorthVertex { get; set; }
            public Vertex EastVertex { get; set; }
            public Vertex SouthVertex { get; set; }
            public Vertex WestVertex { get; set; }

            public List<Vertex> Edges { get; set; }



            public int Row { get; }
            public int Column { get; }



            public Vertex(char data, int row, int  column)
            {
                Data = data;

                Row = row;
                Column = column;

                NorthVertex = null;
                EastVertex = null;
                SouthVertex = null;
                WestVertex = null;
                
                Permanent = false;
                

                Edges = new List<Vertex>();

            }

            public void SetNorthVertex(Vertex vertex)
            {
                NorthVertex = vertex;
                Edges.Add(vertex);
            }

            public void SetEastVertex(Vertex vertex)
            {
                EastVertex = vertex;
                Edges.Add(vertex);

            }

            public void SetWestVertex(Vertex vertex)
            {
                WestVertex = vertex;
                Edges.Add(vertex);

            }

            public void SetSouthVertex(Vertex vertex)
            {
                SouthVertex = vertex;
                Edges.Add(vertex);
            }

        }
    }
}
