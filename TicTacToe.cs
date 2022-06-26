using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace KTANE_Solver
{
    public class TicTacToe : Module
    {
        private char[,] grid;
        private int currentRow;
        public TicTacToe(Bomb bomb, StreamWriter logFileWriter, char[,] grid) : base(bomb, logFileWriter, "Tic Tac Toe")
        { 
            this.grid = grid;
        }

        public void FindStartingRow()
        {
            List<int> row = new List<int>();

            if (Bomb.LastDigit % 2 == 0)
            {
                row.AddRange(new int[] { 5, 6, 7, 8, 9 });
            }

            else
            { 
                row.AddRange(new int[] { 1, 2, 3, 4});

            }

            if (Bomb.Parallel.Visible)
            {
                for (int i = row.Count - 1; i < -1; i--)
                {
                    if (row[i] % 2 == 1)
                    {
                        row.RemoveAt(i);
                    }
                }
            }

            else
            {
                for (int i = row.Count - 1; i < -1; i--)
                {
                    if (row[i] % 2 == 0)
                    {
                        row.RemoveAt(i);
                    }
                }
            }

            if (Bomb.UnlitIndicatorsList.Count > Bomb.LitIndicatorsList.Count)
            {
                if (row[0] < row[1])
                {
                    currentRow = row[0];
                }

                else
                {
                    currentRow = row[1];
                }
            }

            else if (Bomb.LitIndicatorsList.Count < Bomb.UnlitIndicatorsList.Count)
            {
                if (row[0] > row[1])
                {
                    currentRow = row[0];
                }

                else
                {
                    currentRow = row[1];
                }
            }

            else
            {
                currentRow = (row[0] + row[1]) / 2;
            }
        }

        public int[] Solve(char symbol)
        {
            char targetSymbol = PlaceSymbol(symbol);

            int[] targetCoordinates = NumberIsInGrid(targetSymbol);

            while (targetCoordinates.Length == 1)
            {
                currentRow++;
                targetCoordinates = NumberIsInGrid(targetSymbol);
            }

            if (!MakesTicTacToe(targetCoordinates[0], targetCoordinates[1]))
            {
                return new int[] { targetCoordinates[0], targetCoordinates[1], symbol };
            }

            else
            {
                symbol = GetOppositeSymbol(symbol);

                targetSymbol = PlaceSymbol(symbol);

                targetCoordinates = NumberIsInGrid(targetSymbol);

                while (targetCoordinates.Length == 1)
                {
                    currentRow++;
                    targetCoordinates = NumberIsInGrid(targetSymbol);
                }

                if (!MakesTicTacToe(targetCoordinates[0], targetCoordinates[1]))
                {
                    ShowAnswer("Pass", false);
                    return new int[] { targetCoordinates[0], targetCoordinates[1], symbol };
                }

                else
                {
                    ShowAnswer("Double Pass", false);
                    return new int[] { -1 };
                }
            }
        }

        private char GetOppositeSymbol(char symbol)
        {
            if (symbol == 'X')
            {
                return 'O';
            }

            return 'X';
        }

        private char PlaceSymbol(char symbol)
        {
            int xCount = XCount();
            int oCount = OCount();

            if (xCount > oCount)
            {
                if (symbol == 'X')
                {
                    switch (currentRow)
                    {
                        case 1:
                            return '9';

                        case 2:
                            return '5';


                        case 3:
                            return '7';


                        case 4:
                            return '4';


                        case 5:
                            return '9';


                        case 6:
                            return '8';

                        case 7:
                            return '6';

                        case 8:
                            return '2';

                        default:
                            return '3';
                    }
                }

                else
                {
                    switch (currentRow)
                    {
                        case 1:
                            return '3';

                        case 2:
                            return '6';


                        case 3:
                            return '8';


                        case 4:
                            return '5';


                        case 5:
                            return '4';


                        case 6:
                            return '7';

                        case 7:
                            return '1';

                        case 8:
                            return '2';

                        default:
                            return '9';
                    }
                }
            }


            else if (xCount > oCount)
            {
                if (symbol == 'X')
                {
                    switch (currentRow)
                    {
                        case 1:
                            return '3';

                        case 2:
                            return '6';


                        case 3:
                            return '2';


                        case 4:
                            return '7';


                        case 5:
                            return '1';


                        case 6:
                            return '5';

                        case 7:
                            return '8';

                        case 8:
                            return '9';

                        default:
                            return '4';
                    }
                }

                else
                {
                    switch (currentRow)
                    {
                        case 1:
                            return '9';

                        case 2:
                            return '7';


                        case 3:
                            return '1';


                        case 4:
                            return '8';


                        case 5:
                            return '6';


                        case 6:
                            return '2';

                        case 7:
                            return '4';

                        case 8:
                            return '5';

                        default:
                            return '3';
                    }
                }
            }

            else
            {

                {
                    if (symbol == 'X')
                    {
                        switch (currentRow)
                        {
                            case 1:
                                return '8';

                            case 2:
                                return '1';


                            case 3:
                                return '5';


                            case 4:
                                return '9';


                            case 5:
                                return '7';


                            case 6:
                                return '4';

                            case 7:
                                return '3';

                            case 8:
                                return '2';

                            default:
                                return '6';
                        }
                    }

                    else
                    {
                        switch (currentRow)
                        {
                            case 1:
                                return '1';

                            case 2:
                                return '2';


                            case 3:
                                return '8';


                            case 4:
                                return '6';


                            case 5:
                                return '3';


                            case 6:
                                return '4';

                            case 7:
                                return '9';

                            case 8:
                                return '5';

                            default:
                                return '7';
                        }
                    }
                }
            }

        }

        private int XCount()
        {
            int sum = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (grid[i, j] == 'X')
                    {
                        sum++;
                    }
                }
            }

            return sum;
        }

        private int OCount()
        {
            int sum = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (grid[i, j] == 'O')
                    {
                        sum++;
                    }
                }
            }

            return sum;
        }

        private int[] NumberIsInGrid(char target)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                { 
                    if(grid[i,j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return new int[] { -1 };
        }

        private bool MakesTicTacToe(int rowNum, int colNum)
        {
            List<char> row = new List<char>();
            int xCount;
            //horizontal
                row.Clear();
                for (int j = 0; j < 3; j++)
                {
                    row.Add(grid[rowNum, j]);
                }

                xCount = row.Where(x => x.Equals('X')).Count();

                if (xCount == 0 || xCount == 3)
                {
                    return true;
                }

            //vertical
                row.Clear();
                for (int j = 0; j < 3; j++)
                {
                    row.Add(grid[j, colNum]);
                }

                xCount = row.Where(x => x.Equals('X')).Count();

                if (xCount == 0 || xCount == 3)
                {
                    return true;
                }

            //diagnoal

            row.Clear();

            if(rowNum == colNum)
            {
                for (int i = 0; i < 3; i++)
                {
                    row.Add(grid[i, i]);
                }

                xCount = row.Where(x => x.Equals('X')).Count();

                if (xCount == 0 || xCount == 3)
                {
                    return true;
                }
            }

            row.Clear();

            if (rowNum + colNum == 2)
            {
                for (int i = 0; i < 3; i++)
                {
                    row.Add(grid[i, 2 - i]);
                }

                xCount = row.Where(x => x.Equals('X')).Count();

                if (xCount == 0 || xCount == 3)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
