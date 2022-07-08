using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTANE_Solver
{
    class MysticSquares
    {
        private List<Puzzle> openList;
        private List<Puzzle> closedList;
        private Puzzle startingPuzzle;
        public MysticSquares(int[,]startingPuzzle)
        {
            openList = new List<Puzzle>();
            closedList = new List<Puzzle>();

            this.startingPuzzle = new Puzzle(startingPuzzle);

            openList.Add(this.startingPuzzle);
        }



        public class Puzzle
        {
            int[,] grid;

            Puzzle parent;

            int gCost;

            public Puzzle(int[,] grid, Puzzle parent)
            {
                this.grid = grid;
                this.parent = parent;
            }

            //for each tile in the grid, calculate how far away the tile currently is to its goal state (use manhattan distance)
            //add up all costs to get the grid's estimated cost
            public int GetHeuristicCost()
            {
                int cost = 0;

                for (int row = 0; row < 3; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        int num = grid[row, col];

                        if (num == 0)
                        {
                            continue;
                        }

                        int goalRow = num / 3;
                        int goalCol = num % 3;

                        cost += Math.Abs(goalRow - row) + Math.Abs(goalCol - col);
                    }
                }

                return cost;
            }

            public bool IsSolved()
            {
                for (int row = 0; row < 3; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        int target = row * 3 + col + 1;

                        if (row == 3 && col == 3)
                        {
                            continue;
                        }

                        if (target != grid[row, col])
                        {
                            return false;
                        }
                    }

                }
                
                return true;
            }

            public bool AreEqual(Puzzle p)
            {
                for (int row = 0; row < 3; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        if (grid[row, col] != p.grid[row, col])
                        {
                            return false;
                        }
                    }
                }

                return true;
            }

            public void SetChildren()
            {

                //find out where zero is
                int zeroRow = -1;
                int zeroCol = -1;

                for (int row = 0; row < 3; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        if (grid[row, col] == 0)
                        {
                            zeroRow = row;
                            zeroCol = col;
                            break;
                        }
                    }

                    if (zeroRow != -1)
                    {
                        break;
                    }
                }

                //create 4 puzzles based on this 

            }


        }

    }
}
