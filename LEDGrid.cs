using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace KTANE_Solver
{
    public class LEDGrid : Module
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
            PrintDebugLine("Number of unlit indicators: " + Bomb.UnlitIndicatorsList.Count);

            switch (Bomb.UnlitIndicatorsList.Count)
            {
                case 0:
                    if (grid.Where(x => x == Color.Orange).Count() == 0)
                    {
                        PrintDebugLine("There are no orange LEDs");
                        return "CDAB";
                    }

                    if (grid.Where(x => x == Color.Red).Count() >= 3)
                    {
                        PrintDebugLine("There are three or more red LEDs");
                        return "DACB";
                    }

                    if (PairCount() >= 2)
                    {
                        PrintDebugLine("There are two or more pairs");
                        return "BACD";
                    }

                    if (RowSameColor(2))
                    {
                        PrintDebugLine("The bottom row is all the same colour");
                        return "ACDB";
                    }

                    PrintDebugLine("None of the other conditions applied");
                    return "BCDA";

                case 1:

                    if (grid.Distinct().ToList().Count == grid.Length)
                    {
                        PrintDebugLine("Every LED is unique");
                        return "DCBA";
                    }

                    if (RowSameColor(0))
                    {
                        PrintDebugLine("The top row is all the same colour");
                        return "DACB";
                    }

                    if (grid.Where(x => x == Color.Red).Count() == 3 || grid.Where(x => x == Color.Pink).Count() == 3 || grid.Where(x => x == Color.Purple).Count() == 3)
                    {
                        PrintDebugLine("There are exactly three red, three pink or three purple LEDs");
                        return "BACD";
                    }

                    if (grid.Where(x => x == Color.White).Count() == 1 || grid.Where(x => x == Color.Blue).Count() == 2 || grid.Where(x => x == Color.Yellow).Count() == 3)
                    {
                        PrintDebugLine("There is exactly one white, two blue or three yellow LEDs");
                        return "ACDB";
                    }

                    PrintDebugLine("None of the other conditions applied");
                    return "DBAC";

                case 2:

                    if (grid.Where(x => x == Color.Red).Count() >= 3)
                    {
                        PrintDebugLine("There are three or more purple LEDs");
                        return "DCBA";
                    }

                    if (TwoPairs())
                    {
                        PrintDebugLine("There are exactly two pairs");
                        return "DACB";
                    }

                    if (grid.Where(x => x == Color.White).Count() > 1 || grid.Where(x => x == Color.Orange).Count() > 1 || grid.Where(x => x == Color.Pink).Count() > 1)
                    {
                        PrintDebugLine("There is at least one white, one orange and one pink LED");
                        return "BACD";
                    }

                    if (grid.Where(x => x == Color.Green).Count() == 1 || grid.Where(x => x == Color.Yellow).Count() == 2 || grid.Where(x => x == Color.Red).Count() == 3 || grid.Where(x => x == Color.Blue).Count() == 4)
                    {
                        PrintDebugLine("There is exactly one green, two yellow, three red or four blue LEDs");
                        return "ACDB";
                    }

                    PrintDebugLine("None of the other conditions applied");
                    return "DBAC";

                case 3:

                    if (grid.Where(x => x == Color.Orange).Count() == 2)
                    {
                        PrintDebugLine("There are exactly two orange LEDs");
                        return "DCBA";
                    }

                    if (PairCount() > 1)
                    {
                        PrintDebugLine("There is more than one pair");
                        return "DACB";
                    }

                    if (grid.Where(x => x == Color.Purple).Count() == 0)
                    {
                        PrintDebugLine("There are no purple LEDs");
                        return "BACD";
                    }

                    if (grid.Where(x => x == Color.Red).Count() == 1 && grid.Where(x => x == Color.Yellow).Count() == 1)
                    {
                        PrintDebugLine("There is at least one red and one yellow LED");
                        return "ACDB";
                    }

                    PrintDebugLine("None of the other conditions applied");
                    return "DBAC";

                default:

                    if (RowSameColor(1))
                    {
                        PrintDebugLine("The centre row is all the same colour");
                        return "DCBA";
                    }

                    if (grid.Where(x => x == Color.Green).Count() >= 2)
                    {
                        PrintDebugLine("There are two or more green LEDs");
                        return "DACB";
                    }

                    if (TwoPairs())
                    {
                        PrintDebugLine("There are exactly two pairs");
                        return "BACD";
                    }

                    if (grid.Where(x => x == Color.Pink).Count() == 0)
                    {
                        PrintDebugLine("There are no pink LEDs");
                        return "ACDB";
                    }

                    PrintDebugLine("None of the other conditions applied");
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
