using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace KTANE_Solver
{
    class SymbolicPassword : Module
    {
        private List<AnswerGrid> openList;
        private List<AnswerGrid> closedList;


        Symbol[,] grid;
        List<Symbol> symbolList;
        Symbol[,] answerGrid;


        public SymbolicPassword(StreamWriter logFilewriter, List<Symbol> symbolList) : base(null, logFilewriter, "Symbolic Password")
        {
            openList = new List<AnswerGrid>();
            closedList = new List<AnswerGrid>();

            this.symbolList = symbolList;
            SetUpGrid();
        }

        private void SetUpGrid()
        {
            grid = new Symbol[7, 7]
            {
                { Symbol.O, Symbol.E, Symbol.Copyright, Symbol.Six, Symbol.Trident, Symbol.Six, Symbol.QuestionMark },
                { Symbol.A, Symbol.O, Symbol.Butt, Symbol.Paragraph, Symbol.SmilyFace, Symbol.E, Symbol.WhiteStar },
                { Symbol.Lambda, Symbol.BackwardsC, Symbol.Swirl, Symbol.B, Symbol.B, Symbol.Hashtag, Symbol.O,},
                { Symbol.Lightning, Symbol.Swirl, Symbol.X, Symbol.Squid, Symbol.C, Symbol.Ae, Symbol.Lambda},
                {Symbol.Squid, Symbol.WhiteStar, Symbol.UfinishedR, Symbol.X, Symbol.Paragraph, Symbol.Trident, Symbol.Swirl },
                { Symbol.H, Symbol.H, Symbol.Lambda, Symbol.QuestionMark, Symbol.Three, Symbol.N, Symbol.E },
                { Symbol.BackwardsC, Symbol.QuestionMark, Symbol.WhiteStar, Symbol.SmilyFace, Symbol.BlackStar, Symbol.Omega, Symbol.Butt}
            };
        }

        private void Solve()
        {
            answerGrid = FindAnswerGrid();

            Symbol[,] startingGrid = new Symbol[2, 3];

            for (int i = 0; i < 6; i++)
            {
                startingGrid[i % 3, i / 3] = symbolList[i];
            }

            AnswerGrid startingAnswerGrid = new AnswerGrid(startingGrid, answerGrid, null);
            startingAnswerGrid.GCost = 0;
            openList.Add(startingAnswerGrid);

            AnswerGrid currentGrid = startingAnswerGrid;

            while (!GoalIsInOpenList())
            { 
                List<AnswerGrid> children = currentGrid.GetChildren();

                openList.Remove(currentGrid);
                closedList.Add(currentGrid);

                foreach (AnswerGrid a in children)
                {
                    if (a.Parent == null)
                    {
                        a.Parent = currentGrid;
                    }

                    else
                    {
                        if (a.GCost > currentGrid.GCost + 1)
                        {
                            a.Parent = currentGrid;
                        }
                    }

                    openList.Add(a);

                    if (a.Parent == currentGrid)
                    {
                        a.GCost = currentGrid.GCost + 1;
                    }

                    a.TotalCost = a.GCost + a.HeuristicCost;
                }

                currentGrid = AnswerGrid.FindLowestCostNeighbor(openList);
            }

            AnswerGrid goal = null;
            //find the goal in the open list
            foreach (AnswerGrid a in openList)
            {

                if (EqualsGoal(a.grid, answerGrid))
                {
                    goal = a;
                    break;
                }
            }

            List<AnswerGrid> puzzleAnswer = new List<AnswerGrid>();

            AnswerGrid current = goal;

            do
            {
                puzzleAnswer.Add(current);
                current = current.Parent;

            } while (current != null);

            puzzleAnswer.Reverse();

            List<string> directions = FindDirections(puzzleAnswer);

            ShowAnswer(string.Join(", ", directions), true);

        }

        public List<string> FindDirections(List<AnswerGrid> gridAnswer)
        {
            List<string> directions = new List<string>();

            for (int i = 0; i < gridAnswer.Count - 1; i++)
            {
                Symbol[,] first = gridAnswer[i].grid;
                Symbol[,] last = gridAnswer[i + 1].grid;


                if (TopLeft(first, last))
                {
                    directions.Add("Top Left");
                }

                else if (TopRight(first, last))
                {
                    directions.Add("Top Right");
                }

                else if (BottomRight(first, last))
                {
                    directions.Add("Bottom Right");
                }

                else if (BottomLeft(first, last))
                {
                    directions.Add("Bottom Left");
                }

                else if (LefttUp(first, last))
                {
                    directions.Add("Left Up");
                }

                else if (MidtUp(first, last))
                {
                    directions.Add("Mid Up");
                }

                else
                {
                    directions.Add("Right Up");
                }
            }

            return directions;
        }

        public bool TopLeft(Symbol[,] first, Symbol[,] last)
        {
            //bottom row is the same
            for (int i = 0; i < 3; i++)
            {
                if (first[1, i] != last[1, i])
                {
                    return false;
                }
            }

            return first[0, 0] == last[0, 2] && first[0, 1] == last[0, 0] && first[0, 2] == last[0, 1];
        }

        public bool TopRight(Symbol[,] first, Symbol[,] last)
        {
            //bottom row is the same
            for (int i = 0; i < 3; i++)
            {
                if (first[1, i] != last[1, i])
                {
                    return false;
                }
            }

            return first[0, 0] == last[0, 1] && first[0, 1] == last[0, 2] && first[0, 2] == last[0, 0];
        }

        public bool BottomLeft(Symbol[,] first, Symbol[,] last)
        {
            //top row is the same
            for (int i = 0; i < 3; i++)
            {
                if (first[0, i] != last[0, i])
                {
                    return false;
                }
            }

            return first[1, 0] == last[1, 2] && first[1, 1] == last[1, 0] && first[1, 2] == last[1, 1];
        }

        public bool BottomRight(Symbol[,] first, Symbol[,] last)
        {
            //top row is the same
            for (int i = 0; i < 3; i++)
            {
                if (first[0, i] != last[0, i])
                {
                    return false;
                }
            }

            return first[1, 0] == last[1, 1] && first[1, 1] == last[1, 2] && first[1, 2] == last[1, 0];
        }

        public bool LefttUp(Symbol[,] first, Symbol[,] last)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0)
                    {
                        continue;
                    }

                    if (first[i, j] != last[i, j])
                    {
                        return false;
                    }
                }

            }
            
            return first[0, 0] == last[1, 0] && first[1, 0] == last[0, 0];

        }

        public bool MidtUp(Symbol[,] first, Symbol[,] last)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 1)
                    {
                        continue;
                    }

                    if (first[i, j] != last[i, j])
                    {
                        return false;
                    }
                }

            }
            
            return first[0, 1] == last[1, 1] && first[1, 1] == last[0, 1];

        }

        public bool RighttUp(Symbol[,] first, Symbol[,] last)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 1)
                    {
                        continue;
                    }

                    if (first[i, j] != last[i, j])
                    {
                        return false;
                    }
                }

            }

            return first[0, 2] == last[1, 2] && first[1, 2] == last[0, 2];

        }

        public bool EqualsGoal(Symbol[,] current, Symbol[,] goal)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (current[i, j] != goal[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool GoalIsInOpenList()
        {
            
            foreach (AnswerGrid answerGrid in openList)
            {
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (answerGrid.grid[i, j] != this.answerGrid[i, j])
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        private Symbol[,] FindAnswerGrid()
        {
            List<Symbol> answer = null;

            Symbol[,] answerGrid = null;

            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 6; col++)
                {
                    answer = FindAnswerStart(row, col);
                }

                if (answer != null)
                {
                    break;
                }

            }

            if (answer == null)
            {
                return null;
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j ++)
                {
                    answerGrid[i, j] = answer[i * 3 + j];
                }

            }

            return answerGrid;
        }

        private List<Symbol> FindAnswerStart(int row, int col)
        {
            List<Symbol> possbileList = new List<Symbol>();

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    possbileList.Add(grid[row + i, col + j]);
                }


            }

            foreach (Symbol s in symbolList)
            {
                if (!possbileList.Contains(s))
                {
                    return null;
                }
            }

            return possbileList;
        }



        public enum Symbol
        {
            Three,
            Six,
            A,
            Ae,
            B,
            BackwardsC,
            BlackStar,
            Butt,
            C,
            Copyright,
            E,
            H,
            Hashtag,
            Lambda,
            Lightning,
            N,
            O,
            Omega,
            Paragraph,
            QuestionMark,
            SmilyFace,
            Squid,
            Swirl,
            Trident,
            UfinishedR,
            WhiteStar,
            X,
            Null
        }

        public class AnswerGrid
        {
            public Symbol[,] grid;

            public AnswerGrid Parent;
            List<AnswerGrid> children;

            private Symbol[,] goal;
            public int GCost;
            public int HeuristicCost;
            public int TotalCost;

            public AnswerGrid(Symbol[,] grid, Symbol[,] goal, AnswerGrid parent)
            {
                this.grid = grid;
                this.goal = goal;
                Parent = parent;
                FindHeuristicCost(goal);
            }

            private void FindHeuristicCost(Symbol [,] goal)
            {
                foreach (Symbol s in grid)
                {
                    int[] currentCoordinates = null;
                    int[] goalCoordinates = null;

                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            if (grid[i, j] == s)
                            {
                                currentCoordinates = new int[] { i, j };
                            }

                            if (goal[i, j] == s)
                            {
                                goalCoordinates = new int[] { i, j };
                            }
                        }

                        if (currentCoordinates != null && goalCoordinates != null)
                        {
                            break;
                        }
                    }

                    HeuristicCost += FindRowDistance(currentCoordinates[0], goalCoordinates[0]) + FindColDistance(currentCoordinates[1], goalCoordinates[1]);
                }
            }

            private int FindRowDistance(int  currentRow, int goalRow)
            {
                if (currentRow == goalRow)
                {
                    return 0;
                }

                return 1;
            }

            private int FindColDistance(int currentCol, int goalCol)
            {
                //if sybmol is in same row as goal, distance is 1 regardless of direction
                if (currentCol != goalCol)
                {
                    return 1;
                }

                return 0;
            }

            public List<AnswerGrid> GetChildren()
            {
                List<AnswerGrid> children = new List<AnswerGrid>();

                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        children.AddRange(FindRowChildren(i));
                        children.AddRange(FindColumnChildren(j));
                    }
                }

                return children;
            }

            private List<AnswerGrid> FindRowChildren(int row)
            {
                List<AnswerGrid> children = new List<AnswerGrid>();
                //left

                Symbol newLeft0 = grid[row, 1];
                Symbol newLeft1 = grid[row, 2];
                Symbol newLeft2 = grid[row, 0];

                Symbol[,] leftPuzzle = new Symbol[2, 3];


                //right

                Symbol newRight0 = grid[row, 2];
                Symbol newRight1 = grid[row, 0];
                Symbol newRight2 = grid[row, 1];
            
                Symbol[,] rightPuzzle = new Symbol[2, 3];

                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (row == i)
                        {
                            leftPuzzle[i, 0] = newLeft0;
                            leftPuzzle[i, 1] = newLeft1;
                            leftPuzzle[i, 2] = newLeft2;

                            rightPuzzle[i, 0] = newRight0;
                            rightPuzzle[i, 1] = newRight1;
                            rightPuzzle[i, 2] = newRight2;

                            break;
                        }

                        leftPuzzle[i, j] = grid[i, j];
                        rightPuzzle[i, j] = grid[i, j];
                    }

                }

                if (!EqualParant(leftPuzzle))
                {
                    children.Add(new AnswerGrid(leftPuzzle, goal, this));
                }

                if (!EqualParant(rightPuzzle))
                {
                    children.Add(new AnswerGrid(rightPuzzle, goal, this));
                }

                return children;
            }

            private List<AnswerGrid> FindColumnChildren(int col)
            {
                List<AnswerGrid> children = new List<AnswerGrid>();
                //up

                Symbol new0 = grid[1, col];
                Symbol new1 = grid[0, col];

                Symbol[,] newPuzzle = new Symbol[2, 3];

                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (col == j)
                        {
                            newPuzzle[0, j] = new0;
                            newPuzzle[1, j] = new1;
                            break;
                        }

                        newPuzzle[i, j] = grid[i, j];
                    }

                }

                if (!EqualParant(newPuzzle))
                {
                    children.Add(new AnswerGrid(newPuzzle, goal, this));
                }

                return children;
            }

            private bool EqualParant(Symbol[,] newGrid)
            {
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (newGrid[i, j] != Parent.grid[i, j])
                        {
                            return false;
                        }
                    }
                }

                return true;
            }

            public static AnswerGrid FindLowestCostNeighbor(List<AnswerGrid> children)
            {
                List<int> costList = new List<int>();

                foreach (AnswerGrid a in children)
                {
                    costList.Add(a.TotalCost);
                }

                int lowestCost = costList.Min();

                AnswerGrid lowestChild = null;

                foreach (AnswerGrid a in children)
                {
                    if (a.TotalCost == lowestCost)
                    {
                        lowestChild = a;
                        break;
                    }
                }

                return lowestChild;
            }
        }
    }

   
}
