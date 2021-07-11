using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KTANE_Solver
{
    class _3DMaze : Module
    {
        char[,] grid;
        public _3DMaze(Bomb bomb, StreamWriter logFileWriter) : base(bomb, logFileWriter)
        { 
            
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
                    {'.',   '?',    '.',    '?',    '.',    '?',    '.',    '?',    '!',    '?',    '.',    '?',    '.',    '?',    '.',    '?' },
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

            //If any of the spots contain N,E,S, or W convert them to *
            for (int i = 0; i < spots.Count; i++)
            {
                if (spots[i] == 'N' || spots[i] == 'E' || spots[i] == 'S' || spots[i] == 'W')
                {
                    spots[i] = '*';
                }
            }

            //find a location that starts with the first spot

            //if the spot can't be found, return -1
            for (int row = 0; row < 16; row++)
            {
                for (int column = 0; column < 16; column++)
                {
                    if (FoundPathNorth(spots, row, column))
                    {
                        coordinates.Add(new int[] { row, column, 0 });
                    }

                    if (FoundPathEast(spots, row, column))
                    {
                        coordinates.Add(new int[] { row, column, 1 });
                    }

                    if (FoundPathSouth(spots, row, column))
                    {
                        coordinates.Add(new int[] { row, column, 2 });
                    }

                    if (FoundPathWest(spots, row, column))
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

                    //checking one last time just in case
                    if (grid[tempRow, startColumn] == '!')
                    {
                        return false;
                    }

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
            if (startRow == 1 && startColumn == 7)
            {
                Console.WriteLine();
            }

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
        /// Tells if a path is found going west
        /// </summary>
        /// <param name="spots"></param>
        /// <returns></returns>
        private bool FoundPathWest(List<char> spots, int startRow, int startColumn)
        {
            if (startRow == 1 && startColumn == 1)
            {
                Console.WriteLine();
            }
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

                    //checking just in case
                    if (grid[startRow, tempColumn] == '!')
                    {
                        return false;
                    }

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
    }
}
