using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace KTANE_Solver
{
    class LEDGrid : Module
    {
        Color[] grid;

        public LEDGrid(Bomb bomb, StreamWriter logFileWriter, Color[] grid) : base(bomb, logFileWriter, "LED Grid")
        {
            this.grid = grid;
        }

        public void Solve()
        {
            ShowAnswer(FindAnswer(), true);
        }

        public string FindAnswer()
        {
            switch (Bomb.UnlitIndicatorsList.Count)
            {
                case 0:
                    if (grid.Where(x => x == Color.Orange).Count() == 0)
                    {
                        return "CDAB";
                    }

                    if (grid.Where(x => x == Color.Red).Count() >= 3)
                    {
                        return "DACB";
                    }

                    if (TwoPairs())
                    {
                        return "BACD";
                    }

                    if (RowSameColor(2))
                    {
                        return "ACDB";
                    }

                    return "BCDA";

                case 1:

                    if (grid.Distinct().ToList().Count == grid.Length)
                    {
                        return "DCBA";
                    }

                    if (RowSameColor(0))
                    {
                        return "DACB";
                    }

                    if (grid.Where(x => x == Color.Red).Count() == 3 || grid.Where(x => x == Color.Pink).Count() == 3 || grid.Where(x => x == Color.Purple).Count() == 3)
                    {
                        return "BACD";
                    }

                    if (grid.Where(x => x == Color.White).Count() == 1 || grid.Where(x => x == Color.Blue).Count() == 2 || grid.Where(x => x == Color.Yellow).Count() == 3)
                    {
                        return "ACDB";
                    }

                    return "DBAC";

                case 2:

                    if (grid.Where(x => x == Color.Red).Count() >= 3)
                    {
                        return "DCBA";
                    }

                    if (TwoPairs())
                    {
                        return "DACB";
                    }

                    if (grid.Where(x => x == Color.White).Count() > 1 || grid.Where(x => x == Color.Orange).Count() > 1 || grid.Where(x => x == Color.Pink).Count() > 1)
                    {
                        return "BACD";
                    }

                    if (grid.Where(x => x == Color.Green).Count() == 1 || grid.Where(x => x == Color.Yellow).Count() == 2 || grid.Where(x => x == Color.Red).Count() == 3 || grid.Where(x => x == Color.Blue).Count() == 4)
                    {
                        return "ACDB";
                    }

                    return "DBAC";

                case 3:

                    if (grid.Where(x => x == Color.Orange).Count() == 2)
                    {
                        return "DCBA";
                    }

                    if (PairCount() > 1)
                    {
                        return "DACB";
                    }

                    if (grid.Where(x => x == Color.Purple).Count() == 0)
                    {
                        return "BACD";
                    }

                    if (grid.Where(x => x == Color.Red).Count() == 1 && grid.Where(x => x == Color.Yellow).Count() == 1)
                    {
                        return "ACDB";
                    }

                    return "DBAC";

                default:

                    if (RowSameColor(1))
                    {
                        return "DCBA";
                    }

                    if (grid.Where(x => x == Color.Green).Count() >= 2)
                    {
                        return "DACB";
                    }

                    if (TwoPairs())
                    {
                        return "BACD";
                    }

                    if (grid.Where(x => x == Color.Pink).Count() == 0)
                    {
                        return "ACDB";
                    }

                    return "DBAC";
            }
        }

        private bool RowSameColor(int row)
        {
            Color color = grid[row * 3];

            for (int i = 1; i < 3; i++)
            {
                if (color != grid[row * 3 + 1])
                {
                    return false;
                }
            }

            return true;
        }

        private bool TwoPairs()
        {
            return PairCount() == 2;
        }

        private int PairCount()
        {
           return grid.Length - grid.Distinct().ToList().Count;
        }
    }
}
